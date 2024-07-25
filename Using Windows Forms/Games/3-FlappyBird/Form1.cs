namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // to move the pipes to left 
        int gravity = 15; // to move the bird to left 
        int score = 0;  // to record the score
                        // bool gameOver = false;
        int incCounter = 2;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            // Transparent the score background 
            pbGround.Controls.Add(lblScore);
            lblScore.Left = 20;
            lblScore.Top = 15;
            lblScore.BackColor = Color.Transparent;

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10; // if you release the key , bird should go down , its top (Y) should increase. 
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;// if you push the key , bird should go up , its top (Y) should decrease. 
            }
        }

        private void RestartGame()
        {
            // gameOver = false;

            score = 0;
            pbFlappyBird.Location = new Point(119, 220);
            pbPipeButtom.Left = 800;
            pbPipeTop.Left = 1000;
            pipeSpeed = 8;
            gravity = 15;

            gameTimer.Start();

        }

        private int GetRandomNumberBetween(int from, int to) => rnd.Next(from, to);
        private void GameTimerEvent(object sender, EventArgs e)
        {

            pbFlappyBird.Top += gravity;
            pbPipeButtom.Left -= pipeSpeed;
            pbPipeTop.Left -= pipeSpeed;
            lblScore.Text = "Score : " + score;


            if (pbPipeButtom.Left < -130)
            {
                pbPipeButtom.Left = GetRandomNumberBetween(400, 650);
                score++;
            }

            if (pbPipeTop.Left < -130)
            {
                pbPipeTop.Left = GetRandomNumberBetween(400, 800);
                score++;
            }


            // Game Over When 
            if (
                pbFlappyBird.Bounds.IntersectsWith(pbPipeButtom.Bounds) ||
                pbFlappyBird.Bounds.IntersectsWith(pbPipeTop.Bounds) ||
                pbFlappyBird.Bounds.IntersectsWith(pbGround.Bounds) ||
                pbFlappyBird.Top < -10
                )
            {
                GameOver();
                return;
            }

            // make a game little hard
            SpeedUp();

        }

        private void SpeedUp()
        {

            if (score > 14)
                pipeSpeed = 15;

            else if (score > 7)
                pipeSpeed = 11;

            /// we can add more hard

        }

        private void GameOver()
        {
            //gameOver = true;
            gameTimer.Stop();
            MessageBox.Show("Gameover Your Score Is " + score, "Gameover", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("New Game", "Retry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {

                notifyIcon1.Icon = this.Icon ;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Come Again ,Hero";
                notifyIcon1.BalloonTipText = "You Are Playing Well";
                notifyIcon1.ShowBalloonTip(1000); 
                Thread.Sleep(800);


            this.Close();
            }

        }

        
    }
}
