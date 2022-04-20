using System.Diagnostics;

namespace DokaModInterface
{
    public partial class Form1 : Form
    {
        // Various flags indictaing which selections have been made
        public bool delete_pim = true;
        public bool model_file = false;
        public bool model_folder = false;
        public bool hairstyle = false;
        public bool iso_wbfs_file = false;
        public bool game_files_folder = false;
        public bool pac_file = false;
        public bool pah_file = false;

        public Form1()
        {
			InitializeComponent();
        }

        // Clear all labels
        private void Form1_Load(object sender, EventArgs e)
        {
			model_file_label.Text = "";
			apply_status_label.Text = "";
			folder_label.Text = "";
            select_iso_wbfs_label.Text = "";
            extract_game_files_label.Text = "";
            select_game_files_folder_label.Text = "";
            create_wbfs_label.Text = "";
            pac_label.Text = "";
            pah_label.Text = "";
            unpack_pac_label.Text = "";
            repack_pac_label.Text = "";
        }

        // Get checkbox state
        private void Delete_PIM_Checkbox_Click(object sender, EventArgs e)
        {
            delete_pim = pim_delete_checkbox.Checked;
        }

        // Select model button
        // Opens dialog to select IGB file
        private void Select_Button_Click(object sender, EventArgs e)
        {
            model_file_label.Text = "";
            model_file = false;
            if(open_model_dialog.ShowDialog() == DialogResult.OK)
            {
                model_file_label.Text = open_model_dialog.FileName;
                model_file = true;
            }
        }

