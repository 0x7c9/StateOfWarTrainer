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
		private void* gameProcAddr = null;
		private int[] gameAddresess = new int[1]
		{
			0x0070CB04, //0. Money
		};

		public bool GetGameProcess()
		{
			Process[] allProcesses = Process.GetProcesses();
			try
			{
				Process game = allProcesses.Where(x => x.ProcessName == "State of War").Single();
				if (game != null)
				{
					if (Checker.IsGameProcess(game.MainModule.FileName))
					{
						gameProcAddr = WinApi.OpenProcess(0x1F0FFF, false, game.Id);
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

		public int Money
		{
			get
			{
				return GetValue(gameAddresess[0]);
			}
			set
			{
				SetValue(value,gameAddresess[0]);
			}
		}

		private int GetValue(int addr)
		{
			byte[] buffer = new byte[sizeof(int)];
			int readed = 0;
			int result = -1;
			bool ok = WinApi.ReadProcessMemory(gameProcAddr, addr, buffer, sizeof(int),out readed);
			if (ok && readed == sizeof(int))
			{
				result = BitConverter.ToInt32(buffer, 0);
			}
			else
			{
				throw new Exception("Cannot read value on addres!");
			}
			return result;
		}

		private void SetValue(int value, int addr)
		{
			byte[] buffer = BitConverter.GetBytes(value);
			int writted = 0;
			bool ok = WinApi.WriteProcessMemory(gameProcAddr,addr, buffer, buffer.Length, out writted);
			if (ok && writted == sizeof(int))
			{
				return;
			}
			throw new Exception("Cannot set value on addres!");
		}

	}
}
