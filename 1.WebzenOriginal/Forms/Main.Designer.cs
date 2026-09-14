using System.Drawing;

namespace Launcher
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
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
			this.Complete_panel = new System.Windows.Forms.Panel();
			this.CurrentProgress = new Shared.UI.SegmentedProgressBar();
			this.Btn_Play = new System.Windows.Forms.Button();
			this.Btn_Close = new System.Windows.Forms.Button();
			this.Btn_Web = new System.Windows.Forms.Button();
			this.Status_txt = new System.Windows.Forms.Label();
			this.User_panel = new System.Windows.Forms.GroupBox();
			this.USER_TXT = new System.Windows.Forms.Label();
			this.User_box = new System.Windows.Forms.TextBox();
			this.Function_panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.Graphics_panel.SuspendLayout();
			this.Sound_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeLevel)).BeginInit();
			this.Language_panel.SuspendLayout();
			this.Complete_panel.SuspendLayout();
			this.User_panel.SuspendLayout();
			this.Function_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox1.BackgroundImage = global::Launcher.Properties.Resources.Banner;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(292, 54);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(294, 56);
			this.panel1.TabIndex = 2;
			// 
			// Graphics_panel
			// 
			this.Graphics_panel.Controls.Add(this.Resolution_box);
			this.Graphics_panel.Controls.Add(this.WindowMode);
			this.Graphics_panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Graphics_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Graphics_panel.Location = new System.Drawing.Point(9, 58);
			this.Graphics_panel.Name = "Graphics_panel";
			this.Graphics_panel.Size = new System.Drawing.Size(269, 57);
			this.Graphics_panel.TabIndex = 2;
			this.Graphics_panel.TabStop = false;
			this.Graphics_panel.Tag = "GRAPHICS_TITLE";
			this.Graphics_panel.Text = "GRAPHICS";
			// 
			// Resolution_box
			// 
			this.Resolution_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Resolution_box.FormattingEnabled = true;
			this.Resolution_box.Location = new System.Drawing.Point(12, 21);
			this.Resolution_box.Name = "Resolution_box";
			this.Resolution_box.Size = new System.Drawing.Size(121, 23);
			this.Resolution_box.TabIndex = 1;
			// 
			// WindowMode
			// 
			this.WindowMode.AutoSize = true;
			this.WindowMode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WindowMode.Location = new System.Drawing.Point(147, 23);
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
			this.Sound_panel.Controls.Add(this.VolumeLevel);
			this.Sound_panel.Controls.Add(this.Music_check);
			this.Sound_panel.Controls.Add(this.Sound_check);
			this.Sound_panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Sound_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Sound_panel.Location = new System.Drawing.Point(9, 121);
			this.Sound_panel.Name = "Sound_panel";
			this.Sound_panel.Size = new System.Drawing.Size(269, 74);
			this.Sound_panel.TabIndex = 3;
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
			this.VolumeLevel.Location = new System.Drawing.Point(6, 45);
			this.VolumeLevel.Maximum = 9;
			this.VolumeLevel.Name = "VolumeLevel";
			this.VolumeLevel.Size = new System.Drawing.Size(257, 21);
			this.VolumeLevel.TabIndex = 3;
			// 
			// Music_check
			// 
			this.Music_check.AutoSize = true;
			this.Music_check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Music_check.Location = new System.Drawing.Point(159, 20);
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
			this.Sound_check.Location = new System.Drawing.Point(50, 20);
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
			this.Language_panel.Controls.Add(this.Language_Por);
			this.Language_panel.Controls.Add(this.Language_Spn);
			this.Language_panel.Controls.Add(this.Language_Eng);
			this.Language_panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Language_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Language_panel.Location = new System.Drawing.Point(9, 201);
			this.Language_panel.Name = "Language_panel";
			this.Language_panel.Size = new System.Drawing.Size(269, 42);
			this.Language_panel.TabIndex = 4;
			this.Language_panel.TabStop = false;
			this.Language_panel.Tag = "LANGUAGE_TITLE";
			this.Language_panel.Text = "LANGUAGE";
			// 
			// Language_Por
			// 
			this.Language_Por.AutoSize = true;
			this.Language_Por.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Language_Por.Location = new System.Drawing.Point(180, 16);
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
			this.Language_Spn.Location = new System.Drawing.Point(91, 16);
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
			this.Language_Eng.Location = new System.Drawing.Point(7, 16);
			this.Language_Eng.Name = "Language_Eng";
			this.Language_Eng.Size = new System.Drawing.Size(67, 19);
			this.Language_Eng.TabIndex = 1;
			this.Language_Eng.TabStop = true;
			this.Language_Eng.Text = "English";
			this.Language_Eng.UseCompatibleTextRendering = true;
			this.Language_Eng.UseVisualStyleBackColor = true;
			this.Language_Eng.CheckedChanged += new System.EventHandler(this.Language_Eng_CheckedChanged);
			// 
			// Complete_panel
			// 
			this.Complete_panel.BackColor = System.Drawing.SystemColors.Control;
			this.Complete_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Complete_panel.Controls.Add(this.CurrentProgress);
			this.Complete_panel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.Complete_panel.Location = new System.Drawing.Point(10, 323);
			this.Complete_panel.Name = "Complete_panel";
			this.Complete_panel.Size = new System.Drawing.Size(269, 22);
			this.Complete_panel.TabIndex = 0;
			// 
			// CurrentProgress
			// 
			this.CurrentProgress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CurrentProgress.ForeColor = System.Drawing.SystemColors.Highlight;
			this.CurrentProgress.Location = new System.Drawing.Point(0, 0);
			this.CurrentProgress.Maximum = 100;
			this.CurrentProgress.Name = "CurrentProgress";
			this.CurrentProgress.SegmentCount = 20;
			this.CurrentProgress.SegmentSpacing = 2;
			this.CurrentProgress.Size = new System.Drawing.Size(265, 18);
			this.CurrentProgress.TabIndex = 0;
			this.CurrentProgress.Text = "segmentedProgressBar1";
			this.CurrentProgress.Value = 0;
			// 
			// Btn_Play
			// 
			this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Play.FlatAppearance.BorderSize = 0;
			this.Btn_Play.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Play.Location = new System.Drawing.Point(10, 351);
			this.Btn_Play.Name = "Btn_Play";
			this.Btn_Play.Size = new System.Drawing.Size(75, 30);
			this.Btn_Play.TabIndex = 5;
			this.Btn_Play.Tag = "PLAY_TXT";
			this.Btn_Play.Text = "Play";
			this.Btn_Play.UseVisualStyleBackColor = false;
			this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
			// 
			// Btn_Close
			// 
			this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Close.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Close.Location = new System.Drawing.Point(91, 351);
			this.Btn_Close.Name = "Btn_Close";
			this.Btn_Close.Size = new System.Drawing.Size(75, 30);
			this.Btn_Close.TabIndex = 6;
			this.Btn_Close.Tag = "CLOSE_TXT";
			this.Btn_Close.Text = "Close";
			this.Btn_Close.UseVisualStyleBackColor = false;
			this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// Btn_Web
			// 
			this.Btn_Web.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Web.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Web.Location = new System.Drawing.Point(204, 351);
			this.Btn_Web.Name = "Btn_Web";
			this.Btn_Web.Size = new System.Drawing.Size(75, 30);
			this.Btn_Web.TabIndex = 7;
			this.Btn_Web.Tag = "WEB_TXT";
			this.Btn_Web.Text = "Web";
			this.Btn_Web.UseVisualStyleBackColor = false;
			this.Btn_Web.Click += new System.EventHandler(this.Btn_Web_Click);
			// 
			// Status_txt
			// 
			this.Status_txt.Font = new System.Drawing.Font("Arial", 8F);
			this.Status_txt.Location = new System.Drawing.Point(10, 306);
			this.Status_txt.Name = "Status_txt";
			this.Status_txt.Size = new System.Drawing.Size(269, 15);
			this.Status_txt.TabIndex = 0;
			// 
			// User_panel
			// 
			this.User_panel.Controls.Add(this.USER_TXT);
			this.User_panel.Controls.Add(this.User_box);
			this.User_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.User_panel.Location = new System.Drawing.Point(9, 3);
			this.User_panel.Name = "User_panel";
			this.User_panel.Size = new System.Drawing.Size(269, 49);
			this.User_panel.TabIndex = 1;
			this.User_panel.TabStop = false;
			this.User_panel.Tag = "USER_TITLE";
			this.User_panel.Text = "USER";
			// 
			// USER_TXT
			// 
			this.USER_TXT.Location = new System.Drawing.Point(6, 20);
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
			this.User_box.Location = new System.Drawing.Point(120, 20);
			this.User_box.MaxLength = 15;
			this.User_box.Name = "User_box";
			this.User_box.Size = new System.Drawing.Size(143, 21);
			this.User_box.TabIndex = 1;
			// 
			// Function_panel
			// 
			this.Function_panel.Controls.Add(this.User_panel);
			this.Function_panel.Controls.Add(this.Graphics_panel);
			this.Function_panel.Controls.Add(this.Sound_panel);
			this.Function_panel.Controls.Add(this.Language_panel);
			this.Function_panel.Location = new System.Drawing.Point(1, 59);
			this.Function_panel.Name = "Function_panel";
			this.Function_panel.Size = new System.Drawing.Size(292, 244);
			this.Function_panel.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(294, 386);
			this.Controls.Add(this.Status_txt);
			this.Controls.Add(this.Btn_Web);
			this.Controls.Add(this.Btn_Close);
			this.Controls.Add(this.Btn_Play);
			this.Controls.Add(this.Complete_panel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Function_panel);
			this.Font = new System.Drawing.Font("Arial", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "kayito - Mu Launcher";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.Graphics_panel.ResumeLayout(false);
			this.Graphics_panel.PerformLayout();
			this.Sound_panel.ResumeLayout(false);
			this.Sound_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeLevel)).EndInit();
			this.Language_panel.ResumeLayout(false);
			this.Language_panel.PerformLayout();
			this.Complete_panel.ResumeLayout(false);
			this.User_panel.ResumeLayout(false);
			this.User_panel.PerformLayout();
			this.Function_panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox Graphics_panel;
		private System.Windows.Forms.CheckBox WindowMode;
		private System.Windows.Forms.GroupBox Sound_panel;
		private System.Windows.Forms.CheckBox Sound_check;
		private System.Windows.Forms.CheckBox Music_check;
		private System.Windows.Forms.GroupBox Language_panel;
		private System.Windows.Forms.RadioButton Language_Por;
		private System.Windows.Forms.RadioButton Language_Spn;
		private System.Windows.Forms.RadioButton Language_Eng;
		private System.Windows.Forms.Panel Complete_panel;
		private System.Windows.Forms.Button Btn_Play;
		private System.Windows.Forms.Button Btn_Close;
		private System.Windows.Forms.Button Btn_Web;
		private System.Windows.Forms.ComboBox Resolution_box;
		private System.Windows.Forms.TrackBar VolumeLevel;
		private System.Windows.Forms.Label Status_txt;
		private System.Windows.Forms.GroupBox User_panel;
		private System.Windows.Forms.Label USER_TXT;
		private System.Windows.Forms.TextBox User_box;
		private Shared.UI.SegmentedProgressBar CurrentProgress;
		private System.Windows.Forms.Panel Function_panel;
	}
}

