using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace StateOfWarTrainer.Core
{
	class Utils
	{
		public static string GetSHAHash(byte[] data)
		{
			string result = string.Empty;
			byte[] hash = SHA1.Create().ComputeHash(data);
			foreach (var b in hash)
			{
				result += b.ToString("x");
			}
			return result;
		}
	}
}
