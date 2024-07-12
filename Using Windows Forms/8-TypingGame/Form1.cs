using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.PerformanceData;

namespace TypingGame
{
    public partial class TypingGame : Form
    {

        string[] _words =  {
            "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew",
            "kiwi", "lemon", "mango", "nectarine", "orange", "papaya", "quince", "raspberry",
            "strawberry", "tangerine", "ugli", "violet", "watermelon", "xigua", "yam", "zucchini",
            "Hot", "Cop", "cup","fan", "Pen","steve" ,"Labtop","Marker", "book","charger",
            "black", "chair","Mouse","Button","screen","copmuter","uncle","aunt","Counter", "Instance","England"
        };

        int _correct =0,_incorrect =0;
        Random rnd = new Random();  

        public TypingGame()
        {
            InitializeComponent();

            lblWord.Text = _words[rnd.Next(0, _words.Length)];
        }


        private void CheckWord(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtUserWord.Text == lblWord.Text )
                {
                    _correct++;
                    lblWord.Text = _words[rnd.Next(0, _words.Length)];
                    txtUserWord.Text = null; 
                    txtUserWord.Focus();
                }
                else
                {
                    _incorrect++;
                    lblWord.Text = _words[rnd.Next(0, _words.Length)];
                    txtUserWord.Text = null;
                    txtUserWord.Focus();
                }

                lblCorrect.Text = "Correct : " + _correct;
                lblIncorrect.Text = "Incorrect : " + _incorrect;

            }
        }
    }
}
