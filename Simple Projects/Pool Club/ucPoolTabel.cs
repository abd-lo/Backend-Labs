
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pool_Club
{
	public partial class ucPoolTabel : UserControl
	{
		public ucPoolTabel()
		{
			InitializeComponent();

		}

		frmPlayerName frm;

		public int TotalSec;
		[
Category("Pool Config"),
Description("The Player Name.")
]
		public string PlayerName { get { return lblPlayerName.Text; } set { lblPlayerName.Text = value; } }
		[
Category("Pool Config"),
Description("Hourly Rate.")
]
		public float HourlyRate { get; set; }
		[
Category("Pool Config"),
Description("Table Name.")
]
		public string TableName
		{
			get => gbTable.Text;
			set => gbTable.Text = value;
		}

		bool IsItFirstRun = true;
		// Stopwatch variables

		private TimeSpan _elapsed = TimeSpan.Zero;


		public class GameInfoEventArgs : EventArgs
		{
			public string PlayerName;
			public float HourlyRate;
			public string TableName;
			public float TotalFees;
			public TimeSpan TimeElapsed;

			public GameInfoEventArgs(string playerName, float hourlyRate, string tableName, TimeSpan TimeElapsed)
			{
				PlayerName = playerName;
				HourlyRate = hourlyRate;
				TableName = tableName;
				this.TimeElapsed = TimeElapsed;

				TotalFees = (float)(hourlyRate * TimeElapsed.TotalSeconds / 3600);
			}
		}

		public event EventHandler<GameInfoEventArgs> GameInfoEvent;

		protected virtual void RaiseOnEnd(GameInfoEventArgs e)
		{
			GameInfoEvent?.Invoke(this, e);
		}
		public void RaiseOnEnd()
		{
			RaiseOnEnd(new GameInfoEventArgs(PlayerName, HourlyRate, TableName, _elapsed));
		}


		private void timer_Tick(object sender, EventArgs e)
		{
			TotalSec++;
			_elapsed = TimeSpan.FromSeconds(TotalSec);
			lblTime.Text = _elapsed.ToString(@"hh\:mm\:ss");

		}

		private void SetNameAndHourlyFees(object sender, frmPlayerName.StartingEventArgs e)
		{
			HourlyRate = e.HourlyRate;
			PlayerName = e.PlayerName;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (IsItFirstRun)
			{
				using (frm = new frmPlayerName())
				{

					frm.StartingGameInfoEvent += SetNameAndHourlyFees;
					frm.ShowDialog();
				}
				IsItFirstRun = false;
			}
			if (btnStart.Text == "Start")
			{
				btnStart.Text = "Pause";
				timer.Start();
			}
			else
			{
				btnStart.Text = "Start";
				timer.Stop();
			}

		}


		public void ResetTimer()
		{
			timer.Stop();
			_elapsed = TimeSpan.Zero;
			TotalSec = 0;
			lblTime.Text = "00:00:00";
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			if (btnStart.Text == "Pause")
				btnStart.Text = "Start";
			timer.Stop();
			RaiseOnEnd();

			ResetTimer();

		}

	}
}