using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondWindowsFormsApp_H
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket successfully bought.");
        }

        private void btnViewTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List of ticket:");
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket successfully cancelled.");
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
