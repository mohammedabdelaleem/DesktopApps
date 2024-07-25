namespace MovePictureBox
{
    public partial class Form1 : Form
    {
        bool _moveRight, _moveLeft, _moveUp, _moveDown;
        int _speed = 12;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            SetRandomPictureBoxPosition();
        }

        private int GetRandomNumberBetween(int From, int To)
        {
            return rnd.Next(From, To);
        }
        private void SetRandomPictureBoxPosition()
        {
            pictureBox1.Location =new Point( GetRandomNumberBetween(0, 637) , GetRandomNumberBetween(0, 473) ) ;
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                _moveLeft = false;

            if (e.KeyCode == Keys.Right)
                _moveRight = false;

            if (e.KeyCode == Keys.Up)
                _moveUp = false;

            if (e.KeyCode == Keys.Down)
                _moveDown = false;

            pictureBox1.BackColor = Color.FromArgb(GetRandomNumberBetween(0, 255), GetRandomNumberBetween(0, 255), GetRandomNumberBetween(0, 255));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
                _moveLeft = true;

            if (e.KeyCode == Keys.Right)
                _moveRight = true;

            if (e.KeyCode == Keys.Up)
                _moveUp = true;

            if (e.KeyCode == Keys.Down)
                _moveDown = true;

            pictureBox1.BackColor = Color.FromArgb(GetRandomNumberBetween(0, 255), GetRandomNumberBetween(0, 255), GetRandomNumberBetween(0, 255));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // left => -X+  , right => -^ y v+
            if(_moveLeft==true && pictureBox1.Left > 0)
                pictureBox1.Left -= _speed;

            if (_moveRight == true && pictureBox1.Left < 637)
                pictureBox1.Left += _speed;

            if (_moveUp == true && pictureBox1.Top > 0)
                pictureBox1.Top -= _speed;

            if (_moveDown == true && pictureBox1.Top < 473)
                pictureBox1.Top += _speed;

        }
    }
}
