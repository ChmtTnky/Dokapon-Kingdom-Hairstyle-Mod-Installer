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
			open_iso_wbfs_dialog.Filter = "All files (*.*)|*.*|WBFS (*.wbfs)|*.wbfs|ISO (*.iso)|*.iso";
			open_iso_wbfs_dialog.FileOk += this.Open_iso_wbfs_dialog_FileOk;
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
					MessageBox.Show("The IGB file specified by files.ini does not exist", "Error: IGB file not found", MessageBoxButtons.OK);
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
						MessageBox.Show("The PIM file specified by files.ini does not exist", "Error: PIM file not found", MessageBoxButtons.OK);
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
			if (hairstyle_replace_selected && mod_folder_selected && iso_wbfs_file_selected) // only apply if all required options have been selected
			{
				string model_file_header;
				string pim_file_header;

				// If hairstyle is for a job
				if (hairstyle_list_box.SelectedIndex < 22)
				{
					string index_to_string = hairstyle_list_box.SelectedIndex.ToString();
					if (hairstyle_list_box.SelectedIndex < 10)
					{
						index_to_string = "0" + index_to_string;
					}

					model_file_header = Path.Combine("PACFiles", "C" + index_to_string + "A");
					pim_file_header = Path.Combine("PACFiles", "C" + index_to_string + "A" + "_H");
				}
				else // Prank hair is currently unsupported
				{
					model_file_header = Path.Combine("PACFiles", "H" + hairstyle_list_box.SelectedIndex.ToString());
					pim_file_header = Path.Combine("PACFiles", "H" + hairstyle_list_box.SelectedIndex.ToString() + "C");
				}

				// Copy in IGB file
				for (int i = 1; i < 5; i++)
				{
					File.Copy(igb_file_name, model_file_header + "_" + i.ToString() + "P.IGB", true);
				}

				// Copy in PIM files
				for (int i = 0; i < pim_file_name_array.Length; i++)
				{
					if (pim_file_name_array[i] != "Unselected" && pim_file_name_array[i] != string.Empty)
					{
						File.Copy(pim_file_name_array[i], pim_file_header + i.ToString() + ".PIM", true);
					}
					else // If pim file was not selected for a given color, delete the existing PIM file
					{
						File.Delete(pim_file_header + i.ToString() + ".PIM");
					}
				}

				MessageBox.Show("Mod files have successfully been moved into the game files. To complete the application, press Finish.", "Success: Mod successfully applied", MessageBoxButtons.OK);
			}
			else
			{
				if (!iso_wbfs_file_selected)
				{
					MessageBox.Show("Please select an ISO/WBFS first before attempting to apply any mods.", "Error: Game files have yet to be extracted", MessageBoxButtons.OK);
					return;
				}
				if (!mod_folder_selected)
				{
					MessageBox.Show("Please select a mod folder before attempting to apply any mods.", "Error: Mod folder not selected", MessageBoxButtons.OK);
					return;
				}
				if (!hairstyle_replace_selected)
				{
					MessageBox.Show("Please select a hairstyle to replace before attempting to apply any mods.", "Error: Hairstyle not selected", MessageBoxButtons.OK);
					return;
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
				MessageBox.Show("WIT was not found in the same directory as the executable", "Error: WIT was not found", MessageBoxButtons.OK);
				return;
			}

			// Get iso/wbfs file
			iso_wbfs_file_selected = false;
			open_iso_wbfs_dialog.FilterIndex = 0;
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

			// extract files using wit
			Process? process = Process.Start(new ProcessStartInfo()
			{
#if WINDOWS
				FileName = Path.Combine("C:", "Windows", "System32", "cmd.exe"),
				Arguments = $"/c {Path.Combine("WIT", "wit.exe")} extract -o \"{open_iso_wbfs_dialog.FileName}\" \"DokaponFiles\""
#else
				FileName = Path.Combine("WIT", "wit.exe"),
				Arguments = $"extract -o \"{open_iso_wbfs_dialog.FileName}\" \"DokaponFiles\""
#endif
			});
			process?.WaitForExit();
			process?.Close();

			if (!Directory.Exists("DokaponFiles"))
			{
				MessageBox.Show("DokaponFiles folder not found after executing WIT Extract", "Error: WIT extraction failed", MessageBoxButtons.OK);
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
				MessageBox.Show("\"files\" directory not found within DokaponFiles", "Error: Expected directory not found", MessageBoxButtons.OK);
				return;
			}

			// Unpack GAME.PAC
			if (!PACManager.PAC.Unpack(Path.Combine(files_folder_path, "GAME.PAC"), Path.Combine(files_folder_path, "GAME.PAH")))
			{
				MessageBox.Show("The Unpack function could not be completed", "Error: Unpack method failed", MessageBoxButtons.OK);
				return;
			}

			if (!Directory.Exists("PACFiles"))
			{
				MessageBox.Show("The Unpack function finished but PACFiles was not produced", "Error: Unpack method failed", MessageBoxButtons.OK);
				return;
			}
		}

		private void Open_iso_wbfs_dialog_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
		{
			OpenFileDialog? dialog = (OpenFileDialog?)sender;
			if (dialog == null)
			{
				e.Cancel = true;
				MessageBox.Show("An error has occurred. Please notify @jjo71 on Discord.", "FileOk Dialog Error");
				return;
			}
			switch (Path.GetExtension(dialog.FileName))
			{
				case "iso":
				case "wbfs":
					break;
				default:
					e.Cancel = true;
					MessageBox.Show("Please select an ISO or WBFS file.", "Invalid file type selected");
					return;
			}
		}

		// Creates new wbfs file and deletes all unneeded extracted files
		private void Finish_Button_Click(object sender, EventArgs e)
		{
			// Check if output file already exists, as wit will not automatically override it
			if (File.Exists("ModdedDokapon.wbfs"))
			{
				MessageBox.Show("Delete or move ModdedDokapon.wbfs before proceeding", "Error: Output file already exists", MessageBoxButtons.OK);
				return;
			}

			if(iso_wbfs_file_selected) // Has the game files folder been selected?
			{
				// Repack GAME.PAC and GAME.PAH
				if (!PACManager.PAC.Pack(files_folder_path))
				{
					MessageBox.Show("The Pack function could not be completed", "Error: Pack method failed", MessageBoxButtons.OK);
					return;
				}

				// extract files using wit
				Process? process = Process.Start(new ProcessStartInfo()
				{
#if WINDOWS
					FileName = Path.Combine("C:", "Windows", "System32", "cmd.exe"),
					Arguments = $"/c {Path.Combine("WIT", "wit.exe")} copy \"DokaponFiles\" \"ModdedDokapon.wbfs\""
#else
					FileName = Path.Combine("WIT", "wit.exe"),
					Arguments = $"copy \"DokaponFiles\" \"ModdedDokapon.wbfs\""
#endif
				});
				process?.WaitForExit();
				process?.Close();

				if (!File.Exists("ModdedDokapon.wbfs"))
				{
					MessageBox.Show("ModdedDokapon.wbfs not found after executing WIT Copy", "Error: WIT copy failed", MessageBoxButtons.OK);
					return;
				}

				// Delete remaining files
				Directory.Delete("DokaponFiles", true);
				Directory.Delete("PACFiles", true);
				File.Delete("order.txt");

				// Output success message
				if (File.Exists("ModdedDokapon.wbfs"))
				{
					MessageBox.Show("ModdedDokapon.wbfs can be found in the same directory as the executable. You may now exit this program.", "Success: WBFS file was created", MessageBoxButtons.OK);
					iso_wbfs_file_selected = false;
					select_iso_wbfs_label.Text = "ISO/WBFS: Unselected";
					return;
				}
			}
			else
			{
				MessageBox.Show("Please select an ISO/WBFS first before attempting to finish the installation process", "Error: Game files have yet to be extracted", MessageBoxButtons.OK);
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