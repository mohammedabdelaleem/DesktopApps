namespace DialogsSimpleProject
{
    partial class RTF
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
            txtInput = new RichTextBox();
            btnExit = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            btnMyDlg = new Button();
            btnColor = new Button();
            btnFont = new Button();
            dlgOpen = new OpenFileDialog();
            dlgSave = new SaveFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(12, 57);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(776, 346);
            txtInput.TabIndex = 3;
            txtInput.Text = "";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(674, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 39);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Location = new Point(347, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 39);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(113, 39);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnMyDlg
            // 
            btnMyDlg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMyDlg.Location = new Point(675, 409);
            btnMyDlg.Name = "btnMyDlg";
            btnMyDlg.Size = new Size(113, 39);
            btnMyDlg.TabIndex = 6;
            btnMyDlg.Text = "My Dlg";
            btnMyDlg.UseVisualStyleBackColor = true;
            btnMyDlg.Click += btnMyDlg_Click;
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Bottom;
            btnColor.Location = new Point(347, 409);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(113, 39);
            btnColor.TabIndex = 5;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnFont
            // 
            btnFont.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFont.Location = new Point(12, 409);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(113, 39);
            btnFont.TabIndex = 4;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // dlgOpen
            // 
            dlgOpen.InitialDirectory = "D:";
            // 
            // RTF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFont);
            Controls.Add(btnColor);
            Controls.Add(btnMyDlg);
            Controls.Add(btnOpen);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(txtInput);
            MinimumSize = new Size(818, 497);
            Name = "RTF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RTF";
            Load += RTF_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtInput;
        private Button btnExit;
        private Button btnSave;
        private Button btnOpen;
        private Button btnMyDlg;
        private Button btnColor;
        private Button btnFont;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private FontDialog dlgFont;
        private ColorDialog dlgColor;
    }
}
