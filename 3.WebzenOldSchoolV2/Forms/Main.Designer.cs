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
			this.Header_panel = new System.Windows.Forms.Panel();
			this.Title_txt = new System.Windows.Forms.Label();
			this.Main_panel = new System.Windows.Forms.Panel();
			this.Web_panel = new System.Windows.Forms.WebBrowser();
			this.Complete_panel = new System.Windows.Forms.Panel();
			this.Complete_bar = new Shared.UI.SegmentedProgressBar();
			this.Btn_Options = new System.Windows.Forms.Button();
			this.Btn_Play = new System.Windows.Forms.Button();
			this.Btn_Close = new System.Windows.Forms.Button();
			this.Status_txt = new System.Windows.Forms.Label();
			this.Header_panel.SuspendLayout();
			this.Main_panel.SuspendLayout();
			this.Complete_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header_panel
			// 
			this.Header_panel.BackColor = System.Drawing.Color.Transparent;
			this.Header_panel.Controls.Add(this.Title_txt);
			this.Header_panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header_panel.Font = new System.Drawing.Font("Arial", 9F);
			this.Header_panel.Location = new System.Drawing.Point(0, 0);
			this.Header_panel.Name = "Header_panel";
			this.Header_panel.Size = new System.Drawing.Size(450, 26);
			this.Header_panel.TabIndex = 0;
			this.Header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_panel_MouseDown);
			// 
			// Title_txt
			// 
			this.Title_txt.AutoSize = true;
			this.Title_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Title_txt.ForeColor = System.Drawing.SystemColors.Control;
			this.Title_txt.Location = new System.Drawing.Point(5, 5);
			this.Title_txt.Name = "Title_txt";
			this.Title_txt.Size = new System.Drawing.Size(125, 15);
			this.Title_txt.TabIndex = 0;
			this.Title_txt.Text = "kayito - Mu Launcher";
			// 
			// Main_panel
			// 
			this.Main_panel.BackColor = System.Drawing.SystemColors.Control;
			this.Main_panel.BackgroundImage = global::Launcher.Properties.Resources.MainImage;
			this.Main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Main_panel.Controls.Add(this.Web_panel);
			this.Main_panel.Location = new System.Drawing.Point(6, 32);
			this.Main_panel.Name = "Main_panel";
			this.Main_panel.Size = new System.Drawing.Size(437, 327);
			this.Main_panel.TabIndex = 0;
			// 
			// Web_panel
			// 
			this.Web_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Web_panel.Location = new System.Drawing.Point(0, 0);
			this.Web_panel.MinimumSize = new System.Drawing.Size(20, 20);
			this.Web_panel.Name = "Web_panel";
			this.Web_panel.ScriptErrorsSuppressed = true;
			this.Web_panel.ScrollBarsEnabled = false;
			this.Web_panel.Size = new System.Drawing.Size(433, 323);
			this.Web_panel.TabIndex = 0;
			this.Web_panel.TabStop = false;
			this.Web_panel.Visible = false;
			this.Web_panel.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Web_panel_DocumentCompleted);
			this.Web_panel.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Web_panel_Navigating);
			this.Web_panel.NewWindow += new System.ComponentModel.CancelEventHandler(this.Web_panel_NewWindow);
			// 
			// Complete_panel
			// 
			this.Complete_panel.BackColor = System.Drawing.Color.Transparent;
			this.Complete_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Complete_panel.Controls.Add(this.Complete_bar);
			this.Complete_panel.Location = new System.Drawing.Point(6, 365);
			this.Complete_panel.Name = "Complete_panel";
			this.Complete_panel.Size = new System.Drawing.Size(437, 22);
			this.Complete_panel.TabIndex = 0;
			// 
			// Complete_bar
			// 
			this.Complete_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.Complete_bar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Complete_bar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Complete_bar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.Complete_bar.Location = new System.Drawing.Point(0, 0);
			this.Complete_bar.Maximum = 100;
			this.Complete_bar.Name = "Complete_bar";
			this.Complete_bar.SegmentCount = 20;
			this.Complete_bar.SegmentSpacing = 2;
			this.Complete_bar.Size = new System.Drawing.Size(433, 18);
			this.Complete_bar.TabIndex = 0;
			this.Complete_bar.TabStop = false;
			this.Complete_bar.Value = 0;
			// 
			// Btn_Options
			// 
			this.Btn_Options.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Options.BackgroundImage = global::Launcher.Properties.Resources.Button_n;
			this.Btn_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Options.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Options.FlatAppearance.BorderSize = 0;
			this.Btn_Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Btn_Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Btn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Options.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Options.ForeColor = System.Drawing.SystemColors.Control;
			this.Btn_Options.Location = new System.Drawing.Point(46, 407);
			this.Btn_Options.Name = "Btn_Options";
			this.Btn_Options.Size = new System.Drawing.Size(90, 28);
			this.Btn_Options.TabIndex = 1;
			this.Btn_Options.Tag = "OPTIONS_TXT";
			this.Btn_Options.Text = "Options";
			this.Btn_Options.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Options.UseVisualStyleBackColor = false;
			this.Btn_Options.Click += new System.EventHandler(this.Btn_Options_Click);
			// 
			// Btn_Play
			// 
			this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Play.BackgroundImage = global::Launcher.Properties.Resources.Button_n;
			this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Play.FlatAppearance.BorderSize = 0;
			this.Btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Play.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Play.ForeColor = System.Drawing.SystemColors.Control;
			this.Btn_Play.Location = new System.Drawing.Point(221, 407);
			this.Btn_Play.Name = "Btn_Play";
			this.Btn_Play.Size = new System.Drawing.Size(90, 28);
			this.Btn_Play.TabIndex = 2;
			this.Btn_Play.Tag = "PLAY_TXT";
			this.Btn_Play.Text = "Play";
			this.Btn_Play.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Play.UseVisualStyleBackColor = false;
			this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
			// 
			// Btn_Close
			// 
			this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.BackgroundImage = global::Launcher.Properties.Resources.Button_n;
			this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Close.FlatAppearance.BorderSize = 0;
			this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Close.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.Btn_Close.ForeColor = System.Drawing.SystemColors.Control;
			this.Btn_Close.Location = new System.Drawing.Point(311, 407);
			this.Btn_Close.Name = "Btn_Close";
			this.Btn_Close.Size = new System.Drawing.Size(90, 28);
			this.Btn_Close.TabIndex = 3;
			this.Btn_Close.Tag = "CLOSE_TXT";
			this.Btn_Close.Text = "Close";
			this.Btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Btn_Close.UseVisualStyleBackColor = false;
			this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// Status_txt
			// 
			this.Status_txt.BackColor = System.Drawing.Color.Transparent;
			this.Status_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.Status_txt.ForeColor = System.Drawing.Color.White;
			this.Status_txt.Location = new System.Drawing.Point(6, 390);
			this.Status_txt.Margin = new System.Windows.Forms.Padding(0);
			this.Status_txt.Name = "Status_txt";
			this.Status_txt.Size = new System.Drawing.Size(437, 15);
			this.Status_txt.TabIndex = 0;
			this.Status_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::Launcher.Properties.Resources.MainBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(450, 436);
			this.Controls.Add(this.Status_txt);
			this.Controls.Add(this.Complete_panel);
			this.Controls.Add(this.Btn_Close);
			this.Controls.Add(this.Btn_Play);
			this.Controls.Add(this.Btn_Options);
			this.Controls.Add(this.Main_panel);
			this.Controls.Add(this.Header_panel);
			this.Font = new System.Drawing.Font("Arial", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "kayito - Launcher";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Header_panel.ResumeLayout(false);
			this.Header_panel.PerformLayout();
			this.Main_panel.ResumeLayout(false);
			this.Complete_panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Header_panel;
		private System.Windows.Forms.Label Title_txt;
		private System.Windows.Forms.Panel Main_panel;
		private System.Windows.Forms.WebBrowser Web_panel;
		private System.Windows.Forms.Panel Complete_panel;
		private Shared.UI.SegmentedProgressBar Complete_bar;
		public System.Windows.Forms.Button Btn_Options;
		public System.Windows.Forms.Button Btn_Play;
		public System.Windows.Forms.Button Btn_Close;
		public System.Windows.Forms.Label Status_txt;
	}
}



