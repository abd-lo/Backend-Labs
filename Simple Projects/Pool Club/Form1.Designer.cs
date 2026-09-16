namespace Pool_Club
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ucPoolTabel1 = new Pool_Club.ucPoolTabel();
			this.ucPoolTabel2 = new Pool_Club.ucPoolTabel();
			this.ucPoolTabel3 = new Pool_Club.ucPoolTabel();
			this.ucPoolTabel4 = new Pool_Club.ucPoolTabel();
			this.ucPoolTabel5 = new Pool_Club.ucPoolTabel();
			this.ucPoolTabel6 = new Pool_Club.ucPoolTabel();
			this.SuspendLayout();
			// 
			// ucPoolTabel1
			// 
			this.ucPoolTabel1.HourlyRate = 15F;
			this.ucPoolTabel1.Location = new System.Drawing.Point(12, 23);
			this.ucPoolTabel1.Name = "ucPoolTabel1";
			this.ucPoolTabel1.PlayerName = "Ali";
			this.ucPoolTabel1.Size = new System.Drawing.Size(208, 211);
			this.ucPoolTabel1.TabIndex = 0;
			this.ucPoolTabel1.TableName = "Table1";
			this.ucPoolTabel1.GameInfoEvent += new System.EventHandler<Pool_Club.ucPoolTabel.GameInfoEventArgs>(this.EndGameEventHandler);
			// 
			// ucPoolTabel2
			// 
			this.ucPoolTabel2.HourlyRate = 30F;
			this.ucPoolTabel2.Location = new System.Drawing.Point(273, 23);
			this.ucPoolTabel2.Name = "ucPoolTabel2";
			this.ucPoolTabel2.PlayerName = "Mohseen";
			this.ucPoolTabel2.Size = new System.Drawing.Size(208, 211);
			this.ucPoolTabel2.TabIndex = 1;
			this.ucPoolTabel2.TableName = "Table2";
			this.ucPoolTabel2.GameInfoEvent += new System.EventHandler<Pool_Club.ucPoolTabel.GameInfoEventArgs>(this.EndGameEventHandler);
			// 
			// ucPoolTabel3
			// 
			this.ucPoolTabel3.HourlyRate = 0F;
			this.ucPoolTabel3.Location = new System.Drawing.Point(12, 270);
			this.ucPoolTabel3.Name = "ucPoolTabel3";
			this.ucPoolTabel3.PlayerName = "PlayerName";
			this.ucPoolTabel3.Size = new System.Drawing.Size(208, 211);
			this.ucPoolTabel3.TabIndex = 2;
			this.ucPoolTabel3.TableName = "Table";
			this.ucPoolTabel3.GameInfoEvent += new System.EventHandler<Pool_Club.ucPoolTabel.GameInfoEventArgs>(this.EndGameEventHandler);
			// 
			// ucPoolTabel4
			// 
			this.ucPoolTabel4.HourlyRate = 0F;
			this.ucPoolTabel4.Location = new System.Drawing.Point(273, 270);
			this.ucPoolTabel4.Name = "ucPoolTabel4";
			this.ucPoolTabel4.PlayerName = "PlayerName";
			this.ucPoolTabel4.Size = new System.Drawing.Size(208, 211);
			this.ucPoolTabel4.TabIndex = 3;
			this.ucPoolTabel4.TableName = "Table";
			this.ucPoolTabel4.GameInfoEvent += new System.EventHandler<Pool_Club.ucPoolTabel.GameInfoEventArgs>(this.EndGameEventHandler);
			// 
			// ucPoolTabel5
			// 
			this.ucPoolTabel5.HourlyRate = 0F;
			this.ucPoolTabel5.Location = new System.Drawing.Point(541, 23);
			this.ucPoolTabel5.Name = "ucPoolTabel5";
			this.ucPoolTabel5.PlayerName = "PlayerName";
			this.ucPoolTabel5.Size = new System.Drawing.Size(208, 211);
			this.ucPoolTabel5.TabIndex = 4;
			this.ucPoolTabel5.TableName = "Table";
			this.ucPoolTabel5.GameInfoEvent += new System.EventHandler<Pool_Club.ucPoolTabel.GameInfoEventArgs>(this.EndGameEventHandler);
			// 
			// ucPoolTabel6
			// 
			this.ucPoolTabel6.HourlyRate = 0F;
			this.ucPoolTabel6.Location = new System.Drawing.Point(541, 270);
			this.ucPoolTabel6.Name = "ucPoolTabel6";
			this.ucPoolTabel6.PlayerName = "PlayerName";
			this.ucPoolTabel6.Size = new System.Drawing.Size(208, 211);
			this.ucPoolTabel6.TabIndex = 5;
			this.ucPoolTabel6.TableName = "Table";
			this.ucPoolTabel6.GameInfoEvent += new System.EventHandler<Pool_Club.ucPoolTabel.GameInfoEventArgs>(this.EndGameEventHandler);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 621);
			this.Controls.Add(this.ucPoolTabel6);
			this.Controls.Add(this.ucPoolTabel5);
			this.Controls.Add(this.ucPoolTabel4);
			this.Controls.Add(this.ucPoolTabel3);
			this.Controls.Add(this.ucPoolTabel2);
			this.Controls.Add(this.ucPoolTabel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private ucPoolTabel ucPoolTabel1;
		private ucPoolTabel ucPoolTabel2;
		private ucPoolTabel ucPoolTabel3;
		private ucPoolTabel ucPoolTabel4;
		private ucPoolTabel ucPoolTabel5;
		private ucPoolTabel ucPoolTabel6;
	}
}

