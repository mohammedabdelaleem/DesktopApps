namespace TicTacToe
{
    partial class frmStop
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
            btnResume = new Button();
            btnNewGame = new Button();
            btnViewResults = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnResume
            // 
            btnResume.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResume.Location = new Point(52, 22);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(208, 46);
            btnResume.TabIndex = 0;
            btnResume.Text = "Resume ";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewGame.Location = new Point(52, 86);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(208, 46);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnViewResults
            // 
            btnViewResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewResults.Location = new Point(52, 150);
            btnViewResults.Name = "btnViewResults";
            btnViewResults.Size = new Size(208, 46);
            btnViewResults.TabIndex = 2;
            btnViewResults.Text = "View Results";
            btnViewResults.UseVisualStyleBackColor = true;
            btnViewResults.Click += btnViewResults_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.Location = new Point(52, 214);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(208, 46);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmStop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(318, 297);
            Controls.Add(btnClose);
            Controls.Add(btnViewResults);
            Controls.Add(btnNewGame);
            Controls.Add(btnResume);
            Name = "frmStop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stop";
            ResumeLayout(false);
        }

        #endregion

        private Button btnResume;
        private Button btnNewGame;
        private Button btnViewResults;
        private Button btnClose;
    }
}