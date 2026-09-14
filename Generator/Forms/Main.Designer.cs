namespace Generator
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.FileList_Box = new System.Windows.Forms.DataGridView();
			this.FileList_RelativePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Btn_Delete = new System.Windows.Forms.Button();
			this.Btn_Open = new System.Windows.Forms.Button();
			this.Btn_Generate = new System.Windows.Forms.Button();
			this.Filename_txt = new System.Windows.Forms.Label();
			this.Filename_Box = new System.Windows.Forms.TextBox();
			this.FolderBrowser_handler = new System.Windows.Forms.FolderBrowserDialog();
			this.Btn_Clear = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Launcher_Panel = new System.Windows.Forms.GroupBox();
			this.Btn_Launcher = new System.Windows.Forms.Button();
			this.Launcher_Box = new System.Windows.Forms.TextBox();
			this.OpenFile_handler = new System.Windows.Forms.OpenFileDialog();
			this.Filelist_Panel = new System.Windows.Forms.GroupBox();
			this.SaveFile_handler = new System.Windows.Forms.SaveFileDialog();
			this.ProgressBack = new System.Windows.Forms.Panel();
			this.CurrentProgress = new System.Windows.Forms.Panel();
			this.ProgressText = new System.Windows.Forms.Label();
			this.Function_panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.FileList_Box)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Launcher_Panel.SuspendLayout();
			this.Filelist_Panel.SuspendLayout();
			this.ProgressBack.SuspendLayout();
			this.Function_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// FileList_Box
			// 
			this.FileList_Box.AllowUserToAddRows = false;
			this.FileList_Box.AllowUserToResizeRows = false;
			this.FileList_Box.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.FileList_Box.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.FileList_Box.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.FileList_Box.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.FileList_Box.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FileList_Box.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileList_RelativePath});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.FileList_Box.DefaultCellStyle = dataGridViewCellStyle2;
			this.FileList_Box.EnableHeadersVisualStyles = false;
			this.FileList_Box.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.FileList_Box.Location = new System.Drawing.Point(6, 21);
			this.FileList_Box.Name = "FileList_Box";
			this.FileList_Box.ReadOnly = true;
			this.FileList_Box.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.FileList_Box.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.FileList_Box.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.FileList_Box.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.FileList_Box.Size = new System.Drawing.Size(606, 383);
			this.FileList_Box.TabIndex = 1;
			this.FileList_Box.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.FileList_Box_CellFormatting);
			// 
			// FileList_RelativePath
			// 
			this.FileList_RelativePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FileList_RelativePath.DataPropertyName = "RelativePath";
			this.FileList_RelativePath.FillWeight = 80F;
			this.FileList_RelativePath.HeaderText = "File";
			this.FileList_RelativePath.MinimumWidth = 400;
			this.FileList_RelativePath.Name = "FileList_RelativePath";
			this.FileList_RelativePath.ReadOnly = true;
			this.FileList_RelativePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Btn_Delete
			// 
			this.Btn_Delete.ForeColor = System.Drawing.Color.Black;
			this.Btn_Delete.Location = new System.Drawing.Point(618, 81);
			this.Btn_Delete.Name = "Btn_Delete";
			this.Btn_Delete.Size = new System.Drawing.Size(136, 30);
			this.Btn_Delete.TabIndex = 3;
			this.Btn_Delete.Text = "Delete Rows";
			this.Btn_Delete.UseVisualStyleBackColor = true;
			this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
			// 
			// Btn_Open
			// 
			this.Btn_Open.ForeColor = System.Drawing.Color.Black;
			this.Btn_Open.Location = new System.Drawing.Point(618, 141);
			this.Btn_Open.Name = "Btn_Open";
			this.Btn_Open.Size = new System.Drawing.Size(136, 30);
			this.Btn_Open.TabIndex = 4;
			this.Btn_Open.Text = "Open Folder";
			this.Btn_Open.UseVisualStyleBackColor = true;
			this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
			// 
			// Btn_Generate
			// 
			this.Btn_Generate.BackColor = System.Drawing.SystemColors.Control;
			this.Btn_Generate.Enabled = false;
			this.Btn_Generate.ForeColor = System.Drawing.Color.Black;
			this.Btn_Generate.Location = new System.Drawing.Point(630, 492);
			this.Btn_Generate.Name = "Btn_Generate";
			this.Btn_Generate.Size = new System.Drawing.Size(142, 57);
			this.Btn_Generate.TabIndex = 4;
			this.Btn_Generate.Text = "Generate Update";
			this.Btn_Generate.UseVisualStyleBackColor = false;
			this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
			// 
			// Filename_txt
			// 
			this.Filename_txt.AutoSize = true;
			this.Filename_txt.BackColor = System.Drawing.Color.Transparent;
			this.Filename_txt.ForeColor = System.Drawing.Color.DarkOrange;
			this.Filename_txt.Location = new System.Drawing.Point(15, 494);
			this.Filename_txt.Name = "Filename_txt";
			this.Filename_txt.Size = new System.Drawing.Size(113, 14);
			this.Filename_txt.TabIndex = 1;
			this.Filename_txt.Text = "Update Filename";
			this.Filename_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Filename_Box
			// 
			this.Filename_Box.BackColor = System.Drawing.Color.Black;
			this.Filename_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Filename_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Filename_Box.Location = new System.Drawing.Point(134, 492);
			this.Filename_Box.Name = "Filename_Box";
			this.Filename_Box.Size = new System.Drawing.Size(490, 22);
			this.Filename_Box.TabIndex = 3;
			this.Filename_Box.Text = "LauncherUpdate.json";
			// 
			// FolderBrowser_handler
			// 
			this.FolderBrowser_handler.Description = "Select the folder with the update content.";
			this.FolderBrowser_handler.SelectedPath = "AppDomain.CurrentDomain.BaseDirectory";
			// 
			// Btn_Clear
			// 
			this.Btn_Clear.ForeColor = System.Drawing.Color.Black;
			this.Btn_Clear.Location = new System.Drawing.Point(618, 21);
			this.Btn_Clear.Name = "Btn_Clear";
			this.Btn_Clear.Size = new System.Drawing.Size(136, 30);
			this.Btn_Clear.TabIndex = 2;
			this.Btn_Clear.Text = "Clear List";
			this.Btn_Clear.UseVisualStyleBackColor = true;
			this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::Generator.Properties.Resources.Tama_Chan;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(618, 177);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 227);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Launcher_Panel
			// 
			this.Launcher_Panel.BackColor = System.Drawing.Color.Transparent;
			this.Launcher_Panel.Controls.Add(this.Btn_Launcher);
			this.Launcher_Panel.Controls.Add(this.Launcher_Box);
			this.Launcher_Panel.ForeColor = System.Drawing.Color.DarkOrange;
			this.Launcher_Panel.Location = new System.Drawing.Point(12, 12);
			this.Launcher_Panel.Name = "Launcher_Panel";
			this.Launcher_Panel.Size = new System.Drawing.Size(760, 58);
			this.Launcher_Panel.TabIndex = 1;
			this.Launcher_Panel.TabStop = false;
			this.Launcher_Panel.Text = "Launcher executable";
			// 
			// Btn_Launcher
			// 
			this.Btn_Launcher.ForeColor = System.Drawing.Color.Black;
			this.Btn_Launcher.Location = new System.Drawing.Point(618, 21);
			this.Btn_Launcher.Name = "Btn_Launcher";
			this.Btn_Launcher.Size = new System.Drawing.Size(136, 22);
			this.Btn_Launcher.TabIndex = 2;
			this.Btn_Launcher.Text = "Find Launcher.exe";
			this.Btn_Launcher.UseVisualStyleBackColor = true;
			this.Btn_Launcher.Click += new System.EventHandler(this.Btn_Launcher_Click);
			// 
			// Launcher_Box
			// 
			this.Launcher_Box.BackColor = System.Drawing.Color.Black;
			this.Launcher_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Launcher_Box.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Launcher_Box.Location = new System.Drawing.Point(6, 21);
			this.Launcher_Box.Name = "Launcher_Box";
			this.Launcher_Box.ReadOnly = true;
			this.Launcher_Box.Size = new System.Drawing.Size(606, 22);
			this.Launcher_Box.TabIndex = 1;
			// 
			// OpenFile_handler
			// 
			this.OpenFile_handler.InitialDirectory = "AppDomain.CurrentDomain.BaseDirectory";
			// 
			// Filelist_Panel
			// 
			this.Filelist_Panel.BackColor = System.Drawing.Color.Transparent;
			this.Filelist_Panel.Controls.Add(this.FileList_Box);
			this.Filelist_Panel.Controls.Add(this.Btn_Clear);
			this.Filelist_Panel.Controls.Add(this.Btn_Delete);
			this.Filelist_Panel.Controls.Add(this.pictureBox1);
			this.Filelist_Panel.Controls.Add(this.Btn_Open);
			this.Filelist_Panel.ForeColor = System.Drawing.Color.DarkOrange;
			this.Filelist_Panel.Location = new System.Drawing.Point(12, 76);
			this.Filelist_Panel.Name = "Filelist_Panel";
			this.Filelist_Panel.Size = new System.Drawing.Size(760, 410);
			this.Filelist_Panel.TabIndex = 2;
			this.Filelist_Panel.TabStop = false;
			this.Filelist_Panel.Text = "Filelist Update";
			// 
			// ProgressBack
			// 
			this.ProgressBack.BackColor = System.Drawing.Color.Black;
			this.ProgressBack.Controls.Add(this.CurrentProgress);
			this.ProgressBack.Location = new System.Drawing.Point(12, 536);
			this.ProgressBack.Name = "ProgressBack";
			this.ProgressBack.Size = new System.Drawing.Size(612, 12);
			this.ProgressBack.TabIndex = 5;
			// 
			// CurrentProgress
			// 
			this.CurrentProgress.BackColor = System.Drawing.Color.DarkBlue;
			this.CurrentProgress.Location = new System.Drawing.Point(4, 3);
			this.CurrentProgress.Name = "CurrentProgress";
			this.CurrentProgress.Size = new System.Drawing.Size(0, 6);
			this.CurrentProgress.TabIndex = 0;
			// 
			// ProgressText
			// 
			this.ProgressText.BackColor = System.Drawing.Color.Transparent;
			this.ProgressText.ForeColor = System.Drawing.Color.DarkOrange;
			this.ProgressText.Location = new System.Drawing.Point(12, 517);
			this.ProgressText.Name = "ProgressText";
			this.ProgressText.Size = new System.Drawing.Size(612, 16);
			this.ProgressText.TabIndex = 1;
			this.ProgressText.Text = "Progress";
			this.ProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Function_panel
			// 
			this.Function_panel.BackColor = System.Drawing.Color.Transparent;
			this.Function_panel.Controls.Add(this.ProgressText);
			this.Function_panel.Controls.Add(this.Launcher_Panel);
			this.Function_panel.Controls.Add(this.Filelist_Panel);
			this.Function_panel.Controls.Add(this.ProgressBack);
			this.Function_panel.Controls.Add(this.Filename_txt);
			this.Function_panel.Controls.Add(this.Btn_Generate);
			this.Function_panel.Controls.Add(this.Filename_Box);
			this.Function_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Function_panel.Location = new System.Drawing.Point(0, 0);
			this.Function_panel.Name = "Function_panel";
			this.Function_panel.Size = new System.Drawing.Size(784, 561);
			this.Function_panel.TabIndex = 6;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
			this.BackgroundImage = global::Generator.Properties.Resources.MainBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Function_panel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generator - kayito";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.FileList_Box)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Launcher_Panel.ResumeLayout(false);
			this.Launcher_Panel.PerformLayout();
			this.Filelist_Panel.ResumeLayout(false);
			this.ProgressBack.ResumeLayout(false);
			this.Function_panel.ResumeLayout(false);
			this.Function_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView FileList_Box;
		private System.Windows.Forms.Button Btn_Delete;
		private System.Windows.Forms.Button Btn_Open;
		private System.Windows.Forms.Button Btn_Generate;
		private System.Windows.Forms.Label Filename_txt;
		private System.Windows.Forms.TextBox Filename_Box;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowser_handler;
		private System.Windows.Forms.Button Btn_Clear;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox Launcher_Panel;
		private System.Windows.Forms.TextBox Launcher_Box;
		private System.Windows.Forms.Button Btn_Launcher;
		private System.Windows.Forms.OpenFileDialog OpenFile_handler;
		private System.Windows.Forms.GroupBox Filelist_Panel;
		private System.Windows.Forms.SaveFileDialog SaveFile_handler;
		private System.Windows.Forms.Panel ProgressBack;
		private System.Windows.Forms.Panel CurrentProgress;
		private System.Windows.Forms.Label ProgressText;
		private System.Windows.Forms.DataGridViewTextBoxColumn FileList_RelativePath;
		private System.Windows.Forms.Panel Function_panel;
	}
}

