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
		private Timer freezer = new Timer();
		private static int[] savedValues;

		/// <summary>
		/// Initialization constructor
		/// </summary>
		public Gui()
		{
			trainer = new Trainer(); //Create instance of Trainer

			//Check if game really running
			if (Check())
			{
				//Createu updating timer
				updater.Interval = 1000;
				updater.Enabled = true;
				updater.Tick += Updater_Tick;
			}
			InitializeComponent(); //Init form
			this.Text = progName; //Set title
			GetValues(); //Get initial values
		}

		/// <summary>
		/// Updating values in textboxes in form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Updater_Tick(object sender, EventArgs e)
		{
			Check();
			GetValues();
		}

		/// <summary>
		/// Check if game is running.
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		/// Get values from textboxes in form.
		/// </summary>
		private void GetValues()
		{
			txtMoney.Text = trainer.Money.ToString();
			txtBombarders.Text = trainer.Bombarders.ToString();
			txtTrojans.Text = trainer.Trojans.ToString();
			txtTroopers.Text = trainer.Troopers.ToString();
			txtFighters.Text = trainer.Fighters.ToString();
			txtResearch.Text = trainer.Research.ToString();
		}

		/// <summary>
		/// Get number textbox text
		/// </summary>
		/// <param name="control"></param>
		/// <returns></returns>
		private int RetrieveNumberFromTextBox(TextBox control)
		{
			TextBox textBox = (TextBox)control;
			int result = 0;
			int.TryParse(textBox.Text, out result);
			return result;
		}

		/// <summary>
		/// Check range of entered value.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private bool CheckGivenValue(int value)
		{
			if (!(value > 99999))
			{
				return true;
			}
			else
			{
				MessageBox.Show("Please set number in this range: 0 - 99999. And it must not be text!", "Invalid range!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			return false;
		}

		/// <summary>
		/// Simple about program.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAbout_Click(object sender, EventArgs e)
		{
			string text = progName + "\n\nThis is simple in-game resources changer :)\n\n0x7c9 2019 15.09.2019";
			MessageBox.Show(text, "About..", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#region Events
		private void MoneyChanged(object sender, EventArgs e)
		{
			int value = RetrieveNumberFromTextBox((TextBox)sender);
			if (CheckGivenValue(value))
			{
				trainer.Money = value;
			}
		}
		private void BombardersChanged(object sender, EventArgs e)
		{
			int value = RetrieveNumberFromTextBox((TextBox)sender);
			if (CheckGivenValue(value))
			{
				trainer.Bombarders = value;
			}
		}
		private void TrojansChanged(object sender, EventArgs e)
		{
			int value = RetrieveNumberFromTextBox((TextBox)sender);
			if (CheckGivenValue(value))
			{
				trainer.Trojans = value;
			}
		}
		private void TroopersChanged(object sender, EventArgs e)
		{
			int value = RetrieveNumberFromTextBox((TextBox)sender);
			if (CheckGivenValue(value))
			{
				trainer.Troopers = value;
			}
		}
		private void FightersChanged(object sender, EventArgs e)
		{
			int value = RetrieveNumberFromTextBox((TextBox)sender);
			if (CheckGivenValue(value))
			{
				trainer.Fighters = value;
			}
		}
		private void ResearchChanged(object sender, EventArgs e)
		{
			int value = RetrieveNumberFromTextBox((TextBox)sender);
			if (CheckGivenValue(value))
			{
				trainer.Research = value;
			}
		}
		private void FreezeValuesChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = (CheckBox)sender;
			if (checkBox.Checked == true)
			{
				freezer.Interval = 1000;
				freezer.Tick += Freezer_Tick;
				freezer.Enabled = true;
				savedValues = new int[6];
				SaveValues();
			}
			else
			{
				freezer.Enabled = false;
				savedValues = new int[6];
			}
		}
		#endregion

		/// <summary>
		/// Save actual entered values to array for freezeing them.
		/// </summary>
		private void SaveValues()
		{
			savedValues[0] = RetrieveNumberFromTextBox(txtMoney);
			savedValues[1] = RetrieveNumberFromTextBox(txtBombarders);
			savedValues[2] = RetrieveNumberFromTextBox(txtTrojans);
			savedValues[3] = RetrieveNumberFromTextBox(txtTroopers);
			savedValues[4] = RetrieveNumberFromTextBox(txtFighters);
			savedValues[5] = RetrieveNumberFromTextBox(txtResearch);
		}

		/// <summary>
		/// Load values from array and then set all every one second.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Freezer_Tick(object sender, EventArgs e)
		{
			trainer.Money = savedValues[0];
			trainer.Bombarders = savedValues[1];
			trainer.Trojans = savedValues[2];
			trainer.Troopers = savedValues[3];
			trainer.Fighters = savedValues[4];
			trainer.Research = savedValues[5];
		}

	}
}
