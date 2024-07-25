using ContactBuissnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsWF
{
    public partial class frmAddEditContact : Form
    {
        enum enMode { AddNew, Update }
        enMode Mode;

        int _ContactID;
        clsContact _Contact;

        public frmAddEditContact(int ContactID)
        {
            InitializeComponent();
            _ContactID = ContactID;

            if (_ContactID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dlgOpen.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            dlgOpen.FilterIndex = 1;
            dlgOpen.RestoreDirectory = true;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                string ImagePath = dlgOpen.FileName;
                pbImage.Load(ImagePath);
            }
        }
        private void FillCountriesInComboBox()
        {
            DataTable Countries = clsCountry.GetAllCountries();
            foreach (DataRow country in Countries.Rows)
                cbCountry.Items.Add(country["CountryName"]);
        }
        private void LoadData()
        {
            FillCountriesInComboBox();
            cbCountry.SelectedIndex = 0;
            txtContactID.Enabled = false;

            if (Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                txtContactID.Text = "?????";
                _Contact = new clsContact();
                return;
            }

            _Contact = clsContact.Find(_ContactID);
            if (_Contact == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _ContactID);
                this.Close();
                return;
            }

            txtContactID.Text = _Contact.ID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            txtAddress.Text = _Contact.Address;
            dtpDateOfBirth.Value = _Contact.DateOfBirth;

            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Contact.CountryID).CountryName);

            if (_Contact.ImagePath != "")
                try
                {
                    pbImage.Load(_Contact.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            llRemove.Visible = (_Contact.ImagePath != "");


        }
        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llRemove.Visible = false;
            pbImage.ImageLocation = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.Find(cbCountry.Text).CountryID;

            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.CountryID = CountryID;
            _Contact.DateOfBirth = dtpDateOfBirth.Value;

            if (pbImage.ImageLocation != null)
                _Contact.ImagePath = pbImage.ImageLocation.ToString();
            else
                _Contact.ImagePath = "";

            if (_Contact.Save())
                MessageBox.Show($"Contact {_Contact.ID} Saved Successfully");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            lblMode.Text = $"Edit Contact {_Contact.ID}";
            txtContactID.Text = _Contact.ID.ToString();


        }
        private void ConfirmClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Wanna Close The Form?", "Confirm Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
        private void ValidatingControls(object sender, CancelEventArgs e)
        {
            if (sender is TextBox mytextbox)
            {
                if (string.IsNullOrWhiteSpace(mytextbox.Text))
                {
                    e.Cancel = true;
                    mytextbox.Focus();
                    errorProvider1.SetError(mytextbox, "Must Enter The Value");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(mytextbox, "");
                }
            }
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls(sender, e);

        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls(sender, e);

        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
           if(string.IsNullOrWhiteSpace(txtEmail.Text)  ||  !txtEmail.Text.Contains('@') )
                {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email Must Has @");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }
      
        private bool ValidatePhone(string phone)
        {
            for(int i = 0;i<phone.Length;i++)
            {
                if (!char.IsDigit(phone[i]))
                    return false;
            }

            return true;

        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text ) || !ValidatePhone(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Numbers Only");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtPhone, "");
            }

        }
        private void dtpDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls(sender, e);

        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls(sender, e);

        }
   
    }
}
