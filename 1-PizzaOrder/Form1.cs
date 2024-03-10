using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void UpdateOrderSummary()
        {
            // Because Of My Default Values
            UpdateCrustType();
            UpdatePlaceWhereYouEat();
            UpdateSize();
            UpdateToppings();
            UpdateTotalPrice();
        }


        // Total Prices
        private float CalculateSizePrice()
        {

            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }

            if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

            return 0;
        }
        private float CalculateToppingPrcie()
        {
            float toppingPrcie = 0;

            if (chkExtraCheese.Checked)
            {
                toppingPrcie += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                toppingPrcie += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkMushrooms.Checked)
            {
                toppingPrcie += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlivers.Checked)
            {
                toppingPrcie += Convert.ToSingle(chkOlivers.Tag);
            }

            if (chkOnion.Checked)
            {
                toppingPrcie += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkTomatoes.Checked)
            {
                toppingPrcie += Convert.ToSingle(chkTomatoes.Tag);
            }

            return toppingPrcie;
        }
        private float CalculateCrustTypePrice()
        {
            if (rbThin.Checked)
            {
                return Convert.ToSingle(rbThin.Tag);
            }

            if (rbThick.Checked)
            {
                return Convert.ToSingle(rbThick.Tag);
            }

            return 0;
        }

        private float CalculateTotalPrices()
        {
            return CalculateSizePrice() + CalculateToppingPrcie() + CalculateCrustTypePrice();
        }

        private void UpdateTotalPrice()
        {
            lbTotalPrice.Text = "$" + CalculateTotalPrices().ToString();
        }


        // Size Changging
        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lbSizeResult.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lbSizeResult.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lbSizeResult.Text = "Large";
                return;
            }

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



        // Crust Type 
        private void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
                lbCrustTypeResult.Text = "Thin Type";

            else
                lbCrustTypeResult.Text = "Thick Type";
        }
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }
        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }


        // Toppings 



        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlivers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlivers.Checked)
            {
                sToppings += ", Olivers";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lbToppingsResult.Text = sToppings;

        }


        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlaceWhereYouEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlaceWhereYouEat();
        }

        private void UpdatePlaceWhereYouEat()
        {
            if (rbEatIn.Checked)
            {
                lbWhereToEatResult.Text = rbEatIn.Text;
            }

            if (rbTakeOut.Checked)
            {
                lbWhereToEatResult.Text = rbTakeOut.Text;
            }
        }


        // Order && Reset

        private void ResetForm()
        {

            btnOrderPizza.Enabled = true;

            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrust.Enabled = true;
            gbWhereToEat.Enabled = true;

            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlivers.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

            rbMedium.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;
        }
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrust.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update Your Order","Update",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

      
    }
}
