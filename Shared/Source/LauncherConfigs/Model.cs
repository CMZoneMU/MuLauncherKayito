using System.Runtime.Serialization;

namespace Shared.LauncherConfig
{
	[DataContract]
	public class ConfigModel
	{
		[DataMember(Order = 1)]
		public string WindowTitle
		{
			get; set;
		} = "Launcher - kayito";

		[DataMember(Order = 2)]
		public string GameExecutable
		{
			get; set;
		} = "main.exe";

		[DataMember(Order = 3)]
		public string UpdatesURL
		{
			get; set;
		}

		[DataMember(Order = 4)]
		public string UpdateFilename
		{
			get; set;
		} = "LauncherUpdate.json";

		[DataMember(Order = 5)]
		public string WebsiteURL
		{
			get; set;
		}

		[DataMember(Order = 6)]
		public string MutexName
		{
			get; set;
		} = "kayitoLauncherMutex";
	}
}