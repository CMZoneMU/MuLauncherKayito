using System.Threading.Tasks;

namespace Shared.Network
{
	public class NetworkService
	{
		public async Task CheckNetwork(string url)
		{
			var response = await HttpClientManager.Client.GetAsync(url);

			response.EnsureSuccessStatusCode();
		}

		public void CloseNetwork()
		{
			try
			{
				HttpClientManager.Client.Dispose();
			}
			catch
			{
				
			}
		}
	}
}
