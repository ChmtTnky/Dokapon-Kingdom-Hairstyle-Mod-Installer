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
			this.open_model_dialog = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.applyButton = new System.Windows.Forms.Button();
			this.apply_status_label = new System.Windows.Forms.Label();
			this.selectisowbfsButton = new System.Windows.Forms.Button();
			this.createwbfsButton = new System.Windows.Forms.Button();
			this.selectgamefilesfolderButton = new System.Windows.Forms.Button();
			this.extractgamefilesButton = new System.Windows.Forms.Button();
			this.pim_delete_checkbox = new System.Windows.Forms.CheckBox();
			this.hairstyle_list_box = new System.Windows.Forms.ComboBox();
			this.model_file_label = new System.Windows.Forms.Label();
			this.folder_label = new System.Windows.Forms.Label();
			this.selectButton = new System.Windows.Forms.Button();
			this.modelfolderButton = new System.Windows.Forms.Button();
			this.selectgamepacButton = new System.Windows.Forms.Button();
			this.selectgamepahButton = new System.Windows.Forms.Button();
			this.unpackgamepacButton = new System.Windows.Forms.Button();
			this.repackgamepacButton = new System.Windows.Forms.Button();
			this.select_iso_wbfs_label = new System.Windows.Forms.Label();
			this.pac_label = new System.Windows.Forms.Label();
			this.pah_label = new System.Windows.Forms.Label();
			this.extract_game_files_label = new System.Windows.Forms.Label();
			this.unpack_pac_label = new System.Windows.Forms.Label();
			this.select_game_files_folder_label = new System.Windows.Forms.Label();
			this.repack_pac_label = new System.Windows.Forms.Label();
			this.create_wbfs_label = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.model_files_folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.extractfilesButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.open_iso_wbfs_dialog = new System.Windows.Forms.OpenFileDialog();
			this.open_pac_dialog = new System.Windows.Forms.OpenFileDialog();
			this.open_pah_dialog = new System.Windows.Forms.OpenFileDialog();
			this.game_files_folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openmodelDialog
			// 
			this.open_model_dialog.Filter = "IGB files|*.igb|All Files|*.*";
			this.open_model_dialog.Title = "Select Model";
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
			this.tableLayoutPanel1.Controls.Add(this.apply_status_label, 4, 8);
			this.tableLayoutPanel1.Controls.Add(this.selectisowbfsButton, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.createwbfsButton, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.selectgamefilesfolderButton, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.extractgamefilesButton, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.pim_delete_checkbox, 4, 6);
			this.tableLayoutPanel1.Controls.Add(this.hairstyle_list_box, 4, 5);
			this.tableLayoutPanel1.Controls.Add(this.model_file_label, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.folder_label, 4, 4);
			this.tableLayoutPanel1.Controls.Add(this.selectButton, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.modelfolderButton, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.selectgamepacButton, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.selectgamepahButton, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.unpackgamepacButton, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.repackgamepacButton, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.select_iso_wbfs_label, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.pac_label, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.pah_label, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.extract_game_files_label, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.unpack_pac_label, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.select_game_files_folder_label, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.repack_pac_label, 2, 8);
			this.tableLayoutPanel1.Controls.Add(this.create_wbfs_label, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label11, 4, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 9;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 440);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// applyButton
			// 
			this.applyButton.AutoSize = true;
			this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.applyButton.Location = new System.Drawing.Point(526, 340);
			this.applyButton.Margin = new System.Windows.Forms.Padding(2);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(242, 36);
			this.applyButton.TabIndex = 0;
			this.applyButton.Text = "Apply Mod";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.Apply_Button_Click);
			// 
			// applystatusLabel
			// 
			this.apply_status_label.AutoSize = true;
			this.apply_status_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.apply_status_label.Location = new System.Drawing.Point(526, 378);
			this.apply_status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.apply_status_label.Name = "applystatusLabel";
			this.apply_status_label.Size = new System.Drawing.Size(242, 62);
			this.apply_status_label.TabIndex = 1;
			this.apply_status_label.Text = "status";
			// 
			// selectisowbfsButton
			// 
			this.selectisowbfsButton.AutoSize = true;
			this.selectisowbfsButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectisowbfsButton.Location = new System.Drawing.Point(2, 34);
			this.selectisowbfsButton.Margin = new System.Windows.Forms.Padding(2);
			this.selectisowbfsButton.Name = "selectisowbfsButton";
			this.selectisowbfsButton.Size = new System.Drawing.Size(239, 36);
			this.selectisowbfsButton.TabIndex = 4;
			this.selectisowbfsButton.Text = "Select ISO/WBFS";
			this.selectisowbfsButton.UseVisualStyleBackColor = true;
			this.selectisowbfsButton.Click += new System.EventHandler(this.Select_ISO_WBFS_Button_Click);
			// 
			// createwbfsButton
			// 
			this.createwbfsButton.AutoSize = true;
			this.createwbfsButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.createwbfsButton.Location = new System.Drawing.Point(2, 340);
			this.createwbfsButton.Margin = new System.Windows.Forms.Padding(2);
			this.createwbfsButton.Name = "createwbfsButton";
			this.createwbfsButton.Size = new System.Drawing.Size(239, 36);
			this.createwbfsButton.TabIndex = 0;
			this.createwbfsButton.Text = "Create WBFS";
			this.createwbfsButton.UseVisualStyleBackColor = true;
			this.createwbfsButton.Click += new System.EventHandler(this.Create_WBFS_Button_Click);
			// 
			// selectgamefilesfolderButton
			// 
			this.selectgamefilesfolderButton.AutoSize = true;
			this.selectgamefilesfolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectgamefilesfolderButton.Location = new System.Drawing.Point(2, 238);
			this.selectgamefilesfolderButton.Margin = new System.Windows.Forms.Padding(2);
			this.selectgamefilesfolderButton.Name = "selectgamefilesfolderButton";
			this.selectgamefilesfolderButton.Size = new System.Drawing.Size(239, 36);
			this.selectgamefilesfolderButton.TabIndex = 0;
			this.selectgamefilesfolderButton.Text = "Select Game Files Folder";
			this.selectgamefilesfolderButton.UseVisualStyleBackColor = true;
			this.selectgamefilesfolderButton.Click += new System.EventHandler(this.SelectGameFilesFolderButton_Click);
			// 
			// extractgamefilesButton
			// 
			this.extractgamefilesButton.AutoSize = true;
			this.extractgamefilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.extractgamefilesButton.Location = new System.Drawing.Point(2, 136);
			this.extractgamefilesButton.Margin = new System.Windows.Forms.Padding(2);
			this.extractgamefilesButton.Name = "extractgamefilesButton";
			this.extractgamefilesButton.Size = new System.Drawing.Size(239, 36);
			this.extractgamefilesButton.TabIndex = 3;
			this.extractgamefilesButton.Text = "Extract Game Files";
			this.extractgamefilesButton.UseVisualStyleBackColor = true;
			this.extractgamefilesButton.Click += new System.EventHandler(this.ExtractGameFilesButton_Click);
			// 
			// pimdeleteCheckBox
			// 
			this.pim_delete_checkbox.AutoSize = true;
			this.pim_delete_checkbox.Checked = true;
			this.pim_delete_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.pim_delete_checkbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pim_delete_checkbox.Location = new System.Drawing.Point(526, 278);
			this.pim_delete_checkbox.Margin = new System.Windows.Forms.Padding(2);
			this.pim_delete_checkbox.Name = "pimdeleteCheckBox";
			this.pim_delete_checkbox.Size = new System.Drawing.Size(242, 58);
			this.pim_delete_checkbox.TabIndex = 1;
			this.pim_delete_checkbox.Text = "Delete PIM files?";
			this.pim_delete_checkbox.UseVisualStyleBackColor = true;
			this.pim_delete_checkbox.CheckedChanged += new System.EventHandler(this.Delete_PIM_Checkbox_Click);
			// 
			// hairstyleListBox
			// 
			this.hairstyle_list_box.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hairstyle_list_box.FormattingEnabled = true;
			this.hairstyle_list_box.Items.AddRange(new object[] {
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
			this.hairstyle_list_box.Location = new System.Drawing.Point(526, 238);
			this.hairstyle_list_box.Margin = new System.Windows.Forms.Padding(2);
			this.hairstyle_list_box.Name = "hairstyleListBox";
			this.hairstyle_list_box.Size = new System.Drawing.Size(242, 28);
			this.hairstyle_list_box.TabIndex = 0;
			this.hairstyle_list_box.Text = "Select Hairstyle to Replace";
			this.hairstyle_list_box.SelectedIndexChanged += new System.EventHandler(this.hairstyleListBox_SelectedIndexChanged);
			// 
			// modelFileLabel
			// 
			this.model_file_label.AutoSize = true;
			this.model_file_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.model_file_label.Location = new System.Drawing.Point(526, 72);
			this.model_file_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.model_file_label.Name = "modelFileLabel";
			this.model_file_label.Size = new System.Drawing.Size(242, 62);
			this.model_file_label.TabIndex = 1;
			this.model_file_label.Text = "modelpath";
			// 
			// folderLabel
			// 
			this.folder_label.AutoSize = true;
			this.folder_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.folder_label.Location = new System.Drawing.Point(526, 174);
			this.folder_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.folder_label.Name = "folderLabel";
			this.folder_label.Size = new System.Drawing.Size(242, 62);
			this.folder_label.TabIndex = 1;
			this.folder_label.Text = "modelfolderpath";
			// 
			// selectButton
			// 
			this.selectButton.AutoSize = true;
			this.selectButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectButton.Location = new System.Drawing.Point(526, 34);
			this.selectButton.Margin = new System.Windows.Forms.Padding(2);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(242, 36);
			this.selectButton.TabIndex = 0;
			this.selectButton.Text = "Select Model File";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.Select_Button_Click);
			// 
			// modelfolderButton
			// 
			this.modelfolderButton.AutoSize = true;
			this.modelfolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modelfolderButton.Location = new System.Drawing.Point(526, 136);
			this.modelfolderButton.Margin = new System.Windows.Forms.Padding(2);
			this.modelfolderButton.Name = "modelfolderButton";
			this.modelfolderButton.Size = new System.Drawing.Size(242, 36);
			this.modelfolderButton.TabIndex = 0;
			this.modelfolderButton.Text = "Select Model Files Folder";
			this.modelfolderButton.UseVisualStyleBackColor = true;
			this.modelfolderButton.Click += new System.EventHandler(this.Folder_Button_Click);
			// 
			// selectgamepacButton
			// 
			this.selectgamepacButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectgamepacButton.Location = new System.Drawing.Point(264, 34);
			this.selectgamepacButton.Margin = new System.Windows.Forms.Padding(2);
			this.selectgamepacButton.Name = "selectgamepacButton";
			this.selectgamepacButton.Size = new System.Drawing.Size(239, 36);
			this.selectgamepacButton.TabIndex = 5;
			this.selectgamepacButton.Text = "Select GAME.PAC";
			this.selectgamepacButton.UseVisualStyleBackColor = true;
			this.selectgamepacButton.Click += new System.EventHandler(this.Select_Pac_Button_Click);
			// 
			// selectgamepahButton
			// 
			this.selectgamepahButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectgamepahButton.Location = new System.Drawing.Point(264, 136);
			this.selectgamepahButton.Margin = new System.Windows.Forms.Padding(2);
			this.selectgamepahButton.Name = "selectgamepahButton";
			this.selectgamepahButton.Size = new System.Drawing.Size(239, 36);
			this.selectgamepahButton.TabIndex = 6;
			this.selectgamepahButton.Text = "Select GAME.PAH";
			this.selectgamepahButton.UseVisualStyleBackColor = true;
			this.selectgamepahButton.Click += new System.EventHandler(this.Select_Pah_Button_Click);
			// 
			// unpackgamepacButton
			// 
			this.unpackgamepacButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.unpackgamepacButton.Location = new System.Drawing.Point(264, 238);
			this.unpackgamepacButton.Margin = new System.Windows.Forms.Padding(2);
			this.unpackgamepacButton.Name = "unpackgamepacButton";
			this.unpackgamepacButton.Size = new System.Drawing.Size(239, 36);
			this.unpackgamepacButton.TabIndex = 7;
			this.unpackgamepacButton.Text = "Unpack GAME.PAC";
			this.unpackgamepacButton.UseVisualStyleBackColor = true;
			this.unpackgamepacButton.Click += new System.EventHandler(this.Unpack_Pac_Button_Click);
			// 
			// repackgamepacButton
			// 
			this.repackgamepacButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.repackgamepacButton.Location = new System.Drawing.Point(264, 340);
			this.repackgamepacButton.Margin = new System.Windows.Forms.Padding(2);
			this.repackgamepacButton.Name = "repackgamepacButton";
			this.repackgamepacButton.Size = new System.Drawing.Size(239, 36);
			this.repackgamepacButton.TabIndex = 8;
			this.repackgamepacButton.Text = "Repack GAME.PAC";
			this.repackgamepacButton.UseVisualStyleBackColor = true;
			this.repackgamepacButton.Click += new System.EventHandler(this.Repack_Pac_Button_Click);
			// 
			// selectisowbfsLabel
			// 
			this.select_iso_wbfs_label.AutoSize = true;
			this.select_iso_wbfs_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.select_iso_wbfs_label.Location = new System.Drawing.Point(2, 72);
			this.select_iso_wbfs_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.select_iso_wbfs_label.Name = "selectisowbfsLabel";
			this.select_iso_wbfs_label.Size = new System.Drawing.Size(239, 62);
			this.select_iso_wbfs_label.TabIndex = 9;
			this.select_iso_wbfs_label.Text = "isowbfspath";
			// 
			// gamepacLabel
			// 
			this.pac_label.AutoSize = true;
			this.pac_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pac_label.Location = new System.Drawing.Point(264, 72);
			this.pac_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pac_label.Name = "gamepacLabel";
			this.pac_label.Size = new System.Drawing.Size(239, 62);
			this.pac_label.TabIndex = 10;
			this.pac_label.Text = "gamepacpath";
			// 
			// gamepahLabel
			// 
			this.pah_label.AutoSize = true;
			this.pah_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pah_label.Location = new System.Drawing.Point(264, 174);
			this.pah_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pah_label.Name = "gamepahLabel";
			this.pah_label.Size = new System.Drawing.Size(239, 62);
			this.pah_label.TabIndex = 11;
			this.pah_label.Text = "gamepahpath";
			// 
			// extractgamefilesLabel
			// 
			this.extract_game_files_label.AutoSize = true;
			this.extract_game_files_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.extract_game_files_label.Location = new System.Drawing.Point(2, 174);
			this.extract_game_files_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.extract_game_files_label.Name = "extractgamefilesLabel";
			this.extract_game_files_label.Size = new System.Drawing.Size(239, 62);
			this.extract_game_files_label.TabIndex = 12;
			this.extract_game_files_label.Text = "folderpath";
			// 
			// unpackgamepacLabel
			// 
			this.unpack_pac_label.AutoSize = true;
			this.unpack_pac_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.unpack_pac_label.Location = new System.Drawing.Point(264, 276);
			this.unpack_pac_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.unpack_pac_label.Name = "unpackgamepacLabel";
			this.unpack_pac_label.Size = new System.Drawing.Size(239, 62);
			this.unpack_pac_label.TabIndex = 13;
			this.unpack_pac_label.Text = "folderpath";
			// 
			// selectgamefilesfolderLabel
			// 
			this.select_game_files_folder_label.AutoSize = true;
			this.select_game_files_folder_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.select_game_files_folder_label.Location = new System.Drawing.Point(2, 276);
			this.select_game_files_folder_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.select_game_files_folder_label.Name = "selectgamefilesfolderLabel";
			this.select_game_files_folder_label.Size = new System.Drawing.Size(239, 62);
			this.select_game_files_folder_label.TabIndex = 14;
			this.select_game_files_folder_label.Text = "gamefilesfolderpath";
			// 
			// repackgamepacLabel
			// 
			this.repack_pac_label.AutoSize = true;
			this.repack_pac_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.repack_pac_label.Location = new System.Drawing.Point(264, 378);
			this.repack_pac_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.repack_pac_label.Name = "repackgamepacLabel";
			this.repack_pac_label.Size = new System.Drawing.Size(239, 62);
			this.repack_pac_label.TabIndex = 15;
			this.repack_pac_label.Text = "status";
			// 
			// createwbfsLabel
			// 
			this.create_wbfs_label.AutoSize = true;
			this.create_wbfs_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.create_wbfs_label.Location = new System.Drawing.Point(2, 378);
			this.create_wbfs_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.create_wbfs_label.Name = "createwbfsLabel";
			this.create_wbfs_label.Size = new System.Drawing.Size(239, 62);
			this.create_wbfs_label.TabIndex = 16;
			this.create_wbfs_label.Text = "status+wbfspath";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(2, 0);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(239, 32);
			this.label9.TabIndex = 17;
			this.label9.Text = "ISO/WBFS Tools";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(264, 0);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(239, 32);
			this.label10.TabIndex = 18;
			this.label10.Text = "Archive Tools";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(526, 0);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(242, 32);
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
			this.open_iso_wbfs_dialog.Filter = "ISO files|*.iso|WBFS Files|*.wbfs|All Files|*.*";
			this.open_iso_wbfs_dialog.FilterIndex = 3;
			this.open_iso_wbfs_dialog.Title = "Select ISO/WBFS";
			// 
			// opengamepacDialog
			// 
			this.open_pac_dialog.Filter = "PAC File|*.PAC|All Files|*.*";
			this.open_pac_dialog.Title = "Select GAME.PAC";
			// 
			// opengamepahDialog
			// 
			this.open_pah_dialog.Filter = "PAH File|*.PAH|All Files|*.*";
			this.open_pah_dialog.Title = "Select GAME.PAH";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 440);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Hairstyle Mod Installer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private OpenFileDialog open_model_dialog;
		private TableLayoutPanel tableLayoutPanel1;
		private Button selectButton;
		private Label model_file_label;
		private Button applyButton;
		private Label apply_status_label;
		private ComboBox hairstyle_list_box;
		private Button modelfolderButton;
		private Label folder_label;
		private FolderBrowserDialog model_files_folder_dialog;
		private CheckBox pim_delete_checkbox;
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
		private Label select_iso_wbfs_label;
		private Label pac_label;
		private Label pah_label;
		private Label extract_game_files_label;
		private Label unpack_pac_label;
		private Label select_game_files_folder_label;
		private Label repack_pac_label;
		private Label create_wbfs_label;
		private Label label9;
		private Label label10;
		private Label label11;
		private OpenFileDialog open_iso_wbfs_dialog;
		private OpenFileDialog open_pac_dialog;
		private OpenFileDialog open_pah_dialog;
		private FolderBrowserDialog game_files_folder_dialog;
	}
}