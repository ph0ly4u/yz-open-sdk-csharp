using System;
using System.Security.Cryptography;
using System.Text;

namespace YZOpenSDK
{
	public class MD5Util
	{
		private MD5Util()
		{
			
		}

		public static string Hash(string input)
		{
			MD5 md5 = new MD5CryptoServiceProvider();
			byte[] sourceData = System.Text.Encoding.UTF8.GetBytes(input);
			byte[] targetData = md5.ComputeHash(sourceData);

			int i;
			StringBuilder buf = new StringBuilder("");
			for (int offset = 0; offset < targetData.Length; offset++)
			{
				i = targetData[offset];
				if (i < 0)
					i += 256;
				if (i < 16)
					buf.Append("0");
				buf.Append(i.ToString("x"));
			}
			return buf.ToString();
		}
	}
}
