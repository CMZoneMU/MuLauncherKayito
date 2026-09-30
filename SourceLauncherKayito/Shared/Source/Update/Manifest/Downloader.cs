using System.Net.Http;
using System.Threading.Tasks;
// External
using Shared.Utils;

namespace Shared.Update
{
	public class ManifestDownloader
	{
		public async Task<UpdateManifest> DownloadManifest(string url)
		{
			using (HttpClient client = new HttpClient())
			{
				string json = await client.GetStringAsync(url);

				return JsonHelper.Deserialize<UpdateManifest>(json);
			}
		}
	}
}
