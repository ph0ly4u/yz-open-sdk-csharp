using System;
namespace YZOpenSDK
{
	public class Token : Auth
	{
		private string token;

		public Token(string token)
		{
			this.token = token;
		}

		public string getToken()
		{
			return this.token;
		}
	}
}
