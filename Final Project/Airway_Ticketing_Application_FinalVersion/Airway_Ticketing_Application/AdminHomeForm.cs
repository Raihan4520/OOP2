using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airway_Ticketing_Application
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnAddTickets_Click(object sender, EventArgs e)
        {
            new AdminAddTicketsForm().Show();
            this.Hide();
        }

        private void btnUpdateTickets_Click(object sender, EventArgs e)
        {
            new AdminUpdateTicketsForm().Show();
            this.Hide();
        }

        private void btnRemoveTickets_Click(object sender, EventArgs e)
        {
            new AdminRemoveTicketsForm().Show();
            this.Hide();
        }

        private void btnViewAllTickets_Click(object sender, EventArgs e)
        {
            new AdminViewAllTicketsForm().Show();
            this.Hide();
        }

        private void btnViewAllBookedTickets_Click(object sender, EventArgs e)
        {
            new AdminViewBookedTicketsForm().Show();
            this.Hide();
        }
    }
}
