namespace TicTacToe
{
    partial class frmLogin
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
            lblP1Name = new Label();
            P1Header = new Label();
            txtP1Name = new TextBox();
            txtP2Name = new TextBox();
            lblP2Header = new Label();
            lblP2Name = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCancle = new Button();
            btnPlay = new Button();
            LoginErrorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblP1Name
            // 
            lblP1Name.AutoSize = true;
            lblP1Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP1Name.Location = new Point(1, 83);
            lblP1Name.Name = "lblP1Name";
            lblP1Name.Size = new Size(75, 31);
            lblP1Name.TabIndex = 0;
            lblP1Name.Text = "Name";
            // 
            // P1Header
            // 
            P1Header.AutoSize = true;
            P1Header.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1Header.ForeColor = Color.Red;
            P1Header.Location = new Point(99, 16);
            P1Header.Name = "P1Header";
            P1Header.Size = new Size(217, 33);
            P1Header.TabIndex = 2;
            P1Header.Text = "Player1 Info";
            // 
            // txtP1Name
            // 
            txtP1Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtP1Name.Location = new Point(82, 82);
            txtP1Name.Name = "txtP1Name";
            txtP1Name.Size = new Size(350, 34);
            txtP1Name.TabIndex = 3;
            txtP1Name.Validating += TextBoxNameValidating;
            // 
            // txtP2Name
            // 
            txtP2Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtP2Name.Location = new Point(82, 77);
            txtP2Name.Name = "txtP2Name";
            txtP2Name.Size = new Size(350, 34);
            txtP2Name.TabIndex = 6;
            txtP2Name.Validating += TextBoxNameValidating;
            // 
            // lblP2Header
            // 
            lblP2Header.AutoSize = true;
            lblP2Header.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblP2Header.ForeColor = Color.Red;
            lblP2Header.Location = new Point(99, 12);
            lblP2Header.Name = "lblP2Header";
            lblP2Header.Size = new Size(217, 33);
            lblP2Header.TabIndex = 5;
            lblP2Header.Text = "Player2 Info";
            // 
            // lblP2Name
            // 
            lblP2Name.AutoSize = true;
            lblP2Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP2Name.Location = new Point(3, 80);
            lblP2Name.Name = "lblP2Name";
            lblP2Name.Size = new Size(75, 31);
            lblP2Name.TabIndex = 4;
            lblP2Name.Text = "Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(P1Header);
            panel1.Controls.Add(lblP1Name);
            panel1.Controls.Add(txtP1Name);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 152);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblP2Header);
            panel2.Controls.Add(lblP2Name);
            panel2.Controls.Add(txtP2Name);
            panel2.Location = new Point(1, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 145);
            panel2.TabIndex = 8;
            // 
            // btnCancle
            // 
            btnCancle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancle.Location = new Point(241, 342);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(135, 42);
            btnCancle.TabIndex = 9;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(66, 342);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(135, 42);
            btnPlay.TabIndex = 10;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // LoginErrorProvider
            // 
            LoginErrorProvider.ContainerControl = this;
            // 
            // frmLogin
            // 
            AcceptButton = btnPlay;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancle;
            ClientSize = new Size(470, 406);
            Controls.Add(btnCancle);
            Controls.Add(panel2);
            Controls.Add(btnPlay);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MaximumSize = new Size(488, 453);
            MinimizeBox = false;
            MinimumSize = new Size(488, 453);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblP1Name;
        private Label P1Header;
        private TextBox txtP1Name;
        private TextBox txtP2Name;
        private Label lblP2Header;
        private Label lblP2Name;
        private Panel panel1;
        private Panel panel2;
        private Button btnCancle;
        private Button btnPlay;
        private ErrorProvider LoginErrorProvider;
    }
}