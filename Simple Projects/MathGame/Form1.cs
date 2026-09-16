using MathGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        enum enQuestionLevel
        {
            Easy, Medium, Hard, Mix
        }
        enum enOperatorType
        {
            Sum, Subtruct, Multiply, Divide, Mix
        }
        struct stGame
        {
            public enOperatorType OperatorType;
            public enOperatorType CurrentOperatorType;
            public enQuestionLevel QuestionLevel;


            public short UserAnswer;

            public short FirstNumber;
            public short SecondNumber;
            public short RightAnswerCount;
            public byte NumberOfQuestions;

            public byte CurrentQuestionNumber;
            public byte TimePerQuestion;

        }

        public static Random rnd = new Random();
        stGame Game = new stGame();
        public Form1()
        {
            InitializeComponent();
        }


        void HideControlTabTabs()
        {
            tcGame.Appearance = TabAppearance.FlatButtons;
            tcGame.ItemSize = new Size(0, 1);
            tcGame.SizeMode = TabSizeMode.Fixed;
        }
        //Validating Errors
        bool ValidateComboBox(ComboBox cb)
        {
            if (cb.SelectedIndex == -1)
            {
                errorProvider1.SetError(cb, "Please Select An Option");
                cb.Focus();
                return false;
            }

            else
            {
                errorProvider1.SetError(cb, "");
                return true;
            }

        }

        bool ValidateNumericUpDown(NumericUpDown nud)
        {
            if (nud.Value == 0)
            {
                errorProvider1.SetError(nud, "Please Select An Option");
                nud.Focus();
                //IsErrorExist = true;
                return false;

            }

            else
            {
                errorProvider1.SetError(nud, "");
                //IsErrorExist = false;
                return true;
            }
        }


        bool ValidateControl(Control item)
        {
            switch (item)
            {
                case ComboBox cb:
                    return ValidateComboBox(cb);

                case NumericUpDown nud:
                    return ValidateNumericUpDown(nud);


                default:
                    return false;

            }
        }

        bool ValidateAllControls()
        {

            Control[] UserChoicesControls = { cbLevel, cbOperator, nudTimePerQuestion, nudNumberOfQuestion };

            foreach (Control item in UserChoicesControls)
            {
                if (!ValidateControl(item))
                    return false;
            }
            return true;

        }


        short RandomNumberGenerator(short FNum, short SNum)
        {


            return (short)rnd.Next(FNum, SNum);
        }

        void SetNumbersAccordingtoQuestionsLevel()
        {

            switch (Game.QuestionLevel)
            {
                case enQuestionLevel.Easy:
                    Game.FirstNumber = RandomNumberGenerator(1, 10);
                    Game.SecondNumber = RandomNumberGenerator(1, 10);
                    break;

                case enQuestionLevel.Medium:
                    Game.FirstNumber = RandomNumberGenerator(10, 50);
                    Game.SecondNumber = RandomNumberGenerator(10, 50);
                    break;

                case enQuestionLevel.Hard:
                    Game.FirstNumber = RandomNumberGenerator(50, 100);
                    Game.SecondNumber = RandomNumberGenerator(50, 100);
                    break;

                case enQuestionLevel.Mix:
                    Game.FirstNumber = RandomNumberGenerator(1, 250);
                    Game.SecondNumber = RandomNumberGenerator(1, 250);
                    break;

            }

            lbFirstNumber.Text = Game.FirstNumber.ToString();
            lbSecondNumber.Text = Game.SecondNumber.ToString();

        }


        void SwapFirstAndSecondNumber()
        {
            short temp;
            temp = Game.FirstNumber;
            Game.FirstNumber = Game.SecondNumber;
            Game.SecondNumber = temp;
        }

        void GetValidNumbers()
        {
            do
            {
               SetNumbersAccordingtoQuestionsLevel();
            } while ( Game.CurrentOperatorType == enOperatorType.Divide && Game.FirstNumber % Game.SecondNumber != 0);


            if (Game.CurrentOperatorType == enOperatorType.Subtruct && Game.FirstNumber < Game.SecondNumber)
            {
                SwapFirstAndSecondNumber();
            }
        }

        bool CheckAnswer()
        {

            switch (Game.CurrentOperatorType)
            {
                case enOperatorType.Sum:
                    return (Game.FirstNumber + Game.SecondNumber == Game.UserAnswer);


                case enOperatorType.Subtruct:
                    return (Game.FirstNumber - Game.SecondNumber == Game.UserAnswer);


                case enOperatorType.Multiply:
                    return (Game.FirstNumber * Game.SecondNumber == Game.UserAnswer);


                case enOperatorType.Divide:
                    return (Game.FirstNumber / Game.SecondNumber == Game.UserAnswer);

                default:
                    return false;

            }
        }



        void GenerateQuestion()
        {

            GetValidNumbers();

            switch (Game.OperatorType)
            {
                case enOperatorType.Sum:
                    Game.CurrentOperatorType = enOperatorType.Sum;
                    lbInGameOperator.Text = "+";
                    break;

                case enOperatorType.Subtruct:
                    Game.CurrentOperatorType = enOperatorType.Subtruct;
                    lbInGameOperator.Text = "-";
                    break;

                case enOperatorType.Multiply:
                    Game.CurrentOperatorType = enOperatorType.Multiply;
                    lbInGameOperator.Text = "x";
                    break;

                case enOperatorType.Divide:
                    Game.CurrentOperatorType = enOperatorType.Divide;
                    lbInGameOperator.Text = "/";
                    break;

                case enOperatorType.Mix:
                    lbInGameOperator.Text = SetAndGetRandomOperator();
                    break;

                default:
                    break;
            }
        }
        string SetAndGetRandomOperator()
        {
            enOperatorType Op = (enOperatorType)RandomNumberGenerator(0, 3);
            Game.CurrentOperatorType = Op;


            switch (Op)
            {
                case enOperatorType.Sum:
                    return "+";

                case enOperatorType.Subtruct:
                    return "-";

                case enOperatorType.Multiply:
                    return "x";

                case enOperatorType.Divide:
                    return "/";

                default:
                    return "+";
            }

        }


        void StartGame()
        {
            if (ValidateAllControls())
            {
                MessageBox.Show("Starting the game...", "Game Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToGameTab();

                Game.QuestionLevel = (enQuestionLevel)cbLevel.SelectedIndex;
                Game.OperatorType = (enOperatorType)cbOperator.SelectedIndex;
                Game.TimePerQuestion = (byte)nudTimePerQuestion.Value;
                Game.NumberOfQuestions = (byte)nudNumberOfQuestion.Value;



                lbTotalQuestionsNumber.Text = Convert.ToString(Game.NumberOfQuestions);
                lbGameLevel.Text = Convert.ToString(Game.QuestionLevel);
                lbGameOperator.Text = Convert.ToString(Game.OperatorType);
                lbTimePerQuestion.Text = Convert.ToString(Game.TimePerQuestion);

                lbCurrentQuestionNumber.Text = (++Game.CurrentQuestionNumber).ToString();
                GenerateQuestion();


            }
            else
            {
                MessageBox.Show("Please fix the errors before starting the game.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Change Tabs

        void GoToGameRulesTab()
        {
            tcGame.SelectedTab = tpGameRules;
            btnEndGame.Enabled = false;
            btnEndGame.BackColor = Color.DarkGray;

            btnStartNewGame.Enabled = false;
            btnStartNewGame.BackColor = Color.DarkGray;
        }
        void GoToGameTab()
        {
            tcGame.SelectedTab = tpGame;
            tbAnswer.Focus();
            btnEndGame.Enabled = true;
            btnEndGame.BackColor = Color.DarkSlateBlue;

            btnStartNewGame.Enabled = true;
            btnStartNewGame.BackColor = Color.DarkSlateBlue;

        }


        void GoToGameResultsTab()
        {
            tcGame.SelectedTab = tpGameResults;
            btnStartNewGame.Enabled = true;
            btnStartNewGame.BackColor = Color.DarkSlateBlue;

            btnEndGame.Enabled = false;
            btnEndGame.BackColor = Color.DarkGray;
        }


        void ResetAllValues()
        {
            Game = default(stGame);
            tbAnswer.Clear();
            nudTimePerQuestion.Value = nudTimePerQuestion.Minimum;
            // nudNumberOfQuestion.Value = nudTimePerQuestion.Minimum;
            nudNumberOfQuestion.Value = 5;
            cbLevel.SelectedIndex = 0;
            cbOperator.SelectedIndex = 0;
        }

        void GoToResultPage()
        {
            MessageBox.Show("Game Over", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToGameResultsTab();

            lbGRGameLevel.Text = Game.QuestionLevel.ToString();
            lbGROperator.Text = Game.OperatorType.ToString();

            lbGRQuestionsNumber.Text = Game.NumberOfQuestions.ToString();
            lbGRTimePerQuestion.Text = Game.TimePerQuestion.ToString();

            lbGRNumberOfRightAnswers.Text = Game.RightAnswerCount.ToString();
            lbGRNumberOfWrongAnswers.Text = (-Game.RightAnswerCount + Game.NumberOfQuestions).ToString();
            lbGRPercentageScore.Text = ((float)100 * Game.RightAnswerCount / Game.NumberOfQuestions).ToString("0.00") + " % ";
        }

        //Events



        private void Form1_Load(object sender, EventArgs e)
        {
            HideControlTabTabs();
            this.Size=new Size(2415, 1836);
            cbLevel.DataSource = Enum.GetValues(typeof(enQuestionLevel));
            cbOperator.DataSource = Enum.GetValues(typeof(enOperatorType));
            GoToGameRulesTab();
        }


        private void btnStartGame_Click_1(object sender, EventArgs e)
        {
            StartGame();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAnswer.Text) || !int.TryParse(tbAnswer.Text, out int number))
            {
                MessageBox.Show("Not Valid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Game.CurrentQuestionNumber < Game.NumberOfQuestions)
            {
                GoToGameTab();
                lbCurrentQuestionNumber.Text = (++Game.CurrentQuestionNumber).ToString();
                Game.UserAnswer = Convert.ToInt16(tbAnswer.Text.Trim());

                if (CheckAnswer())
                    Game.RightAnswerCount++;

                tbAnswer.Clear();
                GenerateQuestion();
            }
            else
            {
                GoToResultPage();
            }


        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            ResetAllValues();
            GoToGameRulesTab();
        }
        private void ValidatingControlsEvent(object sender, EventArgs e)
        {
            switch (sender)
            {
                case ComboBox cb:
                    ValidateComboBox(cb);
                    break;

                case NumericUpDown nud:
                    ValidateNumericUpDown(nud);
                    break;
            }
        }
        private void btnEndGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                GoToResultPage();
            else
                return;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();

            }
            else
                return;
        }
    }
}
