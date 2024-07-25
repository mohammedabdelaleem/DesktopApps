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
    public partial class Drawing : Form
    {
        public Drawing()
        {
            InitializeComponent();
        }

        private void Drawing_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
                      
            // The Ground
            g.FillRectangle(new SolidBrush(Color.LimeGreen), 0, 700, 1300, 1000);

            //the house rectangle 
            g.FillRectangle(new SolidBrush(Color.OrangeRed), 220, 400, 850, 500);

            //the Windows
            g.FillRectangle(new SolidBrush(Color.Yellow),305,440,130,130);
            g.FillRectangle(new SolidBrush(Color.Yellow), 820, 440, 130, 130);

            //the door
            g.FillRectangle(new SolidBrush(Color.Black), 510, 600, 250, 300);
            g.FillPie(new SolidBrush(Color.Goldenrod), 526, 720, 50, 50,0,25);

            //the roof
            Point[] points = { new Point(215, 400), new Point(652, 200), new Point(1066, 400) };
            g.FillPolygon(new SolidBrush(Color.Gold), points);

            //the sun
            g.FillEllipse(new SolidBrush(Color.Yellow),1000,110,100,120);


        }
    }
}
