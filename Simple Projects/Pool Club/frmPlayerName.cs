using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pool_Club.frmPlayerName;

namespace Pool_Club
{
	public partial class frmPlayerName : Form
	{
		public frmPlayerName()
		{
			InitializeComponent();
		}

		public class StartingEventArgs : EventArgs
		{
			public string PlayerName;
			public float HourlyRate;
			public StartingEventArgs(string PlayerName, float HourlyRate)
			{
				this.PlayerName = PlayerName;
				this.HourlyRate = HourlyRate;
			}
		}
		public EventHandler<StartingEventArgs> StartingGameInfoEvent;


		protected virtual void RaiseStartingGameInfoEventOn(StartingEventArgs e)
		{
			StartingGameInfoEvent?.Invoke(this, e);
		}

		public void RaiseStartingGameInfoEventOn()
		{
			float fees;

			if (rd15.Checked)
				fees = 15;
			else if (rd20.Checked)
				fees = 20;
			else
				fees = 25;
			RaiseStartingGameInfoEventOn(new StartingEventArgs(textBox1.Text, fees));
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text))
			{

				MessageBox.Show($"Enter Player Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				RaiseStartingGameInfoEventOn();
				this.Close();
			}
		}
	}
}
