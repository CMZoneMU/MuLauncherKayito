using System;
using System.Diagnostics;

namespace Shared.Utils
{
	// Update Kayito 92 2.4.9 -> 97K SSeMU Update (Issue 3) - Safe web navigation and protocol handler validation
	public static class WebHelper
	{
		// Validates whether the given URI uses safe HTTP or HTTPS web schemes
		public static bool IsSafeWebUri(Uri? uri)
		{
			if (uri == null || !uri.IsAbsoluteUri)
			{
				return false;
			}

			return uri.Scheme.Equals(Uri.UriSchemeHttp, StringComparison.OrdinalIgnoreCase) ||
			       uri.Scheme.Equals(Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase);
		}

		// Validates and parses a string URL, ensuring it is a safe HTTP or HTTPS web scheme
		public static bool TryParseSafeWebUri(string? url, out Uri? uri)
		{
			uri = null;

			if (string.IsNullOrWhiteSpace(url))
			{
				return false;
			}

			if (!Uri.TryCreate(url.Trim(), UriKind.Absolute, out uri))
			{
				return false;
			}

			return IsSafeWebUri(uri);
		}

		// Opens the given URL safely in the default system browser
		// Strictly prevents execution of dangerous protocol handlers (e.g. file, javascript, ms-msdt, powershell)
		public static bool TryOpenExternalUrl(Uri? uri)
		{
			if (!IsSafeWebUri(uri))
			{
				return false;
			}

			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = uri!.AbsoluteUri,
					UseShellExecute = true
				});

				return true;
			}
			catch
			{
				return false;
			}
		}

		// Opens the given string URL safely in the default system browser
		public static bool TryOpenExternalUrl(string? url)
		{
			if (!TryParseSafeWebUri(url, out var uri))
			{
				return false;
			}

			return TryOpenExternalUrl(uri);
		}
	}
}
