namespace Pool_Club
{
	partial class frmPlayerName
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.rd15 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rd25 = new System.Windows.Forms.RadioButton();
			this.rd20 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
			this.label1.Location = new System.Drawing.Point(103, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "PlayerName";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 15F);
			this.btnSave.Location = new System.Drawing.Point(119, 201);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 49);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// rd15
			// 
			this.rd15.AutoSize = true;
			this.rd15.Checked = true;
			this.rd15.Location = new System.Drawing.Point(6, 36);
			this.rd15.Name = "rd15";
			this.rd15.Size = new System.Drawing.Size(48, 26);
			this.rd15.TabIndex = 2;
			this.rd15.TabStop = true;
			this.rd15.Text = "15";
			this.rd15.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rd25);
			this.groupBox1.Controls.Add(this.rd20);
			this.groupBox1.Controls.Add(this.rd15);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
			this.groupBox1.Location = new System.Drawing.Point(12, 118);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(307, 68);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hourly Rate";
			// 
			// rd25
			// 
			this.rd25.AutoSize = true;
			this.rd25.Location = new System.Drawing.Point(106, 36);
			this.rd25.Name = "rd25";
			this.rd25.Size = new System.Drawing.Size(48, 26);
			this.rd25.TabIndex = 4;
			this.rd25.Text = "25";
			this.rd25.UseVisualStyleBackColor = true;
			// 
			// rd20
			// 
			this.rd20.AutoSize = true;
			this.rd20.Location = new System.Drawing.Point(60, 36);
			this.rd20.Name = "rd20";
			this.rd20.Size = new System.Drawing.Size(48, 26);
			this.rd20.TabIndex = 3;
			this.rd20.Text = "20";
			this.rd20.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 14F);
			this.textBox1.Location = new System.Drawing.Point(85, 82);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 30);
			this.textBox1.TabIndex = 4;
			// 
			// frmPlayerName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 262);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmPlayerName";
			this.Text = "frmPlayerName";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.RadioButton rd15;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rd20;
		private System.Windows.Forms.RadioButton rd25;
		private System.Windows.Forms.TextBox textBox1;
	}
}