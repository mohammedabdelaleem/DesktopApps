using BuissnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmLogin : Form
    {
        bool _chooseExistingPlayer1 = false,
             _chooseExistingPlayer2 = false;
        string P1Name = "", P2Name = "";
        public frmLogin()
        {
            InitializeComponent();

            FillComboBox(cbPlayer1Name);
            FillComboBox(cbPlayer2Name);

            cbPlayer1Name.Sorted = true;

          
            cbPlayer1Name.SelectedIndexChanged += (sender, e) => txtP1Name.Text = cbPlayer1Name.SelectedItem.ToString();
            cbPlayer2Name.SelectedIndexChanged += (sender, e) => txtP2Name.Text = cbPlayer2Name.SelectedItem.ToString();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            txtP1Name.BringToFront();
            txtP2Name.BringToFront();

            _chooseExistingPlayer1 = false;
            _chooseExistingPlayer2 = false;

        }

        // enforcing full name
        private void TextBoxNameValidating(object sender, CancelEventArgs e)
        {


            if (sender is TextBox textBox)
            {
                if (
                    string.IsNullOrWhiteSpace(textBox.Text) ||
                    !IsFullName(textBox.Text.Trim()))
                {
                    e.Cancel = true;
                    textBox.Focus();
                    LoginErrorProvider.SetError(textBox, "Please Enter Full Name");
                }
                else
                {
                    e.Cancel = false;
                }
            }


        }

        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!_chooseExistingPlayer1 && textBox.Tag == "tb1")
                {
                    TextBoxNameValidating(textBox, e);
                }

                else if (!_chooseExistingPlayer2 && textBox.Tag == "tb2")
                {
                    TextBoxNameValidating(textBox, e);
                }


            }
        }

        private bool IsFullName(string fullName)
        {
            string[] f_l_Name = fullName.Split(' ');
            return f_l_Name.Length == 2;
        }

        private void SetDefaultTextBox(TextBox textBox)
        {
            textBox.Text = string.Empty;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtP1Name.Text = "lionel messi";
            txtP2Name.Text = "lionel messi";

            this.Close();
        }


        frmStop frmStop1 = new frmStop();
        private void btnPlay_Click(object sender, EventArgs e)
        {     

            if (
                string.IsNullOrWhiteSpace(txtP1Name.Text) ||
                string.IsNullOrWhiteSpace(txtP2Name.Text) ||
                !IsFullName(txtP1Name.Text.Trim()) ||
                !IsFullName(txtP2Name.Text.Trim()))
            {
                MessageBox.Show("Please Enter Player Full Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtP1Name.Text.Trim() == txtP2Name.Text.Trim()) // not completed yet
            {
                MessageBox.Show("Must Be Different Names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1 frm = new Form1(txtP1Name.Text, txtP2Name.Text);
                this.Hide();
                frm.ShowDialog();

                // erase players names
                SetDefaultTextBox(txtP1Name);
                SetDefaultTextBox(txtP2Name);


                this.Visible = true;

                frmLogin_Load(this, e);

            }

        }

        private void pbClick(PictureBox pictureBox)
        {
        
            switch (pictureBox.Tag)
            {
                case "pb1":
                    cbPlayer1Name.BringToFront();
                    cbPlayer1Name.SelectedIndex = 0;
                    P1Name = cbPlayer1Name.SelectedItem.ToString();
                    txtP1Name.Text = P1Name;
                    _chooseExistingPlayer1 = true;
                    break;

                case "pb2":

                    cbPlayer2Name.BringToFront();
                    cbPlayer2Name.SelectedIndex = 2;
                    P2Name = cbPlayer2Name.SelectedItem.ToString();
                    txtP2Name.Text = P2Name;
                    _chooseExistingPlayer2 = true;
                    break;


            }
        }

        private void pbLoadNames1_Click(object sender, EventArgs e)
        {
            pbClick(pbLoadNames1);
        }
        private void pbLoadNames2_Click(object sender, EventArgs e)
        {
            pbClick(pbLoadNames2);

        }

        DataView playersNames = clsPlayer.GetAllPlayersNames();
        private void FillComboBox(ComboBox cbPlayerName)
        {
            foreach (DataRowView rowView in playersNames)
            {
                DataRow row = rowView.Row;
                cbPlayerName.Items.Add(row["FullName"]);
            }
        }

      
      
        private void textBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(MessageBox.Show("Show TextBox1", "Show TextBox1",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtP1Name.BringToFront();
            }
            if (MessageBox.Show("Show TextBox2", "Show TextBox2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtP2Name.BringToFront();
            }
        }
    }
}
