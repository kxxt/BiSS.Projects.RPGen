using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BiSS.Projects.RPGen.Config
{
	public static class Config
	{
		public static object ReadObject(string json)
		{
			return JsonConvert.DeserializeObject(json);
		}

		public static string WriteObject(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
	}
}
