using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace StateOfWarTrainer.Core
{
	unsafe class WinApi
	{

		/// <summary>
		/// Open process
		/// </summary>
		/// <param name="dwDesiredAccess"></param>
		/// <param name="bInheritHandle"></param>
		/// <param name="dwProcessId"></param>
		/// <returns></returns>
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		public static extern void* OpenProcess(
		int dwDesiredAccess,
		bool bInheritHandle,
		int dwProcessId
);

		/// <summary>
		/// Read data to from process
		/// </summary>
		/// <param name="hProcess"></param>
		/// <param name="lpBaseAddress"></param>
		/// <param name="lpBuffer"></param>
		/// <param name="nSize"></param>
		/// <param name="lpNumberOfBytesRead"></param>
		/// <returns></returns>
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		public static extern bool ReadProcessMemory(
		void* hProcess,
		int lpBaseAddress,
		byte[] lpBuffer,
		int nSize,
		out int lpNumberOfBytesRead
);

		/// <summary>
		/// Write data to process
		/// </summary>
		/// <param name="hProcess"></param>
		/// <param name="lpBaseAddress"></param>
		/// <param name="lpBuffer"></param>
		/// <param name="nSize"></param>
		/// <param name="lpNumberOfBytesWritten"></param>
		/// <returns></returns>
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
		public static extern bool WriteProcessMemory(
		void* hProcess,
		int lpBaseAddress,
		byte[] lpBuffer,
		int nSize,
		out int lpNumberOfBytesWritten
);

	}
}
