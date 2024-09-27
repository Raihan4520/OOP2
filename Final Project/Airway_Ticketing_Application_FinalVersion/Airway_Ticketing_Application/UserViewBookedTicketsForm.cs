using DAL_AirwayTicketing.Operations;
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
    public partial class UserViewBookedTicketsForm : Form
    {
        public UserViewBookedTicketsForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }

        private void ViewBookedTicketsUserForm_Load(object sender, EventArgs e)
        {
            OTicket oTicket = new OTicket();
            dgvBookedTickets.DataSource = oTicket.ViewBookedTicketsByUser();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }
}
