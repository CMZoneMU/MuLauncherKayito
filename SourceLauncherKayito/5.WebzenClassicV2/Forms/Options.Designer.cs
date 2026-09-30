using MuLauncher;
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
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Btn_Close = new System.Windows.Forms.Button();
			this.User_panel = new System.Windows.Forms.GroupBox();
			this.USER_TXT = new System.Windows.Forms.Label();
			this.User_box = new System.Windows.Forms.TextBox();
			this.Graphics_panel = new System.Windows.Forms.GroupBox();
			this.Resolution_box = new System.Windows.Forms.ComboBox();
			this.WindowMode = new System.Windows.Forms.CheckBox();
			this.Sound_panel = new System.Windows.Forms.GroupBox();
			this.VolumeLevel = new System.Windows.Forms.TrackBar();
			this.Music_check = new System.Windows.Forms.CheckBox();
			this.Sound_check = new System.Windows.Forms.CheckBox();
			this.Language_panel = new System.Windows.Forms.GroupBox();
			this.Language_Por = new System.Windows.Forms.RadioButton();
			this.Language_Spn = new System.Windows.Forms.RadioButton();
			this.Language_Eng = new System.Windows.Forms.RadioButton();
			this.User_panel.SuspendLayout();
			this.Graphics_panel.SuspendLayout();
			this.Sound_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeLevel)).BeginInit();
			this.Language_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Save
			// 
			this.Btn_Save.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Save.BackgroundImage")));
			this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Save.FlatAppearance.BorderSize = 0;
			this.Btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Save.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Save.ForeColor = System.Drawing.Color.Goldenrod;
			this.Btn_Save.Location = new System.Drawing.Point(217, 367);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(74, 22);
			this.Btn_Save.TabIndex = 7;
			this.Btn_Save.Tag = "SAVE_TXT";
			this.Btn_Save.Text = "Save";
			this.Btn_Save.UseVisualStyleBackColor = false;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// Btn_Close
			// 
			this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Close.BackgroundImage")));
			this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Close.FlatAppearance.BorderSize = 0;
			this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Close.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Close.ForeColor = System.Drawing.Color.Goldenrod;
			this.Btn_Close.Location = new System.Drawing.Point(79, 367);
			this.Btn_Close.Name = "Btn_Close";
			this.Btn_Close.Size = new System.Drawing.Size(74, 22);
			this.Btn_Close.TabIndex = 5;
			this.Btn_Close.Tag = "CLOSE_TXT";
			this.Btn_Close.Text = "Close";
			this.Btn_Close.UseVisualStyleBackColor = false;
			this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// User_panel
			// 
			this.User_panel.BackColor = System.Drawing.Color.Transparent;
			this.User_panel.Controls.Add(this.USER_TXT);
			this.User_panel.Controls.Add(this.User_box);
			this.User_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.User_panel.ForeColor = System.Drawing.Color.Goldenrod;
			this.User_panel.Location = new System.Drawing.Point(31, 51);
			this.User_panel.Name = "User_panel";
			this.User_panel.Size = new System.Drawing.Size(308, 70);
			this.User_panel.TabIndex = 8;
			this.User_panel.TabStop = false;
			this.User_panel.Tag = "USER_TITLE";
			this.User_panel.Text = "USER";
			// 
			// USER_TXT
			// 
			this.USER_TXT.ForeColor = System.Drawing.Color.IndianRed;
			this.USER_TXT.Location = new System.Drawing.Point(6, 28);
			this.USER_TXT.Name = "USER_TXT";
			this.USER_TXT.Size = new System.Drawing.Size(108, 21);
			this.USER_TXT.TabIndex = 0;
			this.USER_TXT.Tag = "USER_TXT";
			this.USER_TXT.Text = "Account";
			this.USER_TXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.USER_TXT.UseCompatibleTextRendering = true;
			// 
			// User_box
			// 
			this.User_box.Location = new System.Drawing.Point(120, 28);
			this.User_box.MaxLength = 15;
			this.User_box.Name = "User_box";
			this.User_box.Size = new System.Drawing.Size(143, 21);
			this.User_box.TabIndex = 1;
			// 
			// Graphics_panel
			// 
			this.Graphics_panel.BackColor = System.Drawing.Color.Transparent;
			this.Graphics_panel.Controls.Add(this.Resolution_box);
			this.Graphics_panel.Controls.Add(this.WindowMode);
			this.Graphics_panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Graphics_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Graphics_panel.ForeColor = System.Drawing.Color.Goldenrod;
			this.Graphics_panel.Location = new System.Drawing.Point(31, 130);
			this.Graphics_panel.Name = "Graphics_panel";
			this.Graphics_panel.Size = new System.Drawing.Size(308, 61);
			this.Graphics_panel.TabIndex = 9;
			this.Graphics_panel.TabStop = false;
			this.Graphics_panel.Tag = "GRAPHICS_TITLE";
			this.Graphics_panel.Text = "GRAPHICS";
			// 
			// Resolution_box
			// 
			this.Resolution_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Resolution_box.FormattingEnabled = true;
			this.Resolution_box.Location = new System.Drawing.Point(28, 23);
			this.Resolution_box.Name = "Resolution_box";
			this.Resolution_box.Size = new System.Drawing.Size(121, 23);
			this.Resolution_box.TabIndex = 1;
			// 
			// WindowMode
			// 
			this.WindowMode.AutoSize = true;
			this.WindowMode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WindowMode.ForeColor = System.Drawing.Color.IndianRed;
			this.WindowMode.Location = new System.Drawing.Point(163, 25);
			this.WindowMode.Name = "WindowMode";
			this.WindowMode.Size = new System.Drawing.Size(107, 19);
			this.WindowMode.TabIndex = 2;
			this.WindowMode.Tag = "WINDOWMODE_TXT";
			this.WindowMode.Text = "Window Mode";
			this.WindowMode.UseCompatibleTextRendering = true;
			this.WindowMode.UseVisualStyleBackColor = true;
			// 
			// Sound_panel
			// 
			this.Sound_panel.BackColor = System.Drawing.Color.Transparent;
			this.Sound_panel.Controls.Add(this.VolumeLevel);
			this.Sound_panel.Controls.Add(this.Music_check);
			this.Sound_panel.Controls.Add(this.Sound_check);
			this.Sound_panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Sound_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Sound_panel.ForeColor = System.Drawing.Color.Goldenrod;
			this.Sound_panel.Location = new System.Drawing.Point(31, 201);
			this.Sound_panel.Name = "Sound_panel";
			this.Sound_panel.Size = new System.Drawing.Size(308, 88);
			this.Sound_panel.TabIndex = 10;
			this.Sound_panel.TabStop = false;
			this.Sound_panel.Tag = "SOUND_TITLE";
			this.Sound_panel.Text = "SOUND";
			// 
			// VolumeLevel
			// 
			this.VolumeLevel.AutoSize = false;
			this.VolumeLevel.BackColor = System.Drawing.SystemColors.Control;
			this.VolumeLevel.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
			this.VolumeLevel.LargeChange = 1;
			this.VolumeLevel.Location = new System.Drawing.Point(22, 51);
			this.VolumeLevel.Maximum = 9;
			this.VolumeLevel.Name = "VolumeLevel";
			this.VolumeLevel.Size = new System.Drawing.Size(257, 21);
			this.VolumeLevel.TabIndex = 3;
			// 
			// Music_check
			// 
			this.Music_check.AutoSize = true;
			this.Music_check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Music_check.ForeColor = System.Drawing.Color.IndianRed;
			this.Music_check.Location = new System.Drawing.Point(175, 20);
			this.Music_check.Name = "Music_check";
			this.Music_check.Size = new System.Drawing.Size(59, 19);
			this.Music_check.TabIndex = 2;
			this.Music_check.Tag = "MUSIC_TXT";
			this.Music_check.Text = "Music";
			this.Music_check.UseCompatibleTextRendering = true;
			this.Music_check.UseVisualStyleBackColor = true;
			// 
			// Sound_check
			// 
			this.Sound_check.AutoSize = true;
			this.Sound_check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Sound_check.ForeColor = System.Drawing.Color.IndianRed;
			this.Sound_check.Location = new System.Drawing.Point(66, 20);
			this.Sound_check.Name = "Sound_check";
			this.Sound_check.Size = new System.Drawing.Size(69, 19);
			this.Sound_check.TabIndex = 1;
			this.Sound_check.Tag = "SOUND_TXT";
			this.Sound_check.Text = "Sounds";
			this.Sound_check.UseCompatibleTextRendering = true;
			this.Sound_check.UseVisualStyleBackColor = true;
			// 
			// Language_panel
			// 
			this.Language_panel.BackColor = System.Drawing.Color.Transparent;
			this.Language_panel.Controls.Add(this.Language_Por);
			this.Language_panel.Controls.Add(this.Language_Spn);
			this.Language_panel.Controls.Add(this.Language_Eng);
			this.Language_panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Language_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Language_panel.ForeColor = System.Drawing.Color.Goldenrod;
			this.Language_panel.Location = new System.Drawing.Point(31, 300);
			this.Language_panel.Name = "Language_panel";
			this.Language_panel.Size = new System.Drawing.Size(308, 55);
			this.Language_panel.TabIndex = 11;
			this.Language_panel.TabStop = false;
			this.Language_panel.Tag = "LANGUAGE_TITLE";
			this.Language_panel.Text = "LANGUAGE";
			// 
			// Language_Por
			// 
			this.Language_Por.AutoSize = true;
			this.Language_Por.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Language_Por.ForeColor = System.Drawing.Color.IndianRed;
			this.Language_Por.Location = new System.Drawing.Point(197, 22);
			this.Language_Por.Name = "Language_Por";
			this.Language_Por.Size = new System.Drawing.Size(84, 19);
			this.Language_Por.TabIndex = 3;
			this.Language_Por.TabStop = true;
			this.Language_Por.Text = "Português";
			this.Language_Por.UseCompatibleTextRendering = true;
			this.Language_Por.UseVisualStyleBackColor = true;
			this.Language_Por.CheckedChanged += new System.EventHandler(this.Language_Por_CheckedChanged);
			// 
			// Language_Spn
			// 
			this.Language_Spn.AutoSize = true;
			this.Language_Spn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Language_Spn.ForeColor = System.Drawing.Color.IndianRed;
			this.Language_Spn.Location = new System.Drawing.Point(108, 22);
			this.Language_Spn.Name = "Language_Spn";
			this.Language_Spn.Size = new System.Drawing.Size(71, 19);
			this.Language_Spn.TabIndex = 2;
			this.Language_Spn.TabStop = true;
			this.Language_Spn.Text = "Español";
			this.Language_Spn.UseCompatibleTextRendering = true;
			this.Language_Spn.UseVisualStyleBackColor = true;
			this.Language_Spn.CheckedChanged += new System.EventHandler(this.Language_Spn_CheckedChanged);
			// 
			// Language_Eng
			// 
			this.Language_Eng.AutoSize = true;
			this.Language_Eng.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Language_Eng.ForeColor = System.Drawing.Color.IndianRed;
			this.Language_Eng.Location = new System.Drawing.Point(24, 22);
			this.Language_Eng.Name = "Language_Eng";
			this.Language_Eng.Size = new System.Drawing.Size(67, 19);
			this.Language_Eng.TabIndex = 1;
			this.Language_Eng.TabStop = true;
			this.Language_Eng.Text = "English";
			this.Language_Eng.UseCompatibleTextRendering = true;
			this.Language_Eng.UseVisualStyleBackColor = true;
			this.Language_Eng.CheckedChanged += new System.EventHandler(this.Language_Eng_CheckedChanged);
			// 
			// Options
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::Launcher.Properties.Resources.OptionsBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(369, 412);
			this.Controls.Add(this.User_panel);
			this.Controls.Add(this.Graphics_panel);
			this.Controls.Add(this.Sound_panel);
			this.Controls.Add(this.Language_panel);
			this.Controls.Add(this.Btn_Save);
			this.Controls.Add(this.Btn_Close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Options";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.Options_Load);
			this.User_panel.ResumeLayout(false);
			this.User_panel.PerformLayout();
			this.Graphics_panel.ResumeLayout(false);
			this.Graphics_panel.PerformLayout();
			this.Sound_panel.ResumeLayout(false);
			this.Sound_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeLevel)).EndInit();
			this.Language_panel.ResumeLayout(false);
			this.Language_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Button Btn_Save;
		public System.Windows.Forms.Button Btn_Close;
		private System.Windows.Forms.GroupBox User_panel;
		private System.Windows.Forms.Label USER_TXT;
		private System.Windows.Forms.TextBox User_box;
		private System.Windows.Forms.GroupBox Graphics_panel;
		private System.Windows.Forms.ComboBox Resolution_box;
		private System.Windows.Forms.CheckBox WindowMode;
		private System.Windows.Forms.GroupBox Sound_panel;
		private System.Windows.Forms.TrackBar VolumeLevel;
		private System.Windows.Forms.CheckBox Music_check;
		private System.Windows.Forms.CheckBox Sound_check;
		private System.Windows.Forms.GroupBox Language_panel;
		private System.Windows.Forms.RadioButton Language_Por;
		private System.Windows.Forms.RadioButton Language_Spn;
		private System.Windows.Forms.RadioButton Language_Eng;
	}
}

