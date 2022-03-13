namespace DokaModInterface
{
    public partial class Form1 : Form
    {
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            modelfile = false;
            if(openmodelDialog.ShowDialog() == DialogResult.OK)
            {
                modelFileLabel.Text = openmodelDialog.FileName;
                modelfile = true;
            }
        }

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

        private void applyButton_Click(object sender, EventArgs e)
        {
            applystatusLabel.Text = "";

            if (hairstyle && modelfolder && modelfile)
            {
                int index = hairstyleListBox.SelectedIndex + 22;
                string filename = "H" + index.ToString() + "_";

                for (int i = 1; i < 5; i++)
                {
                    File.Copy(openmodelDialog.FileName, Path.Combine(modelfilesfolderDialog.SelectedPath, filename + i.ToString() + "P.IGB"), true);
                }

                for (int i = 0; i < 7; i++)
                {
                    File.Delete(Path.Combine(modelfilesfolderDialog.SelectedPath, "H" + index.ToString() + "C" + i.ToString() + ".PIM"));
                }

                applystatusLabel.Text = "Successfully installed mod";
            }
            else
            {
                applystatusLabel.Text = "Error: Not all parameters are selected";
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            modelfolder = false;
            if(modelfilesfolderDialog.ShowDialog() == DialogResult.OK)
            {
                folderLabel.Text = modelfilesfolderDialog.SelectedPath;
                modelfolder = true;
            }
        }

        private void selectisowbfsButton_Click(object sender, EventArgs e)
        {
            isowbfsfile = false;
            if(openisowbfsDialog.ShowDialog() == DialogResult.OK)
            {
                selectisowbfsLabel.Text = openisowbfsDialog.FileName;
                isowbfsfile = true;
            }
        }

        private void selectgamepacButton_Click(object sender, EventArgs e)
        {
            gamepacfile = false;
            if(opengamepacDialog.ShowDialog() == DialogResult.OK)
            {
                gamepacLabel.Text = opengamepacDialog.FileName;
                gamepacfile = true;
            }
        }

        private void selectgamepahButton_Click(object sender, EventArgs e)
        {
            gamepahfile = false;
            if(opengamepahDialog.ShowDialog() == DialogResult.OK)
            {
                gamepahLabel.Text = opengamepahDialog.FileName;
                gamepahfile = true;
            }
        }

        private void selectgamefilesfolderButton_Click(object sender, EventArgs e)
        {
            gamefilesfolder = false;
            if(gamefilesfolderDialog.ShowDialog() == DialogResult.OK)
            {
                selectgamefilesfolderLabel.Text = gamefilesfolderDialog.SelectedPath;
                gamefilesfolder = true;
            }
        }

        private void extractgamefilesButton_Click(object sender, EventArgs e)
        {
            extractgamefilesLabel.Text = "";
            if (isowbfsfile)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C wit extract " + "\"" + openisowbfsDialog.FileName + "\"" + " \"DokaponFiles\"";
                process.StartInfo = startInfo;
                process.Start();

                extractgamefilesLabel.Text = "Successfully extracted game files to DokaponFiles";
            }
            else
            {
                extractgamefilesLabel.Text = "Error: No ISO/WBFS file selected";
            }
        }

        private void createwbfsButton_Click(object sender, EventArgs e)
        {
            createwbfsLabel.Text = "";
            if(gamefilesfolder)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C wit copy " + "\"" + gamefilesfolderDialog.SelectedPath + "\"" + " \"DokaponKingdom.wbfs\"";
                process.StartInfo = startInfo;
                process.Start();

                createwbfsLabel.Text = "Successfully created DokaponKingdom.wbfs";
            }
            else
            {
                createwbfsLabel.Text = "Error: Game Files folder not selected";
            }
        }
    }
}