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

		private static string[] gameVersions = new string[3] {
			"928af98adb4f5fde9dcb9fac7bf97c21302bc", //0. State of War cracked by SoW-CZ-NoCD.exe
			"391127d7fd55cb72177cdd3be877d12d4387ad",//1. State of War - Warmonger cracked by 0x7c9 
			"312dbcfdf1c854c532a274b8287897bc2fb8b5f" //2. State of War Warmonger Steam Version
		};

		/// <summary>
		/// This check file by hash :). We must know exact process. And this can help.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static bool DetermineVersion(string path, ref int gameID)
		{
			string hashOfRunningProcces = Utils.GetSHAHash(File.ReadAllBytes(path));
			for (int i = 0; i < gameVersions.Length; i++)
			{
				if (hashOfRunningProcces == gameVersions[i])
				{
					gameID = i;
					return true;
				}			
			}
			return false;
		}



	}
}
