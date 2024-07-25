using WindowsFormsTestApp.Properties;

namespace WindowsFormsTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.DevidGoggins;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.AndrowTate;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\University\Coding\Basic\Basic-C#\ITI\WindowsFormsTestApp\Imgs\Fighter.jpeg");
        }
    }
}
