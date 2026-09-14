using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shared.UI
{
	public class SegmentedProgressBar : Control
	{
		private int value;

		public int Maximum { get; set; } = 100;

		public int Value
		{
			get
			{
				return value;
			}
			set
			{
				this.value = Math.Max(0, Math.Min(Maximum, value));

				Invalidate();
			}
		}

		public int SegmentCount { get; set; } = 20;

		public int SegmentSpacing { get; set; } = 2;

		public SegmentedProgressBar()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;

			using (Brush backBrush = new SolidBrush(BackColor))
			{
				graphics.FillRectangle(backBrush, base.ClientRectangle);
			}

			int num = (int)((double)Value / (double)Maximum * (double)SegmentCount);

			float num2 = (SegmentCount - 1) * SegmentSpacing;

			float num3 = ((float)base.Width - num2) / (float)SegmentCount;

			using (Brush foreBrush = new SolidBrush(ForeColor))
			{
				for (int i = 0; i < num; i++)
				{
					float num4 = (float)i * (num3 + (float)SegmentSpacing);

					float num5 = num4 + num3;

					int num6 = (int)Math.Round(num4);

					int num7 = (int)Math.Round(num5) - num6;

					Rectangle rect = new Rectangle(num6, 0, num7, base.Height);

					graphics.FillRectangle(foreBrush, rect);
				}
			}
		}
	}
}
