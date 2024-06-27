namespace DialogsSimpleProject
{
    public partial class RTF : Form
    {
        public RTF()
        {
            InitializeComponent();
        }
        private void RTF_Load(object sender, EventArgs e)
        {
            btnExit.Click += (sender, e) => this.Close();
            dlgOpen.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            dlgSave.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK) // user select a file and choose open 
            {
                switch (dlgOpen.FilterIndex)
                {
                    case 1:
                        txtInput.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        txtInput.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
                // txtInput.LoadFile(dlgOpen.FileName); // Exception: File Extension 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                switch (dlgSave.FilterIndex)
                {
                    case 1:
                        txtInput.SaveFile(dlgSave.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        // Convert the content to plain text before saving
                        string plainText = txtInput.Text;
                        System.IO.File.WriteAllText(dlgSave.FileName, plainText);
                        break;
                }
            }

            #region This is a shortcut code but i made a problems with me
            //if (dlgSave.ShowDialog() == DialogResult.OK)
            //    txtInput.SaveFile(dlgSave.FileName, (RichTextBoxStreamType)dlgOpen.FilterIndex - 1); 
            #endregion
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText.Length > 0)
                dlgFont.Font = txtInput.SelectionFont;

            if (dlgFont.ShowDialog() == DialogResult.OK)
                txtInput.SelectionFont = dlgFont.Font;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText.Length > 0)
                dlgColor.Color = txtInput.SelectionColor;

            if (dlgColor.ShowDialog() == DialogResult.OK)
                txtInput.SelectionColor = dlgColor.Color;
        }

        DlgCustom custom = new DlgCustom(); 
        private void btnMyDlg_Click(object sender, EventArgs e)
        {
            custom.CustomText = "Write Here..";
            if (custom.ShowDialog()==DialogResult.OK)
            {
                txtInput.AppendText(custom.CustomText);
            }
        }
    }
}
