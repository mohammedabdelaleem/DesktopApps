namespace TicTacToe
{
    partial class frmFinalResults
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
            dgvFinalResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFinalResults).BeginInit();
            SuspendLayout();
            // 
            // dgvFinalResults
            // 
            dgvFinalResults.AllowUserToAddRows = false;
            dgvFinalResults.AllowUserToDeleteRows = false;
            dgvFinalResults.AllowUserToOrderColumns = true;
            dgvFinalResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinalResults.Dock = DockStyle.Fill;
            dgvFinalResults.Location = new Point(0, 0);
            dgvFinalResults.Name = "dgvFinalResults";
            dgvFinalResults.ReadOnly = true;
            dgvFinalResults.RowHeadersWidth = 51;
            dgvFinalResults.Size = new Size(794, 626);
            dgvFinalResults.TabIndex = 0;
            // 
            // frmFinalResults
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 626);
            Controls.Add(dgvFinalResults);
            MaximizeBox = false;
            MaximumSize = new Size(812, 673);
            MinimumSize = new Size(812, 673);
            Name = "frmFinalResults";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Final Results";
            Load += frmFinalResults_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFinalResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFinalResults;
    }
}