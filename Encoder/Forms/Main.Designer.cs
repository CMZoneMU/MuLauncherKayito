namespace Encoder
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.Launcher_Info_Box = new System.Windows.Forms.GroupBox();
			this.Website_panel = new System.Windows.Forms.Panel();
			this.Website_Box = new System.Windows.Forms.TextBox();
			this.Website_txt = new System.Windows.Forms.Label();
			this.Btn_Load = new System.Windows.Forms.Button();
			this.Btn_Close = new System.Windows.Forms.PictureBox();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.MutexName_Panel = new System.Windows.Forms.Panel();
			this.MutexName_Box = new System.Windows.Forms.TextBox();
			this.MutexName_txt = new System.Windows.Forms.Label();
			this.UpdateFile_Panel = new System.Windows.Forms.Panel();
			this.UpdateFile_Box = new System.Windows.Forms.TextBox();
			this.UpdateFile_txt = new System.Windows.Forms.Label();
			this.UpdatesUrl_Panel = new System.Windows.Forms.Panel();
			this.UpdatesUrl_Box = new System.Windows.Forms.TextBox();
			this.UpdatesUrl_txt = new System.Windows.Forms.Label();
			this.Executable_Panel = new System.Windows.Forms.Panel();
			this.Executable_Box = new System.Windows.Forms.TextBox();
			this.Executable_txt = new System.Windows.Forms.Label();
			this.WindowTitle_Panel = new System.Windows.Forms.Panel();
			this.WindowTitle_Box = new System.Windows.Forms.TextBox();
			this.WindowTitle_txt = new System.Windows.Forms.Label();
			this.Error_handler = new System.Windows.Forms.ErrorProvider(this.components);
			this.Tooltip_handler = new System.Windows.Forms.ToolTip(this.components);
			this.FolderBrowser_handler = new System.Windows.Forms.FolderBrowserDialog();
			this.Launcher_Info_Box.SuspendLayout();
			this.Website_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
			this.MutexName_Panel.SuspendLayout();
			this.UpdateFile_Panel.SuspendLayout();
			this.UpdatesUrl_Panel.SuspendLayout();
			this.Executable_Panel.SuspendLayout();
			this.WindowTitle_Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Error_handler)).BeginInit();
			this.SuspendLayout();
			// 
			// Launcher_Info_Box
			// 
			this.Launcher_Info_Box.BackColor = System.Drawing.Color.Transparent;
			this.Launcher_Info_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Launcher_Info_Box.Controls.Add(this.Website_panel);
			this.Launcher_Info_Box.Controls.Add(this.Btn_Load);
			this.Launcher_Info_Box.Controls.Add(this.Btn_Close);
			this.Launcher_Info_Box.Controls.Add(this.Btn_Save);
			this.Launcher_Info_Box.Controls.Add(this.MutexName_Panel);
			this.Launcher_Info_Box.Controls.Add(this.UpdateFile_Panel);
			this.Launcher_Info_Box.Controls.Add(this.UpdatesUrl_Panel);
			this.Launcher_Info_Box.Controls.Add(this.Executable_Panel);
			this.Launcher_Info_Box.Controls.Add(this.WindowTitle_Panel);
			this.Launcher_Info_Box.Font = new System.Drawing.Font("Verdana", 11F);
			this.Launcher_Info_Box.ForeColor = System.Drawing.Color.DarkOrange;
			this.Launcher_Info_Box.Location = new System.Drawing.Point(12, 12);
			this.Launcher_Info_Box.Name = "Launcher_Info_Box";
			this.Launcher_Info_Box.Size = new System.Drawing.Size(560, 576);
			this.Launcher_Info_Box.TabIndex = 0;
			this.Launcher_Info_Box.TabStop = false;
			this.Launcher_Info_Box.Text = "Launcher Information";
			// 
			// Website_panel
			// 
			this.Website_panel.Controls.Add(this.Website_Box);
			this.Website_panel.Controls.Add(this.Website_txt);
			this.Website_panel.Location = new System.Drawing.Point(6, 350);
			this.Website_panel.Name = "Website_panel";
			this.Website_panel.Size = new System.Drawing.Size(548, 70);
			this.Website_panel.TabIndex = 6;
			// 
			// Website_Box
			// 
			this.Website_Box.BackColor = System.Drawing.SystemColors.InfoText;
			this.Website_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Website_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Website_Box.Location = new System.Drawing.Point(35, 38);
			this.Website_Box.MaxLength = 256;
			this.Website_Box.Name = "Website_Box";
			this.Website_Box.Size = new System.Drawing.Size(473, 25);
			this.Website_Box.TabIndex = 1;
			// 
			// Website_txt
			// 
			this.Website_txt.Cursor = System.Windows.Forms.Cursors.Help;
			this.Website_txt.Font = new System.Drawing.Font("Verdana", 10F);
			this.Website_txt.Location = new System.Drawing.Point(35, 10);
			this.Website_txt.Name = "Website_txt";
			this.Website_txt.Size = new System.Drawing.Size(473, 25);
			this.Website_txt.TabIndex = 0;
			this.Website_txt.Text = "Website URL";
			this.Website_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Btn_Load
			// 
			this.Btn_Load.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Load.BackgroundImage = global::Encoder.Properties.Resources.Load_n;
			this.Btn_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Load.FlatAppearance.BorderSize = 0;
			this.Btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Load.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Btn_Load.Location = new System.Drawing.Point(96, 515);
			this.Btn_Load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn_Load.Name = "Btn_Load";
			this.Btn_Load.Size = new System.Drawing.Size(108, 43);
			this.Btn_Load.TabIndex = 7;
			this.Btn_Load.Text = "Load";
			this.Btn_Load.UseVisualStyleBackColor = false;
			this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
			// 
			// Btn_Close
			// 
			this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Close.BackgroundImage = global::Encoder.Properties.Resources.Close_n;
			this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Close.Location = new System.Drawing.Point(532, 1);
			this.Btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn_Close.Name = "Btn_Close";
			this.Btn_Close.Size = new System.Drawing.Size(22, 22);
			this.Btn_Close.TabIndex = 1;
			this.Btn_Close.TabStop = false;
			this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// Btn_Save
			// 
			this.Btn_Save.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Save.BackgroundImage = global::Encoder.Properties.Resources.Save_n;
			this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Save.FlatAppearance.BorderSize = 0;
			this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Save.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.Btn_Save.Location = new System.Drawing.Point(353, 515);
			this.Btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(108, 43);
			this.Btn_Save.TabIndex = 8;
			this.Btn_Save.Text = "Save";
			this.Btn_Save.UseVisualStyleBackColor = false;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// MutexName_Panel
			// 
			this.MutexName_Panel.Controls.Add(this.MutexName_Box);
			this.MutexName_Panel.Controls.Add(this.MutexName_txt);
			this.MutexName_Panel.Location = new System.Drawing.Point(6, 430);
			this.MutexName_Panel.Name = "MutexName_Panel";
			this.MutexName_Panel.Size = new System.Drawing.Size(548, 70);
			this.MutexName_Panel.TabIndex = 6;
			// 
			// MutexName_Box
			// 
			this.MutexName_Box.BackColor = System.Drawing.SystemColors.InfoText;
			this.MutexName_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MutexName_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.MutexName_Box.Location = new System.Drawing.Point(35, 38);
			this.MutexName_Box.MaxLength = 256;
			this.MutexName_Box.Name = "MutexName_Box";
			this.MutexName_Box.Size = new System.Drawing.Size(473, 25);
			this.MutexName_Box.TabIndex = 1;
			// 
			// MutexName_txt
			// 
			this.MutexName_txt.Cursor = System.Windows.Forms.Cursors.Help;
			this.MutexName_txt.Font = new System.Drawing.Font("Verdana", 10F);
			this.MutexName_txt.Location = new System.Drawing.Point(35, 10);
			this.MutexName_txt.Name = "MutexName_txt";
			this.MutexName_txt.Size = new System.Drawing.Size(473, 25);
			this.MutexName_txt.TabIndex = 0;
			this.MutexName_txt.Text = "Mutex Name";
			this.MutexName_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UpdateFile_Panel
			// 
			this.UpdateFile_Panel.Controls.Add(this.UpdateFile_Box);
			this.UpdateFile_Panel.Controls.Add(this.UpdateFile_txt);
			this.UpdateFile_Panel.Location = new System.Drawing.Point(6, 270);
			this.UpdateFile_Panel.Name = "UpdateFile_Panel";
			this.UpdateFile_Panel.Size = new System.Drawing.Size(548, 70);
			this.UpdateFile_Panel.TabIndex = 5;
			// 
			// UpdateFile_Box
			// 
			this.UpdateFile_Box.BackColor = System.Drawing.SystemColors.InfoText;
			this.UpdateFile_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UpdateFile_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.UpdateFile_Box.Location = new System.Drawing.Point(35, 38);
			this.UpdateFile_Box.MaxLength = 256;
			this.UpdateFile_Box.Name = "UpdateFile_Box";
			this.UpdateFile_Box.Size = new System.Drawing.Size(473, 25);
			this.UpdateFile_Box.TabIndex = 1;
			// 
			// UpdateFile_txt
			// 
			this.UpdateFile_txt.Cursor = System.Windows.Forms.Cursors.Help;
			this.UpdateFile_txt.Font = new System.Drawing.Font("Verdana", 10F);
			this.UpdateFile_txt.Location = new System.Drawing.Point(35, 10);
			this.UpdateFile_txt.Name = "UpdateFile_txt";
			this.UpdateFile_txt.Size = new System.Drawing.Size(473, 25);
			this.UpdateFile_txt.TabIndex = 0;
			this.UpdateFile_txt.Text = "Update Filename";
			this.UpdateFile_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UpdatesUrl_Panel
			// 
			this.UpdatesUrl_Panel.Controls.Add(this.UpdatesUrl_Box);
			this.UpdatesUrl_Panel.Controls.Add(this.UpdatesUrl_txt);
			this.UpdatesUrl_Panel.Location = new System.Drawing.Point(6, 190);
			this.UpdatesUrl_Panel.Name = "UpdatesUrl_Panel";
			this.UpdatesUrl_Panel.Size = new System.Drawing.Size(548, 70);
			this.UpdatesUrl_Panel.TabIndex = 4;
			// 
			// UpdatesUrl_Box
			// 
			this.UpdatesUrl_Box.BackColor = System.Drawing.SystemColors.InfoText;
			this.UpdatesUrl_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UpdatesUrl_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.UpdatesUrl_Box.Location = new System.Drawing.Point(35, 38);
			this.UpdatesUrl_Box.MaxLength = 256;
			this.UpdatesUrl_Box.Name = "UpdatesUrl_Box";
			this.UpdatesUrl_Box.Size = new System.Drawing.Size(473, 25);
			this.UpdatesUrl_Box.TabIndex = 1;
			// 
			// UpdatesUrl_txt
			// 
			this.UpdatesUrl_txt.Cursor = System.Windows.Forms.Cursors.Help;
			this.UpdatesUrl_txt.Font = new System.Drawing.Font("Verdana", 10F);
			this.UpdatesUrl_txt.Location = new System.Drawing.Point(35, 10);
			this.UpdatesUrl_txt.Name = "UpdatesUrl_txt";
			this.UpdatesUrl_txt.Size = new System.Drawing.Size(473, 25);
			this.UpdatesUrl_txt.TabIndex = 0;
			this.UpdatesUrl_txt.Text = "Updates URL";
			this.UpdatesUrl_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Executable_Panel
			// 
			this.Executable_Panel.Controls.Add(this.Executable_Box);
			this.Executable_Panel.Controls.Add(this.Executable_txt);
			this.Executable_Panel.Location = new System.Drawing.Point(6, 110);
			this.Executable_Panel.Name = "Executable_Panel";
			this.Executable_Panel.Size = new System.Drawing.Size(548, 70);
			this.Executable_Panel.TabIndex = 3;
			// 
			// Executable_Box
			// 
			this.Executable_Box.BackColor = System.Drawing.SystemColors.InfoText;
			this.Executable_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Executable_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Executable_Box.Location = new System.Drawing.Point(35, 38);
			this.Executable_Box.MaxLength = 256;
			this.Executable_Box.Name = "Executable_Box";
			this.Executable_Box.Size = new System.Drawing.Size(473, 25);
			this.Executable_Box.TabIndex = 1;
			// 
			// Executable_txt
			// 
			this.Executable_txt.Cursor = System.Windows.Forms.Cursors.Help;
			this.Executable_txt.Font = new System.Drawing.Font("Verdana", 10F);
			this.Executable_txt.Location = new System.Drawing.Point(35, 10);
			this.Executable_txt.Name = "Executable_txt";
			this.Executable_txt.Size = new System.Drawing.Size(473, 25);
			this.Executable_txt.TabIndex = 0;
			this.Executable_txt.Text = "Executable";
			this.Executable_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WindowTitle_Panel
			// 
			this.WindowTitle_Panel.Controls.Add(this.WindowTitle_Box);
			this.WindowTitle_Panel.Controls.Add(this.WindowTitle_txt);
			this.WindowTitle_Panel.Location = new System.Drawing.Point(6, 30);
			this.WindowTitle_Panel.Name = "WindowTitle_Panel";
			this.WindowTitle_Panel.Size = new System.Drawing.Size(548, 70);
			this.WindowTitle_Panel.TabIndex = 2;
			// 
			// WindowTitle_Box
			// 
			this.WindowTitle_Box.BackColor = System.Drawing.SystemColors.InfoText;
			this.WindowTitle_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WindowTitle_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.WindowTitle_Box.Location = new System.Drawing.Point(35, 38);
			this.WindowTitle_Box.MaxLength = 256;
			this.WindowTitle_Box.Name = "WindowTitle_Box";
			this.WindowTitle_Box.Size = new System.Drawing.Size(473, 25);
			this.WindowTitle_Box.TabIndex = 1;
			// 
			// WindowTitle_txt
			// 
			this.WindowTitle_txt.Cursor = System.Windows.Forms.Cursors.Help;
			this.WindowTitle_txt.Font = new System.Drawing.Font("Verdana", 10F);
			this.WindowTitle_txt.Location = new System.Drawing.Point(35, 10);
			this.WindowTitle_txt.Name = "WindowTitle_txt";
			this.WindowTitle_txt.Size = new System.Drawing.Size(473, 25);
			this.WindowTitle_txt.TabIndex = 0;
			this.WindowTitle_txt.Text = "Window Title";
			this.WindowTitle_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Error_handler
			// 
			this.Error_handler.ContainerControl = this;
			// 
			// Tooltip_handler
			// 
			this.Tooltip_handler.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.Tooltip_handler.ToolTipTitle = "Help info";
			// 
			// FolderBrowser_handler
			// 
			this.FolderBrowser_handler.Description = "Select the folder for the Launcher Config file.";
			this.FolderBrowser_handler.SelectedPath = "AppDomain.CurrentDomain.BaseDirectory";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.BackgroundImage = global::Encoder.Properties.Resources.Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(584, 600);
			this.Controls.Add(this.Launcher_Info_Box);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Encoder - kayito";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Launcher_Info_Box.ResumeLayout(false);
			this.Website_panel.ResumeLayout(false);
			this.Website_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
			this.MutexName_Panel.ResumeLayout(false);
			this.MutexName_Panel.PerformLayout();
			this.UpdateFile_Panel.ResumeLayout(false);
			this.UpdateFile_Panel.PerformLayout();
			this.UpdatesUrl_Panel.ResumeLayout(false);
			this.UpdatesUrl_Panel.PerformLayout();
			this.Executable_Panel.ResumeLayout(false);
			this.Executable_Panel.PerformLayout();
			this.WindowTitle_Panel.ResumeLayout(false);
			this.WindowTitle_Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Error_handler)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox Launcher_Info_Box;
		private System.Windows.Forms.TextBox WindowTitle_Box;
		private System.Windows.Forms.Label WindowTitle_txt;
		private System.Windows.Forms.Panel WindowTitle_Panel;
		private System.Windows.Forms.Panel Executable_Panel;
		private System.Windows.Forms.TextBox Executable_Box;
		private System.Windows.Forms.Label Executable_txt;
		private System.Windows.Forms.Panel UpdatesUrl_Panel;
		private System.Windows.Forms.TextBox UpdatesUrl_Box;
		private System.Windows.Forms.Label UpdatesUrl_txt;
		private System.Windows.Forms.Panel UpdateFile_Panel;
		private System.Windows.Forms.TextBox UpdateFile_Box;
		private System.Windows.Forms.Label UpdateFile_txt;
		private System.Windows.Forms.Panel MutexName_Panel;
		private System.Windows.Forms.TextBox MutexName_Box;
		private System.Windows.Forms.Label MutexName_txt;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.PictureBox Btn_Close;
		private System.Windows.Forms.Button Btn_Load;
		private System.Windows.Forms.ErrorProvider Error_handler;
		private System.Windows.Forms.ToolTip Tooltip_handler;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowser_handler;
		private System.Windows.Forms.Panel Website_panel;
		private System.Windows.Forms.TextBox Website_Box;
		private System.Windows.Forms.Label Website_txt;
	}
}