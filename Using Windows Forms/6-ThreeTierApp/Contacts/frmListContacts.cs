using ContactBuissnessLayer;

namespace ContactsWF
{
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }
        public void _RefreshContactsList()
        {
            dgvContactsList.DataSource = clsContact.GetAllContacts();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }
        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact(-1);
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact((int)dgvContactsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int deletedContactID = (int)dgvContactsList.CurrentRow.Cells[0].Value;
            if(clsContact.DeleteContact(deletedContactID))
            {
                if (MessageBox.Show($"Are You Sure That You Wanna Delete Contact {deletedContactID}", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MessageBox.Show("Contact Deleted Successfully");
                    _RefreshContactsList();
                }
                else
                    MessageBox.Show("Contact doesn't Deleted Successfully");
            }
        }
    }
}
