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
            this.pimdeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.modelFileLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.applyButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.Label();
            this.hairstyleListBox = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.gamefilesfolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openmodelDialog
            // 
            this.openmodelDialog.FileName = "openFileDialog1";
            this.openmodelDialog.Filter = "IGB files|*.igb|All Files|*.*";
            this.openmodelDialog.Title = "Select Model File";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pimdeleteCheckBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.modelFileLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.folderLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hairstyleListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.selectButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pimdeleteCheckBox
            // 
            this.pimdeleteCheckBox.Checked = true;
            this.pimdeleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pimdeleteCheckBox.Location = new System.Drawing.Point(3, 198);
            this.pimdeleteCheckBox.Name = "pimdeleteCheckBox";
            this.pimdeleteCheckBox.Size = new System.Drawing.Size(204, 37);
            this.pimdeleteCheckBox.TabIndex = 1;
            this.pimdeleteCheckBox.Text = "Delete PIM files?";
            this.pimdeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelFileLabel
            // 
            this.modelFileLabel.AutoSize = true;
            this.modelFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelFileLabel.Location = new System.Drawing.Point(213, 0);
            this.modelFileLabel.Name = "modelFileLabel";
            this.modelFileLabel.Size = new System.Drawing.Size(370, 75);
            this.modelFileLabel.TabIndex = 1;
            this.modelFileLabel.Text = "modelfilename";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.applyButton);
            this.flowLayoutPanel3.Controls.Add(this.statusLabel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 243);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(204, 76);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(3, 3);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(201, 35);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 41);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(59, 25);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "status";
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderLabel.Location = new System.Drawing.Point(213, 75);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(370, 75);
            this.folderLabel.TabIndex = 1;
            this.folderLabel.Text = "foldername";
            // 
            // hairstyleListBox
            // 
            this.hairstyleListBox.FormattingEnabled = true;
            this.hairstyleListBox.Items.AddRange(new object[] {
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
            this.hairstyleListBox.Location = new System.Drawing.Point(3, 153);
            this.hairstyleListBox.Name = "hairstyleListBox";
            this.hairstyleListBox.Size = new System.Drawing.Size(204, 33);
            this.hairstyleListBox.TabIndex = 0;
            this.hairstyleListBox.Text = "Select Hairstyle";
            this.hairstyleListBox.SelectedIndexChanged += new System.EventHandler(this.hairstyleListBox_SelectedIndexChanged);
            // 
            // selectButton
            // 
            this.selectButton.AutoSize = true;
            this.selectButton.Location = new System.Drawing.Point(3, 3);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(204, 35);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select Model";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(3, 78);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(204, 35);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Select Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hairstyle Mod Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openmodelDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private Button selectButton;
        private Label modelFileLabel;
        private Button applyButton;
        private Label statusLabel;
        private ComboBox hairstyleListBox;
        private Button folderButton;
        private Label folderLabel;
        private FolderBrowserDialog gamefilesfolderDialog;
        private CheckBox pimdeleteCheckBox;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}