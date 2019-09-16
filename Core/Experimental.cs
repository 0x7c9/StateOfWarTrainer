using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StateOfWarTrainer.Core
{
	struct Experimental
	{
		public static bool isExperimental;
		public static int PID;
		public static bool accepted;
		public static int gameID;
		public static bool AreYouSure()
		{
			if (accepted)
				return true;
			DialogResult dialogResult = MessageBox.Show("This option can OpenProcess from given PID. If PID is bad or game is incompatible then you can damage other memory region! This can crash process and cause BSOD!", "Are you sure with that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				return true;
			}
			return false;
		}
	}
}
