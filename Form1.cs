using System.Diagnostics;

namespace DokaModInterface
{
	public partial class Form1 : Form
	{
		// Various flags indictaing which selections have been made
		public bool mod_folder_selected = false;
		public bool hairstyle_replace_selected = false;
		public bool iso_wbfs_file_selected = false;

		// PIM and IGB file paths
		public string igb_file_name = string.Empty;
		public string[] pim_file_name_array = new string[7];

		// Path to directory containing GAME.PAC and GAME.PAH
		string files_folder_path = string.Empty;

		public Form1()
		{
			InitializeComponent();
		}

		// Set all labels
		private void Form1_Load(object sender, EventArgs e)
		{
			// Label default text
			mod_folder_label.Text = "Mod Folder: Unselected";
			select_iso_wbfs_label.Text = "ISO/WBFS: Unselected";
			igb_file_label.Text = "IGB Model: Unselected";
			pim_red_label.Text = "Red Texture: Unselected";
			pim_blue_label.Text = "Blue Texture: Unselected";
			pim_green_label.Text = "Green Texture: Unselected";
			pim_yellow_label.Text = "Yellow Texture: Unselected";
			pim_pink_label.Text = "Pink Texture: Unselected";
			pim_white_label.Text = "White Texture: Unselected";
			pim_black_label.Text = "Black Texture: Unselected";
		}

		// Select model button
		// Opens dialog to select IGB file
		private void Select_Mod_Folder_Button_Click(object sender, EventArgs e)
		{
			mod_folder_selected = false;
			if(open_mod_folder_dialog.ShowDialog() == DialogResult.OK)
			{
				mod_folder_label.Text = open_mod_folder_dialog.SelectedPath;
				mod_folder_selected = true;

				Ini asset_list = Ini.Load(Path.Combine(open_mod_folder_dialog.SelectedPath, "files.ini"));
				Array.Fill(pim_file_name_array, "Unselected");

				// Get and verify the existence of the IGB file
				igb_file_name = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["IGB File", "IGB"]);
				if (!File.Exists(igb_file_name))
				{
					var error = MessageBox.Show("The IGB file specified by files.ini does not exist", "Error: IGB file not found", MessageBoxButtons.OK);
					return;
				}
				igb_file_label.Text = "IGB Model: " + igb_file_name;

				// Get the paths of the pim files
				if (asset_list["PIM Files", "Red"] != null && asset_list["PIM Files", "Red"] != string.Empty)
					pim_file_name_array[0] = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["PIM Files", "Red"]);

				if (asset_list["PIM Files", "Blue"] != null && asset_list["PIM Files", "Blue"] != string.Empty)
					pim_file_name_array[1] = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["PIM Files", "Blue"]);

