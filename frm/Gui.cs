using StateOfWarTrainer.Core;
using System;
using System.Windows.Forms;

namespace StateOfWarTrainer.frm
{
	public partial class Gui : Form
	{

		private const string progName = "State Of War Warmonger - Money changer by 0x7c9";
		private Trainer trainer;
		private Timer updater = new Timer();
		public Gui()
		{
			trainer = new Trainer();
			if (Check())
			{
				updater.Interval = 1000;
				updater.Enabled = true;
				updater.Tick += Updater_Tick;
			}
			InitializeComponent();
			this.Text = progName;
			GetMoney();
		}

		private void Updater_Tick(object sender, EventArgs e)
		{
			Check();
			GetMoney();
		}

		private bool Check()
		{
			if (!trainer.GetGameProcess())
			{
				if (updater.Enabled == true)
				{
					updater.Enabled = false;
				}
				MessageBox.Show("Sorry game is not runnning!\nPlease run game then open this trainer!", "Game not running!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Environment.Exit(1);
			}
			return true;
		}

		private void GetMoney()
		{
			txtMoney.Text = trainer.Money.ToString();
		}

		private void MoneyChanged(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			int givenValue = 0;
			int.TryParse(textBox.Text, out givenValue);
			if (!(givenValue > 99999))
			{
				trainer.Money = givenValue;
			}
			else
			{
				MessageBox.Show("Please set number in this range: 0 - 99999. And it must not be text!", "Invalid range!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void BtnAbout_Click(object sender, EventArgs e)
		{
			string text = progName + "\n\nThis is simple money changer :)\n\n0x7c9 2019 15.09.2019";
			MessageBox.Show(text, "About..", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
