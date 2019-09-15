using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StateOfWarTrainer.frm;

namespace StateOfWarTrainer
{
	class Program
	{
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Gui gui = new Gui();
			Application.Run(gui);
		}
	}
}
