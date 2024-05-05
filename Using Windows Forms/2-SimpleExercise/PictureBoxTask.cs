using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsTestApp.Properties;

namespace WindowsFormsTestApp
{
    public partial class PictureBoxTask : Form
    {
        public PictureBoxTask()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            lblMainTitle.Text = ((RadioButton)sender).Tag.ToString();
            // lblMainTitle.Text = "BOY";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            lblMainTitle.Text = ((RadioButton)sender).Tag.ToString();
            //lblMainTitle.Text = "Girl";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            lblMainTitle.Text = ((RadioButton)sender).Tag.ToString();
            // lblMainTitle.Text = "BOOK";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Pen;
            // lblMainTitle.Text = ((RadioButton)sender).Tag.ToString();
            //lblMainTitle.Text = "PEN";
            lblMainTitle.Text = radioButton3.Tag.ToString();
        }

        private void PictureBoxTask_Load(object sender, EventArgs e)
        {
                lblMainTitle.Text = "BOY";
        }
    }
}
