using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckShowShirtCalc
{
    public partial class ShirtCalculator : Form
    {
        public ShirtCalculator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            double oldShirts = 5.00;
            double newShirts = 10.00;
            double shipping = 5.00;
            double quantity = Convert.ToDouble(textBox1.Text);
            double sum;
            

            if (comboBox1.Text == "Truck Mafia")
            {
                if (checkBox1.Checked == true)
                {
                    sum = oldShirts * quantity + shipping;
                    textBox2.Text = sum.ToString("0.00");
                }
                else
                {
                    sum = oldShirts * quantity;
                    textBox2.Text = sum.ToString("0.00");
                }
            }

            if (comboBox1.Text == "2nd Annual")
            {
                if (checkBox1.Checked == true)
                {
                    sum = oldShirts * quantity + shipping;
                    textBox2.Text = sum.ToString("0.00");
                }
                else
                {
                    sum = oldShirts * quantity;
                    textBox2.Text = sum.ToString("0.00");
                }
            }

            if (comboBox1.Text == "3rd Annual")
            {
                if (checkBox1.Checked == true)
                {
                    sum = oldShirts * quantity + shipping;
                    textBox2.Text = sum.ToString("0.00");
                }
                else
                {
                    sum = oldShirts * quantity;
                    textBox2.Text = sum.ToString("0.00");
                }
            }

            if (comboBox1.Text == "4th Annual")
            {
                if (checkBox1.Checked == true)
                {
                    sum = newShirts * quantity + shipping;
                    textBox2.Text = sum.ToString("0.00");
                }
                else
                {
                    sum = newShirts * quantity;
                    textBox2.Text = sum.ToString("0.00");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}
