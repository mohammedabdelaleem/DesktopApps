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
       
        public frmStop()
        {
            InitializeComponent();
        }

        public event EventHandler<clsStateEventArgs> ClickPressE;

        protected virtual void OnClickPressE(clsStateEventArgs e)
        {
            //invoke event
            ClickPressE?.Invoke(this, e);
        }

        public  void OnClickPressE(clsStateEventArgs.enStatus status)
        {
            //invoke event
            OnClickPressE(new clsStateEventArgs(status));
        }
        private void btnResume_Click(object sender, EventArgs e)
        {
            this.Close();
            OnClickPressE(clsStateEventArgs.enStatus.Resume);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Close();
            OnClickPressE(clsStateEventArgs.enStatus.NewGame);
        }

        frmFinalResults frmFinalResults = new frmFinalResults();
        private void btnViewResults_Click(object sender, EventArgs e)
        {
            frmFinalResults.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.FormClosed += (sender, e) => Application.Exit();
        }
    }
}
