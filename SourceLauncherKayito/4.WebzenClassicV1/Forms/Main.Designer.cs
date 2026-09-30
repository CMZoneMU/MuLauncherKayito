using MuLauncher;
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
			this.Btn_Exit = new System.Windows.Forms.PictureBox();
			this.Web_panel = new System.Windows.Forms.WebBrowser();
			this.Btn_Play = new System.Windows.Forms.Button();
			this.Btn_Options = new System.Windows.Forms.Button();
			this.Update_panel = new System.Windows.Forms.Panel();
			this.Complete_txt = new System.Windows.Forms.Label();
			this.Current_txt = new System.Windows.Forms.Label();
			this.Complete_bar = new System.Windows.Forms.PictureBox();
			this.Status_txt = new System.Windows.Forms.Label();
			this.Current_bar = new System.Windows.Forms.PictureBox();
			this.Btn_Close = new System.Windows.Forms.Button();
			this.Header_panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Exit)).BeginInit();
			this.Update_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Complete_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Current_bar)).BeginInit();
			this.Header_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Exit
			// 
			this.Btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Exit.BackgroundImage = global::Launcher.Properties.Resources.Cerrar_n;
			this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Exit.Location = new System.Drawing.Point(750, 46);
			this.Btn_Exit.Name = "Btn_Exit";
			this.Btn_Exit.Size = new System.Drawing.Size(22, 20);
			this.Btn_Exit.TabIndex = 4;
			this.Btn_Exit.TabStop = false;
			this.Btn_Exit.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// Web_panel
			// 
			this.Web_panel.Location = new System.Drawing.Point(25, 225);
			this.Web_panel.MinimumSize = new System.Drawing.Size(20, 20);
			this.Web_panel.Name = "Web_panel";
			this.Web_panel.ScriptErrorsSuppressed = true;
			this.Web_panel.ScrollBarsEnabled = false;
			this.Web_panel.Size = new System.Drawing.Size(749, 284);
			this.Web_panel.TabIndex = 0;
			this.Web_panel.TabStop = false;
			this.Web_panel.Url = new System.Uri("", System.UriKind.Relative);
			this.Web_panel.Visible = false;
			this.Web_panel.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Web_panel_DocumentCompleted);
			this.Web_panel.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Web_panel_Navigating);
			this.Web_panel.NewWindow += new System.ComponentModel.CancelEventHandler(this.Web_panel_NewWindow);
			// 
			// Btn_Play
			// 
			this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Play.BackgroundImage = global::Launcher.Properties.Resources.Jugar_n;
			this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Play.FlatAppearance.BorderSize = 0;
			this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Play.Font = new System.Drawing.Font("Ubuntu", 22F, System.Drawing.FontStyle.Bold);
			this.Btn_Play.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.Btn_Play.Location = new System.Drawing.Point(615, 515);
			this.Btn_Play.Name = "Btn_Play";
			this.Btn_Play.Size = new System.Drawing.Size(159, 49);
			this.Btn_Play.TabIndex = 2;
			this.Btn_Play.Tag = "PLAY_TXT";
			this.Btn_Play.Text = "Play";
			this.Btn_Play.UseVisualStyleBackColor = false;
			this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
			// 
			// Btn_Options
			// 
			this.Btn_Options.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Options.BackgroundImage = global::Launcher.Properties.Resources.Boton_n;
			this.Btn_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Options.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Options.FlatAppearance.BorderSize = 0;
			this.Btn_Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Btn_Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Btn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Options.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Options.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Btn_Options.Location = new System.Drawing.Point(518, 515);
			this.Btn_Options.Name = "Btn_Options";
			this.Btn_Options.Size = new System.Drawing.Size(74, 22);
			this.Btn_Options.TabIndex = 1;
			this.Btn_Options.Tag = "OPTIONS_TXT";
			this.Btn_Options.Text = "Options";
			this.Btn_Options.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Options.UseVisualStyleBackColor = false;
			this.Btn_Options.Click += new System.EventHandler(this.Btn_Options_Click);
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
			this.Update_panel.Location = new System.Drawing.Point(29, 515);
			this.Update_panel.Name = "Update_panel";
			this.Update_panel.Size = new System.Drawing.Size(469, 49);
			this.Update_panel.TabIndex = 0;
			// 
			// Complete_txt
			// 
			this.Complete_txt.AutoSize = true;
			this.Complete_txt.BackColor = System.Drawing.Color.Transparent;
			this.Complete_txt.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Complete_txt.Location = new System.Drawing.Point(425, 19);
			this.Complete_txt.Name = "Complete_txt";
			this.Complete_txt.Size = new System.Drawing.Size(21, 13);
			this.Complete_txt.TabIndex = 0;
			this.Complete_txt.Text = "0%";
			// 
			// Current_txt
			// 
			this.Current_txt.AutoSize = true;
			this.Current_txt.BackColor = System.Drawing.Color.Transparent;
			this.Current_txt.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Current_txt.Location = new System.Drawing.Point(425, 32);
			this.Current_txt.Name = "Current_txt";
			this.Current_txt.Size = new System.Drawing.Size(21, 13);
			this.Current_txt.TabIndex = 0;
			this.Current_txt.Text = "0%";
			// 
			// Complete_bar
			// 
			this.Complete_bar.BackgroundImage = global::Launcher.Properties.Resources.CompleteProgress;
			this.Complete_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Complete_bar.Location = new System.Drawing.Point(54, 23);
			this.Complete_bar.Name = "Complete_bar";
			this.Complete_bar.Size = new System.Drawing.Size(368, 8);
			this.Complete_bar.TabIndex = 7;
			this.Complete_bar.TabStop = false;
			// 
			// Status_txt
			// 
			this.Status_txt.BackColor = System.Drawing.Color.Transparent;
			this.Status_txt.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.Status_txt.Location = new System.Drawing.Point(51, 5);
			this.Status_txt.Name = "Status_txt";
			this.Status_txt.Size = new System.Drawing.Size(368, 15);
			this.Status_txt.TabIndex = 0;
			this.Status_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Current_bar
			// 
			this.Current_bar.BackgroundImage = global::Launcher.Properties.Resources.CurrentProgress;
			this.Current_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Current_bar.Location = new System.Drawing.Point(54, 34);
			this.Current_bar.Name = "Current_bar";
			this.Current_bar.Size = new System.Drawing.Size(368, 8);
			this.Current_bar.TabIndex = 6;
			this.Current_bar.TabStop = false;
			// 
			// Btn_Close
			// 
			this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.BackgroundImage = global::Launcher.Properties.Resources.Boton_n;
			this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Close.FlatAppearance.BorderSize = 0;
			this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Close.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Close.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Btn_Close.Location = new System.Drawing.Point(518, 542);
			this.Btn_Close.Name = "Btn_Close";
			this.Btn_Close.Size = new System.Drawing.Size(74, 22);
			this.Btn_Close.TabIndex = 5;
			this.Btn_Close.Tag = "CLOSE_TXT";
			this.Btn_Close.Text = "Close";
			this.Btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Close.UseVisualStyleBackColor = false;
			this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// Header_panel
			// 
			this.Header_panel.BackColor = System.Drawing.Color.Transparent;
			this.Header_panel.Controls.Add(this.Btn_Exit);
			this.Header_panel.Location = new System.Drawing.Point(1, 152);
			this.Header_panel.Name = "Header_panel";
			this.Header_panel.Size = new System.Drawing.Size(791, 71);
			this.Header_panel.TabIndex = 6;
			this.Header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_panel_MouseDown);
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.BackgroundImage = global::Launcher.Properties.Resources.MainBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(792, 582);
			this.Controls.Add(this.Btn_Close);
			this.Controls.Add(this.Update_panel);
			this.Controls.Add(this.Btn_Options);
			this.Controls.Add(this.Btn_Play);
			this.Controls.Add(this.Web_panel);
			this.Controls.Add(this.Header_panel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "kayito - Mu Launcher";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.Btn_Exit)).EndInit();
			this.Update_panel.ResumeLayout(false);
			this.Update_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Complete_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Current_bar)).EndInit();
			this.Header_panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Btn_Exit;
		private System.Windows.Forms.WebBrowser Web_panel;
		private System.Windows.Forms.Button Btn_Play;
		public System.Windows.Forms.Button Btn_Options;
		private System.Windows.Forms.Panel Update_panel;
		private System.Windows.Forms.Label Complete_txt;
		private System.Windows.Forms.Label Current_txt;
		private System.Windows.Forms.PictureBox Complete_bar;
		private System.Windows.Forms.Label Status_txt;
		private System.Windows.Forms.PictureBox Current_bar;
		public System.Windows.Forms.Button Btn_Close;
		private System.Windows.Forms.Panel Header_panel;
	}
}