				if (asset_list["PIM Files", "Green"] != null && asset_list["PIM Files", "Green"] != string.Empty)
					pim_file_name_array[2] = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["PIM Files", "Green"]);

				if (asset_list["PIM Files", "Yellow"] != null && asset_list["PIM Files", "Yellow"] != string.Empty)
					pim_file_name_array[3] = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["PIM Files", "Yellow"]);

				if (asset_list["PIM Files", "Pink"] != null && asset_list["PIM Files", "Pink"] != string.Empty)
					pim_file_name_array[4] = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["PIM Files", "Pink"]);

				if (asset_list["PIM Files", "White"] != null && asset_list["PIM Files", "White"] != string.Empty)
					pim_file_name_array[5] = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["PIM Files", "White"]);

				if (asset_list["PIM Files", "Black"] != null && asset_list["PIM Files", "Black"] != string.Empty)
					pim_file_name_array[6] = Path.Combine(open_mod_folder_dialog.SelectedPath, asset_list["PIM Files", "Black"]);

				// Verify that the pim files exists
				for (int i = 0; i < 7; i++)
				{
					if (pim_file_name_array[i] != "Unselected" && !File.Exists(pim_file_name_array[i]))
					{
						var error = MessageBox.Show("The PIM file specified by files.ini does not exist", "Error: PIM file not found", MessageBoxButtons.OK);
						return;
					}
				}

				// Set labels
				pim_red_label.Text = "Red Texture: " + pim_file_name_array[0];
				pim_blue_label.Text = "Blue Texture: " + pim_file_name_array[1];
				pim_green_label.Text = "Green Texture: " + pim_file_name_array[2];
				pim_yellow_label.Text = "Yellow Texture: " + pim_file_name_array[3];
				pim_pink_label.Text = "Pink Texture: " + pim_file_name_array[4];
				pim_white_label.Text = "White Texture: " + pim_file_name_array[5];
				pim_black_label.Text = "Black Texture: " + pim_file_name_array[6];
			}
			else
			{
				mod_folder_label.Text = "Mod Folder: Unselected";
				return;
			}
		}

		// Select hairstyle from dropdown box
		// If a hairstyle is selected, set the flag to indicate that.
		private void Hairstyle_List_Select_Change(object sender, EventArgs e)
		{
			if (hairstyle_list_box.SelectedIndex != -1)
			{
				hairstyle_replace_selected = true;
			}
			else
			{
				hairstyle_replace_selected = false;
			}
		}
		
		// Apply mod button
		// This functions takes the select model file and make 4 copies 
		// of it with the correct names to replace the selected hairstyle.
		// This will also put in the specified pim files
		// for all that have been selected
		private void Apply_Mod_Button_Click(object sender, EventArgs e)
		{
			if (hairstyle_replace_selected && mod_folder_selected) // only apply if all required options have been selected
			{
				string model_file_header;
				string pim_file_header;

				if (hairstyle_list_box.SelectedIndex < 22)
				{
					string index_to_string = ToString();
					if (hairstyle_list_box.SelectedIndex < 10)
					{
						index_to_string = "0" + index_to_string;
					}

					model_file_header = Path.Combine("PACFiles", "C" + index_to_string + "A");
					pim_file_header = Path.Combine("PACFiles", "C" + index_to_string + "A" + "_H");
				}
				else
				{
					model_file_header = Path.Combine("PACFiles", "H" + ToString());
					pim_file_header = Path.Combine("PACFiles", "H" + ToString() + "C");
				}

				for (int i = 1; i < 5; i++)
				{
					File.Copy(igb_file_name, model_file_header + "_" + i.ToString() + "P.IGB", true);
				}

				for (int i = 0; i < 7; i++)
				{
					File.Delete(Path.Combine("PACFiles", pim_file_header + i.ToString() + ".PIM"));
				}
			}
		}

		// Select ISO/WBFS button
		// Opens dialog to select file
		// Then extracts games files with wit
		// Then extract pac files with the PACManager by Lulu
		private void Select_ISO_WBFS_Button_Click(object sender, EventArgs e)
		{
			// Check for WIT
			if (!Directory.Exists("WIT"))
			{
				var error = MessageBox.Show("WIT was not found in the same directory as the executable", "Error: WIT was not found", MessageBoxButtons.OK);
				return;
			}

			// Get iso/wbfs file
			iso_wbfs_file_selected = false;
			if (open_iso_wbfs_dialog.ShowDialog() == DialogResult.OK)
			{
				select_iso_wbfs_label.Text = open_iso_wbfs_dialog.FileName;
				iso_wbfs_file_selected = true;
			}
			else
			{
				select_iso_wbfs_label.Text = "ISO/WBFS: Unselected";
				return;
			}

			// Delete any existing extracted files
			if (Directory.Exists("DokaponFiles"))
				Directory.Delete("DokaponFiles", true);
			if (Directory.Exists("PACFiles"))
				Directory.Delete("PACFiles", true);

			// extract files using wit
			Process process = new();
			ProcessStartInfo startInfo = new();
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo.FileName = Path.Combine("WIT", "wit.exe");
			startInfo.Arguments = "extract " + "\"" + open_iso_wbfs_dialog.FileName + "\"" + " " + "\"DokaponFiles\"";
			process.StartInfo = startInfo;
			process.Start();

			while(!process.HasExited)
			{
				// wait, otherwise it will try to unpack the files before wit is finished
			}

			if (!Directory.Exists("DokaponFiles"))
			{
				var error = MessageBox.Show("DokaponFiles folder not found after executing WIT Extract", "Error: WIT extraction failed", MessageBoxButtons.OK);
				return;
			}

			// Get path to directory containing GAME.PAC and GAME.PAH
			if (Directory.Exists(Path.Combine("DokaponFiles", "DATA", "files")))
			{
				files_folder_path = Path.Combine("DokaponFiles", "DATA", "files");
			}
			else if (Directory.Exists(Path.Combine("DokaponFiles", "files")))
			{
				files_folder_path = Path.Combine("DokaponFiles", "files");
			}
			else
			{
				var error = MessageBox.Show("\"files\" directory not found within DokaponFiles", "Error: Expected directory not found", MessageBoxButtons.OK);
				return;
			}

			// Unpack GAME.PAC
			if (!PACManager.PAC.Unpack(Path.Combine(files_folder_path, "GAME.PAC"), Path.Combine(files_folder_path, "GAME.PAH")))
			{
				var error = MessageBox.Show("The Unpack function could not be completed", "Error: Unpack method failed", MessageBoxButtons.OK);
				return;
			}

			if (!Directory.Exists("PACFiles"))
			{
				var error = MessageBox.Show("The Unpack function finished by PACFiles was not produced", "Error: Unpack method failed", MessageBoxButtons.OK);
				return;
			}
		}

		// Creates new wbfs file and deletes all unneeded extracted files
		private void Finish_Button_Click(object sender, EventArgs e)
		{
			// Check if output file already exists, as wit will not automatically override it
			if (File.Exists("ModdedDokapon.wbfs"))
			{
				var error = MessageBox.Show("Delete or move ModdedDokapon.wbfs before proceeding", "Error: Output file already exists", MessageBoxButtons.OK);
				return;
			}

			if(iso_wbfs_file_selected) // Has the game files folder been selected?
			{
				// Repack GAME.PAC and GAME.PAH
				if (!PACManager.PAC.Pack())
				{
					var error = MessageBox.Show("The Pack function could not be completed", "Error: Pack method failed", MessageBoxButtons.OK);
					return;
				}

				// Move GAME.PAC and GAME.PAH to correct directory
				File.Move("GAME.PAC", Path.Combine(files_folder_path, "GAME.PAC"), true);
				File.Move("GAME.PAH", Path.Combine(files_folder_path, "GAME.PAH"), true);

				// Create WBFS using wit
				Process process = new();
				ProcessStartInfo startInfo = new();
				startInfo.WindowStyle = ProcessWindowStyle.Hidden;
				startInfo.FileName = Path.Combine("WIT", "wit.exe");
				startInfo.Arguments = "copy " + "\"DokaponFiles\"" + " " + "\"ModdedDokapon.wbfs\"";
				process.StartInfo = startInfo;
				process.Start();

				while (!process.HasExited)
				{
					// wait, otherwise it will try to delete the files before wit is finished
				}

				if (!File.Exists("ModdedDokapon.wbfs"))
				{
					var error = MessageBox.Show("ModdedDokapon.wbfs not found after executing WIT Copy", "Error: WIT copy failed", MessageBoxButtons.OK);
					return;
				}

				// Delete remaining files
				Directory.Delete("DokaponFiles", true);
				Directory.Delete("PACFiles", true);
				File.Delete("order.txt");

				// Output success message
				if (File.Exists("ModdedDokapon.wbfs"))
				{
					var error = MessageBox.Show("ModdedDokapon.wbfs can be found in the same directory as the executable", "Success: WBFS file was created", MessageBoxButtons.OK);
					iso_wbfs_file_selected = false;
					select_iso_wbfs_label.Text = "ISO/WBFS: Unselected";
					return;
				}
			}
			else
			{
				var error = MessageBox.Show("Please select an ISO/WBFS first before attempting to finish the installation process", "Error: Game files have yet to be extracted", MessageBoxButtons.OK);
				return;
			}
		}


		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void select_iso_wbfs_label_Click(object sender, EventArgs e)
		{

		}

		private void model_file_label_Click(object sender, EventArgs e)
		{

		}

	}
}