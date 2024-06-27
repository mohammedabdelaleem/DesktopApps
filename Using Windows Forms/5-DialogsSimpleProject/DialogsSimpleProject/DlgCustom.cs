using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogsSimpleProject
{
    public partial class DlgCustom : Form
    {
        public DlgCustom()
        {
            InitializeComponent();
        }

        public string CustomText
        {
            get => this.txtDlgCustom.Text;
            set => this.txtDlgCustom.Text = value;
        }
    }
}
