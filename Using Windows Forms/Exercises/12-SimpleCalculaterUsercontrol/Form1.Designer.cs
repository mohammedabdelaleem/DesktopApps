namespace Usercontrols
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ctrlSimpleCalculater1 = new ctrlSimpleCalculater();
            SuspendLayout();
            // 
            // ctrlSimpleCalculater1
            // 
            ctrlSimpleCalculater1.BackColor = SystemColors.ButtonShadow;
            ctrlSimpleCalculater1.Dock = DockStyle.Fill;
            ctrlSimpleCalculater1.Location = new Point(0, 0);
            ctrlSimpleCalculater1.Name = "ctrlSimpleCalculater1";
            ctrlSimpleCalculater1.Size = new Size(349, 319);
            ctrlSimpleCalculater1.TabIndex = 0;
            ctrlSimpleCalculater1.Load += ctrlSimpleCalculater1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 319);
            Controls.Add(ctrlSimpleCalculater1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UC - Simple Calculator";
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ctrlSimpleCalculater ctrlSimpleCalculater1;
    }
}
