namespace WindowsFormsTestApp
{
    partial class PictureBoxTask
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
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            lblMainTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Boy;
            pictureBox1.Image = Properties.Resources.Boy;
            pictureBox1.Location = new Point(316, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(316, 499);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 35);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Tag = "BOY";
            radioButton1.Text = "Boy";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(484, 499);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 35);
            radioButton2.TabIndex = 2;
            radioButton2.Tag = "Girl";
            radioButton2.Text = "Girl";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(832, 499);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(72, 35);
            radioButton3.TabIndex = 3;
            radioButton3.Tag = "Pen";
            radioButton3.Text = "Pen";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(651, 499);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(85, 35);
            radioButton4.TabIndex = 4;
            radioButton4.Tag = "Book";
            radioButton4.Text = "Book";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMainTitle.ForeColor = Color.Red;
            lblMainTitle.Location = new Point(532, -1);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(214, 106);
            lblMainTitle.TabIndex = 5;
            lblMainTitle.Text = "Title";
            // 
            // PictureBoxTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 652);
            Controls.Add(lblMainTitle);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Name = "PictureBoxTask";
            Tag = "BOY";
            Text = "PictureBoxTask";
            Load += PictureBoxTask_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label lblMainTitle;
    }
}