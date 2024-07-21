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
        public frmLogin()
        {
            InitializeComponent();
        }

        // enforcing full name
        private void TextBoxNameValidating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text) || !IsFullName(textBox.Text.Trim()))
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
            if (string.IsNullOrWhiteSpace(txtP1Name.Text) || string.IsNullOrWhiteSpace(txtP2Name.Text) || !IsFullName(txtP1Name.Text.Trim()) || !IsFullName(txtP2Name.Text.Trim()))
            {
                MessageBox.Show("Please Enter Player Full Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            }
        }

    }
}
