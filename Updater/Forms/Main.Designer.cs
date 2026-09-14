namespace Updater
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
			this.CompleteBarBack = new System.Windows.Forms.Panel();
			this.CompleteBar = new System.Windows.Forms.Panel();
			this.LogoPanel = new System.Windows.Forms.Panel();
			this.StatusText = new System.Windows.Forms.Label();
			this.CompleteBarBack.SuspendLayout();
			this.SuspendLayout();
			// 
			// CompleteBarBack
			// 
			this.CompleteBarBack.Controls.Add(this.CompleteBar);
			this.CompleteBarBack.Location = new System.Drawing.Point(57, 264);
			this.CompleteBarBack.Margin = new System.Windows.Forms.Padding(4);
			this.CompleteBarBack.Name = "CompleteBarBack";
			this.CompleteBarBack.Size = new System.Drawing.Size(190, 28);
			this.CompleteBarBack.TabIndex = 0;
			// 
			// CompleteBar
			// 
			this.CompleteBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
			this.CompleteBar.Location = new System.Drawing.Point(4, 4);
			this.CompleteBar.Margin = new System.Windows.Forms.Padding(4);
			this.CompleteBar.Name = "CompleteBar";
			this.CompleteBar.Size = new System.Drawing.Size(182, 19);
			this.CompleteBar.TabIndex = 0;
			// 
			// LogoPanel
			// 
			this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
			this.LogoPanel.BackgroundImage = global::Updater.Properties.Resources.MuLogo;
			this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.LogoPanel.Location = new System.Drawing.Point(75, 52);
			this.LogoPanel.Margin = new System.Windows.Forms.Padding(4);
			this.LogoPanel.Name = "LogoPanel";
			this.LogoPanel.Size = new System.Drawing.Size(153, 102);
			this.LogoPanel.TabIndex = 0;
			// 
			// StatusText
			// 
			this.StatusText.BackColor = System.Drawing.Color.Transparent;
			this.StatusText.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
			this.StatusText.ForeColor = System.Drawing.SystemColors.Control;
			this.StatusText.Location = new System.Drawing.Point(13, 158);
			this.StatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.StatusText.Name = "StatusText";
			this.StatusText.Size = new System.Drawing.Size(278, 102);
			this.StatusText.TabIndex = 0;
			this.StatusText.Text = "Starting...";
			this.StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(304, 354);
			this.Controls.Add(this.StatusText);
			this.Controls.Add(this.CompleteBarBack);
			this.Controls.Add(this.LogoPanel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 11F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "kayito - Updater";
			this.Load += new System.EventHandler(this.Main_Load);
			this.CompleteBarBack.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel LogoPanel;
		private System.Windows.Forms.Panel CompleteBarBack;
		private System.Windows.Forms.Panel CompleteBar;
		private System.Windows.Forms.Label StatusText;
	}
}

