using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdWindowsFormsApp_H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = cboOccupation.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime current = DateTime.Now;
            TimeSpan timeSpan = current - from; // It returns in days
            txtAge.Text = (timeSpan.TotalDays / 365).ToString("0"); // Converted to year and "0" to floor
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtName.Text;
            dataGridView1.Rows[n].Cells[1].Value = cboOccupation.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtAge.Text;
        }

        private void txtAge_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtAge_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Age will be calculated automatically.";
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write your full name here.";
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void cboOccupation_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose your occupation.";
        }

        private void cboOccupation_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to show all info in the table below.";
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
