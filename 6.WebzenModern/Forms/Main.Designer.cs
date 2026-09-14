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
			this.MuIcon = new System.Windows.Forms.PictureBox();
			this.Title_txt = new System.Windows.Forms.Label();
			this.Btn_Options = new System.Windows.Forms.PictureBox();
			this.Btn_Exit = new System.Windows.Forms.PictureBox();
			this.MuLogo = new System.Windows.Forms.PictureBox();
			this.Update_panel = new System.Windows.Forms.Panel();
			this.Complete_txt = new System.Windows.Forms.Label();
			this.Current_txt = new System.Windows.Forms.Label();
			this.Complete_bar = new System.Windows.Forms.PictureBox();
			this.Status_txt = new System.Windows.Forms.Label();
			this.Current_bar = new System.Windows.Forms.PictureBox();
			this.Btn_Play = new System.Windows.Forms.Button();
			this.Web_panel = new System.Windows.Forms.WebBrowser();
			this.Main_Image = new System.Windows.Forms.PictureBox();
			this.Header_panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.MuIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Options)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Exit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MuLogo)).BeginInit();
			this.Update_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Complete_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Current_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Main_Image)).BeginInit();
			this.Header_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MuIcon
			// 
			this.MuIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MuIcon.BackgroundImage")));
			this.MuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MuIcon.Location = new System.Drawing.Point(6, 6);
			this.MuIcon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.MuIcon.Name = "MuIcon";
			this.MuIcon.Size = new System.Drawing.Size(18, 18);
			this.MuIcon.TabIndex = 0;
			this.MuIcon.TabStop = false;
			// 
			// Title_txt
			// 
			this.Title_txt.AutoSize = true;
			this.Title_txt.BackColor = System.Drawing.Color.Transparent;
			this.Title_txt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.Title_txt.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Title_txt.Location = new System.Drawing.Point(34, 8);
			this.Title_txt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Title_txt.Name = "Title_txt";
			this.Title_txt.Size = new System.Drawing.Size(166, 14);
			this.Title_txt.TabIndex = 0;
			this.Title_txt.Text = "Mu Launcher - by kayito";
			this.Title_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Btn_Options
			// 
			this.Btn_Options.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Options.BackgroundImage = global::Launcher.Properties.Resources.Config_n;
			this.Btn_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Options.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Options.Location = new System.Drawing.Point(976, 6);
			this.Btn_Options.Name = "Btn_Options";
			this.Btn_Options.Size = new System.Drawing.Size(18, 18);
			this.Btn_Options.TabIndex = 2;
			this.Btn_Options.TabStop = false;
			this.Btn_Options.Tag = "";
			this.Btn_Options.Click += new System.EventHandler(this.Btn_Options_Click);
			// 
			// Btn_Exit
			// 
			this.Btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Exit.BackgroundImage = global::Launcher.Properties.Resources.Cerrar_n;
			this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Exit.Location = new System.Drawing.Point(1000, 6);
			this.Btn_Exit.Name = "Btn_Exit";
			this.Btn_Exit.Size = new System.Drawing.Size(18, 18);
			this.Btn_Exit.TabIndex = 3;
			this.Btn_Exit.TabStop = false;
			this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
			// 
			// MuLogo
			// 
			this.MuLogo.BackColor = System.Drawing.Color.Transparent;
			this.MuLogo.BackgroundImage = global::Launcher.Properties.Resources.MuLogo;
			this.MuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MuLogo.Location = new System.Drawing.Point(6, 517);
			this.MuLogo.Name = "MuLogo";
			this.MuLogo.Size = new System.Drawing.Size(109, 53);
			this.MuLogo.TabIndex = 4;
			this.MuLogo.TabStop = false;
			// 
			// Update_panel
			// 
			this.Update_panel.BackColor = System.Drawing.Color.Transparent;
			this.Update_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Update_panel.Controls.Add(this.Complete_txt);
			this.Update_panel.Controls.Add(this.Current_txt);
			this.Update_panel.Controls.Add(this.Complete_bar);
			this.Update_panel.Controls.Add(this.Status_txt);
			this.Update_panel.Controls.Add(this.Current_bar);
			this.Update_panel.Location = new System.Drawing.Point(121, 517);
			this.Update_panel.Name = "Update_panel";
			this.Update_panel.Size = new System.Drawing.Size(745, 53);
			this.Update_panel.TabIndex = 0;
			// 
			// Complete_txt
			// 
			this.Complete_txt.AutoSize = true;
			this.Complete_txt.BackColor = System.Drawing.Color.Transparent;
			this.Complete_txt.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Complete_txt.Location = new System.Drawing.Point(688, 35);
			this.Complete_txt.Name = "Complete_txt";
			this.Complete_txt.Size = new System.Drawing.Size(28, 14);
			this.Complete_txt.TabIndex = 0;
			this.Complete_txt.Text = "0%";
			// 
			// Current_txt
			// 
			this.Current_txt.AutoSize = true;
			this.Current_txt.BackColor = System.Drawing.Color.Transparent;
			this.Current_txt.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Current_txt.Location = new System.Drawing.Point(688, 18);
			this.Current_txt.Name = "Current_txt";
			this.Current_txt.Size = new System.Drawing.Size(28, 14);
			this.Current_txt.TabIndex = 0;
			this.Current_txt.Text = "0%";
			// 
			// Complete_bar
			// 
			this.Complete_bar.BackgroundImage = global::Launcher.Properties.Resources.CurrentProgress;
			this.Complete_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Complete_bar.Location = new System.Drawing.Point(12, 36);
			this.Complete_bar.Name = "Complete_bar";
			this.Complete_bar.Size = new System.Drawing.Size(670, 12);
			this.Complete_bar.TabIndex = 7;
			this.Complete_bar.TabStop = false;
			// 
			// Status_txt
			// 
			this.Status_txt.BackColor = System.Drawing.Color.Transparent;
			this.Status_txt.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Status_txt.Location = new System.Drawing.Point(12, 2);
			this.Status_txt.Name = "Status_txt";
			this.Status_txt.Size = new System.Drawing.Size(678, 15);
			this.Status_txt.TabIndex = 0;
			this.Status_txt.Text = "Status";
			this.Status_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Current_bar
			// 
			this.Current_bar.BackgroundImage = global::Launcher.Properties.Resources.CompleteProgress;
			this.Current_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Current_bar.Location = new System.Drawing.Point(12, 20);
			this.Current_bar.Name = "Current_bar";
			this.Current_bar.Size = new System.Drawing.Size(670, 12);
			this.Current_bar.TabIndex = 6;
			this.Current_bar.TabStop = false;
			// 
			// Btn_Play
			// 
			this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Play.BackgroundImage = global::Launcher.Properties.Resources.Jugar_n;
			this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Play.FlatAppearance.BorderSize = 0;
			this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Play.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Play.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Btn_Play.Location = new System.Drawing.Point(872, 517);
			this.Btn_Play.Name = "Btn_Play";
			this.Btn_Play.Size = new System.Drawing.Size(146, 53);
			this.Btn_Play.TabIndex = 0;
			this.Btn_Play.TabStop = false;
			this.Btn_Play.Tag = "PLAY_TXT";
			this.Btn_Play.Text = "Play";
			this.Btn_Play.UseVisualStyleBackColor = false;
			this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
			// 
			// Web_panel
			// 
			this.Web_panel.Location = new System.Drawing.Point(6, 30);
			this.Web_panel.MinimumSize = new System.Drawing.Size(20, 20);
			this.Web_panel.Name = "Web_panel";
			this.Web_panel.ScriptErrorsSuppressed = true;
			this.Web_panel.ScrollBarsEnabled = false;
			this.Web_panel.Size = new System.Drawing.Size(1012, 481);
			this.Web_panel.TabIndex = 0;
			this.Web_panel.TabStop = false;
			this.Web_panel.Url = new System.Uri("", System.UriKind.Relative);
			this.Web_panel.Visible = false;
			this.Web_panel.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Web_panel_DocumentCompleted);
			this.Web_panel.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Web_panel_Navigating);
			this.Web_panel.NewWindow += new System.ComponentModel.CancelEventHandler(this.Web_panel_NewWindow);
			// 
			// Main_Image
			// 
			this.Main_Image.BackColor = System.Drawing.Color.Transparent;
			this.Main_Image.BackgroundImage = global::Launcher.Properties.Resources.MainImage;
			this.Main_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Main_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Main_Image.Location = new System.Drawing.Point(6, 30);
			this.Main_Image.Name = "Main_Image";
			this.Main_Image.Size = new System.Drawing.Size(1012, 481);
			this.Main_Image.TabIndex = 5;
			this.Main_Image.TabStop = false;
			// 
			// Header_panel
			// 
			this.Header_panel.BackColor = System.Drawing.Color.Transparent;
			this.Header_panel.Controls.Add(this.Title_txt);
			this.Header_panel.Controls.Add(this.MuIcon);
			this.Header_panel.Controls.Add(this.Btn_Options);
			this.Header_panel.Controls.Add(this.Btn_Exit);
			this.Header_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header_panel.Location = new System.Drawing.Point(0, 0);
			this.Header_panel.Name = "Header_panel";
			this.Header_panel.Size = new System.Drawing.Size(1024, 29);
			this.Header_panel.TabIndex = 6;
			this.Header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_panel_MouseDown);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.BackgroundImage = global::Launcher.Properties.Resources.MainBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1024, 576);
			this.Controls.Add(this.Btn_Play);
			this.Controls.Add(this.Update_panel);
			this.Controls.Add(this.MuLogo);
			this.Controls.Add(this.Web_panel);
			this.Controls.Add(this.Main_Image);
			this.Controls.Add(this.Header_panel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Launcher - kayito";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.MuIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Options)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Exit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MuLogo)).EndInit();
			this.Update_panel.ResumeLayout(false);
			this.Update_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Complete_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Current_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Main_Image)).EndInit();
			this.Header_panel.ResumeLayout(false);
			this.Header_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox MuIcon;
		private System.Windows.Forms.Label Title_txt;
		private System.Windows.Forms.PictureBox Btn_Options;
		private System.Windows.Forms.PictureBox Btn_Exit;
		private System.Windows.Forms.PictureBox MuLogo;
		private System.Windows.Forms.Panel Update_panel;
		private System.Windows.Forms.Label Status_txt;
		private System.Windows.Forms.PictureBox Current_bar;
		private System.Windows.Forms.PictureBox Complete_bar;
		private System.Windows.Forms.Label Current_txt;
		private System.Windows.Forms.Label Complete_txt;
		private System.Windows.Forms.Button Btn_Play;
		private System.Windows.Forms.WebBrowser Web_panel;
		private System.Windows.Forms.PictureBox Main_Image;
		private System.Windows.Forms.Panel Header_panel;
	}
}

