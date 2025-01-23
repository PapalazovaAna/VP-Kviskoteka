using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka
{
    public partial class Kvizomanija : Form
    {
        private KvizomanijaData data;
        private int questionNum;
        private int numCorrectAnswers;
        private int numWrongAnswers;
        private string correctAnswer;
        private HashSet<int> previousQuestions;
        private Timer timer1;
        private Random random = new Random();

        public Kvizomanija()
        {
            InitializeComponent();
            data = new KvizomanijaData();

            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;

            lblQuestionNum.Text = "Прашање бр. 0 / 5";
            tbTimeLeft.Text = "50";
        }

      

        private void btnStart_Click(object sender, EventArgs e)
        {
            newGame();
            btnStart.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(tbTimeLeft.Text);
            if (timeLeft == 0)
            {
                timer2.Stop();
                endGame();
            }
            else
            {
                timeLeft--;
                tbTimeLeft.Text = timeLeft.ToString();
            }
        }

        private void newGame()
        {
            btnAnswer1.Enabled = true;
            btnAnswer2.Enabled = true;
            btnAnswer3.Enabled = true;
            btnAnswer4.Enabled = true;
            btnNextQuestion.Enabled = true;

            timer2.Start();

            questionNum = 0;
            numCorrectAnswers = 0;
            numWrongAnswers = 0;
            previousQuestions = new HashSet<int>();

            lblQuestionNum.Text = "Прашање бр. 0 / 5";
            lblQuestion.Text = "";
            btnAnswer1.Text = "";
            btnAnswer2.Text = "";
            btnAnswer3.Text = "";
            btnAnswer4.Text = "";
            tbTimeLeft.Text = "50";

            newQuestion();
        }

        private void newQuestion()
        {
            if (questionNum < 5)
            {
                questionNum++;
                lblQuestionNum.Text = "Прашање бр." + questionNum.ToString() + " / 5";
                int num = randomQuestion();

                while (previousQuestions.Contains(num))
                {
                    num = randomQuestion();
                }

                previousQuestions.Add(num);

                lblQuestion.Text = data.questions[num];
                btnAnswer1.Text = data.givenAnswers[num][0];
                btnAnswer2.Text = data.givenAnswers[num][1];
                btnAnswer3.Text = data.givenAnswers[num][2];
                btnAnswer4.Text = data.givenAnswers[num][3];
                correctAnswer = data.trueAnswers[num];

                btnAnswer1.BackColor = Color.White;
                btnAnswer2.BackColor = Color.White;
                btnAnswer3.BackColor = Color.White;
                btnAnswer4.BackColor = Color.White;

                ResizeLabel();
            }
        }

        private int randomQuestion()
        {
            return random.Next(0, data.questions.Count);
        }


        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btnAnswer = (Button)sender;
            if (btnAnswer.Text == correctAnswer)
            {
                numCorrectAnswers++;
                btnAnswer.BackColor = Color.LawnGreen;
            }
            else
            {
                numWrongAnswers++;
                btnAnswer.BackColor = Color.Red;
                if (btnAnswer1.Text == correctAnswer) btnAnswer1.BackColor = Color.LawnGreen;
                if (btnAnswer2.Text == correctAnswer) btnAnswer2.BackColor = Color.LawnGreen;
                if (btnAnswer3.Text == correctAnswer) btnAnswer3.BackColor = Color.LawnGreen;
                if (btnAnswer4.Text == correctAnswer) btnAnswer4.BackColor = Color.LawnGreen;
            }
            if (questionNum == 5)
            {
                timer2.Stop();
                endGame();
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (questionNum == 5)
            {
                endGame();
            }
            else
            {
                newQuestion();
            }
        }

        private void endGame()
        {
            timer2.Stop();

            KvizomanijaEndDialog kvizomanijaEndDialog = new KvizomanijaEndDialog(numCorrectAnswers, numWrongAnswers);
            var result = kvizomanijaEndDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                newGame();
            }
            else if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }


        private void ResizeLabel()
        {

            int maxWidth = this.Width - 50;

            if (lblQuestion.Width > maxWidth)
            {
                string text = lblQuestion.Text;
                lblQuestion.Text = "";
                bool newRow = true;

                for (int i = 0; i < text.Length; i++)
                {
                    lblQuestion.Text += text[i];

                    if (lblQuestion.Width >= maxWidth && newRow)
                    {
                        newRow = false;
                        if (text[i] == ' ')
                        {
                            lblQuestion.Text += "\n";
                        }
                        else
                        {
                            lblQuestion.Text += "-\n";
                        }
                    }

                }
            }

        }
    }
}
