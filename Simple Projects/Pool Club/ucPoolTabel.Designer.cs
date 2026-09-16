namespace Pool_Club
{
	partial class ucPoolTabel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gbTable = new System.Windows.Forms.GroupBox();
			this.lblPlayerName = new System.Windows.Forms.Label();
			this.btnEnd = new System.Windows.Forms.Button();
			this.lblTime = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.gbTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbTable
			// 
			this.gbTable.Controls.Add(this.lblPlayerName);
			this.gbTable.Controls.Add(this.btnEnd);
			this.gbTable.Controls.Add(this.lblTime);
			this.gbTable.Controls.Add(this.btnStart);
			this.gbTable.Font = new System.Drawing.Font("Tahoma", 12F);
			this.gbTable.Location = new System.Drawing.Point(3, 3);
			this.gbTable.Name = "gbTable";
			this.gbTable.Size = new System.Drawing.Size(199, 202);
			this.gbTable.TabIndex = 0;
			this.gbTable.TabStop = false;
			this.gbTable.Text = "Table";
			// 
			// lblPlayerName
			// 
			this.lblPlayerName.AutoSize = true;
			this.lblPlayerName.Font = new System.Drawing.Font("Tahoma", 20F);
			this.lblPlayerName.Location = new System.Drawing.Point(15, 23);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new System.Drawing.Size(156, 33);
			this.lblPlayerName.TabIndex = 5;
			this.lblPlayerName.Text = "PlayerName";
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(103, 154);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(80, 42);
			this.btnEnd.TabIndex = 4;
			this.btnEnd.Text = "End";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Tahoma", 20F);
			this.lblTime.Location = new System.Drawing.Point(34, 96);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(125, 33);
			this.lblTime.TabIndex = 3;
			this.lblTime.Text = "00:00:00";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(6, 154);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(80, 42);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// ucPoolTabel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbTable);
			this.Name = "ucPoolTabel";
			this.Size = new System.Drawing.Size(208, 211);
			this.gbTable.ResumeLayout(false);
			this.gbTable.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbTable;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label lblPlayerName;
	}
}
