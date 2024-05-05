namespace WindowsFormsTestApp
{
    partial class Startup
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
            btnPictureboxExample = new Button();
            btnPictureboxTask = new Button();
            btnDrawing = new Button();
            SuspendLayout();
            // 
            // btnPictureboxExample
            // 
            btnPictureboxExample.Location = new Point(155, 33);
            btnPictureboxExample.Name = "btnPictureboxExample";
            btnPictureboxExample.Size = new Size(410, 76);
            btnPictureboxExample.TabIndex = 0;
            btnPictureboxExample.Text = "PictureBox Simple Example";
            btnPictureboxExample.UseVisualStyleBackColor = true;
            btnPictureboxExample.Click += btnPictureboxExample_Click;
            // 
            // btnPictureboxTask
            // 
            btnPictureboxTask.Location = new Point(155, 156);
            btnPictureboxTask.Name = "btnPictureboxTask";
            btnPictureboxTask.Size = new Size(410, 76);
            btnPictureboxTask.TabIndex = 1;
            btnPictureboxTask.Text = "Picturebox Task";
            btnPictureboxTask.UseVisualStyleBackColor = true;
            btnPictureboxTask.Click += button2_Click;
            // 
            // btnDrawing
            // 
            btnDrawing.Location = new Point(155, 279);
            btnDrawing.Name = "btnDrawing";
            btnDrawing.Size = new Size(410, 76);
            btnDrawing.TabIndex = 2;
            btnDrawing.Text = "Drawing Task";
            btnDrawing.UseVisualStyleBackColor = true;
            btnDrawing.Click += btnDrawing_Click;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 422);
            Controls.Add(btnDrawing);
            Controls.Add(btnPictureboxTask);
            Controls.Add(btnPictureboxExample);
            Name = "Startup";
            Text = "Startup";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPictureboxExample;
        private Button btnPictureboxTask;
        private Button btnDrawing;
    }
}