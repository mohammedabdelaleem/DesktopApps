namespace HitTestGame
{
    public partial class Form1 : Form
    {

        bool moveUp, moveDown, moveRight, moveLeft;
        int speed = 15;
        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveLeft && pbPlayer.Left > 0)
                pbPlayer.Left -= speed;

            if (moveRight && pbPlayer.Left < 748)
                pbPlayer.Left += speed;

            if (moveUp && pbPlayer.Top > 0)
                pbPlayer.Top -= speed;

            if (moveDown && pbPlayer.Top < 540)
                pbPlayer.Top += speed;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.BackColor = Color.Red;
                        label1.Text = "You Hit: "+ x.Name;
                    }
                    else
                        x.BackColor = Color.DarkBlue;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = false;

            if (e.KeyCode == Keys.Right)
                moveRight = false;

            if (e.KeyCode == Keys.Up)
                moveUp = false;

            if (e.KeyCode == Keys.Down)
                moveDown = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = true;

            if (e.KeyCode == Keys.Right)
                moveRight = true;

            if (e.KeyCode == Keys.Up)
                moveUp = true;

            if (e.KeyCode == Keys.Down)
                moveDown = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
