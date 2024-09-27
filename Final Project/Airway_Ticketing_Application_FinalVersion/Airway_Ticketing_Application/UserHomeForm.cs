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
    public partial class UserHomeForm : Form
    {
        public UserHomeForm()
        {
            InitializeComponent();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            new UserBookTicketsForm().Show();
            this.Hide();
        }

        private void btnViewTicket_Click(object sender, EventArgs e)
        {
            new UserViewBookedTicketsForm().Show();
            this.Hide();
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            new UserCancelTicketsForm().Show();
            this.Hide();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnViewAvailableTickets_Click(object sender, EventArgs e)
        {
            new UserViewAllTicketsForm().Show();
            this.Hide();
        }
    }
}
