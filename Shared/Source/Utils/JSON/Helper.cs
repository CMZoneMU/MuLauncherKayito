using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Shared.Utils
{
	public static class JsonHelper
	{
		private static readonly ConcurrentDictionary<Type, DataContractJsonSerializer> Cache
		    = new ConcurrentDictionary<Type, DataContractJsonSerializer>();

		private static DataContractJsonSerializer GetSerializer(Type type)
		{
			return Cache.GetOrAdd(type, t => new DataContractJsonSerializer(t));
		}

		public static string Serialize<T>(T obj)
		{
			if (obj == null)
			{
				return "null";
			}

			var serializer = GetSerializer(typeof(T));

			using (var ms = new MemoryStream())
			{
				serializer.WriteObject(ms, obj);

				return Encoding.UTF8.GetString(ms.ToArray());
			}
		}

		public static T Deserialize<T>(string json)
		{
			var serializer = GetSerializer(typeof(T));

			using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
			{
				return (T)serializer.ReadObject(ms);
			}
		}
	}
}