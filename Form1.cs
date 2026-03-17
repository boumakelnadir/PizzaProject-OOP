using System;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetCalcSizePrice()
        {
            if (rb_small.Checked)
            {
                return Convert.ToSingle(rb_small.Tag);
            }

            else if (rb_medium.Checked)
            {
                return Convert.ToSingle(rb_medium.Tag);
            }

            else
            {
                return Convert.ToSingle(rb_large.Tag);
            }

        }

        float GetCalcCrustTypePrice()
        {
            if (rb_thin_crust.Checked)
                return Convert.ToSingle(rb_thin_crust.Tag);
            else
                return Convert.ToSingle(rb_thick_crust.Tag);
        }

        float GetCalcToppingsPrice()
        {
            float TotalToppingsPrice = 0;

            if (ckb_extra_chees.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(ckb_extra_chees.Tag);
            }

            if (ckb_mushrooms.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(ckb_mushrooms.Tag);
            }

            if (ckb_tomatos.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(ckb_tomatos.Tag);
            }

            if (ckb_onion.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(ckb_onion.Tag);
            }

            if (ckb_olives.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(ckb_olives.Tag);
            }

            if (ckb_green_pappers.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(ckb_green_pappers.Tag);
            }

            return TotalToppingsPrice;
        }

        float GetCalcWhereToEatPrice()
        {
            if (rb_eat_in.Checked)
                return Convert.ToSingle(rb_eat_in.Tag);
            else
                return Convert.ToSingle(rb_eat_out.Tag);
        }

        float CalcTotalPrice()
        {
            return GetCalcSizePrice() + GetCalcCrustTypePrice() + GetCalcToppingsPrice() + GetCalcWhereToEatPrice();
        }

        void UpdateTotalPrice()
        {
            lb_total_price.Text = "$" + CalcTotalPrice().ToString();
        }

        void GetSelectSize()
        {

            if (rb_small.Checked)
                lb_order_summary_size.Text = "Small";

            if (rb_medium.Checked)
                lb_order_summary_size.Text = "Medium";

            if (rb_large.Checked)
                lb_order_summary_size.Text = "Large";

            UpdateTotalPrice();
        }

        void GetSelectCrustType()
        {

            if (rb_thin_crust.Checked)
            {
                lb_order_summary_crust_type.Text = "Thin Crust";
            }
            else
            {
                lb_order_summary_crust_type.Text = "Thick Crust";
            }

            UpdateTotalPrice();
        }

        void GetSelectToppings()
        {

            string stTopping = "";

            if (ckb_extra_chees.Checked)
            {
                stTopping += ",Extra Chees ";
            }

            if (ckb_mushrooms.Checked)
            {
                stTopping += ",Mushrooms ";
            }

            if (ckb_tomatos.Checked)
            {
                stTopping += ",Tomatos ";
            }

            if (ckb_onion.Checked)
            {
                stTopping += ",Onion ";
            }

            if (ckb_olives.Checked)
            {
                stTopping += ",Olives ";
            }

            if (ckb_green_pappers.Checked)
            {
                stTopping += ",Green Pappers ";
            }

            if (stTopping.StartsWith(","))
            {
                stTopping = stTopping.Substring(1, stTopping.Length - 1).Trim();
            }

            if (stTopping == "")
            {
                stTopping = "No Toppings";
            }



            lb_order_summary_toppings.Text = stTopping;

            UpdateTotalPrice();
        }

        void GetSelectWhereToEat()
        {

            if (rb_eat_in.Checked)
            {
                lb_where_to_eat.Text = "Eat In";
            }
            else
            {
                lb_where_to_eat.Text = "Eat Out";
            }

            UpdateTotalPrice();
        }

        void UpdateOrderSummary()
        {
            GetSelectSize();
            GetSelectCrustType();
            GetSelectToppings();
            GetSelectWhereToEat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }


        private void rb_small_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectSize();
        }

        private void rb_medium_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectSize();
        }

        private void rb_large_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectSize();
        }


        private void rb_thin_crust_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectCrustType();
        }

        private void rb_thick_crust_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectCrustType();
        }


        private void ckb_extra_chees_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectToppings();
        }

        private void ckb_mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectToppings();
        }

        private void ckb_tomatos_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectToppings();
        }

        private void ckb_onion_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectToppings();
        }

        private void ckb_olives_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectToppings();
        }

        private void ckb_green_pappers_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectToppings();
        }


        private void rb_eat_in_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectWhereToEat();
        }

        private void rb_eat_out_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectWhereToEat();
        }

        private void btn_order_pizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Take Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Successfully Order", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gb_size.Enabled = false;
                gb_cust_type.Enabled = false;
                gb_toppings.Enabled = false;
                gb_where_to_eat.Enabled = false;
                btn_order_pizza.Enabled = false;
                btn_reset_form.Enabled = true;

            }
            else

                MessageBox.Show("Update Your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_reset_form_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reset Your Order", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset Groups
            gb_size.Enabled = true;
            gb_toppings.Enabled = true;
            gb_cust_type.Enabled = true;
            gb_where_to_eat.Enabled = true;

            //reset Size
            rb_small.Checked = true;

            //reset Toppings.
            ckb_extra_chees.Checked = false;
            ckb_onion.Checked = false;
            ckb_mushrooms.Checked = false;
            ckb_olives.Checked = false;
            ckb_tomatos.Checked = false;
            ckb_green_pappers.Checked = false;

            //reset CrustType
            rb_thin_crust.Checked = true;

            //reset Where to Eat
            rb_eat_in.Checked = true;

            //Reset Order Button
            btn_order_pizza.Enabled = true;
        }
    }
}

