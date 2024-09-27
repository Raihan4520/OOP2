using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class CalculatorForm : Form
    {
        //double res = 0;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txtResult.Text = "";
            //res = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " / ";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " * ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " - ";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //res = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text += " + ";

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //txtResult.Text = txtDisplay.Text;
            DataTable dt = new DataTable();
            var v = dt.Compute(txtDisplay.Text, "");
            txtResult.Text = v.ToString();
        }
    }
}
