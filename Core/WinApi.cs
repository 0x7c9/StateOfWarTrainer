using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace StateOfWarTrainer.Core
{
	unsafe class WinApi
	{

		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		public static extern void* OpenProcess(
		int dwDesiredAccess,
		bool bInheritHandle,
		int dwProcessId
);

		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		public static extern bool ReadProcessMemory(
		void* hProcess,
		int lpBaseAddress,
		byte[] lpBuffer,
		int nSize,
		out int lpNumberOfBytesRead
);

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
