using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart_Task1
{
    public partial class ShoppingCart: Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int shoe_quantity;
            int shirt_quantity;
            int pant_quantity;
            double shoe_price = 20.00;
            double shirt_price = 9.00;
            double pant_price = 15.00;
            double calculated_shoe_price;
            double calculated_shirt_price;
            double calculated_pant_price;

            // Get the quantity of each item from the text boxes
            if (int.TryParse(txt_quantity_shoe.Text, out shoe_quantity) && int.TryParse(txt_quantity_shirt.Text, out shirt_quantity) && int.TryParse(txt_quantity_pant.Text, out pant_quantity))
            {
                calculated_shoe_price = (shoe_quantity * shoe_price);
                calculated_shirt_price = (shirt_quantity * shirt_price);
                calculated_pant_price = (pant_quantity * pant_price);
                lbl_calculated_2.Text = calculated_shoe_price.ToString();
                lbl_calculated_1.Text = calculated_shirt_price.ToString();
                lbl_calculated_3.Text = calculated_pant_price.ToString();
                double total_price = calculated_shoe_price + calculated_shirt_price + calculated_pant_price;
                lbl_calculated_total.Text = total_price.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid quantities.");
            }
        }
    }
}
