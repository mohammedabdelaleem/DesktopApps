using ImaegGallary.Properties;
using System;

namespace ImaegGallary
{
    public partial class Form1 : Form
    {
        sbyte i = 3;
        public Form1()
        {
            InitializeComponent();

            ChangeImage(num: i);
        }

        private void GoNext(object sender, EventArgs e)
        {
            i++;
            if (i > 10) i = 0;
            ChangeImage (i);
        }

        private void GoBack(object sender, EventArgs e)
        {
            i--;
            if (i < 0) i = 10;
            ChangeImage(i);
        }

        private void ChangeImage(int num)
        {
            switch (num)
            {
                case 0:
                    pictureBox1.Image = Resources.Zero;
                    break;

                case 1:
                    pictureBox1.Image = Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Resources._2;
                    break;

                case 3:
                    pictureBox1.Image = Resources._3;
                    break;

                case 4:
                    pictureBox1.Image = Resources._4;
                    break;

                case 5:
                    pictureBox1.Image = Resources._5;
                    break;

                case 6:
                    pictureBox1.Image = Resources._6;
                    break;

                case 7:
                    pictureBox1.Image = Resources._7;
                    break;

                case 8:
                    pictureBox1.Image = Resources._8;
                    break;

                case 9:
                    pictureBox1.Image = Resources._9;
                    break;

                case 10:
                    pictureBox1.Image = Resources._10;
                    break;
            }
        }
    }
}
