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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.extractfilesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.open_iso_wbfs_dialog = new System.Windows.Forms.OpenFileDialog();
            this.hairstyle_list_box = new System.Windows.Forms.ComboBox();
            this.finish_button = new System.Windows.Forms.Button();
            this.mod_folder_label = new System.Windows.Forms.Label();
            this.select_mod_folder_button = new System.Windows.Forms.Button();
            this.select_iso_wbfs_label = new System.Windows.Forms.Label();
            this.select_iso_wbfs_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pim_red_label = new System.Windows.Forms.Label();
            this.pim_blue_label = new System.Windows.Forms.Label();
            this.pim_black_label = new System.Windows.Forms.Label();
            this.pim_white_label = new System.Windows.Forms.Label();
            this.pim_green_label = new System.Windows.Forms.Label();
            this.pim_pink_label = new System.Windows.Forms.Label();
            this.pim_yellow_label = new System.Windows.Forms.Label();
            this.igb_file_label = new System.Windows.Forms.Label();
            this.apply_mod_button = new System.Windows.Forms.Button();
            this.open_mod_folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.open_igb_model_dialog = new System.Windows.Forms.OpenFileDialog();
            this.open_pim_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // open_iso_wbfs_dialog
            // 
            this.open_iso_wbfs_dialog.Filter = "ISO files|*.iso|WBFS Files|*.wbfs|All Files|*.*";
            this.open_iso_wbfs_dialog.FilterIndex = 3;
            this.open_iso_wbfs_dialog.Title = "Select ISO/WBFS";
            // 
            // hairstyle_list_box
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
            this.hairstyle_list_box.Location = new System.Drawing.Point(5, 800);
            this.hairstyle_list_box.Margin = new System.Windows.Forms.Padding(5);
            this.hairstyle_list_box.Name = "hairstyle_list_box";
            this.hairstyle_list_box.Size = new System.Drawing.Size(712, 56);
            this.hairstyle_list_box.TabIndex = 0;
            this.hairstyle_list_box.Text = "Select Hairstyle to Replace";
            this.hairstyle_list_box.SelectedIndexChanged += new System.EventHandler(this.Hairstyle_List_Select_Change);
            // 
            // finish_button
            // 
            this.finish_button.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.finish_button, 2);
            this.finish_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finish_button.Location = new System.Drawing.Point(5, 1118);
            this.finish_button.Margin = new System.Windows.Forms.Padding(5);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(1435, 150);
            this.finish_button.TabIndex = 0;
            this.finish_button.Text = "Finish";
            this.finish_button.UseVisualStyleBackColor = true;
            this.finish_button.Click += new System.EventHandler(this.Finish_Button_Click);
            // 
            // mod_folder_label
            // 
            this.mod_folder_label.AutoSize = true;
            this.mod_folder_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mod_folder_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mod_folder_label.Location = new System.Drawing.Point(5, 477);
            this.mod_folder_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mod_folder_label.Name = "mod_folder_label";
            this.mod_folder_label.Size = new System.Drawing.Size(712, 159);
            this.mod_folder_label.TabIndex = 1;
            this.mod_folder_label.Text = "mod_folder_path";
            // 
            // select_mod_folder_button
            // 
            this.select_mod_folder_button.AutoSize = true;
            this.select_mod_folder_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select_mod_folder_button.Location = new System.Drawing.Point(5, 323);
            this.select_mod_folder_button.Margin = new System.Windows.Forms.Padding(5);
            this.select_mod_folder_button.Name = "select_mod_folder_button";
            this.select_mod_folder_button.Size = new System.Drawing.Size(712, 149);
            this.select_mod_folder_button.TabIndex = 0;
            this.select_mod_folder_button.Text = "Select Mod Folder";
            this.select_mod_folder_button.UseVisualStyleBackColor = true;
            this.select_mod_folder_button.Click += new System.EventHandler(this.Select_Mod_Folder_Button_Click);
            // 
            // select_iso_wbfs_label
            // 
            this.select_iso_wbfs_label.AutoSize = true;
            this.select_iso_wbfs_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select_iso_wbfs_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_iso_wbfs_label.Location = new System.Drawing.Point(5, 159);
            this.select_iso_wbfs_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.select_iso_wbfs_label.Name = "select_iso_wbfs_label";
            this.select_iso_wbfs_label.Size = new System.Drawing.Size(712, 159);
            this.select_iso_wbfs_label.TabIndex = 9;
            this.select_iso_wbfs_label.Text = "iso_wbfs_path";
            // 
            // select_iso_wbfs_button
            // 
            this.select_iso_wbfs_button.AutoSize = true;
            this.select_iso_wbfs_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select_iso_wbfs_button.Location = new System.Drawing.Point(5, 5);
            this.select_iso_wbfs_button.Margin = new System.Windows.Forms.Padding(5);
            this.select_iso_wbfs_button.Name = "select_iso_wbfs_button";
            this.select_iso_wbfs_button.Size = new System.Drawing.Size(712, 149);
            this.select_iso_wbfs_button.TabIndex = 4;
            this.select_iso_wbfs_button.Text = "Select ISO/WBFS";
            this.select_iso_wbfs_button.UseVisualStyleBackColor = true;
            this.select_iso_wbfs_button.Click += new System.EventHandler(this.Select_ISO_WBFS_Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.select_iso_wbfs_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.select_iso_wbfs_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pim_red_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pim_blue_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pim_black_label, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.mod_folder_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pim_white_label, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pim_green_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.select_mod_folder_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pim_pink_label, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pim_yellow_label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.igb_file_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.hairstyle_list_box, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.apply_mod_button, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.finish_button, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1445, 1273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pim_red_label
            // 
            this.pim_red_label.AutoSize = true;
            this.pim_red_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pim_red_label.Location = new System.Drawing.Point(725, 0);
            this.pim_red_label.Name = "pim_red_label";
            this.pim_red_label.Size = new System.Drawing.Size(717, 159);
            this.pim_red_label.TabIndex = 22;
            this.pim_red_label.Text = "pim_red";
            this.pim_red_label.Click += new System.EventHandler(this.pim_red_label_Click);
            // 
            // pim_blue_label
            // 
            this.pim_blue_label.AutoSize = true;
            this.pim_blue_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pim_blue_label.Location = new System.Drawing.Point(725, 159);
            this.pim_blue_label.Name = "pim_blue_label";
            this.pim_blue_label.Size = new System.Drawing.Size(717, 159);
            this.pim_blue_label.TabIndex = 23;
            this.pim_blue_label.Text = "pim_blue";
            this.pim_blue_label.Click += new System.EventHandler(this.pim_blue_label_Click);
            // 
            // pim_black_label
            // 
            this.pim_black_label.AutoSize = true;
            this.pim_black_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pim_black_label.Location = new System.Drawing.Point(725, 954);
            this.pim_black_label.Name = "pim_black_label";
            this.pim_black_label.Size = new System.Drawing.Size(717, 159);
            this.pim_black_label.TabIndex = 28;
            this.pim_black_label.Text = "pim_black";
            this.pim_black_label.Click += new System.EventHandler(this.pim_black_label_Click);
            // 
            // pim_white_label
            // 
            this.pim_white_label.AutoSize = true;
            this.pim_white_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pim_white_label.Location = new System.Drawing.Point(725, 795);
            this.pim_white_label.Name = "pim_white_label";
            this.pim_white_label.Size = new System.Drawing.Size(717, 159);
            this.pim_white_label.TabIndex = 26;
            this.pim_white_label.Text = "pim_white";
            this.pim_white_label.Click += new System.EventHandler(this.pim_white_label_Click);
            // 
            // pim_green_label
            // 
            this.pim_green_label.AutoSize = true;
            this.pim_green_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pim_green_label.Location = new System.Drawing.Point(725, 318);
            this.pim_green_label.Name = "pim_green_label";
            this.pim_green_label.Size = new System.Drawing.Size(717, 159);
            this.pim_green_label.TabIndex = 24;
            this.pim_green_label.Text = "pim_green";
            this.pim_green_label.Click += new System.EventHandler(this.pim_green_label_Click);
            // 
            // pim_pink_label
            // 
            this.pim_pink_label.AutoSize = true;
            this.pim_pink_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pim_pink_label.Location = new System.Drawing.Point(725, 636);
            this.pim_pink_label.Name = "pim_pink_label";
            this.pim_pink_label.Size = new System.Drawing.Size(717, 159);
            this.pim_pink_label.TabIndex = 27;
            this.pim_pink_label.Text = "pim_pink";
            this.pim_pink_label.Click += new System.EventHandler(this.pim_pink_label_Click);
            // 
            // pim_yellow_label
            // 
            this.pim_yellow_label.AutoSize = true;
            this.pim_yellow_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pim_yellow_label.Location = new System.Drawing.Point(725, 477);
            this.pim_yellow_label.Name = "pim_yellow_label";
            this.pim_yellow_label.Size = new System.Drawing.Size(717, 159);
            this.pim_yellow_label.TabIndex = 25;
            this.pim_yellow_label.Text = "pim_yellow";
            this.pim_yellow_label.Click += new System.EventHandler(this.pim_yellow_label_Click);
            // 
            // igb_file_label
            // 
            this.igb_file_label.AutoSize = true;
            this.igb_file_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.igb_file_label.Location = new System.Drawing.Point(3, 636);
            this.igb_file_label.Name = "igb_file_label";
            this.igb_file_label.Size = new System.Drawing.Size(716, 159);
            this.igb_file_label.TabIndex = 21;
            this.igb_file_label.Text = "igb_file";
            this.igb_file_label.Click += new System.EventHandler(this.igb_file_label_Click);
            // 
            // apply_mod_button
            // 
            this.apply_mod_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apply_mod_button.Location = new System.Drawing.Point(3, 957);
            this.apply_mod_button.Name = "apply_mod_button";
            this.apply_mod_button.Size = new System.Drawing.Size(716, 153);
            this.apply_mod_button.TabIndex = 19;
            this.apply_mod_button.Text = "Apply Mod";
            this.apply_mod_button.UseVisualStyleBackColor = true;
            this.apply_mod_button.Click += new System.EventHandler(this.Apply_Mod_Button_Click);
            // 
            // open_igb_model_dialog
            // 
            this.open_igb_model_dialog.Filter = "IGB files|*.igb|All Files|*.*";
            // 
            // open_pim_file_dialog
            // 
            this.open_pim_file_dialog.Filter = "PIM files|*.pim|All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 1273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Hairstyle Mod Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private TableLayoutPanel tableLayoutPanel2;
		private Button extractfilesButton;
		private TableLayoutPanel tableLayoutPanel4;
		private Button button2;
		private OpenFileDialog open_iso_wbfs_dialog;
		private ComboBox hairstyle_list_box;
		private Button finish_button;
		private Label mod_folder_label;
		private Button select_mod_folder_button;
		private Label select_iso_wbfs_label;
		private Button select_iso_wbfs_button;
		private TableLayoutPanel tableLayoutPanel1;
		private Button apply_mod_button;
		private FolderBrowserDialog open_mod_folder_dialog;
		private Label pim_red_label;
		private Label pim_blue_label;
		private Label pim_green_label;
		private Label pim_black_label;
		private Label pim_yellow_label;
		private Label pim_white_label;
		private Label pim_pink_label;
		private Label igb_file_label;
		private OpenFileDialog open_igb_model_dialog;
		private OpenFileDialog open_pim_file_dialog;
	}
}