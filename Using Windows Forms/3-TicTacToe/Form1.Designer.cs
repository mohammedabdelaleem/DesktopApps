namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblTurn = new Label();
            label3 = new Label();
            lblWinner = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnNewGame = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(58, 252);
            label1.Name = "label1";
            label1.Size = new Size(130, 62);
            label1.TabIndex = 0;
            label1.Text = "Turn";
            // 
            // lblTurn
            // 
            lblTurn.AccessibleDescription = "4";
            lblTurn.AutoSize = true;
            lblTurn.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTurn.ForeColor = Color.Lime;
            lblTurn.Location = new Point(39, 314);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(183, 60);
            lblTurn.TabIndex = 1;
            lblTurn.Text = "Player1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(39, 420);
            label3.Name = "label3";
            label3.Size = new Size(188, 62);
            label3.TabIndex = 2;
            label3.Text = "Winner";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWinner.ForeColor = Color.Lime;
            lblWinner.Location = new Point(23, 482);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(253, 60);
            lblWinner.TabIndex = 3;
            lblWinner.Text = "In Progress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(463, 33);
            label2.Name = "label2";
            label2.Size = new Size(512, 93);
            label2.TabIndex = 4;
            label2.Text = "Tic Tac Toe ";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.MainIcom;
            pictureBox1.Image = Properties.Resources.MainIcom;
            pictureBox1.Location = new Point(-1, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewGame.ForeColor = SystemColors.ActiveCaptionText;
            btnNewGame.Location = new Point(32, 598);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(183, 52);
            btnNewGame.TabIndex = 6;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.question_mark_96;
            button1.Location = new Point(492, 208);
            button1.Name = "button1";
            button1.Size = new Size(120, 96);
            button1.TabIndex = 7;
            button1.Tag = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.question_mark_96;
            button2.Location = new Point(660, 208);
            button2.Name = "button2";
            button2.Size = new Size(120, 96);
            button2.TabIndex = 8;
            button2.Tag = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.question_mark_96;
            button3.Location = new Point(831, 208);
            button3.Name = "button3";
            button3.Size = new Size(120, 96);
            button3.TabIndex = 9;
            button3.Tag = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.question_mark_96;
            button4.Location = new Point(492, 381);
            button4.Name = "button4";
            button4.Size = new Size(120, 96);
            button4.TabIndex = 10;
            button4.Tag = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.question_mark_96;
            button5.Location = new Point(660, 381);
            button5.Name = "button5";
            button5.Size = new Size(120, 96);
            button5.TabIndex = 11;
            button5.Tag = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.question_mark_96;
            button6.Location = new Point(831, 381);
            button6.Name = "button6";
            button6.Size = new Size(120, 96);
            button6.TabIndex = 12;
            button6.Tag = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.question_mark_96;
            button7.Location = new Point(492, 539);
            button7.Name = "button7";
            button7.Size = new Size(120, 96);
            button7.TabIndex = 13;
            button7.Tag = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.question_mark_96;
            button8.Location = new Point(660, 539);
            button8.Name = "button8";
            button8.Size = new Size(120, 96);
            button8.TabIndex = 14;
            button8.Tag = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = Properties.Resources.question_mark_96;
            button9.Location = new Point(831, 539);
            button9.Name = "button9";
            button9.Size = new Size(120, 96);
            button9.TabIndex = 15;
            button9.Tag = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1335, 692);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnNewGame);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(lblWinner);
            Controls.Add(label3);
            Controls.Add(lblTurn);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTurn;
        private Label label3;
        private Label lblWinner;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnNewGame;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
