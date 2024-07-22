using BuissnessLayer;

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
        string _Player1Name, _Player2Name;
        string _P1Turn, _P2Turn;
        string _Winner;
        string _Loser="";
        int _TimerCount = 0;
        int _TempTimerCount = 0;

        enum enName { _firstName, _lastName }

        clsPlayer player1;
        clsPlayer player2;


        public string Player1Name
        {
            get => _Player1Name;
            private set => _Player1Name = value;
        }

        public string Player2Name
        {
            get => _Player2Name;
            private set => _Player2Name = value;
        }

        public Form1(string P1Name, string P2Name)
        {
            InitializeComponent();

            /// set Players Names 
            _Player1Name = P1Name;
            _Player2Name = P2Name;

            _P1Turn = HandlePlayerTurnName(_Player1Name); // which show at lblTurn => // mohammed ali , mohammed moaz => m.ali , m.moaz
            _P2Turn = HandlePlayerTurnName(_Player2Name);

            CheckIfNamesLblAreEquals(ref _P1Turn, ref _P2Turn); // moaz ali , mazen ali => m.ali1 , m.ali2

            lblTurn.Text = _P1Turn;

            /// load data from DB 
            LoadPlayersIfFound();
        }

        private void CheckIfNamesLblAreEquals(ref string p1Turn, ref string p2Turn)
        {
            if (p1Turn.Equals(p2Turn, StringComparison.OrdinalIgnoreCase))
            {
                p1Turn += "1";
                p2Turn += "2";

            }
        }

        private void LoadPlayersIfFound()
        {
            player1 = clsPlayer.Find(GetFirst_LastName(_Player1Name, enName._firstName), GetFirst_LastName(_Player1Name, enName._lastName));
            if (player1 == null)
            {
                player1 = new clsPlayer() { FirstName = GetFirst_LastName(_Player1Name, enName._firstName), LastName = GetFirst_LastName(_Player1Name, enName._lastName), Win = 0, Loss = 0, Draw = 0 }; // add new mode
            }

            player2 = clsPlayer.Find(GetFirst_LastName(_Player2Name, enName._firstName), GetFirst_LastName(_Player2Name, enName._lastName));
            if (player2 == null)
            {
                player2 = new clsPlayer() { FirstName = GetFirst_LastName(_Player2Name, enName._firstName), LastName = GetFirst_LastName(_Player2Name, enName._lastName), Win = 0, Loss = 0, Draw = 0 }; // add new mode;
            }
        }

        public string HandlePlayerTurnName(string PlayerName)
        {
            return PlayerName[0] + "." + GetFirst_LastName(PlayerName, enName._lastName);
        }

        private string GetFirst_LastName(string FullName, enName which)
        {
            int spaceIndex = FullName.IndexOf(' ');   // 0 1 2 3 (4)
            return (which == enName._firstName) ? FullName.Substring(0, spaceIndex) : FullName.Substring(spaceIndex + 1, FullName.Length - spaceIndex - 1); // M o a z 
        }
        private void SplitFullName(string FullName, ref string firstName, ref string lastName)
        {
            string[] Names = FullName.Split(" ");
            firstName = Names[0]; // i sure from this 
            lastName = Names[1] ?? "Tiger";
        }
        /// <summary>
        /// //////////////////////
        /// </summary>
        private void FillPlayerInfo()
        {
            string firstname = "", lastname = "";
            SplitFullName(_Player1Name, ref firstname, ref lastname);
            clsPlayer player1 = clsPlayer.Find(firstname, lastname);
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
                        lblTurn.Text = _P2Turn;
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        btn.Tag = "O";
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = _P1Turn;
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
                    _Winner = "Congratulation " + _Player1Name;
                    _Loser = _Player2Name;
                    player1.Win++;
                    player2.Loss++;
                    break;

                case enWinner.Player2:
                    _Winner = "Congratulation " + _Player2Name;
                    _Loser = _Player1Name;
                    player2.Win++;
                    player1.Loss++;
                    break;

                default:
                    _Winner = "Draw (No Winner).";
                    player1.Draw++;
                    player2.Draw++;
                    break;
            }

            //Updata and Save Players into DB
            player1.Save();
            player2.Save();

            GameTimer.Stop();

            // Winner MSG
            MessageBox.Show(_Winner, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Losser MSG
          if(_Loser.Length>1) 
            ShowGoodLuck();


            RestartGameOrNot();
        }

        private void ShowGoodLuck()
        {
            notifyIcon1.Icon = SystemIcons.Hand;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = $"Good Luck {_Loser}";
            notifyIcon1.BalloonTipText = "Keep Going, You Did Well";
            notifyIcon1.ShowBalloonTip(1100);

        }

        private void RestartGameOrNot()
        {
            if (MessageBox.Show("New Game, Heros","New Game",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close();
            } 
                
        }



        // sender -> btn that fire an event , we can use the sender as a general btn to make less complexity and use DRY Concept
        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        #region Well Abbreviation 
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

        #endregion

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

            lblTurn.Text = _P1Turn;
            lblTimer.Text = _TimerCount.ToString();
            GameStatus.Winner = enWinner.InProgress;
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
            PlayerTurn = enPlayer.Player1;

            _TimerCount = 0;
            GameTimer.Start();

        }

        private void ReseatButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Black;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GameTimer.Start();
        }

        public Form1 GetCurrentObject()
        {
            Form1 frm = this;
            return frm;
        }


        frmStop frmResume1 = new frmStop();
        private void btnStop_Click(object sender, EventArgs e)
        {
           GameTimer.Stop();
            this.Hide();
            frmResume1.ClickPressE += StopForm;
            frmResume1.ShowDialog();

        }

        private void StopForm(object? sender, clsStateEventArgs e)
        {
            if (e.State == clsStateEventArgs.enStatus.Resume)
            {
                this.Visible = true;
                GameTimer.Start();
            }
            else if (e.State == clsStateEventArgs.enStatus.NewGame)
            {
                this.Visible = true;/////////
                this.RestartGame();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            _TimerCount++;
            lblTimer.Text = _TimerCount.ToString();
        }
    }
}
