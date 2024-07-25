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
    public partial class frmFinalResults : Form
    {
        public frmFinalResults()
        {
            InitializeComponent();
        }

        private void frmFinalResults_Load(object sender, EventArgs e)
        {
            dgvFinalResults.DataSource = clsPlayer.GetAllPlayers();
        }
    }
}
