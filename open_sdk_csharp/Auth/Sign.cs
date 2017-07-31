using System;
namespace YZOpenSDK
{
	public class Sign : Auth
	{
		private string appId;
		private string appSecret;

		public Sign(string appId, string appSecret)
		{
			this.appId = appId;
			this.appSecret = appSecret;
		}

		public string getAppId()
		{
			return this.appId;
		}

		public string getAppSecret()
		{
			return this.appSecret;
		}
	}
}
