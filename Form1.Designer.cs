using PACManager;

namespace DokaModInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openmodelDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.applyButton = new System.Windows.Forms.Button();
            this.applystatusLabel = new System.Windows.Forms.Label();
            this.selectisowbfsButton = new System.Windows.Forms.Button();
            this.createwbfsButton = new System.Windows.Forms.Button();
            this.selectgamefilesfolderButton = new System.Windows.Forms.Button();
            this.extractgamefilesButton = new System.Windows.Forms.Button();
            this.pimdeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.hairstyleListBox = new System.Windows.Forms.ComboBox();
            this.modelFileLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.modelfolderButton = new System.Windows.Forms.Button();
            this.selectgamepacButton = new System.Windows.Forms.Button();
            this.selectgamepahButton = new System.Windows.Forms.Button();
            this.unpackgamepacButton = new System.Windows.Forms.Button();
            this.repackgamepacButton = new System.Windows.Forms.Button();
            this.selectisowbfsLabel = new System.Windows.Forms.Label();
            this.gamepacLabel = new System.Windows.Forms.Label();
            this.gamepahLabel = new System.Windows.Forms.Label();
            this.extractgamefilesLabel = new System.Windows.Forms.Label();
            this.unpackgamepacLabel = new System.Windows.Forms.Label();
            this.selectgamefilesfolderLabel = new System.Windows.Forms.Label();
            this.repackgamepacLabel = new System.Windows.Forms.Label();
            this.createwbfsLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.modelfilesfolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.extractfilesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.openisowbfsDialog = new System.Windows.Forms.OpenFileDialog();
            this.opengamepacDialog = new System.Windows.Forms.OpenFileDialog();
            this.opengamepahDialog = new System.Windows.Forms.OpenFileDialog();
            this.gamefilesfolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openmodelDialog
            // 
            this.openmodelDialog.Filter = "IGB files|*.igb|All Files|*.*";
            this.openmodelDialog.Title = "Select Model";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.62055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.56917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.62055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.56917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.62055F));
            this.tableLayoutPanel1.Controls.Add(this.applyButton, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.applystatusLabel, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.selectisowbfsButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.createwbfsButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.selectgamefilesfolderButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.extractgamefilesButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pimdeleteCheckBox, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.hairstyleListBox, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.modelFileLabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.folderLabel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.selectButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.modelfolderButton, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectgamepacButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectgamepahButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.unpackgamepacButton, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.repackgamepacButton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.selectisowbfsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gamepacLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gamepahLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.extractgamefilesLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.unpackgamepacLabel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.selectgamefilesfolderLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.repackgamepacLabel, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.createwbfsLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2108, 1131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = true;
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.Location = new System.Drawing.Point(1446, 872);
            this.applyButton.Margin = new System.Windows.Forms.Padding(6);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(656, 84);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply Mod";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // applystatusLabel
            // 
            this.applystatusLabel.AutoSize = true;
            this.applystatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applystatusLabel.Location = new System.Drawing.Point(1446, 962);
            this.applystatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.applystatusLabel.Name = "applystatusLabel";
            this.applystatusLabel.Size = new System.Drawing.Size(656, 169);
            this.applystatusLabel.TabIndex = 1;
            this.applystatusLabel.Text = "status";
            // 
            // selectisowbfsButton
            // 
            this.selectisowbfsButton.AutoSize = true;
            this.selectisowbfsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectisowbfsButton.Location = new System.Drawing.Point(6, 83);
            this.selectisowbfsButton.Margin = new System.Windows.Forms.Padding(6);
            this.selectisowbfsButton.Name = "selectisowbfsButton";
            this.selectisowbfsButton.Size = new System.Drawing.Size(654, 84);
            this.selectisowbfsButton.TabIndex = 4;
            this.selectisowbfsButton.Text = "Select ISO/WBFS";
            this.selectisowbfsButton.UseVisualStyleBackColor = true;
            this.selectisowbfsButton.Click += new System.EventHandler(this.selectisowbfsButton_Click);
            // 
            // createwbfsButton
            // 
            this.createwbfsButton.AutoSize = true;
            this.createwbfsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createwbfsButton.Location = new System.Drawing.Point(6, 872);
            this.createwbfsButton.Margin = new System.Windows.Forms.Padding(6);
            this.createwbfsButton.Name = "createwbfsButton";
            this.createwbfsButton.Size = new System.Drawing.Size(654, 84);
            this.createwbfsButton.TabIndex = 0;
            this.createwbfsButton.Text = "Create WBFS";
            this.createwbfsButton.UseVisualStyleBackColor = true;
            this.createwbfsButton.Click += new System.EventHandler(this.createwbfsButton_Click);
            // 
            // selectgamefilesfolderButton
            // 
            this.selectgamefilesfolderButton.AutoSize = true;
            this.selectgamefilesfolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectgamefilesfolderButton.Location = new System.Drawing.Point(6, 609);
            this.selectgamefilesfolderButton.Margin = new System.Windows.Forms.Padding(6);
            this.selectgamefilesfolderButton.Name = "selectgamefilesfolderButton";
            this.selectgamefilesfolderButton.Size = new System.Drawing.Size(654, 84);
            this.selectgamefilesfolderButton.TabIndex = 0;
            this.selectgamefilesfolderButton.Text = "Select Game Files Folder";
            this.selectgamefilesfolderButton.UseVisualStyleBackColor = true;
            this.selectgamefilesfolderButton.Click += new System.EventHandler(this.selectgamefilesfolderButton_Click);
            // 
            // extractgamefilesButton
            // 
            this.extractgamefilesButton.AutoSize = true;
            this.extractgamefilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractgamefilesButton.Location = new System.Drawing.Point(6, 346);
            this.extractgamefilesButton.Margin = new System.Windows.Forms.Padding(6);
            this.extractgamefilesButton.Name = "extractgamefilesButton";
            this.extractgamefilesButton.Size = new System.Drawing.Size(654, 84);
            this.extractgamefilesButton.TabIndex = 3;
            this.extractgamefilesButton.Text = "Extract Game Files";
            this.extractgamefilesButton.UseVisualStyleBackColor = true;
            this.extractgamefilesButton.Click += new System.EventHandler(this.extractgamefilesButton_Click);
            // 
            // pimdeleteCheckBox
            // 
            this.pimdeleteCheckBox.AutoSize = true;
            this.pimdeleteCheckBox.Checked = true;
            this.pimdeleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pimdeleteCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pimdeleteCheckBox.Location = new System.Drawing.Point(1446, 705);
            this.pimdeleteCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.pimdeleteCheckBox.Name = "pimdeleteCheckBox";
            this.pimdeleteCheckBox.Size = new System.Drawing.Size(656, 155);
            this.pimdeleteCheckBox.TabIndex = 1;
            this.pimdeleteCheckBox.Text = "Delete PIM files?";
            this.pimdeleteCheckBox.UseVisualStyleBackColor = true;
            this.pimdeleteCheckBox.CheckedChanged += new System.EventHandler(this.pimdeleteCheckBox_CheckedChanged);
            // 
            // hairstyleListBox
            // 
            this.hairstyleListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hairstyleListBox.FormattingEnabled = true;
            this.hairstyleListBox.Items.AddRange(new object[] {
            "Warrior (Male)",
            "Warrior (Female)",
            "Magician (Male)",
            "Magician (Female)",
            "Thief (Male)",
            "Thief (Female)",
            "Cleric (Male)",
            "Cleric (Female)",
            "Spellsword (Male)",
            "Spellsword (Female)",
            "Alchemist (Male)",
            "Alchemist (Female)",
            "Ninja (Male)",
            "Ninja (Female)",
            "Monk (Male)",
            "Monk (Female)",
            "Acrobat (Male)",
            "Acrobat (Female)",
            "Robo Knight (Male)",
            "Robo Knight (Female)",
            "Hero (Male)",
            "Hero (Female)",
            "Afro (Male)",
            "Afro (Female)",
            "Punk (Male)",
            "Punk (Female)",
            "Horror (Male)",
            "Horror (Female)",
            "Raiden (Male)",
            "Raiden (Female)",
            "Samurai",
            "Geisha",
            "Pompadour",
            "Pigtails",
            "Prince",
            "Princess",
            "Cowboy",
            "Kitty",
            "Elephant (Male)",
            "Elephant (Female)",
            "Ducky (Male)",
            "Ducky (Female)",
            "Wabbit (Male)",
            "Wabbit (Female)"});
            this.hairstyleListBox.Location = new System.Drawing.Point(1446, 609);
            this.hairstyleListBox.Margin = new System.Windows.Forms.Padding(6);
            this.hairstyleListBox.Name = "hairstyleListBox";
            this.hairstyleListBox.Size = new System.Drawing.Size(656, 56);
            this.hairstyleListBox.TabIndex = 0;
            this.hairstyleListBox.Text = "Select Hairstyle to Replace";
            this.hairstyleListBox.SelectedIndexChanged += new System.EventHandler(this.hairstyleListBox_SelectedIndexChanged);
            // 
            // modelFileLabel
            // 
            this.modelFileLabel.AutoSize = true;
            this.modelFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelFileLabel.Location = new System.Drawing.Point(1446, 173);
            this.modelFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modelFileLabel.Name = "modelFileLabel";
            this.modelFileLabel.Size = new System.Drawing.Size(656, 167);
            this.modelFileLabel.TabIndex = 1;
            this.modelFileLabel.Text = "modelpath";
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderLabel.Location = new System.Drawing.Point(1446, 436);
            this.folderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(656, 167);
            this.folderLabel.TabIndex = 1;
            this.folderLabel.Text = "modelfolderpath";
            // 
            // selectButton
            // 
            this.selectButton.AutoSize = true;
            this.selectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectButton.Location = new System.Drawing.Point(1446, 83);
            this.selectButton.Margin = new System.Windows.Forms.Padding(6);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(656, 84);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select Model File";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // modelfolderButton
            // 
            this.modelfolderButton.AutoSize = true;
            this.modelfolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelfolderButton.Location = new System.Drawing.Point(1446, 346);
            this.modelfolderButton.Margin = new System.Windows.Forms.Padding(6);
            this.modelfolderButton.Name = "modelfolderButton";
            this.modelfolderButton.Size = new System.Drawing.Size(656, 84);
            this.modelfolderButton.TabIndex = 0;
            this.modelfolderButton.Text = "Select Model Files Folder";
            this.modelfolderButton.UseVisualStyleBackColor = true;
            this.modelfolderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // selectgamepacButton
            // 
            this.selectgamepacButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectgamepacButton.Location = new System.Drawing.Point(726, 83);
            this.selectgamepacButton.Margin = new System.Windows.Forms.Padding(6);
            this.selectgamepacButton.Name = "selectgamepacButton";
            this.selectgamepacButton.Size = new System.Drawing.Size(654, 84);
            this.selectgamepacButton.TabIndex = 5;
            this.selectgamepacButton.Text = "Select GAME.PAC";
            this.selectgamepacButton.UseVisualStyleBackColor = true;
            this.selectgamepacButton.Click += new System.EventHandler(this.selectgamepacButton_Click);
            // 
            // selectgamepahButton
            // 
            this.selectgamepahButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectgamepahButton.Location = new System.Drawing.Point(726, 346);
            this.selectgamepahButton.Margin = new System.Windows.Forms.Padding(6);
            this.selectgamepahButton.Name = "selectgamepahButton";
            this.selectgamepahButton.Size = new System.Drawing.Size(654, 84);
            this.selectgamepahButton.TabIndex = 6;
            this.selectgamepahButton.Text = "Select GAME.PAH";
            this.selectgamepahButton.UseVisualStyleBackColor = true;
            this.selectgamepahButton.Click += new System.EventHandler(this.selectgamepahButton_Click);
            // 
            // unpackgamepacButton
            // 
            this.unpackgamepacButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unpackgamepacButton.Location = new System.Drawing.Point(726, 609);
            this.unpackgamepacButton.Margin = new System.Windows.Forms.Padding(6);
            this.unpackgamepacButton.Name = "unpackgamepacButton";
            this.unpackgamepacButton.Size = new System.Drawing.Size(654, 84);
            this.unpackgamepacButton.TabIndex = 7;
            this.unpackgamepacButton.Text = "Unpack GAME.PAC";
            this.unpackgamepacButton.UseVisualStyleBackColor = true;
            this.unpackgamepacButton.Click += new System.EventHandler(this.unpackgamepacButton_Click);
            // 
            // repackgamepacButton
            // 
            this.repackgamepacButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repackgamepacButton.Location = new System.Drawing.Point(726, 872);
            this.repackgamepacButton.Margin = new System.Windows.Forms.Padding(6);
            this.repackgamepacButton.Name = "repackgamepacButton";
            this.repackgamepacButton.Size = new System.Drawing.Size(654, 84);
            this.repackgamepacButton.TabIndex = 8;
            this.repackgamepacButton.Text = "Repack GAME.PAC";
            this.repackgamepacButton.UseVisualStyleBackColor = true;
            this.repackgamepacButton.Click += new System.EventHandler(this.repackgamepacButton_Click);
            // 
            // selectisowbfsLabel
            // 
            this.selectisowbfsLabel.AutoSize = true;
            this.selectisowbfsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectisowbfsLabel.Location = new System.Drawing.Point(6, 173);
            this.selectisowbfsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectisowbfsLabel.Name = "selectisowbfsLabel";
            this.selectisowbfsLabel.Size = new System.Drawing.Size(654, 167);
            this.selectisowbfsLabel.TabIndex = 9;
            this.selectisowbfsLabel.Text = "isowbfspath";
            // 
            // gamepacLabel
            // 
            this.gamepacLabel.AutoSize = true;
            this.gamepacLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamepacLabel.Location = new System.Drawing.Point(726, 173);
            this.gamepacLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gamepacLabel.Name = "gamepacLabel";
            this.gamepacLabel.Size = new System.Drawing.Size(654, 167);
            this.gamepacLabel.TabIndex = 10;
            this.gamepacLabel.Text = "gamepacpath";
            // 
            // gamepahLabel
            // 
            this.gamepahLabel.AutoSize = true;
            this.gamepahLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamepahLabel.Location = new System.Drawing.Point(726, 436);
            this.gamepahLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gamepahLabel.Name = "gamepahLabel";
            this.gamepahLabel.Size = new System.Drawing.Size(654, 167);
            this.gamepahLabel.TabIndex = 11;
            this.gamepahLabel.Text = "gamepahpath";
            // 
            // extractgamefilesLabel
            // 
            this.extractgamefilesLabel.AutoSize = true;
            this.extractgamefilesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractgamefilesLabel.Location = new System.Drawing.Point(6, 436);
            this.extractgamefilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.extractgamefilesLabel.Name = "extractgamefilesLabel";
            this.extractgamefilesLabel.Size = new System.Drawing.Size(654, 167);
            this.extractgamefilesLabel.TabIndex = 12;
            this.extractgamefilesLabel.Text = "folderpath";
            // 
            // unpackgamepacLabel
            // 
            this.unpackgamepacLabel.AutoSize = true;
            this.unpackgamepacLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unpackgamepacLabel.Location = new System.Drawing.Point(726, 699);
            this.unpackgamepacLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.unpackgamepacLabel.Name = "unpackgamepacLabel";
            this.unpackgamepacLabel.Size = new System.Drawing.Size(654, 167);
            this.unpackgamepacLabel.TabIndex = 13;
            this.unpackgamepacLabel.Text = "folderpath";
            // 
            // selectgamefilesfolderLabel
            // 
            this.selectgamefilesfolderLabel.AutoSize = true;
            this.selectgamefilesfolderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectgamefilesfolderLabel.Location = new System.Drawing.Point(6, 699);
            this.selectgamefilesfolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectgamefilesfolderLabel.Name = "selectgamefilesfolderLabel";
            this.selectgamefilesfolderLabel.Size = new System.Drawing.Size(654, 167);
            this.selectgamefilesfolderLabel.TabIndex = 14;
            this.selectgamefilesfolderLabel.Text = "gamefilesfolderpath";
            // 
            // repackgamepacLabel
            // 
            this.repackgamepacLabel.AutoSize = true;
            this.repackgamepacLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repackgamepacLabel.Location = new System.Drawing.Point(726, 962);
            this.repackgamepacLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.repackgamepacLabel.Name = "repackgamepacLabel";
            this.repackgamepacLabel.Size = new System.Drawing.Size(654, 169);
            this.repackgamepacLabel.TabIndex = 15;
            this.repackgamepacLabel.Text = "status";
            // 
            // createwbfsLabel
            // 
            this.createwbfsLabel.AutoSize = true;
            this.createwbfsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createwbfsLabel.Location = new System.Drawing.Point(6, 962);
            this.createwbfsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.createwbfsLabel.Name = "createwbfsLabel";
            this.createwbfsLabel.Size = new System.Drawing.Size(654, 169);
            this.createwbfsLabel.TabIndex = 16;
            this.createwbfsLabel.Text = "status+wbfspath";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(654, 77);
            this.label9.TabIndex = 17;
            this.label9.Text = "ISO/WBFS Tools";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(726, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(654, 77);
            this.label10.TabIndex = 18;
            this.label10.Text = "Archive Tools";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1446, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(656, 77);
            this.label11.TabIndex = 19;
            this.label11.Text = "Installation Tools";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // extractfilesButton
            // 
            this.extractfilesButton.Location = new System.Drawing.Point(3, 3);
            this.extractfilesButton.Name = "extractfilesButton";
            this.extractfilesButton.Size = new System.Drawing.Size(194, 35);
            this.extractfilesButton.TabIndex = 3;
            this.extractfilesButton.Text = "Extract Game Files";
            this.extractfilesButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Extract Game Files";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openisowbfsDialog
            // 
            this.openisowbfsDialog.Filter = "ISO files|*.iso|WBFS Files|*.wbfs|All Files|*.*";
            this.openisowbfsDialog.FilterIndex = 3;
            this.openisowbfsDialog.Title = "Select ISO/WBFS";
            // 
            // opengamepacDialog
            // 
            this.opengamepacDialog.Filter = "PAC File|*.PAC|All Files|*.*";
            this.opengamepacDialog.Title = "Select GAME.PAC";
            // 
            // opengamepahDialog
            // 
            this.opengamepahDialog.Filter = "PAH File|*.PAH|All Files|*.*";
            this.opengamepahDialog.Title = "Select GAME.PAH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2108, 1131);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Hairstyle Mod Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openmodelDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private Button selectButton;
        private Label modelFileLabel;
        private Button applyButton;
        private Label applystatusLabel;
        private ComboBox hairstyleListBox;
        private Button modelfolderButton;
        private Label folderLabel;
        private FolderBrowserDialog modelfilesfolderDialog;
        private CheckBox pimdeleteCheckBox;
        private Button selectgamefilesfolderButton;
        private Button createwbfsButton;
        private Button selectisowbfsButton;
        private Button extractgamefilesButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button extractfilesButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button2;
        private Button selectgamepacButton;
        private Button selectgamepahButton;
        private Button unpackgamepacButton;
        private Button repackgamepacButton;
        private Label selectisowbfsLabel;
        private Label gamepacLabel;
        private Label gamepahLabel;
        private Label extractgamefilesLabel;
        private Label unpackgamepacLabel;
        private Label selectgamefilesfolderLabel;
        private Label repackgamepacLabel;
        private Label createwbfsLabel;
        private Label label9;
        private Label label10;
        private Label label11;
        private OpenFileDialog openisowbfsDialog;
        private OpenFileDialog opengamepacDialog;
        private OpenFileDialog opengamepahDialog;
        private FolderBrowserDialog gamefilesfolderDialog;
    }
}