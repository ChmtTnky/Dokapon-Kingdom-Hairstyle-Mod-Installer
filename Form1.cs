using System.Text;

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

        // Packer Functions
        static void WriteInt32(FileStream f, int value)
        {
            f.Write(BitConverter.GetBytes(value), 0, 4);
        }
        static int ReadInt32(FileStream f)
        {
            byte[] tmp = new byte[4];
            f.Read(tmp, 0, 4);
            return BitConverter.ToInt32(tmp, 0);
        }

        // Archive Packer made by Yacker
        // Modified slightly by ChmtTnky
        // Finds PACFiles folder and makes GAME.PAC and GAME.PAH from its contents
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

            // okay let's iterate over the folder
            string[] files = Directory.GetFiles("PACFiles");
            string[] fileNames = new string[files.Length];

            for (int i = 0; i < files.Length; ++i)
            {
                fileNames[i] = Path.GetFileName(files[i]);
            }

            uint[] fileSizes = new uint[files.Length];
            uint[] fileOffs = new uint[files.Length];
            // output PAC
            FileStream PAC, PAH;
            try
            {
                PAC = File.Open("GAME.PAC", FileMode.OpenOrCreate, FileAccess.Write);
            }
            catch
            {
                repackgamepacLabel.Text = "Failed to open GAME.PAC!";
                return;
            }
            try
            {
                PAH = File.Open("GAME.PAH", FileMode.OpenOrCreate, FileAccess.Write);
            }
            catch
            {
                repackgamepacLabel.Text = "Failed to open GAME.PAH!";
                return;
            }
            // open all the files and read them
            uint totalFileSize = 0;
            byte[] data = new byte[0];
            byte[] padding = new byte[0x800];
            for (int i = 0; i < files.Length; ++i)
            {
                FileStream fs = File.Open(files[i], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                // get file size
                fs.Seek(0, SeekOrigin.End);
                fileSizes[i] = (uint)fs.Position;
                fileOffs[i] = totalFileSize;
                totalFileSize += (uint)fs.Position;
                // now read the data
                fs.Seek(0, SeekOrigin.Begin);
                if (fileSizes[i] > data.Length)
                {
                    data = new byte[fileSizes[i]];
                }
                fs.Read(data, 0, (int)fileSizes[i]);
                // great, done
                fs.Close();
                // write the data to PAC now
                PAC.Write(data, 0, (int)fileSizes[i]);
                // pad it out to nearest 0x800
                int padCount = (int)(0x800 - (PAC.Position % 0x800));
                if (padCount != 0x800)
                {
                    PAC.Write(padding, 0, padCount);
                    totalFileSize += (uint)padCount;
                }
            }
            PAC.Close();
            // PAC exists, now write PAH
            // write file count
            WriteInt32(PAH, files.Length);
            // always 0x70
            WriteInt32(PAH, 0x70);
            // create alphabetical listings
            List<ushort>[] alphabetIDs = new List<ushort>[26];
            int totalAlphabetSpace = 0; // account for size
            int[] alphabetOffsets = new int[26];
            for (int i = 0; i < 26; ++i)
            {
                alphabetIDs[i] = new List<ushort>();
            }
            for (int i = 0; i < fileNames.Length; ++i)
            {
                byte[] strAscii = ASCIIEncoding.ASCII.GetBytes(fileNames[i]);
                if (strAscii[0] >= 0x61)
                {
                    strAscii[0] -= 0x20;
                }
                strAscii[0] -= 0x41;
                alphabetIDs[strAscii[0]].Add((ushort)i);
            }
            // set up offsets for them
            for (int i = 0; i < 26; ++i)
            {
                alphabetOffsets[i] = totalAlphabetSpace + (files.Length * 0x10) + 0x70;
                totalAlphabetSpace += (alphabetIDs[i].Count + 1) * 2;
            }
            // write the alphabet data offsets
            int stringOffs = (files.Length * 0x10) + 0x70 + totalAlphabetSpace;
            for (int i = 0; i < 26; ++i)
            {
                WriteInt32(PAH, alphabetOffsets[i]);
            }
            // write the file data now
            for (int i = 0; i < files.Length; ++i)
            {
                WriteInt32(PAH, (int)fileOffs[i]);
                WriteInt32(PAH, (int)fileSizes[i]);
                // ?
                WriteInt32(PAH, 0);
                // string offset
                WriteInt32(PAH, stringOffs);
                // update string offset
                stringOffs += fileNames[i].Length + 1;
                if (stringOffs % 2 != 0)
                {
                    stringOffs += 1;
                }
            }
            // write alphabet data
            for (int i = 0; i < 26; ++i)
            {
                PAH.Write(BitConverter.GetBytes((short)alphabetIDs[i].Count), 0, 2);
                for (int i2 = 0; i2 < alphabetIDs[i].Count; ++i2)
                {
                    PAH.Write(BitConverter.GetBytes(alphabetIDs[i][i2]), 0, 2);
                }
            }
            byte[] zero = new byte[1];
            zero[0] = 0;
            // string time
            for (int i = 0; i < files.Length; ++i)
            {
                // write file names simply
                byte[] currFileName = ASCIIEncoding.ASCII.GetBytes(fileNames[i]);
                PAH.Write(currFileName, 0, currFileName.Length);
                // and 1 0
                PAH.Write(zero, 0, 1);
                // and one more if we must
                if (PAH.Position % 2 != 0)
                {
                    PAH.Write(zero, 0, 1);
                }
            }
            // great, we're done!
            PAH.Close();

            // Replace selected GAME.PAC and GAME.PAH
            if (gamepacfile)
            {
                File.Move("GAME.PAC", opengamepacDialog.FileName, true);
            }
            if (gamepahfile)
            {
                File.Move("GAME.PAH", opengamepahDialog.FileName, true);
            }

            repackgamepacLabel.Text = "Successfully created GAME.PAC and GAME.PAH from PACFiles";
        }

        static int ReadInt(FileStream fs)
        {
            byte[] buff = new byte[4];
            fs.Read(buff, 0, 4);
            return BitConverter.ToInt32(buff);
        }

        // Unpacker Functions
        static string ReadString(FileStream fs)
        {
            string retVal = "";
            byte[] buff = new byte[1];
            fs.Read(buff);
            while (buff[0] != 0)
            {
                retVal += System.Text.Encoding.ASCII.GetString(buff);
                fs.Read(buff);
            }
            return retVal;
        }

        // Unpacker made by Yacker
        // Modified by ChmtTnky
        // Takes selected GAME.PAC and GAME.PAH and extracts the GAME.PAC to a foler called PACFiles
        private void unpackgamepacButton_Click(object sender, EventArgs e)
        {
            unpackgamepacLabel.Text = "Unpacking GAME.PAC to PACFiles...";

            if (!Directory.Exists("PACFiles"))
            {
                unpackgamepacLabel.Text = "Could not find PACFiles folder";
            }

            string sdir = "PACFiles";
            string spac = opengamepacDialog.FileName;
            string spah = opengamepahDialog.FileName;

            FileStream pac, pah;
            try
            {
                pac = File.Open(spac, FileMode.Open);
                pah = File.Open(spah, FileMode.Open);
            }
            catch
            {
                unpackgamepacLabel.Text = "Failed to open either pac or pah file";
                return;
            }
            Directory.CreateDirectory(sdir);
            int fCount = ReadInt(pah);
            int fOffs = ReadInt(pah);
            for (int i = 0; i < fCount; ++i)
            {
                pah.Seek(fOffs + (0x10 * i), SeekOrigin.Begin);
                int currFileOffs = ReadInt(pah);
                int currFileSize = ReadInt(pah);
                // blank
                ReadInt(pah);
                int fileNameOffs = ReadInt(pah);
                pah.Seek(fileNameOffs, SeekOrigin.Begin);
                string newFileName = ReadString(pah);
                // just read the actual data and we're done
                pac.Seek(currFileOffs, SeekOrigin.Begin);
                byte[] fileData = new byte[currFileSize];
                pac.Read(fileData);
                FileStream newFile = File.Open(sdir + "\\" + newFileName, FileMode.Create);
                newFile.Write(fileData);
                newFile.Close();
            }
            pac.Close();
            pah.Close();

            unpackgamepacLabel.Text = "Successfully extracted GAME.PAC and GAME.PAH to PACFiles";
        }
    }
}