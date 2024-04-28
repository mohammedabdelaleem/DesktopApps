namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float GetSelectedSizePrice()
        {
            // UpdateTotalPrice();

            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateToppingsPrice()
        {
            float price = 0;
            if (chkExtraCheese.Checked)
                price += Convert.ToSingle(chkExtraCheese.Tag);
             if (chkMusrooms.Checked)
                price += Convert.ToSingle(chkMusrooms.Tag);
             if (chkTomatoes.Checked)
                price += Convert.ToSingle(chkTomatoes.Tag);
             if (chkOnion.Checked)
                price += Convert.ToSingle(chkOnion.Tag);
             if (chkOlives.Checked)
                price += Convert.ToSingle(chkOlives.Tag);
             if (chkGreenPepper.Checked)
                price += Convert.ToSingle(chkGreenPepper.Tag);

            return price;
        }


        double GetCrustTypePrice()
        {
            if (rbThin.Checked)
                return Convert.ToDouble(rbThin.Tag);
            else
                return Convert.ToDouble(rbThick.Tag);
        }

        double CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetCrustTypePrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
                lblSize1.Text = rbSmall.Text;
            else if (rbMedium.Checked)
                lblSize1.Text = rbMedium.Text;
            else
                lblSize1.Text = rbLarge.Text;
        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheese.Checked)
                sToppings = chkExtraCheese.Text;

            if (chkMusrooms.Checked)
                sToppings += ", " + chkMusrooms.Text;

            if (chkTomatoes.Checked)
                sToppings += ", " + chkTomatoes.Text;

            if (chkGreenPepper.Checked)
                sToppings += ", " + chkGreenPepper.Text;

            if (chkOnion.Checked)
                sToppings += ", " + chkOnion.Text;

            if (chkOlives.Checked)
                sToppings += ",  " + chkOlives.Text;

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;
        }

        private void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
                lblCrustType.Text = rbThin.Text;
            else lblCrustType.Text = rbThick.Text;
        }


        void UpdateWhereToEat()
        {
            // UpdateTotalPrice(); // if there is a tips on eat in in the future

            if (rbEatIn.Checked)
                lblWhereToEate.Text = rbEatIn.Text;
            else
                lblWhereToEate.Text = rbTakeOut.Text;

            //  lblWhereToEate.Text = (rbEatIn.Checked)?rbEatIn.Text : rbTakeOut.Text;

        }
        private void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrustType();
            UpdateWhereToEat();
            UpdateToppings();
            UpdateTotalPrice();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                btnOrder.Enabled = false;
                gbPizzaSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbEatPlace.Enabled = false;

                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Update Your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Go Back To The Menu Order", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //reset Order button
                btnOrder.Enabled = true;

                // reset groups
                gbPizzaSize.Enabled = true;
                gbCrustType.Enabled = true;
                gbToppings.Enabled = true;
                gbEatPlace.Enabled = true;

                //reset default checked buttons
                rbThin.Checked = true;
                rbEatIn.Checked = true;
                rbMedium.Checked = true;

                chkExtraCheese.Checked = false;
                chkGreenPepper.Checked = false;
                chkMusrooms.Checked = false;    
                chkOlives.Checked = false;
                chkTomatoes.Checked = false;
                chkOnion.Checked = false;
            }

        }



        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }
        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }


        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMusrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
    }
}
