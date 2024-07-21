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
    public partial class frmStop : Form
    {
        Form1 _frmResume;
        public Form1 FrmResume { get; set; }
        // recive the players name because of the new game 
        public frmStop()
        {
            InitializeComponent();
            //_P1Name = P1Name;
            //_P2Name = P2Name;
            //this._frmResume = frmResume;
        }

     //   Form1 frmResume = new Form1("Resume");
        private void btnResume_Click(object sender, EventArgs e)
        {
            this.Close();
            this._frmResume.Visible = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this._frmResume.Visible = true;
            this._frmResume.RestartGame();
        }

        frmFinalResults frmFinalResults = new frmFinalResults();
        private void btnViewResults_Click(object sender, EventArgs e)
        {
            frmFinalResults.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.FormClosed += (sender, e) => Application.Exit();
        }
    }
}
