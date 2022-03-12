namespace DokaModInterface
{
    public partial class Form1 : Form
    {
        public bool model = false;
        public bool folder = false;
        public bool hairstyle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modelFileLabel.Text = "";
            statusLabel.Text = "";
            folderLabel.Text = "";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            model = false;
            if(openmodelDialog.ShowDialog() == DialogResult.OK)
            {
                modelFileLabel.Text = openmodelDialog.FileName;
                model = true;
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
            statusLabel.Text = "";

            if (hairstyle && folder && model)
            {
                int index = hairstyleListBox.SelectedIndex + 22;
                string filename = "H" + index.ToString() + "_";

                for (int i = 1; i < 5; i++)
                {
                    File.Copy(openmodelDialog.FileName, Path.Combine(gamefilesfolderDialog.SelectedPath, filename + i.ToString() + "P.IGB"), true);
                }

                for (int i = 0; i < 7; i++)
                {
                    File.Delete(Path.Combine(gamefilesfolderDialog.SelectedPath, "H" + index.ToString() + "C" + i.ToString() + ".PIM"));
                }

                statusLabel.Text = "Done";
            }
            else
            {
                statusLabel.Text = "Error";
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            folder = false;
            if(gamefilesfolderDialog.ShowDialog() == DialogResult.OK)
            {
                folderLabel.Text = gamefilesfolderDialog.SelectedPath;
                folder = true;
            }
        }
    }
}