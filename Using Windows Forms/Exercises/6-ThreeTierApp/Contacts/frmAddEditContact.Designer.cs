namespace ContactsWF
{
    partial class frmAddEditContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMode = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtContactID = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            cbCountry = new ComboBox();
            btnClose = new Button();
            btnSave = new Button();
            llRemove = new LinkLabel();
            llSetImage = new LinkLabel();
            pbImage = new PictureBox();
            dlgOpen = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(47, 287);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 229);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(47, 173);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(47, 120);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "ContactID";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.Location = new Point(306, 40);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(126, 38);
            lblMode.TabIndex = 4;
            lblMode.Text = "lblMode";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(47, 339);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 5;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(47, 544);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(167, 395);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(265, 27);
            dtpDateOfBirth.TabIndex = 5;
            dtpDateOfBirth.Validating += dtpDateOfBirth_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(47, 395);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 8;
            label7.Text = "DateOfBirth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(47, 474);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 9;
            label8.Text = "Country";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 291);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 27);
            txtEmail.TabIndex = 3;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(167, 233);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(193, 27);
            txtLastName.TabIndex = 2;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(167, 177);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(193, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // txtContactID
            // 
            txtContactID.Location = new Point(167, 124);
            txtContactID.Name = "txtContactID";
            txtContactID.Size = new Size(193, 27);
            txtContactID.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(167, 339);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 27);
            txtPhone.TabIndex = 4;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(167, 548);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(231, 73);
            txtAddress.TabIndex = 7;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(167, 478);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(219, 28);
            cbCountry.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(214, 650);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 43);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(397, 650);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 43);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // llRemove
            // 
            llRemove.AutoSize = true;
            llRemove.Font = new Font("Segoe UI", 12F);
            llRemove.Location = new Point(653, 127);
            llRemove.Name = "llRemove";
            llRemove.Size = new Size(82, 28);
            llRemove.TabIndex = 9;
            llRemove.TabStop = true;
            llRemove.Text = "Remove";
            llRemove.LinkClicked += llRemove_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Font = new Font("Segoe UI", 12F);
            llSetImage.Location = new Point(525, 127);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(99, 28);
            llSetImage.TabIndex = 8;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(555, 173);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(163, 160);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 21;
            pbImage.TabStop = false;
            // 
            // dlgOpen
            // 
            dlgOpen.FileName = "openFileDialog1";
            dlgOpen.InitialDirectory = "d:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditContact
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(768, 705);
            Controls.Add(pbImage);
            Controls.Add(llSetImage);
            Controls.Add(llRemove);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(cbCountry);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtContactID);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblMode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(786, 752);
            MinimumSize = new Size(786, 752);
            Name = "frmAddEditContact";
            Text = "frmAddEditContact";
            FormClosing += ConfirmClosing;
            Load += frmAddEditContact_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblMode;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpDateOfBirth;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtContactID;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox cbCountry;
        private Button btnClose;
        private Button btnSave;
        private LinkLabel llRemove;
        private LinkLabel llSetImage;
        private PictureBox pbImage;
        private OpenFileDialog dlgOpen;
        private ErrorProvider errorProvider1;
    }
}