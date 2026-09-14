namespace Launcher
{
	partial class Options
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.OptionsPanel = new System.Windows.Forms.Panel();
			this.Configurations_txt = new System.Windows.Forms.Label();
			this.AccountPanel = new System.Windows.Forms.Panel();
			this.Account_txt = new System.Windows.Forms.Label();
			this.User_box = new System.Windows.Forms.TextBox();
			this.LanguagePanel = new System.Windows.Forms.Panel();
			this.Language_box = new System.Windows.Forms.ComboBox();
			this.Language_txt = new System.Windows.Forms.Label();
			this.ResolutionPanel = new System.Windows.Forms.Panel();
			this.Resolution_box = new System.Windows.Forms.ComboBox();
			this.Resolution_txt = new System.Windows.Forms.Label();
			this.WindowMode = new System.Windows.Forms.CheckBox();
			this.SoundPanel = new System.Windows.Forms.Panel();
			this.VolumeLevel = new System.Windows.Forms.TrackBar();
			this.Volume_txt = new System.Windows.Forms.Label();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Btn_Close = new System.Windows.Forms.PictureBox();
			this.Sound_check = new System.Windows.Forms.CheckBox();
			this.Music_check = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.OptionsPanel.SuspendLayout();
			this.AccountPanel.SuspendLayout();
			this.LanguagePanel.SuspendLayout();
			this.ResolutionPanel.SuspendLayout();
			this.SoundPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// OptionsPanel
			// 
			this.OptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.OptionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OptionsPanel.Controls.Add(this.Configurations_txt);
			this.OptionsPanel.Location = new System.Drawing.Point(12, 35);
			this.OptionsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OptionsPanel.Name = "OptionsPanel";
			this.OptionsPanel.Size = new System.Drawing.Size(422, 58);
			this.OptionsPanel.TabIndex = 0;
			// 
			// Configurations_txt
			// 
			this.Configurations_txt.BackColor = System.Drawing.Color.Transparent;
			this.Configurations_txt.Font = new System.Drawing.Font("Verdana", 11F);
			this.Configurations_txt.Location = new System.Drawing.Point(3, 11);
			this.Configurations_txt.Name = "Configurations_txt";
			this.Configurations_txt.Size = new System.Drawing.Size(416, 36);
			this.Configurations_txt.TabIndex = 0;
			this.Configurations_txt.Tag = "CONFIGURATIONS_TXT";
			this.Configurations_txt.Text = "Configurations of the game";
			this.Configurations_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AccountPanel
			// 
			this.AccountPanel.BackColor = System.Drawing.Color.Transparent;
			this.AccountPanel.Controls.Add(this.Account_txt);
			this.AccountPanel.Controls.Add(this.User_box);
			this.AccountPanel.Location = new System.Drawing.Point(44, 110);
			this.AccountPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AccountPanel.Name = "AccountPanel";
			this.AccountPanel.Size = new System.Drawing.Size(361, 33);
			this.AccountPanel.TabIndex = 1;
			// 
			// Account_txt
			// 
			this.Account_txt.BackColor = System.Drawing.Color.Transparent;
			this.Account_txt.Location = new System.Drawing.Point(17, 4);
			this.Account_txt.Name = "Account_txt";
			this.Account_txt.Size = new System.Drawing.Size(162, 25);
			this.Account_txt.TabIndex = 0;
			this.Account_txt.Tag = "USER_TXT";
			this.Account_txt.Text = "Account";
			this.Account_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// User_box
			// 
			this.User_box.BackColor = System.Drawing.Color.Black;
			this.User_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.User_box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.User_box.Location = new System.Drawing.Point(185, 3);
			this.User_box.MaxLength = 20;
			this.User_box.Name = "User_box";
			this.User_box.Size = new System.Drawing.Size(150, 25);
			this.User_box.TabIndex = 1;
			// 
			// LanguagePanel
			// 
			this.LanguagePanel.BackColor = System.Drawing.Color.Transparent;
			this.LanguagePanel.Controls.Add(this.Language_box);
			this.LanguagePanel.Controls.Add(this.Language_txt);
			this.LanguagePanel.Location = new System.Drawing.Point(44, 160);
			this.LanguagePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LanguagePanel.Name = "LanguagePanel";
			this.LanguagePanel.Size = new System.Drawing.Size(361, 33);
			this.LanguagePanel.TabIndex = 2;
			// 
			// Language_box
			// 
			this.Language_box.BackColor = System.Drawing.Color.Black;
			this.Language_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Language_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Language_box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Language_box.FormattingEnabled = true;
			this.Language_box.ItemHeight = 18;
			this.Language_box.Location = new System.Drawing.Point(185, 3);
			this.Language_box.Name = "Language_box";
			this.Language_box.Size = new System.Drawing.Size(150, 26);
			this.Language_box.TabIndex = 1;
			this.Language_box.SelectedIndexChanged += new System.EventHandler(this.Language_box_SelectedIndexChanged);
			// 
			// Language_txt
			// 
			this.Language_txt.BackColor = System.Drawing.Color.Transparent;
			this.Language_txt.Location = new System.Drawing.Point(17, 4);
			this.Language_txt.Name = "Language_txt";
			this.Language_txt.Size = new System.Drawing.Size(162, 25);
			this.Language_txt.TabIndex = 0;
			this.Language_txt.Tag = "LANGUAGE_TXT";
			this.Language_txt.Text = "Language";
			this.Language_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ResolutionPanel
			// 
			this.ResolutionPanel.BackColor = System.Drawing.Color.Transparent;
			this.ResolutionPanel.Controls.Add(this.Resolution_box);
			this.ResolutionPanel.Controls.Add(this.Resolution_txt);
			this.ResolutionPanel.Location = new System.Drawing.Point(44, 210);
			this.ResolutionPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ResolutionPanel.Name = "ResolutionPanel";
			this.ResolutionPanel.Size = new System.Drawing.Size(361, 33);
			this.ResolutionPanel.TabIndex = 3;
			// 
			// Resolution_box
			// 
			this.Resolution_box.BackColor = System.Drawing.Color.Black;
			this.Resolution_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Resolution_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Resolution_box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Resolution_box.FormattingEnabled = true;
			this.Resolution_box.ItemHeight = 18;
			this.Resolution_box.Location = new System.Drawing.Point(185, 3);
			this.Resolution_box.Name = "Resolution_box";
			this.Resolution_box.Size = new System.Drawing.Size(150, 26);
			this.Resolution_box.TabIndex = 1;
			// 
			// Resolution_txt
			// 
			this.Resolution_txt.BackColor = System.Drawing.Color.Transparent;
			this.Resolution_txt.Location = new System.Drawing.Point(17, 4);
			this.Resolution_txt.Name = "Resolution_txt";
			this.Resolution_txt.Size = new System.Drawing.Size(162, 25);
			this.Resolution_txt.TabIndex = 0;
			this.Resolution_txt.Tag = "RESOLUTION_TXT";
			this.Resolution_txt.Text = "Resolution";
			this.Resolution_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WindowMode
			// 
			this.WindowMode.Appearance = System.Windows.Forms.Appearance.Button;
			this.WindowMode.AutoSize = true;
			this.WindowMode.BackColor = System.Drawing.Color.Transparent;
			this.WindowMode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WindowMode.FlatAppearance.BorderSize = 0;
			this.WindowMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.WindowMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.WindowMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.WindowMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WindowMode.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.WindowMode.Image = global::Launcher.Properties.Resources.CheckBox_u;
			this.WindowMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.WindowMode.Location = new System.Drawing.Point(116, 2);
			this.WindowMode.Name = "WindowMode";
			this.WindowMode.Size = new System.Drawing.Size(139, 28);
			this.WindowMode.TabIndex = 1;
			this.WindowMode.Tag = "WINDOWMODE_TXT";
			this.WindowMode.Text = "Window Mode";
			this.WindowMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.WindowMode.UseVisualStyleBackColor = false;
			// 
			// SoundPanel
			// 
			this.SoundPanel.BackColor = System.Drawing.Color.Transparent;
			this.SoundPanel.Controls.Add(this.VolumeLevel);
			this.SoundPanel.Controls.Add(this.Volume_txt);
			this.SoundPanel.Location = new System.Drawing.Point(44, 310);
			this.SoundPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SoundPanel.Name = "SoundPanel";
			this.SoundPanel.Size = new System.Drawing.Size(361, 33);
			this.SoundPanel.TabIndex = 5;
			// 
			// VolumeLevel
			// 
			this.VolumeLevel.AutoSize = false;
			this.VolumeLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.VolumeLevel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.VolumeLevel.LargeChange = 1;
			this.VolumeLevel.Location = new System.Drawing.Point(185, 3);
			this.VolumeLevel.Maximum = 9;
			this.VolumeLevel.Name = "VolumeLevel";
			this.VolumeLevel.Size = new System.Drawing.Size(150, 28);
			this.VolumeLevel.TabIndex = 1;
			// 
			// Volume_txt
			// 
			this.Volume_txt.BackColor = System.Drawing.Color.Transparent;
			this.Volume_txt.Location = new System.Drawing.Point(17, 4);
			this.Volume_txt.Name = "Volume_txt";
			this.Volume_txt.Size = new System.Drawing.Size(162, 25);
			this.Volume_txt.TabIndex = 0;
			this.Volume_txt.Tag = "VOLUME_TXT";
			this.Volume_txt.Text = "Volume";
			this.Volume_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Btn_Save
			// 
			this.Btn_Save.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Save.BackgroundImage = global::Launcher.Properties.Resources.Accept_n;
			this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Save.FlatAppearance.BorderSize = 0;
			this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Save.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Btn_Save.Location = new System.Drawing.Point(170, 410);
			this.Btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(108, 43);
			this.Btn_Save.TabIndex = 7;
			this.Btn_Save.TabStop = false;
			this.Btn_Save.Tag = "SAVE_TXT";
			this.Btn_Save.Text = "Save";
			this.Btn_Save.UseVisualStyleBackColor = false;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// Btn_Close
			// 
			this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.BackgroundImage = global::Launcher.Properties.Resources.Cerrar_n;
			this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Close.Location = new System.Drawing.Point(422, 6);
			this.Btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn_Close.Name = "Btn_Close";
			this.Btn_Close.Size = new System.Drawing.Size(18, 18);
			this.Btn_Close.TabIndex = 0;
			this.Btn_Close.TabStop = false;
			this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// Sound_check
			// 
			this.Sound_check.Appearance = System.Windows.Forms.Appearance.Button;
			this.Sound_check.AutoSize = true;
			this.Sound_check.BackColor = System.Drawing.Color.Transparent;
			this.Sound_check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Sound_check.FlatAppearance.BorderSize = 0;
			this.Sound_check.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.Sound_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Sound_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Sound_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sound_check.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Sound_check.Image = global::Launcher.Properties.Resources.CheckBox_u;
			this.Sound_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Sound_check.Location = new System.Drawing.Point(55, 3);
			this.Sound_check.Name = "Sound_check";
			this.Sound_check.Size = new System.Drawing.Size(89, 28);
			this.Sound_check.TabIndex = 1;
			this.Sound_check.Tag = "SOUND_TXT";
			this.Sound_check.Text = "Sounds";
			this.Sound_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Sound_check.UseVisualStyleBackColor = false;
			// 
			// Music_check
			// 
			this.Music_check.Appearance = System.Windows.Forms.Appearance.Button;
			this.Music_check.AutoSize = true;
			this.Music_check.BackColor = System.Drawing.Color.Transparent;
			this.Music_check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Music_check.FlatAppearance.BorderSize = 0;
			this.Music_check.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.Music_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Music_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Music_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Music_check.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Music_check.Image = global::Launcher.Properties.Resources.CheckBox_u;
			this.Music_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Music_check.Location = new System.Drawing.Point(225, 3);
			this.Music_check.Name = "Music_check";
			this.Music_check.Size = new System.Drawing.Size(75, 28);
			this.Music_check.TabIndex = 2;
			this.Music_check.Tag = "MUSIC_TXT";
			this.Music_check.Text = "Music";
			this.Music_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Music_check.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.WindowMode);
			this.panel1.Location = new System.Drawing.Point(44, 260);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(361, 33);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.Music_check);
			this.panel2.Controls.Add(this.Sound_check);
			this.panel2.Location = new System.Drawing.Point(44, 360);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(361, 33);
			this.panel2.TabIndex = 6;
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::Launcher.Properties.Resources.OptionsBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(446, 461);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.SoundPanel);
			this.Controls.Add(this.ResolutionPanel);
			this.Controls.Add(this.LanguagePanel);
			this.Controls.Add(this.AccountPanel);
			this.Controls.Add(this.OptionsPanel);
			this.Controls.Add(this.Btn_Save);
			this.Controls.Add(this.Btn_Close);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 11F);
			this.ForeColor = System.Drawing.Color.DarkOrange;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.Options_Load);
			this.OptionsPanel.ResumeLayout(false);
			this.AccountPanel.ResumeLayout(false);
			this.AccountPanel.PerformLayout();
			this.LanguagePanel.ResumeLayout(false);
			this.ResolutionPanel.ResumeLayout(false);
			this.SoundPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VolumeLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Btn_Close;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Panel OptionsPanel;
		private System.Windows.Forms.Label Configurations_txt;
		private System.Windows.Forms.Panel AccountPanel;
		private System.Windows.Forms.Panel LanguagePanel;
		private System.Windows.Forms.Panel ResolutionPanel;
		private System.Windows.Forms.Panel SoundPanel;
		private System.Windows.Forms.TextBox User_box;
		private System.Windows.Forms.Label Account_txt;
		private System.Windows.Forms.Label Language_txt;
		private System.Windows.Forms.Label Resolution_txt;
		private System.Windows.Forms.Label Volume_txt;
		private System.Windows.Forms.ComboBox Language_box;
		private System.Windows.Forms.CheckBox WindowMode;
		private System.Windows.Forms.ComboBox Resolution_box;
		private System.Windows.Forms.TrackBar VolumeLevel;
		private System.Windows.Forms.CheckBox Music_check;
		private System.Windows.Forms.CheckBox Sound_check;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}