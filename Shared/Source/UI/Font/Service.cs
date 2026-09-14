using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Shared.UI
{
	public static class FontManager
	{
		[DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, ref uint pcFonts);

		private static readonly PrivateFontCollection _fontCollection = new PrivateFontCollection();

		// Keep buffers alive
		private static readonly List<IntPtr> _fontBuffers = new List<IntPtr>();

		// Cache by name
		private static readonly Dictionary<string, FontFamily> _fonts = new Dictionary<string, FontFamily>();

		private static readonly object _lock = new object();

		public static FontFamily LoadFont(string key, byte[] fontData)
		{
			lock (_lock)
			{
				if (_fonts.ContainsKey(key))
				{
					return _fonts[key];
				}

				IntPtr data = Marshal.AllocCoTaskMem(fontData.Length);
				Marshal.Copy(fontData, 0, data, fontData.Length);

				uint cFonts = 0;
				AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

				_fontCollection.AddMemoryFont(data, fontData.Length);

				_fontBuffers.Add(data);

				var family = _fontCollection.Families[_fontCollection.Families.Length - 1];

				_fonts[key] = family;

				return family;
			}
		}

		public static Font GetFont(string key, float size, FontStyle style = FontStyle.Regular)
		{
			if (!_fonts.ContainsKey(key))
			{
				throw new InvalidOperationException($"Font '{key}' no está cargada.");
			}

			return new Font(_fonts[key], size, style);
		}
	}
}