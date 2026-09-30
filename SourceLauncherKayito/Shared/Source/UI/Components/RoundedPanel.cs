using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Shared.UI
{
	public class RoundedPanel : Panel
	{
		public int Radius { get; set; } = 20;
		public Color BorderColor { get; set; } = Color.Black;
		public int BorderThickness { get; set; } = 1;

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			Rectangle rect = this.ClientRectangle;
			int d = Radius * 2;

			GraphicsPath path = new GraphicsPath();
			path.AddArc(rect.X, rect.Y, d, d, 180, 90);
			path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
			path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
			path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
			path.CloseFigure();

			this.Region = new Region(path);

			using (Pen pen = new Pen(BorderColor, BorderThickness))
			{
				e.Graphics.DrawPath(pen, path);
			}
		}
	}
}
