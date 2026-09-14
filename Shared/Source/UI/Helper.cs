using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shared.UI
{
	public static class UITextureHelper
	{
		public static void ApplyTextureControl(
			Control control,
			Image normal,
			Image disabled,
			Image hover,
			Image click)
		{
			void ApplyNormal()
			{
				control.BackgroundImage = control.Enabled ? normal : disabled;
			}

			control.BackgroundImage = control.Enabled ? normal : disabled;

			control.EnabledChanged += (_, __) =>
			{
				ApplyNormal();
			};

			control.MouseEnter += (_, __) =>
			{
				if (!control.Enabled)
				{
					return;
				}

				control.BackgroundImage = hover;
			};

			control.MouseLeave += (_, __) =>
			{
				ApplyNormal();
			};

			control.MouseDown += (_, __) =>
			{
				if (!control.Enabled)
				{
					return;
				}

				control.BackgroundImage = click;
			};

			control.MouseUp += (_, __) =>
			{
				if (!control.Enabled)
				{
					return;
				}

				var client = control.PointToClient(Cursor.Position);

				control.BackgroundImage =
				    control.ClientRectangle.Contains(client) ? hover : normal;
			};

			control.MouseCaptureChanged += (_, __) =>
			{
				ApplyNormal();
			};
		}

		public static void CheckBoxApply(
		    CheckBox btn,
		    Image checkedImg,
		    Image uncheckedImg)
		{
			btn.CheckedChanged += (_, __) =>
			{
				if (btn.Checked)
				{
					btn.Image = checkedImg;
				}
				else
				{
					btn.Image = uncheckedImg;
				}
			};
		}
	}
}
