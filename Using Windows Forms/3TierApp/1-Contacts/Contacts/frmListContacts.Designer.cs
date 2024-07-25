namespace ContactsWF
{
    partial class frmListContacts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvContactsList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnAddNewContact = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactsList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvContactsList
            // 
            dgvContactsList.AllowUserToAddRows = false;
            dgvContactsList.AllowUserToDeleteRows = false;
            dgvContactsList.AllowUserToOrderColumns = true;
            dgvContactsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactsList.ContextMenuStrip = contextMenuStrip1;
            dgvContactsList.Dock = DockStyle.Bottom;
            dgvContactsList.Location = new Point(0, 115);
            dgvContactsList.Name = "dgvContactsList";
            dgvContactsList.ReadOnly = true;
            dgvContactsList.RowHeadersWidth = 51;
            dgvContactsList.Size = new Size(1169, 573);
            dgvContactsList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 56);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.EditIcon;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            editToolStripMenuItem.Size = new Size(162, 26);
            editToolStripMenuItem.Text = "&Edit ";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.deleteIcon;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(162, 26);
            deleteToolStripMenuItem.Text = "Del&ete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnAddNewContact
            // 
            btnAddNewContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewContact.Location = new Point(944, 26);
            btnAddNewContact.Name = "btnAddNewContact";
            btnAddNewContact.Size = new Size(194, 62);
            btnAddNewContact.TabIndex = 1;
            btnAddNewContact.Text = "Add New Contact";
            btnAddNewContact.UseVisualStyleBackColor = true;
            btnAddNewContact.Click += btnAddNewContact_Click;
            // 
            // frmListContacts
            // 
            AcceptButton = btnAddNewContact;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 688);
            Controls.Add(btnAddNewContact);
            Controls.Add(dgvContactsList);
            MaximizeBox = false;
            MaximumSize = new Size(1187, 735);
            MinimumSize = new Size(1187, 735);
            Name = "frmListContacts";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactsList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContactsList;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button btnAddNewContact;
    }
}
