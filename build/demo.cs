using System;
using System.Collections.Generic;

namespace open_sdk_csharp1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Auth auth = new Sign("app_id", "app_secret");
			Auth auth = new Token("xxx");
			YZClient yzClient = new DefaultYZClient(auth);
			Dictionary<string, object> dict = new System.Collections.Generic.Dictionary<string, object>();
			dict.Add("title", "aaaaa");
			dict.Add("price", 1.0);
			dict.Add("post_fee", 1.0);

			List<KeyValuePair<string, string>> files = new List<KeyValuePair<string, string>>();
			files.Add(new KeyValuePair<string, string>("images[]", "/xx/xx/1.jpg"));

			//var result = yzClient.Invoke("kdt.item.add", "1.0.0", "post", dict, files);
			var result = yzClient.Invoke("kdt.items.onsale.get", "1.0.0", "get", dict, null);
			Console.WriteLine(result);
		}
	}
}