        // Select hairstyle from dropdown box
        // If a hairstyle is selected, set the flag to indicate that.
        private void hairstyleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hairstyle_list_box.SelectedIndex != -1)
            {
                hairstyle = true;
            }
            else
            {
                hairstyle = false;
            }
        }

        // Apply mod button
        // This functions takes the select model file and make 4 copies 
        // of it with the correct names to replace the selected hairstyle.
        // This will also delete the pim files of the selected hairstyle
        // if that option is selected.
        private void Apply_Button_Click(object sender, EventArgs e)
        {
            apply_status_label.Text = "";

            if (hairstyle && model_folder && model_file) // only apply if all required options have been selected
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

                    model_file_header = Path.Combine(model_files_folder_dialog.SelectedPath, "C" + index_to_string + "A");
                    pim_file_header = Path.Combine(model_files_folder_dialog.SelectedPath, "C" + index_to_string + "A" + "_H");
                }
                else
                {
                    model_file_header = Path.Combine(model_files_folder_dialog.SelectedPath, "H" + ToString());
                    pim_file_header = Path.Combine(model_files_folder_dialog.SelectedPath, "H" + ToString() + "C");
                }

                for (int i = 1; i < 5; i++)
                {
                    File.Copy(open_model_dialog.FileName, model_file_header + "_" + i.ToString() + "P.IGB", true);
                }

                if (delete_pim)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        File.Delete(Path.Combine(model_files_folder_dialog.SelectedPath, pim_file_header + i.ToString() + ".PIM"));
                    }
                }

                apply_status_label.Text = "Successfully installed mod";
            }
            else
            {
                apply_status_label.Text = "Error: Not all parameters are selected";
            }
        }

        // Select model files folder button
        // Opens dialog to select folder
        private void Folder_Button_Click(object sender, EventArgs e)
        {
            folder_label.Text = "";
            model_folder = false;
            if(model_files_folder_dialog.ShowDialog() == DialogResult.OK)
            {
                folder_label.Text = model_files_folder_dialog.SelectedPath;
                model_folder = true;
            }
        }

        // Select ISO/WBFS button
        // Opens dialog to select file
        private void Select_ISO_WBFS_Button_Click(object sender, EventArgs e)
        {
            select_iso_wbfs_label.Text = "";
            iso_wbfs_file = false;
            if(open_iso_wbfs_dialog.ShowDialog() == DialogResult.OK)
            {
                select_iso_wbfs_label.Text = open_iso_wbfs_dialog.FileName;
                iso_wbfs_file = true;
            }
        }

        // Select GAME.PAC file
        // Opens dialog to select file
        private void Select_Pac_Button_Click(object sender, EventArgs e)
        {
            pac_label.Text = "";
            pac_file = false;
            if(open_pac_dialog.ShowDialog() == DialogResult.OK)
            {
                pac_label.Text = open_pac_dialog.FileName;
                pac_file = true;
            }
        }

        // Select GAME.PAH file
        // Opens dialog to select file
        private void Select_Pah_Button_Click(object sender, EventArgs e)
        {
            pah_label.Text = "";
            pah_file = false;
            if(open_pah_dialog.ShowDialog() == DialogResult.OK)
            {
                pah_label.Text = open_pah_dialog.FileName;
                pah_file = true;
            }
        }

        // Select game files folder
        // Opens dialog to select folder
        private void SelectGameFilesFolderButton_Click(object sender, EventArgs e)
        {
            select_game_files_folder_label.Text = "";
            game_files_folder = false;
            if(game_files_folder_dialog.ShowDialog() == DialogResult.OK)
            {
                select_game_files_folder_label.Text = game_files_folder_dialog.SelectedPath;
                game_files_folder = true;
            }
        }

        // Extract game files button
        // Opens a cmd and enters the wit command to extract the files
        // wit extract "Selectediso/wbfs" "DokaponFiles"
        private void ExtractGameFilesButton_Click(object sender, EventArgs e)
        {
            extract_game_files_label.Text = "";
            if (Directory.Exists("DokaponFiles"))
            {
                extract_game_files_label.Text = "Error: DokaponFiles folder already exists. Please delete or move before trying again";
                return;
            }

            if (iso_wbfs_file) // Has iso or wbfs been selected?
            {
				// Start cmd process
				Process process = new();
                ProcessStartInfo startInfo = new();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                // Write and execute command to extract files
                startInfo.Arguments = "/C wit extract " + "\"" + open_iso_wbfs_dialog.FileName + "\"" + " \"DokaponFiles\"";
                process.StartInfo = startInfo;
                process.Start();
                // Wait for cmd to close
                process.WaitForExit();

                // Was the command successful?
                if (Directory.Exists("DokaponFiles"))
                {
                    extract_game_files_label.Text = "Successfully extracted game files to DokaponFiles";
                }
                else
                {
                    extract_game_files_label.Text = "Error: Could not execute command. Is WIT installed?";
                }
            }
            else
            {
                extract_game_files_label.Text = "Error: No ISO/WBFS file selected";
            }
        }

        // Create Wbfs Button
        // Opens a cmd and enters the wit command to make the wbfs for you
        // wit copy "gamefilesfolder" "DokaponKingdom.wbfs"
        private void Create_WBFS_Button_Click(object sender, EventArgs e)
        {
            if (File.Exists("DokaponKingdom.wbfs"))
            {
                create_wbfs_label.Text = "DokaponKingdom.wbfs already exists. Please move or delete it before trying again.";
                return;
            }
            create_wbfs_label.Text = "";
            if(game_files_folder) // Has the game files folder been selected?
            {
                // Start cmd process
                Process process = new();
				ProcessStartInfo startInfo = new()
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					// Write and execute command to create new wbfs
					Arguments = "/C wit copy " + "\"" + game_files_folder_dialog.SelectedPath + "\"" + " \"DokaponKingdom.wbfs\""
				};
				process.StartInfo = startInfo;
                process.Start();
                // Wait for cmd to close
                process.WaitForExit();

                // Was the command successful?
                if (File.Exists("DokaponKingdom.wbfs"))
                {
                    create_wbfs_label.Text = "Successfully created DokaponKingdom.wbfs";
                }
                else
                {
                    extract_game_files_label.Text = "Error: Could not execute command. Is WIT installed?";
                }
            }
            else
            {
                create_wbfs_label.Text = "Error: Game Files folder not selected";
            }
        }

        private void Repack_Pac_Button_Click(object sender, EventArgs e)
        {
            repack_pac_label.Text = "";
            // Check for PACFiles folder
            if (!Directory.Exists("PACFiles"))
            {
                repack_pac_label.Text = "Error: PACFiles folder not found";
                return;
            }
            repack_pac_label.Text = "Creating GAME.PAC and GAME.PAH";

            if (!PACManager.PAC.Pack())
            {
                repack_pac_label.Text = "Error: Packing function failed";
                return;
            }

            // Check if file creation was successful
            if (File.Exists("GAME.PAC") && File.Exists("GAME.PAH"))
            {
                repack_pac_label.Text = "Successfully created GAME.PAC and GAME.PAH from PACFiles";
            }
            else
            {
                repack_pac_label.Text = "Error: Could not create GAME.PAC and GAME.PAH";
                return;
            }

            // Replace selected GAME.PAC and GAME.PAH
            if (pac_file)
            {
                File.Move("GAME.PAC", open_pac_dialog.FileName, true);
            }
            if (pah_file)
            {
                File.Move("GAME.PAH", open_pah_dialog.FileName, true);
            }
        }

        private void Unpack_Pac_Button_Click(object sender, EventArgs e)
        {
            unpack_pac_label.Text = "Unpacking GAME.PAC to PACFiles...";

            if (!pac_file || !pah_file)
            {
                unpack_pac_label.Text = "Error: GAME.PAC or GAME.PAH is not selected";
                return;
            }

            if (!PACManager.PAC.Unpack(open_pac_dialog.FileName, open_pah_dialog.FileName))
            {
                unpack_pac_label.Text = "Error: Unpack function failed";
                return;
            }

            if (!Directory.Exists("PACFiles"))
            {
                unpack_pac_label.Text = "Error: PACFiles folder was not created";
                return;
            }

            unpack_pac_label.Text = "Successfully extracted GAME.PAC and GAME.PAH to PACFiles";
        }
    }
}