using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp_H
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("The Button has been clicked");

            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);
            double result = number1 + number2;
            lblResult.Text = "The result is " + result.ToString();
            lblResult.Visible = true;

            //MessageBox.Show("The result is " + result);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);
            double result = number1 - number2;
            lblResult.Text = "The result is " + result.ToString();
            lblResult.Visible = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);
            double result = number1 * number2;
            lblResult.Text = "The result is " + result.ToString();
            lblResult.Visible = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumber1.Text);
            double number2 = Convert.ToDouble(txtNumber2.Text);
            if(number2 == 0)
            {
                MessageBox.Show("Divided by zero is not possible.");
            }
            else
            {
                double result = number1 / number2;
                lblResult.Text = "The result is " + result.ToString();
                lblResult.Visible = true;
            }
        }
    }
}
