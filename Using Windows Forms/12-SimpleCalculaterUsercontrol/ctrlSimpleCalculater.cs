using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrols
{
    public partial class ctrlSimpleCalculater : UserControl
    {
        StringBuilder userInput = new StringBuilder();
        string answer;

        public ctrlSimpleCalculater()
        {
            InitializeComponent();
            txtAns.Visible = false;
        }

        #region Numbers 

        private void ClickNumberOrParenteces(Button button)
        {
            txtAns.Visible = false;
            userInput.Append(button?.Tag?.ToString());
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button)sender);

        }
        #endregion

        #region O/C Paranteces 

        private void btnOpenPranteces_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button) sender);
        }

        private void btnClosePranteces_Click(object sender, EventArgs e)
        {
            ClickNumberOrParenteces((Button) sender);
        }

        #endregion

        #region Del , Ac
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtAns.Visible = false;

            if (userInput.Length > 0)
                userInput.Remove((userInput.Length) - 1, 1);
            else
                MessageBox.Show("Expression Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtAns.Visible = false;

            userInput.Clear();
        }

        #endregion

        #region Operators

        private void ClickOperator(Button op)
        {
            txtAns.Visible = false;

            switch (op?.Tag)
            {
                case "+":
                    userInput.Append(op?.Tag);
                    break;

                case "-":
                    userInput.Append(op?.Tag);
                    break;

                case "*":
                    userInput.Append(op?.Tag);
                    break;

                case "/":
                    userInput.Append(op?.Tag);
                    break;
            }
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            ClickOperator((Button)sender);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ClickOperator((Button)sender);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            ClickOperator((Button)sender);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ClickOperator((Button)sender);
        }
        #endregion

        #region Ans , = 


        int Precedence(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            return 0;
        }

        string InfixToPostfix(string infix)
        {
            Stack<char> operators = new Stack<char>();
            List<string> postfix = new List<string>();
            int i = 0;

            while (i < infix.Length)
            {
                if (char.IsWhiteSpace(infix[i]))
                {
                    i++;
                    continue;
                }

                if (char.IsDigit(infix[i]))
                {
                    string num = "";
                    while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                    {
                        num += infix[i];
                        i++;
                    }
                    postfix.Add(num);
                }
                else if (infix[i] == '(')
                {
                    operators.Push(infix[i]);
                    i++;
                }
                else if (infix[i] == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        postfix.Add(operators.Pop().ToString());
                    }
                    operators.Pop(); // remove '('
                    i++;
                }
                else
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(infix[i]))
                    {
                        postfix.Add(operators.Pop().ToString());
                    }
                    operators.Push(infix[i]);
                    i++;
                }
            }

            while (operators.Count > 0)
            {
                postfix.Add(operators.Pop().ToString());
            }

            return string.Join(" ", postfix);
        }

        double EvaluatePostfix(string postfix)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = postfix.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double num))
                {
                    stack.Push(num);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    switch (token)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            stack.Push(a / b);
                            break;
                    }
                }
            }

            return stack.Pop();
        }



        private void btnAns_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(answer))
                MessageBox.Show("No Answer Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(answer, "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double Result = EvaluatePostfix(InfixToPostfix(userInput.ToString()));
                answer = Result.ToString();
                ShowResult();

            }
            catch
            {
                MessageBox.Show("Check Your Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void ShowResult()
        {
            txtAns.Visible = true;
            txtAns.Text = answer;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdataCalculaterInput();
        }

        private void UpdataCalculaterInput()
        {
            txtUserInput.Text = userInput.ToString();
        }

    
    }
}
