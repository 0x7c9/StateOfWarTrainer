using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace StateOfWarTrainer.Core
{
	unsafe class Trainer
	{
		internal string gameVersion;
		internal string[] supportedGames = new string[3] { "State of War", "State of War - Warmonger", "State of War Warmonger" };
		private const int dwDesiredAcces = 0x1F0FFF; //This is full acces flag for open procsess.
		private void* gameProcAddr = null;

		/* State of war memory addresses */
		private int[] sowAddresess = new int[6]
	{
			0x0070CB04, //0. Money
			0x006BAF78, //1. Bombarders
			0x006BAF84, //2. Trojans
			0x006BAF80, //3. Troopers
			0x006BAF88, //4. Fighters
			0x0070CAF8, //5. Research
 };

		/* State of war - warmonger memory addresses */
		private int[] sowwAddresess = new int[6]
		{
			0x00708828, //0. Money
			0x006B6CE0, //1. Bombarders
			0x006B6CEC, //2. Trojans
			0x006B6CE8, //3. Troopers
			0x006B6CF0, //4. Fighters
			0x0070881C, //5. Research
	 };

		/* State of war - warmonger steam version  memory adresses*/
		private int[] sowwAdresessSteam = new int[6]
		{
		0x00458F70,	//0. Money
		0x005527F0,	//1. Bombarders
		0x005527FC,	//2. Trojans
		0x005527F8,	//3. Troopers
		0x00552800,	//4. Fighters
		0x00458F7C,	//5. Research
		};

		private int[] gameAddresess;

		/// <summary>
		/// Checking if game running and if game is supported.
		/// </summary>
		/// <returns></returns>
		public bool GetGameProcess()
		{
			//If user want make some experiments
			if (Experimental.isExperimental && Experimental.AreYouSure())
			{
				try
				{
					gameProcAddr = WinApi.OpenProcess(dwDesiredAcces, false, Experimental.PID);
					//If game not exist.
					if (gameProcAddr == (void*)0x00)
					{
						return false;
					}
					Experimental.accepted = true;
					SetGameAddresses(Experimental.gameID);
					return true;
				}
				catch
				{
					return false;
				}
			}

			//Okay then no experiments.
			Process[] allProcesses = Process.GetProcesses();
			try
			{
				Process game = allProcesses.Where(x => x.ProcessName == supportedGames[0] || x.ProcessName == supportedGames[1] || x.ProcessName == supportedGames[2]).Single();
				if (game != null)
				{
					int gameID = 0;
					if (Checker.DetermineVersion(game.MainModule.FileName, ref gameID))
					{
						gameProcAddr = WinApi.OpenProcess(dwDesiredAcces, false, game.Id);

						if (gameProcAddr == (void*)0x00)
						{
							//If game process not exist.
							return false;
						}
						//Set game name and set game working addresses
						SetGameAddresses(gameID);
						gameVersion = supportedGames[gameID];
						return true;
					}
				}
			}
			catch
			{
				return false;
			}
			return false;
		}

		private void SetGameAddresses(int gameID)
		{
			switch (gameID)
			{
				case 0:
					gameAddresess = sowAddresess;
					break;
				case 1:
					gameAddresess = sowwAddresess;
					break;
				case 2:
					gameAddresess = sowwAdresessSteam;
					break;
			}
		}

		#region Trainer options
		public int Money
		{
			get
			{
				return GetValue(gameAddresess[0]);
			}
			set
			{
				SetValue(value, gameAddresess[0]);
			}
		}
		public int Bombarders
		{
			get
			{
				return GetValue(gameAddresess[1]);
			}
			set
			{
				SetValue(value, gameAddresess[1]);
			}
		}
		public int Trojans
		{
			get
			{
				return GetValue(gameAddresess[2]);
			}
			set
			{
				SetValue(value, gameAddresess[2]);
			}
		}
		public int Troopers
		{
			get
			{
				return GetValue(gameAddresess[3]);
			}
			set
			{
				SetValue(value, gameAddresess[3]);
			}
		}
		public int Fighters
		{
			get
			{
				return GetValue(gameAddresess[4]);
			}
			set
			{
				SetValue(value, gameAddresess[4]);
			}
		}
		public int Research
		{
			get
			{
				return GetValue(gameAddresess[5]);
			}
			set
			{
				SetValue(value, gameAddresess[5]);
			}
		}
		#endregion

		/// <summary>
		/// Get value (number) from addres
		/// </summary>
		/// <param name="addr"></param>
		/// <returns></returns>
		private int GetValue(int addr)
		{
			if (GetGameProcess() != true)
				return 0;

			byte[] buffer = new byte[sizeof(int)];
			int readed = 0;
			int result = -1;
			bool ok = WinApi.ReadProcessMemory(gameProcAddr, addr, buffer, sizeof(int), out readed);
			if (ok && readed == sizeof(int))
			{
				result = BitConverter.ToInt32(buffer, 0);
			}
			else
			{
				throw new Exception("Cannot read value on address!");
			}
			return result;
		}

		/// <summary>
		/// Set value (int) ond addres
		/// </summary>
		/// <param name="value"></param>
		/// <param name="addr"></param>
		private void SetValue(int value, int addr)
		{
			if (GetGameProcess() != true)
				return;

			byte[] buffer = BitConverter.GetBytes(value);
			int writted = 0;
			bool ok = WinApi.WriteProcessMemory(gameProcAddr, addr, buffer, buffer.Length, out writted);
			if (ok && writted == sizeof(int))
			{
				return;
			}
			throw new Exception("Cannot set value on address!");
		}

	}
}
