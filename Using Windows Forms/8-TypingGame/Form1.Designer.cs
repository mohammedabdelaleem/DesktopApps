namespace TypingGame
{
    partial class TypingGame
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
            lblCorrect = new Label();
            lblIncorrect = new Label();
            label3 = new Label();
            lblWord = new Label();
            txtUserWord = new TextBox();
            SuspendLayout();
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.Font = new Font("Segoe UI", 13.8F);
            lblCorrect.Location = new Point(12, 28);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(88, 31);
            lblCorrect.TabIndex = 0;
            lblCorrect.Text = "Correct";
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.Font = new Font("Segoe UI", 13.8F);
            lblIncorrect.Location = new Point(635, 28);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new Size(104, 31);
            lblIncorrect.TabIndex = 1;
            lblIncorrect.Text = "Incorrect";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 410);
            label3.Name = "label3";
            label3.Size = new Size(278, 28);
            label3.TabIndex = 2;
            label3.Text = "Press Enter To Check The Word";
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblWord.Location = new Point(319, 177);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(120, 46);
            lblWord.TabIndex = 3;
            lblWord.Text = "Word";
            // 
            // txtUserWord
            // 
            txtUserWord.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            txtUserWord.Location = new Point(171, 280);
            txtUserWord.Name = "txtUserWord";
            txtUserWord.Size = new Size(436, 53);
            txtUserWord.TabIndex = 4;
            txtUserWord.TextAlign = HorizontalAlignment.Center;
            txtUserWord.KeyUp += CheckWord;
            // 
            // TypingGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 491);
            Controls.Add(txtUserWord);
            Controls.Add(lblWord);
            Controls.Add(label3);
            Controls.Add(lblIncorrect);
            Controls.Add(lblCorrect);
            MaximizeBox = false;
            MaximumSize = new Size(797, 538);
            MinimumSize = new Size(797, 538);
            Name = "TypingGame";
            Text = "Typing Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorrect;
        private Label lblIncorrect;
        private Label label3;
        private Label lblWord;
        private TextBox txtUserWord;
    }
}
