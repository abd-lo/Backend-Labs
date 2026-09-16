namespace MathGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.tcGame = new System.Windows.Forms.TabControl();
            this.tpGameRules = new System.Windows.Forms.TabPage();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.nudNumberOfQuestion = new System.Windows.Forms.NumericUpDown();
            this.nudTimePerQuestion = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.tpGame = new System.Windows.Forms.TabPage();
            this.tbAnswer = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCurrentQuestionNumber = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSecondNumber = new System.Windows.Forms.Label();
            this.lbInGameOperator = new System.Windows.Forms.Label();
            this.lbFirstNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTimePerQuestion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbGameLevel = new System.Windows.Forms.Label();
            this.lbGameOperator = new System.Windows.Forms.Label();
            this.lbTotalQuestionsNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tpGameResults = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbGRNumberOfWrongAnswers = new System.Windows.Forms.Label();
            this.lbGRNumberOfRightAnswers = new System.Windows.Forms.Label();
            this.lbGRPercentageScore = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbGRTimePerQuestion = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbGRGameLevel = new System.Windows.Forms.Label();
            this.lbGROperator = new System.Windows.Forms.Label();
            this.lbGRQuestionsNumber = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tcGame.SuspendLayout();
            this.tpGameRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerQuestion)).BeginInit();
            this.tpGame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpGameResults.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEndGame.ForeColor = System.Drawing.Color.Black;
            this.btnEndGame.Location = new System.Drawing.Point(22, 963);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(343, 159);
            this.btnEndGame.TabIndex = 0;
            this.btnEndGame.Text = "EndGame";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.BackColor = System.Drawing.Color.DarkGray;
            this.btnStartNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStartNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnStartNewGame.Location = new System.Drawing.Point(22, 668);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(343, 159);
            this.btnStartNewGame.TabIndex = 3;
            this.btnStartNewGame.Text = "Start New Game";
            this.btnStartNewGame.UseVisualStyleBackColor = false;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // tcGame
            // 
            this.tcGame.Controls.Add(this.tpGameRules);
            this.tcGame.Controls.Add(this.tpGame);
            this.tcGame.Controls.Add(this.tpGameResults);
            this.tcGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcGame.Location = new System.Drawing.Point(481, 239);
            this.tcGame.Margin = new System.Windows.Forms.Padding(0);
            this.tcGame.Name = "tcGame";
            this.tcGame.SelectedIndex = 0;
            this.tcGame.Size = new System.Drawing.Size(1459, 1425);
            this.tcGame.TabIndex = 5;
            // 
            // tpGameRules
            // 
            this.tpGameRules.BackColor = System.Drawing.Color.Black;
            this.tpGameRules.Controls.Add(this.btnStartGame);
            this.tpGameRules.Controls.Add(this.nudNumberOfQuestion);
            this.tpGameRules.Controls.Add(this.nudTimePerQuestion);
            this.tpGameRules.Controls.Add(this.label4);
            this.tpGameRules.Controls.Add(this.label3);
            this.tpGameRules.Controls.Add(this.label2);
            this.tpGameRules.Controls.Add(this.cbOperator);
            this.tpGameRules.Controls.Add(this.label1);
            this.tpGameRules.Controls.Add(this.cbLevel);
            this.tpGameRules.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpGameRules.Location = new System.Drawing.Point(8, 39);
            this.tpGameRules.Name = "tpGameRules";
            this.tpGameRules.Padding = new System.Windows.Forms.Padding(3);
            this.tpGameRules.Size = new System.Drawing.Size(1443, 1378);
            this.tpGameRules.TabIndex = 0;
            this.tpGameRules.Text = "tabPage1";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStartGame.ForeColor = System.Drawing.Color.Black;
            this.btnStartGame.Location = new System.Drawing.Point(482, 1066);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(558, 117);
            this.btnStartGame.TabIndex = 35;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click_1);
            // 
            // nudNumberOfQuestion
            // 
            this.nudNumberOfQuestion.BackColor = System.Drawing.Color.DarkGray;
            this.nudNumberOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nudNumberOfQuestion.Location = new System.Drawing.Point(502, 892);
            this.nudNumberOfQuestion.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumberOfQuestion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfQuestion.Name = "nudNumberOfQuestion";
            this.nudNumberOfQuestion.Size = new System.Drawing.Size(512, 68);
            this.nudNumberOfQuestion.TabIndex = 34;
            this.nudNumberOfQuestion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfQuestion.Validated += new System.EventHandler(this.ValidatingControlsEvent);
            // 
            // nudTimePerQuestion
            // 
            this.nudTimePerQuestion.BackColor = System.Drawing.Color.DarkGray;
            this.nudTimePerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nudTimePerQuestion.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimePerQuestion.Location = new System.Drawing.Point(502, 661);
            this.nudTimePerQuestion.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTimePerQuestion.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimePerQuestion.Name = "nudTimePerQuestion";
            this.nudTimePerQuestion.Size = new System.Drawing.Size(512, 68);
            this.nudTimePerQuestion.TabIndex = 33;
            this.nudTimePerQuestion.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimePerQuestion.Validated += new System.EventHandler(this.ValidatingControlsEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(440, 756);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(817, 98);
            this.label4.TabIndex = 32;
            this.label4.Text = "Number Of Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(440, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(715, 98);
            this.label3.TabIndex = 31;
            this.label3.Text = "Time Per Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(449, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 98);
            this.label2.TabIndex = 30;
            this.label2.Text = "Operator";
            // 
            // cbOperator
            // 
            this.cbOperator.BackColor = System.Drawing.Color.DarkGray;
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "Sum",
            "Subtruct",
            "DIvide",
            "Multiplication",
            "Mix"});
            this.cbOperator.Location = new System.Drawing.Point(502, 431);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(512, 69);
            this.cbOperator.TabIndex = 29;
            this.cbOperator.Validated += new System.EventHandler(this.ValidatingControlsEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(449, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 98);
            this.label1.TabIndex = 28;
            this.label1.Text = "LEVEL";
            // 
            // cbLevel
            // 
            this.cbLevel.BackColor = System.Drawing.Color.DimGray;
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbLevel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(502, 225);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(512, 69);
            this.cbLevel.TabIndex = 27;
            this.cbLevel.Validated += new System.EventHandler(this.ValidatingControlsEvent);
            // 
            // tpGame
            // 
            this.tpGame.BackColor = System.Drawing.Color.Black;
            this.tpGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpGame.BackgroundImage")));
            this.tpGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpGame.Controls.Add(this.tbAnswer);
            this.tpGame.Controls.Add(this.panel2);
            this.tpGame.Controls.Add(this.btnEnter);
            this.tpGame.Controls.Add(this.label8);
            this.tpGame.Controls.Add(this.lbSecondNumber);
            this.tpGame.Controls.Add(this.lbInGameOperator);
            this.tpGame.Controls.Add(this.lbFirstNumber);
            this.tpGame.Controls.Add(this.panel1);
            this.tpGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.tpGame.Location = new System.Drawing.Point(8, 39);
            this.tpGame.Name = "tpGame";
            this.tpGame.Padding = new System.Windows.Forms.Padding(3);
            this.tpGame.Size = new System.Drawing.Size(1443, 1378);
            this.tpGame.TabIndex = 1;
            this.tpGame.Text = "tabPage2";
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbAnswer.BeepOnError = true;
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tbAnswer.Location = new System.Drawing.Point(526, 902);
            this.tbAnswer.Mask = "000";
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(369, 98);
            this.tbAnswer.TabIndex = 20;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lbCurrentQuestionNumber);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(796, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 286);
            this.panel2.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(539, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 63);
            this.label13.TabIndex = 16;
            this.label13.Text = "5";
            // 
            // lbCurrentQuestionNumber
            // 
            this.lbCurrentQuestionNumber.AutoSize = true;
            this.lbCurrentQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbCurrentQuestionNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCurrentQuestionNumber.Location = new System.Drawing.Point(539, 106);
            this.lbCurrentQuestionNumber.Name = "lbCurrentQuestionNumber";
            this.lbCurrentQuestionNumber.Size = new System.Drawing.Size(57, 63);
            this.lbCurrentQuestionNumber.TabIndex = 14;
            this.lbCurrentQuestionNumber.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(31, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(267, 63);
            this.label15.TabIndex = 15;
            this.label15.Text = "Time Left:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(31, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(465, 63);
            this.label12.TabIndex = 13;
            this.label12.Text = "Question Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(539, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 63);
            this.label14.TabIndex = 12;
            this.label14.Text = "5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(31, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(492, 63);
            this.label16.TabIndex = 11;
            this.label16.Text = "Time Per Question:";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Location = new System.Drawing.Point(409, 1099);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(627, 159);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(81, 930);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 63);
            this.label8.TabIndex = 18;
            this.label8.Text = "YourAnswer:";
            // 
            // lbSecondNumber
            // 
            this.lbSecondNumber.AutoSize = true;
            this.lbSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbSecondNumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbSecondNumber.Location = new System.Drawing.Point(904, 671);
            this.lbSecondNumber.Name = "lbSecondNumber";
            this.lbSecondNumber.Size = new System.Drawing.Size(110, 120);
            this.lbSecondNumber.TabIndex = 17;
            this.lbSecondNumber.Text = "2";
            // 
            // lbInGameOperator
            // 
            this.lbInGameOperator.AutoSize = true;
            this.lbInGameOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbInGameOperator.ForeColor = System.Drawing.Color.Turquoise;
            this.lbInGameOperator.Location = new System.Drawing.Point(651, 671);
            this.lbInGameOperator.Name = "lbInGameOperator";
            this.lbInGameOperator.Size = new System.Drawing.Size(112, 120);
            this.lbInGameOperator.TabIndex = 16;
            this.lbInGameOperator.Text = "+";
            // 
            // lbFirstNumber
            // 
            this.lbFirstNumber.AutoSize = true;
            this.lbFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbFirstNumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbFirstNumber.Location = new System.Drawing.Point(403, 671);
            this.lbFirstNumber.Name = "lbFirstNumber";
            this.lbFirstNumber.Size = new System.Drawing.Size(110, 120);
            this.lbFirstNumber.TabIndex = 15;
            this.lbFirstNumber.Text = "3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTimePerQuestion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.lbGameLevel);
            this.panel1.Controls.Add(this.lbGameOperator);
            this.panel1.Controls.Add(this.lbTotalQuestionsNumber);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(19, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 430);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(33, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 63);
            this.label5.TabIndex = 0;
            this.label5.Text = "Game Level:";
            // 
            // lbTimePerQuestion
            // 
            this.lbTimePerQuestion.AutoSize = true;
            this.lbTimePerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTimePerQuestion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTimePerQuestion.Location = new System.Drawing.Point(529, 324);
            this.lbTimePerQuestion.Name = "lbTimePerQuestion";
            this.lbTimePerQuestion.Size = new System.Drawing.Size(57, 63);
            this.lbTimePerQuestion.TabIndex = 12;
            this.lbTimePerQuestion.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(33, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(492, 63);
            this.label6.TabIndex = 1;
            this.label6.Text = "Questions Number:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(33, 324);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(477, 63);
            this.label.TabIndex = 11;
            this.label.Text = "Time Per Question";
            // 
            // lbGameLevel
            // 
            this.lbGameLevel.AutoSize = true;
            this.lbGameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGameLevel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbGameLevel.Location = new System.Drawing.Point(484, 33);
            this.lbGameLevel.Name = "lbGameLevel";
            this.lbGameLevel.Size = new System.Drawing.Size(147, 63);
            this.lbGameLevel.TabIndex = 7;
            this.lbGameLevel.Text = "Easy";
            // 
            // lbGameOperator
            // 
            this.lbGameOperator.AutoSize = true;
            this.lbGameOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGameOperator.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbGameOperator.Location = new System.Drawing.Point(484, 130);
            this.lbGameOperator.Name = "lbGameOperator";
            this.lbGameOperator.Size = new System.Drawing.Size(147, 63);
            this.lbGameOperator.TabIndex = 10;
            this.lbGameOperator.Text = "SUM";
            // 
            // lbTotalQuestionsNumber
            // 
            this.lbTotalQuestionsNumber.AutoSize = true;
            this.lbTotalQuestionsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTotalQuestionsNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTotalQuestionsNumber.Location = new System.Drawing.Point(529, 227);
            this.lbTotalQuestionsNumber.Name = "lbTotalQuestionsNumber";
            this.lbTotalQuestionsNumber.Size = new System.Drawing.Size(57, 63);
            this.lbTotalQuestionsNumber.TabIndex = 8;
            this.lbTotalQuestionsNumber.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(33, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 63);
            this.label9.TabIndex = 9;
            this.label9.Text = "Operator:";
            // 
            // tpGameResults
            // 
            this.tpGameResults.BackColor = System.Drawing.Color.Black;
            this.tpGameResults.Controls.Add(this.panel3);
            this.tpGameResults.Controls.Add(this.label7);
            this.tpGameResults.Location = new System.Drawing.Point(8, 39);
            this.tpGameResults.Name = "tpGameResults";
            this.tpGameResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpGameResults.Size = new System.Drawing.Size(1443, 1378);
            this.tpGameResults.TabIndex = 2;
            this.tpGameResults.Text = "tabPage1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbGRNumberOfWrongAnswers);
            this.panel3.Controls.Add(this.lbGRNumberOfRightAnswers);
            this.panel3.Controls.Add(this.lbGRPercentageScore);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lbGRTimePerQuestion);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.lbGRGameLevel);
            this.panel3.Controls.Add(this.lbGROperator);
            this.panel3.Controls.Add(this.lbGRQuestionsNumber);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(260, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 1048);
            this.panel3.TabIndex = 14;
            // 
            // lbGRNumberOfWrongAnswers
            // 
            this.lbGRNumberOfWrongAnswers.AutoSize = true;
            this.lbGRNumberOfWrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGRNumberOfWrongAnswers.ForeColor = System.Drawing.Color.IndianRed;
            this.lbGRNumberOfWrongAnswers.Location = new System.Drawing.Point(748, 527);
            this.lbGRNumberOfWrongAnswers.Name = "lbGRNumberOfWrongAnswers";
            this.lbGRNumberOfWrongAnswers.Size = new System.Drawing.Size(57, 63);
            this.lbGRNumberOfWrongAnswers.TabIndex = 18;
            this.lbGRNumberOfWrongAnswers.Text = "5";
            // 
            // lbGRNumberOfRightAnswers
            // 
            this.lbGRNumberOfRightAnswers.AutoSize = true;
            this.lbGRNumberOfRightAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGRNumberOfRightAnswers.ForeColor = System.Drawing.Color.Green;
            this.lbGRNumberOfRightAnswers.Location = new System.Drawing.Point(748, 421);
            this.lbGRNumberOfRightAnswers.Name = "lbGRNumberOfRightAnswers";
            this.lbGRNumberOfRightAnswers.Size = new System.Drawing.Size(57, 63);
            this.lbGRNumberOfRightAnswers.TabIndex = 17;
            this.lbGRNumberOfRightAnswers.Text = "5";
            // 
            // lbGRPercentageScore
            // 
            this.lbGRPercentageScore.AutoSize = true;
            this.lbGRPercentageScore.Font = new System.Drawing.Font("Mistral", 60F);
            this.lbGRPercentageScore.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lbGRPercentageScore.Location = new System.Drawing.Point(318, 771);
            this.lbGRPercentageScore.Name = "lbGRPercentageScore";
            this.lbGRPercentageScore.Size = new System.Drawing.Size(311, 191);
            this.lbGRPercentageScore.TabIndex = 16;
            this.lbGRPercentageScore.Text = "50%";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label27.Location = new System.Drawing.Point(225, 681);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(473, 63);
            this.label27.TabIndex = 15;
            this.label27.Text = "Percentage Score:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label26.Location = new System.Drawing.Point(33, 527);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(699, 63);
            this.label26.TabIndex = 14;
            this.label26.Text = "Number Of Wrong Answers:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label25.Location = new System.Drawing.Point(33, 421);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(667, 63);
            this.label25.TabIndex = 13;
            this.label25.Text = "Number Of Right Answers:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(33, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(333, 63);
            this.label17.TabIndex = 0;
            this.label17.Text = "Game Level:";
            // 
            // lbGRTimePerQuestion
            // 
            this.lbGRTimePerQuestion.AutoSize = true;
            this.lbGRTimePerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGRTimePerQuestion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbGRTimePerQuestion.Location = new System.Drawing.Point(748, 324);
            this.lbGRTimePerQuestion.Name = "lbGRTimePerQuestion";
            this.lbGRTimePerQuestion.Size = new System.Drawing.Size(57, 63);
            this.lbGRTimePerQuestion.TabIndex = 12;
            this.lbGRTimePerQuestion.Text = "5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(33, 227);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(492, 63);
            this.label19.TabIndex = 1;
            this.label19.Text = "Questions Number:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(33, 324);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(492, 63);
            this.label20.TabIndex = 11;
            this.label20.Text = "Time Per Question:";
            // 
            // lbGRGameLevel
            // 
            this.lbGRGameLevel.AutoSize = true;
            this.lbGRGameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGRGameLevel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbGRGameLevel.Location = new System.Drawing.Point(703, 33);
            this.lbGRGameLevel.Name = "lbGRGameLevel";
            this.lbGRGameLevel.Size = new System.Drawing.Size(147, 63);
            this.lbGRGameLevel.TabIndex = 7;
            this.lbGRGameLevel.Text = "Easy";
            // 
            // lbGROperator
            // 
            this.lbGROperator.AutoSize = true;
            this.lbGROperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGROperator.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbGROperator.Location = new System.Drawing.Point(703, 130);
            this.lbGROperator.Name = "lbGROperator";
            this.lbGROperator.Size = new System.Drawing.Size(147, 63);
            this.lbGROperator.TabIndex = 10;
            this.lbGROperator.Text = "SUM";
            // 
            // lbGRQuestionsNumber
            // 
            this.lbGRQuestionsNumber.AutoSize = true;
            this.lbGRQuestionsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbGRQuestionsNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbGRQuestionsNumber.Location = new System.Drawing.Point(748, 227);
            this.lbGRQuestionsNumber.Name = "lbGRQuestionsNumber";
            this.lbGRQuestionsNumber.Size = new System.Drawing.Size(57, 63);
            this.lbGRQuestionsNumber.TabIndex = 8;
            this.lbGRQuestionsNumber.Text = "5";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(33, 130);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(255, 63);
            this.label24.TabIndex = 9;
            this.label24.Text = "Operator:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 49.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(249, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1053, 172);
            this.label7.TabIndex = 0;
            this.label7.Text = "Game Results";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(22, 1258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(343, 159);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MV Boli", 60F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(723, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(960, 210);
            this.label11.TabIndex = 36;
            this.label11.Text = "Math Game";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2389, 1765);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcGame);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.btnEndGame);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "MathGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcGame.ResumeLayout(false);
            this.tpGameRules.ResumeLayout(false);
            this.tpGameRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimePerQuestion)).EndInit();
            this.tpGame.ResumeLayout(false);
            this.tpGame.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpGameResults.ResumeLayout(false);
            this.tpGameResults.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.TabControl tcGame;
        private System.Windows.Forms.TabPage tpGameRules;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.NumericUpDown nudNumberOfQuestion;
        private System.Windows.Forms.NumericUpDown nudTimePerQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.TabPage tpGame;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpGameResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalQuestionsNumber;
        private System.Windows.Forms.Label lbGameLevel;
        private System.Windows.Forms.Label lbGameOperator;
        private System.Windows.Forms.Label lbTimePerQuestion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSecondNumber;
        private System.Windows.Forms.Label lbInGameOperator;
        private System.Windows.Forms.Label lbFirstNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCurrentQuestionNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbGRNumberOfWrongAnswers;
        private System.Windows.Forms.Label lbGRNumberOfRightAnswers;
        private System.Windows.Forms.Label lbGRPercentageScore;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbGRTimePerQuestion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbGRGameLevel;
        private System.Windows.Forms.Label lbGROperator;
        private System.Windows.Forms.Label lbGRQuestionsNumber;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MaskedTextBox tbAnswer;
        private System.Windows.Forms.Label label11;
    }
}

