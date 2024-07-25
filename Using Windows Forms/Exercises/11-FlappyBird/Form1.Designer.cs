namespace FlappyBird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbPipeButtom = new PictureBox();
            pbPipeTop = new PictureBox();
            pbFlappyBird = new PictureBox();
            pbGround = new PictureBox();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pbPipeButtom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGround).BeginInit();
            SuspendLayout();
            // 
            // pbPipeButtom
            // 
            pbPipeButtom.BackgroundImageLayout = ImageLayout.Stretch;
            pbPipeButtom.Image = Properties.Resources.pipe;
            pbPipeButtom.Location = new Point(378, 390);
            pbPipeButtom.Name = "pbPipeButtom";
            pbPipeButtom.Size = new Size(127, 310);
            pbPipeButtom.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPipeButtom.TabIndex = 0;
            pbPipeButtom.TabStop = false;
            // 
            // pbPipeTop
            // 
            pbPipeTop.BackgroundImageLayout = ImageLayout.Stretch;
            pbPipeTop.Image = Properties.Resources.pipedown;
            pbPipeTop.Location = new Point(577, -15);
            pbPipeTop.Name = "pbPipeTop";
            pbPipeTop.Size = new Size(127, 238);
            pbPipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPipeTop.TabIndex = 1;
            pbPipeTop.TabStop = false;
            // 
            // pbFlappyBird
            // 
            pbFlappyBird.BackgroundImageLayout = ImageLayout.Stretch;
            pbFlappyBird.Image = Properties.Resources.bird;
            pbFlappyBird.Location = new Point(79, 192);
            pbFlappyBird.Name = "pbFlappyBird";
            pbFlappyBird.Size = new Size(50, 54);
            pbFlappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlappyBird.TabIndex = 2;
            pbFlappyBird.TabStop = false;
            // 
            // pbGround
            // 
            pbGround.Image = Properties.Resources.ground;
            pbGround.Location = new Point(-11, 644);
            pbGround.Name = "pbGround";
            pbGround.Size = new Size(857, 68);
            pbGround.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGround.TabIndex = 3;
            pbGround.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(12, 665);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(136, 41);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score : 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(835, 712);
            Controls.Add(pbFlappyBird);
            Controls.Add(lblScore);
            Controls.Add(pbGround);
            Controls.Add(pbPipeButtom);
            Controls.Add(pbPipeTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(853, 759);
            MinimumSize = new Size(853, 759);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Bird";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pbPipeButtom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGround).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPipeButtom;
        private PictureBox pbPipeTop;
        private PictureBox pbFlappyBird;
        private PictureBox pbGround;
        private Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private NotifyIcon notifyIcon1;
    }
}
