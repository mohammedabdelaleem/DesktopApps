namespace ImaegGallary
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
            btnNext = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(519, 485);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(136, 56);
            btnNext.TabIndex = 0;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += GoNext;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(177, 485);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 56);
            btnBack.TabIndex = 1;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += GoBack;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Zero;
            pictureBox1.Location = new Point(120, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(607, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 586);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            MaximizeBox = false;
            MaximumSize = new Size(891, 633);
            MinimumSize = new Size(891, 633);
            Name = "Form1";
            Text = "Image Galary";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNext;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}
