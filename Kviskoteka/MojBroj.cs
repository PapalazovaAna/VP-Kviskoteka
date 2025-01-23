using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka
{
    public partial class MojBroj : Form
    {
        private MojBrojData data;
        private List<Button> clickedButtons;
        private string trueFormula;
        private Random random = new Random();
        public MojBroj()
        {
            InitializeComponent();

            data = new MojBrojData();
            clickedButtons = new List<Button>();
        }

        private void newGame()
        {
            btnNum1.Enabled = true;
            btnNum2.Enabled = true;
            btnNum3.Enabled = true;
            btnNum4.Enabled = true;
            btnNum5.Enabled = true;
            btnNum6.Enabled = true;
            btnOperation1.Enabled = true;
            btnOperation2.Enabled = true;
            btnOperation3.Enabled = true;
            btnOperation4.Enabled = true;
            btnOperation5.Enabled = true;
            btnOperation6.Enabled = true;
            btnDelete.Enabled = true;
            btnEnd.Enabled = true;

            int gameNum = random.Next(0, data.baraniBroevi.Count);
            tbTargetNum.Text = data.baraniBroevi[gameNum].ToString();
            btnNum1.Text = data.ponudeniBroevi[gameNum][0].ToString();
            btnNum2.Text = data.ponudeniBroevi[gameNum][1].ToString();
            btnNum3.Text = data.ponudeniBroevi[gameNum][2].ToString();
            btnNum4.Text = data.ponudeniBroevi[gameNum][3].ToString();
            btnNum5.Text = data.ponudeniBroevi[gameNum][4].ToString();
            btnNum6.Text = data.ponudeniBroevi[gameNum][5].ToString();
            trueFormula = data.tocnaFormula[gameNum];

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Enabled = true;

            tbTimeLeft.Text = "100";
            tbFormula.Text = "";
            clickedButtons.Clear();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (clickedButtons.Count != 0 && clickedButtons[clickedButtons.Count - 1].Name.StartsWith("btnNum"))
            {
                lblError.Text = "Не може да се внесат два броја еден по друг!";
            }
            else
            {
                lblError.Text = "";
                Button clickedButton = (Button)sender;
                clickedButton.Enabled = false;
                clickedButtons.Add(clickedButton);
                tbFormula.Text += clickedButton.Text;
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (clickedButtons.Count != 0 && clickedButtons[clickedButtons.Count - 1].Name.StartsWith("btnOperation") && clickedButtons[clickedButtons.Count - 1].Name != "btnOperation5" && clickedButtons[clickedButtons.Count - 1].Name != "btnOperation6")
            {
                lblError.Text = "Не може да се внесат две операции една по друга!";
            }
            else
            {
                lblError.Text = "";
                Button clickedButton = (Button)sender;
                clickedButtons.Add(clickedButton);
                tbFormula.Text += clickedButton.Text;
            }
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButtons.Add(clickedButton);
            tbFormula.Text += clickedButton.Text;
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButtons.Add(clickedButton);
            tbFormula.Text += clickedButton.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = int.Parse(tbTimeLeft.Text);
            if (time == 0)
            {
                timer1.Enabled = false;
                CheckExpression();
            }
            else
            {
                time -= 1;
                tbTimeLeft.Text = time.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            newGame();
            btnStart.Visible = false;
        }


        private bool IsValidExpression(string expression)
        {
            return IsBalancedParentheses(expression) && IsValidStart(expression) && EndsWithNumberOrClosedParenthesis(expression);
        }

        private bool IsBalancedParentheses(string expression)
        {
            int balance = 0;
            foreach (char c in expression)
            {
                if (c == '(') balance++;
                else if (c == ')') balance--;
                if (balance < 0) return false;
            }
            return balance == 0;
        }

        private bool IsValidStart(string expression)
        {
            if (string.IsNullOrEmpty(expression)) return true;

            char firstChar = expression.First();
            return char.IsDigit(firstChar) || firstChar == '(';
        }

        private bool EndsWithNumberOrClosedParenthesis(string expression)
        {
            if (string.IsNullOrEmpty(expression)) return true;

            char lastChar = expression.Last();
            return char.IsDigit(lastChar) || lastChar == ')';
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clickedButtons.Count != 0)
            {
                lblError.Text = "";
                Button deleted = clickedButtons[clickedButtons.Count - 1];
                clickedButtons.RemoveAt(clickedButtons.Count - 1);
                deleted.Enabled = true;
                string deletedText = deleted.Text;
                string formulaText = tbFormula.Text;
                if (formulaText.Length - deletedText.Length < 0)
                {
                    tbFormula.Text = "";
                }
                else
                {
                    string newText = formulaText.Remove(formulaText.Length - deletedText.Length);
                    tbFormula.Text = newText;
                }
            }
            else
            {
                lblError.Text = "Нема повеќе ништо за бришење!";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            CheckExpression();
        }


        public string GetExpressionFromButtons(List<Button> clickedButtons)
        {
            StringBuilder expression = new StringBuilder();
            foreach (Button button in clickedButtons)
            {
                expression.Append(button.Text);
            }
            return expression.ToString();
        }

        private void CheckExpression()
        {
            string expression = GetExpressionFromButtons(clickedButtons);
            if (IsValidExpression(expression))
            {
                double yourResult;
                string textToSend = "";
                if (expression.Length == 0)
                {
                    yourResult = 0;
                    textToSend = "Немате внесено израз!";
                }
                else
                {
                    yourResult = EvaluateExpression(expression);
                    textToSend = tbFormula.Text;
                }

                timer1.Enabled = false;

                MojBrojEndDialog mojBrojEndDialog = new MojBrojEndDialog(textToSend, yourResult, trueFormula, int.Parse(tbTargetNum.Text));
                var result = mojBrojEndDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    newGame();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                if(tbTimeLeft.Text == "0")
                {
                    string textToSend = tbFormula.Text;
                    int yourResult = -1;
                    MojBrojEndDialog mojBrojEndDialog = new MojBrojEndDialog(textToSend, yourResult, trueFormula, int.Parse(tbTargetNum.Text));
                    var result = mojBrojEndDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        newGame();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                lblError.Text = "Невалиден израз!";
            }
        }

        public double EvaluateExpression(string expression)
        {
            string postFixExpression = ConvertToPostfix(expression);
            return EvaluatePostfix(postFixExpression);
        }

        private string ConvertToPostfix(string expression)
        {
            StringBuilder postFix = new StringBuilder();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (char.IsDigit(c))
                {
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        postFix.Append(expression[i]);
                        i++;
                    }
                    postFix.Append(' ');
                    i--;
                }
                else if (c == '(')
                {
                    operators.Push(c);
                }
                else if (c == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        postFix.Append(operators.Pop());
                        postFix.Append(' ');
                    }
                    operators.Pop();
                }
                else if (IsOperator(c))
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(c))
                    {
                        postFix.Append(operators.Pop());
                        postFix.Append(' ');
                    }
                    operators.Push(c);
                }
            }

            while (operators.Count > 0)
            {
                postFix.Append(operators.Pop());
                postFix.Append(' ');
            }

            return postFix.ToString().Trim();
        }

        private int Precedence(char c)
        {
            if (c == '+' || c == '-') return 1;
            if (c == '*' || c == '/') return 2;
            return 0;
        }

        private double EvaluatePostfix(string postFixExpression)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = postFixExpression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else if (IsOperator(token[0]))
                {
                    if (stack.Count < 2)
                    {
                        throw new InvalidOperationException("Невалиден израз!");
                    }

                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token[0])
                    {
                        case '+': stack.Push(a + b); break;
                        case '-': stack.Push(a - b); break;
                        case '*': stack.Push(a * b); break;
                        case '/': stack.Push(a / b); break;
                        default: throw new InvalidOperationException("Невалиден оператор!");
                    }
                }
            }

            if (stack.Count != 1)
            {
                throw new InvalidOperationException("Невалиден израз!");
            }

            return stack.Pop();
        }

    }
}
