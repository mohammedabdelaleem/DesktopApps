namespace Listview
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
            listView1 = new ListView();
            Name1 = new ColumnHeader();
            DataModified = new ColumnHeader();
            Type = new ColumnHeader();
            Size = new ColumnHeader();
            imageList2 = new ImageList(components);
            imageList1 = new ImageList(components);
            label2 = new Label();
            txtName1 = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnAddRandom = new Button();
            groupBox1 = new GroupBox();
            rbList = new RadioButton();
            rbTiles = new RadioButton();
            rbDetails = new RadioButton();
            rbLargeIcons = new RadioButton();
            rbSmallIcons = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.WindowFrame;
            listView1.Columns.AddRange(new ColumnHeader[] { Name1, DataModified, Type, Size });
            listView1.Font = new Font("Segoe UI", 12F);
            listView1.ForeColor = Color.White;
            listView1.LargeImageList = imageList2;
            listView1.Location = new Point(24, 137);
            listView1.Name = "listView1";
            listView1.Size = new Size(972, 498);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Name1
            // 
            Name1.Text = "Name";
            // 
            // DataModified
            // 
            DataModified.Text = "Date Modified";
            // 
            // Type
            // 
            Type.Text = "Type";
            // 
            // Size
            // 
            Size.Text = "Size";
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "FolderIcon.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "FolderIcon.png");
            imageList1.Images.SetKeyName(1, "pdfIcon.png");
            imageList1.Images.SetKeyName(2, "photo.png");
            imageList1.Images.SetKeyName(3, "textIcon.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtName1
            // 
            txtName1.Location = new Point(107, 69);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(227, 27);
            txtName1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(447, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 50);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(619, 48);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 50);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddRandom
            // 
            btnAddRandom.Location = new Point(791, 48);
            btnAddRandom.Name = "btnAddRandom";
            btnAddRandom.Size = new Size(128, 50);
            btnAddRandom.TabIndex = 7;
            btnAddRandom.Text = "Add Random";
            btnAddRandom.UseVisualStyleBackColor = true;
            btnAddRandom.Click += btnAddRandom_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbList);
            groupBox1.Controls.Add(rbTiles);
            groupBox1.Controls.Add(rbDetails);
            groupBox1.Controls.Add(rbLargeIcons);
            groupBox1.Controls.Add(rbSmallIcons);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(1058, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 401);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "View";
            // 
            // rbList
            // 
            rbList.AutoSize = true;
            rbList.Location = new Point(38, 329);
            rbList.Name = "rbList";
            rbList.Size = new Size(70, 36);
            rbList.TabIndex = 12;
            rbList.Text = "List";
            rbList.UseVisualStyleBackColor = true;
            rbList.CheckedChanged += rbList_CheckedChanged;
            // 
            // rbTiles
            // 
            rbTiles.AutoSize = true;
            rbTiles.Location = new Point(38, 261);
            rbTiles.Name = "rbTiles";
            rbTiles.Size = new Size(73, 36);
            rbTiles.TabIndex = 13;
            rbTiles.Text = "Tile";
            rbTiles.UseVisualStyleBackColor = true;
            rbTiles.CheckedChanged += rbTiles_CheckedChanged;
            // 
            // rbDetails
            // 
            rbDetails.AutoSize = true;
            rbDetails.Location = new Point(38, 57);
            rbDetails.Name = "rbDetails";
            rbDetails.Size = new Size(107, 36);
            rbDetails.TabIndex = 11;
            rbDetails.Text = "Details";
            rbDetails.UseVisualStyleBackColor = true;
            rbDetails.CheckedChanged += rbDetails_CheckedChanged;
            // 
            // rbLargeIcons
            // 
            rbLargeIcons.AutoSize = true;
            rbLargeIcons.Location = new Point(38, 125);
            rbLargeIcons.Name = "rbLargeIcons";
            rbLargeIcons.Size = new Size(155, 36);
            rbLargeIcons.TabIndex = 9;
            rbLargeIcons.Text = "Large Icons";
            rbLargeIcons.UseVisualStyleBackColor = true;
            rbLargeIcons.CheckedChanged += rbLargeIcons_CheckedChanged;
            // 
            // rbSmallIcons
            // 
            rbSmallIcons.AutoSize = true;
            rbSmallIcons.Location = new Point(38, 193);
            rbSmallIcons.Name = "rbSmallIcons";
            rbSmallIcons.Size = new Size(155, 36);
            rbSmallIcons.TabIndex = 10;
            rbSmallIcons.Text = "Small Icons";
            rbSmallIcons.UseVisualStyleBackColor = true;
            rbSmallIcons.CheckedChanged += rbSmallIcons_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 609);
            Controls.Add(groupBox1);
            Controls.Add(btnAddRandom);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtName1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label2;
        private TextBox txtName1;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnAddRandom;
        private GroupBox groupBox1;
        private RadioButton rbList;
        private RadioButton rbTiles;
        private RadioButton rbDetails;
        private RadioButton rbLargeIcons;
        private RadioButton rbSmallIcons;
        private ColumnHeader Name1;
        private ColumnHeader DataModified;
        private ColumnHeader Type;
        private ImageList imageList1;
        private ImageList imageList2;
        private ColumnHeader Size;
    }
}
