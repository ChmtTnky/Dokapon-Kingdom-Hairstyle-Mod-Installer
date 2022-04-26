using System.Text;

namespace PACManager
{
	public static class PAC
	{
		public static Encoding shift_jis { get; private set; }
		public static bool Pack(string output_path)
		{
			shift_jis = CodePagesEncodingProvider.Instance.GetEncoding("shift-jis");

			SortedDictionary<string, short> file_dict = new();
			string[] order = File.ReadAllLines("order.txt");
			string[] file_names = order.Where(a => File.Exists(Path.Combine("PACFiles", a))).ToArray();
			string[] files = file_names.Select(a => Path.Combine("PACFiles", a)).ToArray();

			for (short i = 0; i < file_names.Length; i++)
			{
				file_dict.Add(file_names[i], i);
			}

			BinaryWriter pac = new(File.Create(Path.Combine(output_path, "GAME.PAC")));
			int[] file_data_lengths = new int[files.Length];
			int[] file_data_ptrs = new int[files.Length];
			byte[] buffer = new byte[0x800];
			for (int i = 0; i < files.Length; i++)
			{
				byte[] data = File.ReadAllBytes(files[i]);
				// store the length of this file
				file_data_lengths[i] = data.Length;
				// store the current position in pac where this file will be
				file_data_ptrs[i] = (int)pac.BaseStream.Position;
				// write the data
				pac.Write(data, 0, file_data_lengths[i]);
				// align the data to 0x800
				int alignment = buffer.Length - (file_data_lengths[i] % buffer.Length);
				if (alignment != buffer.Length)
				{
					pac.Write(buffer, 0, alignment);
				}
			}
			pac.Flush();
			pac.Close();



			BinaryWriter pah = new(File.Create(Path.Combine(output_path, "GAME.PAH")));
			pah.Write(files.Length);
			// write the pointer to the start of data
			const int header_size = 0x70;
			pah.Write(header_size);

			// sort each file into an alphabet

			// create an array of lists for alphabet use
			List<string>[] alphabet_list = new List<string>[26];
			// initialize a value to contain the total number of bytes used by alphabets
			int total_alphabet_count = 0;
			// buffer the initial alphabet
			int[] alphabet = new int[26];
			// initialize every list in the alphabet array
			for (int i = 0; i < alphabet_list.Length; i++)
			{
				alphabet_list[i] = new List<string>();
			}

			byte upper_a = shift_jis.GetBytes("A")[0];
			byte lower_a = shift_jis.GetBytes("a")[0];
			// iterate through each file's name
			for (int i = 0; i < file_names.Length; i++)
			{
				// get the first letter of the name
				byte c = shift_jis.GetBytes(file_names[i])[0];
				// if the letter's value is higher than 'a'
				if (c > lower_a)
				{
					// shrink to even out with uppercase
					c -= (byte)(lower_a - upper_a);
				}
				// subtract the value of 'A' to get the index in the array
				c -= upper_a;
				// add the file's name to this index
				alphabet_list[c].Add(file_names[i]);
			}
			for (int i = 0; i < alphabet_list.Length; i++)
			{
				// sort the files for each letter index
				alphabet_list[i].Sort();
				// apparently this 0x2D7 object is bugged and has to be in this specific position to avoid crashing
				int index;
				bool found = false;
				// scan the list for 0x2D7
				for (index = 0; index < alphabet_list[i].Count - 1; index++)
				{
					if (file_dict[alphabet_list[i][index]] == 0x2D7)
					{
						found = true;
						break;
					}
				}
				if (found)
				{
					// if 0x2D7 exists, move it to the correct position
					string name = alphabet_list[i][index];
					alphabet_list[i].RemoveAt(index);
					alphabet_list[i].Insert(alphabet_list[i].Count - 1, name);
				}
				// find the offsets for each letter's position in pah
				alphabet[i] = total_alphabet_count + (file_names.Length * 0x10) + header_size;
				total_alphabet_count += (alphabet_list[i].Count + 1) * sizeof(ushort);
			}
			int file_name_offset = (files.Length * 0x10) + header_size + total_alphabet_count;

			// write the pointers to each letter
			for (int i = 0; i < alphabet.Length; i++)
			{
				pah.Write(alphabet[i]);
			}

			// write the file data
			for (int i = 0; i < files.Length; i++)
			{
				// pointers to their starting position in pac
				pah.Write(file_data_ptrs[i]);
				// length of the file not including padding
				pah.Write(file_data_lengths[i]);
				// separate pac and pah? idk
				pah.Write(0);
				// pointer to file name in pah
				pah.Write(file_name_offset);
				// increment the pointer for the next file
				file_name_offset += file_names[i].Length + 1;
				if (file_name_offset % 2 != 0)
				{
					file_name_offset++;
				}
			}

			// write the alphabets
			for (int i = 0; i < alphabet_list.Length; i++)
			{
				// write the length of the array
				pah.Write(BitConverter.GetBytes((short)alphabet_list[i].Count), 0, 2);
				for (int j = 0; j < alphabet_list[i].Count; j++)
				{
					// write the id of the file at this index
					pah.Write(BitConverter.GetBytes(file_dict[alphabet_list[i][j]]), 0, 2);
				}
			}

			// write file names
			for (int i = 0; i < files.Length; i++)
			{
				byte[] bytes = shift_jis.GetBytes(file_names[i]);
				pah.Write(bytes, 0, bytes.Length);
				pah.Write(buffer, 0, 1);
				if (pah.BaseStream.Position % 2 != 0)
				{
					pah.Write(buffer, 0, 1);
				}
			}

			// realign pah itself
			int pah_align = 0x10 - ((int)pah.BaseStream.Position % 0x10);
			if (pah_align != 0x10)
			{
				pah.Write(buffer, 0, pah_align);
			}
			pah.Write(buffer, 0, 0x30);
			pah.Flush();
			pah.Close();
			return true;
		}

		public static bool Unpack(string pac_path, string pah_path)
		{
			BinaryReader pah = new(File.OpenRead(pah_path));
			int file_count = pah.ReadInt32();
			pah.BaseStream.Position = pah.ReadInt32();
			BinaryReader pac = new(File.OpenRead(pac_path));
			if (Directory.Exists("PACFiles"))
			{
				Directory.Delete("PACFiles", true);
			}
			Directory.CreateDirectory("PACFiles");
			byte[] data;
			int old_pos;
			string name;
			StreamWriter order = new(File.Create("order.txt"));
			for (int file_id = 0; file_id < file_count; file_id++)
			{
				pac.BaseStream.Position = pah.ReadInt32();
				data = pac.ReadBytes(pah.ReadInt32());
				pah.BaseStream.Position += sizeof(int);
				old_pos = (int)pah.BaseStream.Position + sizeof(int);
				pah.BaseStream.Position = pah.ReadInt32();
				name = pah.ReadZeroTerminatedString();
				order.WriteLine(name);
				BinaryWriter temp = new(File.Create($"PACFiles/{name}"));
				pah.BaseStream.Position = old_pos;
				temp.Write(data);
				temp.Flush();
				temp.Close();
			}
			order.Flush();
			order.Close();
			pac.Close();
			pah.Close();
			return true;
		}
	}
}
