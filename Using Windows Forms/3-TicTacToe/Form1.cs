using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        enum enPlayer
        {
            Player1, Player2
        }
        enum enWinner
        {
            Player1, Player2, Draw, InProgress
        }
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;
        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        int timerStart = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(Color.White);
            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            Graphics g = e.Graphics;

            //V_Lines
            g.DrawLine(pen, 630, 200, 630, 640);
            g.DrawLine(pen, 810, 200, 810, 640);

            //H_Lines
            g.DrawLine(pen, 495, 350, 960, 350);
            g.DrawLine(pen, 495, 510, 960, 510);

        }

        private void ChangeImage(Button btn)
        {
            if (btn?.Tag?.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        btn.Tag = "X";
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player2";
                        GameStatus.PlayCount++;
                        CheckWinner();

                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        btn.Tag = "O";
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player1";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9 && !CheckWinner())
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

        }

        private bool CheckWinner()
        {
            // h-rows
            if (CheckValues(button1, button2, button3) || CheckValues(button4, button5, button6) || (CheckValues(button7, button8, button9)))
                return true;

            // v-rows
            if (CheckValues(button1, button4, button7) || CheckValues(button2, button5, button8) || CheckValues(button3, button6, button9))
                return true;

            // diagonals
            if (CheckValues(button1, button5, button9) || (CheckValues(button3, button5, button7)))
                return true;

            return false;

        }

        private bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1?.Tag?.ToString() != "?" && btn1?.Tag?.ToString() == btn2?.Tag?.ToString() && btn1?.Tag?.ToString() == btn3?.Tag?.ToString())
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                switch (btn1?.Tag?.ToString())
                {
                    case "X":
                        GameStatus.Winner = enWinner.Player1;
                        GameStatus.GameOver = true;
                        EndGame();
                        return true;

                    case "O":
                        GameStatus.Winner = enWinner.Player2;
                        GameStatus.GameOver = true;
                        EndGame();
                        return true;
                }
            }

            GameStatus.GameOver = false;
            return false;

        }

        private void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player1";
                    ShowWinnerNotify(lblWinner.Text);
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player2";
                    ShowWinnerNotify(lblWinner.Text);
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;

            }
            timer1.Enabled = false; //Stop Timer
            MessageBox.Show(lblWinner.Text, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWinnerNotify(string winner)
        {
            if (winner.Equals("Draw", StringComparison.OrdinalIgnoreCase)) return;

            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Congratiolation";
            notifyIcon1.BalloonTipText = winner;
            notifyIcon1.ShowBalloonTip(500);
        }

        // sender -> btn that fire an event , we can use the sender as a general btn to make less complexity and use DRY Concept
        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button1);
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button2);
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button3);
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button4);
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button5);
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button6);
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button7);
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button8);
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button9);
        //}


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            ReseatButton(button1);
            ReseatButton(button2);
            ReseatButton(button3);
            ReseatButton(button4);
            ReseatButton(button5);
            ReseatButton(button6);
            ReseatButton(button7);
            ReseatButton(button8);
            ReseatButton(button9);

            lblTurn.Text = "Player1";
            lblWinner.Text = "In Progress";
            GameStatus.Winner = enWinner.InProgress;
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
            PlayerTurn = enPlayer.Player1;

            lblTimer.ForeColor = Color.GreenYellow;
            timerStart = 0;
            timer1.Enabled = true;
        }

        private void ReseatButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTurn.Text = "Player 1";
            timerStart = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerStart++;
            if (timerStart > 6)
                lblTimer.ForeColor = Color.Gold;
            if (timerStart > 12)
                lblTimer.ForeColor = Color.Red;

            lblTimer.Text = timerStart.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
