namespace Pizza_Order
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
            label2 = new Label();
            gbPizzaSize = new GroupBox();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            rbSmall = new RadioButton();
            gbToppings = new GroupBox();
            chkOnion = new CheckBox();
            chkOlives = new CheckBox();
            chkGreenPepper = new CheckBox();
            chkTomatoes = new CheckBox();
            chkMusrooms = new CheckBox();
            chkExtraCheese = new CheckBox();
            gbCrustType = new GroupBox();
            rbThick = new RadioButton();
            rbThin = new RadioButton();
            gbEatPlace = new GroupBox();
            rbTakeOut = new RadioButton();
            rbEatIn = new RadioButton();
            btnOrder = new Button();
            btnReset = new Button();
            label1111 = new Label();
            label = new Label();
            Label222 = new Label();
            label3 = new Label();
            Label111 = new Label();
            lblSize = new Label();
            lblToppings = new Label();
            lblWhereToEate = new Label();
            lblCrustType = new Label();
            lblTotalPrice = new Label();
            lblSize1 = new Label();
            groupBox2 = new GroupBox();
            gbPizzaSize.SuspendLayout();
            gbToppings.SuspendLayout();
            gbCrustType.SuspendLayout();
            gbEatPlace.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(424, 26);
            label2.Name = "label2";
            label2.Size = new Size(758, 98);
            label2.TabIndex = 0;
            label2.Text = "Make Your Pizza";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbPizzaSize
            // 
            gbPizzaSize.BackColor = Color.Transparent;
            gbPizzaSize.Controls.Add(rbMedium);
            gbPizzaSize.Controls.Add(rbLarge);
            gbPizzaSize.Controls.Add(rbSmall);
            gbPizzaSize.FlatStyle = FlatStyle.Flat;
            gbPizzaSize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbPizzaSize.ForeColor = Color.DarkOrange;
            gbPizzaSize.Location = new Point(293, 168);
            gbPizzaSize.Name = "gbPizzaSize";
            gbPizzaSize.Size = new Size(157, 239);
            gbPizzaSize.TabIndex = 4;
            gbPizzaSize.TabStop = false;
            gbPizzaSize.Text = "Size";
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Checked = true;
            rbMedium.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMedium.ForeColor = Color.Orange;
            rbMedium.Location = new Point(30, 115);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(99, 29);
            rbMedium.TabIndex = 6;
            rbMedium.TabStop = true;
            rbMedium.Tag = "20";
            rbMedium.Text = "Medium";
            rbMedium.TextAlign = ContentAlignment.TopCenter;
            rbMedium.UseVisualStyleBackColor = true;
            rbMedium.CheckedChanged += rbMedium_CheckedChanged;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbLarge.ForeColor = Color.Orange;
            rbLarge.Location = new Point(30, 174);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(76, 29);
            rbLarge.TabIndex = 5;
            rbLarge.Tag = "40";
            rbLarge.Text = "Large";
            rbLarge.TextAlign = ContentAlignment.TopCenter;
            rbLarge.UseVisualStyleBackColor = true;
            rbLarge.CheckedChanged += rbLarge_CheckedChanged;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSmall.ForeColor = Color.Orange;
            rbSmall.Location = new Point(30, 56);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(76, 29);
            rbSmall.TabIndex = 4;
            rbSmall.Tag = "10";
            rbSmall.Text = "Small";
            rbSmall.TextAlign = ContentAlignment.TopCenter;
            rbSmall.UseVisualStyleBackColor = true;
            rbSmall.CheckedChanged += rbSmall_CheckedChanged;
            // 
            // gbToppings
            // 
            gbToppings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbToppings.AutoSize = true;
            gbToppings.BackColor = Color.Transparent;
            gbToppings.Controls.Add(chkOnion);
            gbToppings.Controls.Add(chkOlives);
            gbToppings.Controls.Add(chkGreenPepper);
            gbToppings.Controls.Add(chkTomatoes);
            gbToppings.Controls.Add(chkMusrooms);
            gbToppings.Controls.Add(chkExtraCheese);
            gbToppings.FlatStyle = FlatStyle.Flat;
            gbToppings.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbToppings.ForeColor = Color.DarkOrange;
            gbToppings.Location = new Point(556, 168);
            gbToppings.Name = "gbToppings";
            gbToppings.Size = new Size(355, 231);
            gbToppings.TabIndex = 11;
            gbToppings.TabStop = false;
            gbToppings.Text = "Toppings";
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkOnion.ForeColor = Color.Orange;
            chkOnion.Location = new Point(209, 57);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(83, 29);
            chkOnion.TabIndex = 16;
            chkOnion.Tag = "5";
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkOlives.ForeColor = Color.Orange;
            chkOlives.Location = new Point(209, 111);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(82, 29);
            chkOlives.TabIndex = 15;
            chkOlives.Tag = "5";
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += chkOlives_CheckedChanged;
            // 
            // chkGreenPepper
            // 
            chkGreenPepper.AutoSize = true;
            chkGreenPepper.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkGreenPepper.ForeColor = Color.Orange;
            chkGreenPepper.Location = new Point(209, 165);
            chkGreenPepper.Name = "chkGreenPepper";
            chkGreenPepper.Size = new Size(140, 29);
            chkGreenPepper.TabIndex = 14;
            chkGreenPepper.Tag = "5";
            chkGreenPepper.Text = "Green Pepper";
            chkGreenPepper.UseVisualStyleBackColor = true;
            chkGreenPepper.CheckedChanged += chkGreenPepper_CheckedChanged;
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTomatoes.ForeColor = Color.Orange;
            chkTomatoes.Location = new Point(37, 165);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(111, 29);
            chkTomatoes.TabIndex = 13;
            chkTomatoes.Tag = "5";
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.UseVisualStyleBackColor = true;
            chkTomatoes.CheckedChanged += chkTomatoes_CheckedChanged;
            // 
            // chkMusrooms
            // 
            chkMusrooms.AutoSize = true;
            chkMusrooms.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMusrooms.ForeColor = Color.Orange;
            chkMusrooms.Location = new Point(37, 111);
            chkMusrooms.Name = "chkMusrooms";
            chkMusrooms.Size = new Size(120, 29);
            chkMusrooms.TabIndex = 12;
            chkMusrooms.Tag = "5";
            chkMusrooms.Text = "Musrooms";
            chkMusrooms.UseVisualStyleBackColor = true;
            chkMusrooms.CheckedChanged += chkMusrooms_CheckedChanged;
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkExtraCheese.ForeColor = Color.Orange;
            chkExtraCheese.Location = new Point(37, 57);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(133, 29);
            chkExtraCheese.TabIndex = 11;
            chkExtraCheese.Tag = "5";
            chkExtraCheese.Text = "Extra Cheese";
            chkExtraCheese.UseVisualStyleBackColor = true;
            chkExtraCheese.CheckedChanged += chkExtraCheese_CheckedChanged;
            // 
            // gbCrustType
            // 
            gbCrustType.BackColor = Color.Transparent;
            gbCrustType.Controls.Add(rbThick);
            gbCrustType.Controls.Add(rbThin);
            gbCrustType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCrustType.ForeColor = Color.DarkOrange;
            gbCrustType.Location = new Point(48, 185);
            gbCrustType.Name = "gbCrustType";
            gbCrustType.Size = new Size(170, 155);
            gbCrustType.TabIndex = 15;
            gbCrustType.TabStop = false;
            gbCrustType.Text = "Crust Type";
            // 
            // rbThick
            // 
            rbThick.AutoSize = true;
            rbThick.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbThick.ForeColor = Color.Orange;
            rbThick.Location = new Point(28, 100);
            rbThick.Name = "rbThick";
            rbThick.Size = new Size(119, 29);
            rbThick.TabIndex = 16;
            rbThick.Tag = "30";
            rbThick.Text = "Thick Crust";
            rbThick.TextAlign = ContentAlignment.TopCenter;
            rbThick.UseVisualStyleBackColor = true;
            rbThick.CheckedChanged += rbThick_CheckedChanged;
            // 
            // rbThin
            // 
            rbThin.AutoSize = true;
            rbThin.Checked = true;
            rbThin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbThin.ForeColor = Color.Orange;
            rbThin.Location = new Point(28, 53);
            rbThin.Name = "rbThin";
            rbThin.Size = new Size(112, 29);
            rbThin.TabIndex = 15;
            rbThin.TabStop = true;
            rbThin.Tag = "10";
            rbThin.Text = "Thin Crust";
            rbThin.TextAlign = ContentAlignment.TopCenter;
            rbThin.UseVisualStyleBackColor = true;
            rbThin.CheckedChanged += rbThin_CheckedChanged;
            // 
            // gbEatPlace
            // 
            gbEatPlace.BackColor = Color.Transparent;
            gbEatPlace.Controls.Add(rbTakeOut);
            gbEatPlace.Controls.Add(rbEatIn);
            gbEatPlace.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbEatPlace.ForeColor = Color.DarkOrange;
            gbEatPlace.Location = new Point(568, 445);
            gbEatPlace.Name = "gbEatPlace";
            gbEatPlace.Size = new Size(337, 106);
            gbEatPlace.TabIndex = 16;
            gbEatPlace.TabStop = false;
            gbEatPlace.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            rbTakeOut.AutoSize = true;
            rbTakeOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbTakeOut.ForeColor = Color.Orange;
            rbTakeOut.Location = new Point(157, 53);
            rbTakeOut.Name = "rbTakeOut";
            rbTakeOut.Size = new Size(102, 29);
            rbTakeOut.TabIndex = 16;
            rbTakeOut.Tag = "0";
            rbTakeOut.Text = "Take Out";
            rbTakeOut.TextAlign = ContentAlignment.TopCenter;
            rbTakeOut.UseVisualStyleBackColor = true;
            rbTakeOut.CheckedChanged += rbTakeOut_CheckedChanged;
            // 
            // rbEatIn
            // 
            rbEatIn.AutoSize = true;
            rbEatIn.Checked = true;
            rbEatIn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbEatIn.ForeColor = Color.Orange;
            rbEatIn.Location = new Point(28, 53);
            rbEatIn.Name = "rbEatIn";
            rbEatIn.Size = new Size(77, 29);
            rbEatIn.TabIndex = 15;
            rbEatIn.TabStop = true;
            rbEatIn.Tag = "";
            rbEatIn.Text = "Eat In";
            rbEatIn.TextAlign = ContentAlignment.TopCenter;
            rbEatIn.UseVisualStyleBackColor = true;
            rbEatIn.CheckedChanged += rbEatIn_CheckedChanged;
            // 
            // btnOrder
            // 
            btnOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOrder.BackColor = Color.Transparent;
            btnOrder.FlatAppearance.BorderSize = 3;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.Orange;
            btnOrder.Location = new Point(852, 591);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(146, 55);
            btnOrder.TabIndex = 20;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.BackColor = Color.Transparent;
            btnReset.FlatAppearance.BorderSize = 3;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Orange;
            btnReset.Location = new Point(621, 591);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 55);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label1111
            // 
            label1111.AutoSize = true;
            label1111.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1111.ForeColor = Color.Orange;
            label1111.Location = new Point(25, 56);
            label1111.Name = "label1111";
            label1111.Size = new Size(67, 28);
            label1111.TabIndex = 27;
            label1111.Text = "Size : ";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label.ForeColor = Color.Orange;
            label.Location = new Point(25, 102);
            label.Name = "label";
            label.Size = new Size(114, 28);
            label.TabIndex = 29;
            label.Text = "Toppings : ";
            // 
            // Label222
            // 
            Label222.AutoSize = true;
            Label222.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Label222.ForeColor = Color.Orange;
            Label222.Location = new Point(25, 211);
            Label222.Name = "Label222";
            Label222.Size = new Size(129, 28);
            Label222.TabIndex = 31;
            Label222.Text = "Crust  Type :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(25, 265);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 33;
            label3.Text = "Where To Eat :";
            // 
            // Label111
            // 
            Label111.AutoSize = true;
            Label111.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label111.ForeColor = Color.Orange;
            Label111.Location = new Point(18, 346);
            Label111.Name = "Label111";
            Label111.Size = new Size(181, 37);
            Label111.TabIndex = 35;
            Label111.Text = "Total Price :";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Enabled = false;
            lblSize.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(165, 61);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 25);
            lblSize.TabIndex = 36;
            lblSize.Visible = false;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToppings.ForeColor = Color.Snow;
            lblToppings.Location = new Point(96, 130);
            lblToppings.MaximumSize = new Size(280, 300);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(118, 25);
            lblToppings.TabIndex = 37;
            lblToppings.Text = "No Toppings";
            // 
            // lblWhereToEate
            // 
            lblWhereToEate.AutoSize = true;
            lblWhereToEate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblWhereToEate.ForeColor = Color.Snow;
            lblWhereToEate.Location = new Point(166, 265);
            lblWhereToEate.Name = "lblWhereToEate";
            lblWhereToEate.Size = new Size(61, 25);
            lblWhereToEate.TabIndex = 38;
            lblWhereToEate.Text = "Eat In";
            // 
            // lblCrustType
            // 
            lblCrustType.AutoSize = true;
            lblCrustType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblCrustType.ForeColor = Color.Snow;
            lblCrustType.Location = new Point(148, 211);
            lblCrustType.Name = "lblCrustType";
            lblCrustType.Size = new Size(50, 25);
            lblCrustType.TabIndex = 39;
            lblCrustType.Text = "Thin";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalPrice.Location = new Point(205, 357);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(105, 81);
            lblTotalPrice.TabIndex = 40;
            lblTotalPrice.Text = "$0";
            // 
            // lblSize1
            // 
            lblSize1.AutoSize = true;
            lblSize1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize1.ForeColor = Color.Snow;
            lblSize1.Location = new Point(87, 56);
            lblSize1.Name = "lblSize1";
            lblSize1.Size = new Size(77, 23);
            lblSize1.TabIndex = 41;
            lblSize1.Text = "Medium";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lblSize1);
            groupBox2.Controls.Add(lblTotalPrice);
            groupBox2.Controls.Add(lblCrustType);
            groupBox2.Controls.Add(lblWhereToEate);
            groupBox2.Controls.Add(lblToppings);
            groupBox2.Controls.Add(lblSize);
            groupBox2.Controls.Add(Label111);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label);
            groupBox2.Controls.Add(Label222);
            groupBox2.Controls.Add(label1111);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Orange;
            groupBox2.Location = new Point(1034, 168);
            groupBox2.Margin = new Padding(3, 3, 0, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 3, 0, 3);
            groupBox2.Size = new Size(430, 462);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Summary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PizzaBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1492, 729);
            Controls.Add(groupBox2);
            Controls.Add(gbEatPlace);
            Controls.Add(gbCrustType);
            Controls.Add(gbToppings);
            Controls.Add(gbPizzaSize);
            Controls.Add(label2);
            Controls.Add(btnOrder);
            Controls.Add(btnReset);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1510, 776);
            Name = "Form1";
            Text = "Pizza Order";
            Load += Form1_Load;
            gbPizzaSize.ResumeLayout(false);
            gbPizzaSize.PerformLayout();
            gbToppings.ResumeLayout(false);
            gbToppings.PerformLayout();
            gbCrustType.ResumeLayout(false);
            gbCrustType.PerformLayout();
            gbEatPlace.ResumeLayout(false);
            gbEatPlace.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox gbPizzaSize;
        private RadioButton rbMedium;
        private RadioButton rbLarge;
        private RadioButton rbSmall;
        private GroupBox gbToppings;
        private CheckBox chkOnion;
        private CheckBox chkOlives;
        private CheckBox chkGreenPepper;
        private CheckBox chkTomatoes;
        private CheckBox chkMusrooms;
        private CheckBox chkExtraCheese;
        private GroupBox gbCrustType;
        private RadioButton rbThick;
        private RadioButton rbThin;
        private GroupBox gbEatPlace;
        private RadioButton rbTakeOut;
        private RadioButton rbEatIn;
        private Button btnOrder;
        private Button btnReset;
        private Label label1111;
        private Label label;
        private Label Label222;
        private Label label3;
        private Label Label111;
        private Label lblSize;
        private Label lblToppings;
        private Label lblWhereToEate;
        private Label lblCrustType;
        private Label lblTotalPrice;
        private Label lblSize1;
        private GroupBox groupBox2;
    }
}
