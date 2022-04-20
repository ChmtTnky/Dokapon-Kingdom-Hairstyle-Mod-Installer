namespace DokaModInterface
{
    public partial class Form1 : Form
    {
        // Various flags indictaing which selections have been made
        public bool deletepim = true;
        public bool modelfile = false;
        public bool modelfolder = false;
        public bool hairstyle = false;
        public bool isowbfsfile = false;
        public bool gamefilesfolder = false;
        public bool gamepacfile = false;
        public bool gamepahfile = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Clear all labels
        private void Form1_Load(object sender, EventArgs e)
        {
            modelFileLabel.Text = "";
            applystatusLabel.Text = "";
            folderLabel.Text = "";
            selectisowbfsLabel.Text = "";
            extractgamefilesLabel.Text = "";
            selectgamefilesfolderLabel.Text = "";
            createwbfsLabel.Text = "";
            gamepacLabel.Text = "";
            gamepahLabel.Text = "";
            unpackgamepacLabel.Text = "";
            repackgamepacLabel.Text = "";
        }

        // Get checkbox state
        private void pimdeleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            deletepim = pimdeleteCheckBox.Checked;
        }

        // Select model button
        // Opens dialog to select IGB file
        private void selectButton_Click(object sender, EventArgs e)
        {
            modelFileLabel.Text = "";
            modelfile = false;
            if(openmodelDialog.ShowDialog() == DialogResult.OK)
            {
                modelFileLabel.Text = openmodelDialog.FileName;
                modelfile = true;
            }
        }

        // Select hairstyle from dropdown box
        // If a hairstyle is selected, set the flag to indicate that.
        private void hairstyleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hairstyleListBox.SelectedIndex != -1)
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
        private void applyButton_Click(object sender, EventArgs e)
        {
            applystatusLabel.Text = "";

            if (hairstyle && modelfolder && modelfile) // only apply if all required options have been selected
            {
                string modelfileheader;
                string pimfileheader;

                if (hairstyleListBox.SelectedIndex < 22)
                {
                    string indextostring = hairstyleListBox.SelectedIndex.ToString();
                    if (hairstyleListBox.SelectedIndex < 10)
                    {
                        indextostring = "0" + indextostring;
                    }

                    modelfileheader = Path.Combine(modelfilesfolderDialog.SelectedPath, "C" + indextostring + "A");
                    pimfileheader = Path.Combine(modelfilesfolderDialog.SelectedPath, "C" + indextostring + "A" + "_H");
                }
                else
                {
                    modelfileheader = Path.Combine(modelfilesfolderDialog.SelectedPath, "H" + hairstyleListBox.SelectedIndex.ToString());
                    pimfileheader = Path.Combine(modelfilesfolderDialog.SelectedPath, "H" + hairstyleListBox.SelectedIndex.ToString() + "C");
                }

                for (int i = 1; i < 5; i++)
                {
                    File.Copy(openmodelDialog.FileName, modelfileheader + "_" + i.ToString() + "P.IGB", true);
                }

                if (deletepim)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        File.Delete(Path.Combine(modelfilesfolderDialog.SelectedPath, pimfileheader + i.ToString() + ".PIM"));
                    }
                }

                applystatusLabel.Text = "Successfully installed mod";
            }
            else
            {
                applystatusLabel.Text = "Error: Not all parameters are selected";
            }
        }

        // Select model files folder button
        // Opens dialog to select folder
        private void folderButton_Click(object sender, EventArgs e)
        {
            folderLabel.Text = "";
            modelfolder = false;
            if(modelfilesfolderDialog.ShowDialog() == DialogResult.OK)
            {
                folderLabel.Text = modelfilesfolderDialog.SelectedPath;
                modelfolder = true;
            }
        }

        // Select ISO/WBFS button
        // Opens dialog to select file
        private void selectisowbfsButton_Click(object sender, EventArgs e)
        {
            selectisowbfsLabel.Text = "";
            isowbfsfile = false;
            if(openisowbfsDialog.ShowDialog() == DialogResult.OK)
            {
                selectisowbfsLabel.Text = openisowbfsDialog.FileName;
                isowbfsfile = true;
            }
        }

        // Select GAME.PAC file
        // Opens dialog to select file
        private void selectgamepacButton_Click(object sender, EventArgs e)
        {
            gamepacLabel.Text = "";
            gamepacfile = false;
            if(opengamepacDialog.ShowDialog() == DialogResult.OK)
            {
                gamepacLabel.Text = opengamepacDialog.FileName;
                gamepacfile = true;
            }
        }

        // Select GAME.PAH file
        // Opens dialog to select file
        private void selectgamepahButton_Click(object sender, EventArgs e)
        {
            gamepahLabel.Text = "";
            gamepahfile = false;
            if(opengamepahDialog.ShowDialog() == DialogResult.OK)
            {
                gamepahLabel.Text = opengamepahDialog.FileName;
                gamepahfile = true;
            }
        }

        // Select game files folder
        // Opens dialog to select folder
        private void selectgamefilesfolderButton_Click(object sender, EventArgs e)
        {
            selectgamefilesfolderLabel.Text = "";
            gamefilesfolder = false;
            if(gamefilesfolderDialog.ShowDialog() == DialogResult.OK)
            {
                selectgamefilesfolderLabel.Text = gamefilesfolderDialog.SelectedPath;
                gamefilesfolder = true;
            }
        }

        // Extract game files button
        // Opens a cmd and enters the wit command to extract the files
        // wit extract "Selectediso/wbfs" "DokaponFiles"
        private void extractgamefilesButton_Click(object sender, EventArgs e)
        {
            extractgamefilesLabel.Text = "";
            if (Directory.Exists("DokaponFiles"))
            {
                extractgamefilesLabel.Text = "Error: DokaponFiles folder already exists. Please delete or move before trying again";
                return;
            }

            if (isowbfsfile) // Has iso or wbfs been selected?
            {
                // Start cmd process
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                // Write and execute command to extract files
                startInfo.Arguments = "/C wit extract " + "\"" + openisowbfsDialog.FileName + "\"" + " \"DokaponFiles\"";
                process.StartInfo = startInfo;
                process.Start();
                // Wait for cmd to close
                process.WaitForExit();

                // Was the command successful?
                if (Directory.Exists("DokaponFiles"))
                {
                    extractgamefilesLabel.Text = "Successfully extracted game files to DokaponFiles";
                }
                else
                {
                    extractgamefilesLabel.Text = "Error: Could not execute command. Is WIT installed?";
                }
            }
            else
            {
                extractgamefilesLabel.Text = "Error: No ISO/WBFS file selected";
            }
        }

        // Create Wbfs Button
        // Opens a cmd and enters the wit command to make the wbfs for you
        // wit copy "gamefilesfolder" "DokaponKingdom.wbfs"
        private void createwbfsButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("DokaponKingdom.wbfs"))
            {
                createwbfsLabel.Text = "DokaponKingdom.wbfs already exists. Please move or delete it before trying again.";
                return;
            }
            createwbfsLabel.Text = "";
            if(gamefilesfolder) // Has the game files folder been selected?
            {
                // Start cmd process
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                // Write and execute command to create new wbfs
                startInfo.Arguments = "/C wit copy " + "\"" + gamefilesfolderDialog.SelectedPath + "\"" + " \"DokaponKingdom.wbfs\"";
                process.StartInfo = startInfo;
                process.Start();
                // Wait for cmd to close
                process.WaitForExit();

                // Was the command successful?
                if (File.Exists("DokaponKingdom.wbfs"))
                {
                    createwbfsLabel.Text = "Successfully created DokaponKingdom.wbfs";
                }
                else
                {
                    extractgamefilesLabel.Text = "Error: Could not execute command. Is WIT installed?";
                }
            }
            else
            {
                createwbfsLabel.Text = "Error: Game Files folder not selected";
            }
        }

        private void repackgamepacButton_Click(object sender, EventArgs e)
        {
            repackgamepacLabel.Text = "";
            // Check for PACFiles folder
            if (!Directory.Exists("PACFiles"))
            {
                repackgamepacLabel.Text = "Error: PACFiles folder not found";
                return;
            }
            repackgamepacLabel.Text = "Creating GAME.PAC and GAME.PAH";

            if (!PACManager.PAC.Pack())
            {
                repackgamepacLabel.Text = "Error: Packing function failed";
                return;
            }

            // Check if file creation was successful
            if (File.Exists("GAME.PAC") && File.Exists("GAME.PAH"))
            {
                repackgamepacLabel.Text = "Successfully created GAME.PAC and GAME.PAH from PACFiles";
            }
            else
            {
                repackgamepacLabel.Text = "Error: Could not create GAME.PAC and GAME.PAH";
                return;
            }

            // Replace selected GAME.PAC and GAME.PAH
            if (gamepacfile)
            {
                File.Move("GAME.PAC", opengamepacDialog.FileName, true);
            }
            if (gamepahfile)
            {
                File.Move("GAME.PAH", opengamepahDialog.FileName, true);
            }
        }

        private void unpackgamepacButton_Click(object sender, EventArgs e)
        {
            unpackgamepacLabel.Text = "Unpacking GAME.PAC to PACFiles...";

            if (!gamepacfile || !gamepahfile)
            {
                unpackgamepacLabel.Text = "Error: GAME.PAC or GAME.PAH is not selected";
                return;
            }

            if (!PACManager.PAC.Unpack(opengamepacDialog.FileName, opengamepahDialog.FileName))
            {
                unpackgamepacLabel.Text = "Error: Unpack function failed";
                return;
            }

            if (!Directory.Exists("PACFiles"))
            {
                unpackgamepacLabel.Text = "Error: PACFiles folder was not created";
                return;
            }

            unpackgamepacLabel.Text = "Successfully extracted GAME.PAC and GAME.PAH to PACFiles";
        }
    }
}