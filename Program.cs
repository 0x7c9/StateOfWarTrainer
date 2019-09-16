using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StateOfWarTrainer.frm;
using StateOfWarTrainer.Core;

namespace StateOfWarTrainer
{
	class Program
	{
		/// <summary>
		/// Entrypoint of this program.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{

			if (args.Length == 3)
			{
				if (args[0] == "-experimental")
				{
					int pid = int.Parse(args[1]);
					int gameID = int.Parse(args[2]);
					if (pid != 0)
					{
						Experimental.isExperimental = true;
						Experimental.PID = pid;
						Experimental.gameID = gameID;
					}
				}
			}

			Application.EnableVisualStyles();
			Gui gui = new Gui();
			Application.Run(gui);
		}
	}
}
