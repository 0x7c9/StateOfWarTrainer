using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace StateOfWarTrainer.Core
{
	class Checker
	{

		/// <summary>
		/// This check file by hash :). We must know exact process. And this can help.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static bool IsGameProcess(string path)
		{
			string result = string.Empty;
			string target = "928af98adb4f5fde9dcb9fac7bf97c21302bc"; //This is a hash of game file, main exe.
			byte[] hash = SHA1.Create().ComputeHash(File.ReadAllBytes(path));
			foreach (var b in hash)
			{
				result += b.ToString("x");
			}
			if (result == target)
			{
				return true;
			}
			return false;
		}
	}
}
