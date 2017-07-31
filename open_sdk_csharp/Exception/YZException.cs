using System;
namespace YZOpenSDK
{
	public class YZException : Exception
	{
		private string message;
		
		public YZException(string message)
		{
			this.message = message;
		}
	}
}
