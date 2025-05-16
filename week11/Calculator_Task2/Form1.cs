using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Task2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double n1 = 0;
        double n2 = 0;
        string operation = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text.Contains("/"))
            //{
            //    Cal_no1();
            //    operation = "divide";
            //    textBox1.Text = "";
            //}
            //else if (textBox1.Text.Contains("*"))
            //{
            //    Cal_no1();
            //    operation = "multiply";
            //    textBox1.Text = "";
            //}
            //else if (textBox1.Text.Contains("-"))
            //{
            //    Cal_no1();
            //    operation = "minus";
            //    textBox1.Text = "";
            //}
            //else if (textBox1.Text.Contains("+"))
            //{
            //    Cal_no1();
            //    operation = "plus";
            //    textBox1.Text = "";
            //}

            if (textBox1.Text.Contains("="))
            {
                Cal_no2();
                textBox1.Text = "";
            }
        }

        public void Cal_no1()
        {
            int position = textBox1.TextLength - 1;
            textBox1.Text = textBox1.Text.Remove(position);
            double.TryParse(textBox1.Text, out n1);
        }
        public void Cal_no2()
        {
            int position = textBox1.TextLength - 1;
            textBox1.Text = textBox1.Text.Remove(position);
            double.TryParse(textBox1.Text, out n2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            operation = "divide";
            textBox1.Text = "";
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            operation = "multiply";
            textBox1.Text = "";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            operation = "minus";
            textBox1.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            operation = "plus";
            textBox1.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (n1 != 0)
            {
                double.TryParse(textBox1.Text, out n2);
                if (operation == "plus")
                {
                    textBox1.Text = (n1 + n2).ToString();
                }
                else if (operation == "minus")
                {
                    textBox1.Text = (n1 - n2).ToString();
                }
                else if (operation == "multiply")
                {
                    textBox1.Text = (n1 * n2).ToString();
                }
                else if (operation == "divide")
                {
                    textBox1.Text = (n1 / n2).ToString();
                }
            }
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            int position = textBox1.TextLength - 1;
            textBox1.Text = textBox1.Text.Remove(position);
        }

        private void button_clear_all_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            n1 = 0;
            n2 = 0;
        }
    }
}
