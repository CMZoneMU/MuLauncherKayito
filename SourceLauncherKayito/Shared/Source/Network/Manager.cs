using System;
using System.Net;
using System.Net.Http;

namespace Shared.Network
{
	public static class HttpClientManager
	{
		public static readonly HttpClient Client = Create();

		private static HttpClient Create()
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
			ServicePointManager.DefaultConnectionLimit = 20;

			var client = new HttpClient();

			client.Timeout = TimeSpan.FromMinutes(10);

			client.DefaultRequestHeaders.ConnectionClose = true;

			return client;
		}
	}
}
