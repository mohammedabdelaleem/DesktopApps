namespace DialogsSimpleProject
{
    partial class DlgCustom
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
            txtDlgCustom = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtDlgCustom
            // 
            txtDlgCustom.Location = new Point(23, 22);
            txtDlgCustom.Multiline = true;
            txtDlgCustom.Name = "txtDlgCustom";
            txtDlgCustom.Size = new Size(681, 34);
            txtDlgCustom.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(537, 80);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(167, 48);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(23, 83);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 45);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // DlgCustom
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(727, 140);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtDlgCustom);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DlgCustom";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "DlgCustom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDlgCustom;
        private Button btnOK;
        private Button btnCancel;
    }
}