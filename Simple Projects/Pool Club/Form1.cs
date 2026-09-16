using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//ucPoolTabel1.GameInfoEvent += EndGameEventHandler;
		}

		public void EndGameEventHandler(object sender, ucPoolTabel.GameInfoEventArgs e)
		{

			MessageBox.Show($"Game Has End\n TimeSpan {e.TimeElapsed} \nHourlyRate {e.HourlyRate}\n PlayerName {e.PlayerName}\n Fees {e.TotalFees}\nTotalSec {e.TimeElapsed.TotalSeconds}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}



	}
}
