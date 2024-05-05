using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestApp
{
    public partial class Startup : Form
    {
        Form1 form1 = new Form1();
        PictureBoxTask pbTask = new PictureBoxTask();
        Drawing drawing = new Drawing();
        public Startup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pbTask.ShowDialog();
        }

        private void btnPictureboxExample_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            drawing.ShowDialog();
        }
    }
}
