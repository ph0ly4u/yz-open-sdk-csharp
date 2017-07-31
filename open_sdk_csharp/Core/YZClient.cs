using System;
using System.Collections.Generic;

namespace YZOpenSDK
{
	public interface YZClient
	{
		string Invoke(string apiName, string version, string method, IDictionary<string, object> apiParams, List<KeyValuePair<string, string>> files);
	}
}
