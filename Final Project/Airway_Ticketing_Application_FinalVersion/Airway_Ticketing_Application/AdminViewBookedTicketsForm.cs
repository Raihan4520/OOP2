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
    public partial class AdminViewBookedTicketsForm : Form
    {
        public AdminViewBookedTicketsForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }

        private void ViewBookedTicketsAdminForm_Load(object sender, EventArgs e)
        {
            OTicket oTicket = new OTicket();
            dgvBookedTickets.DataSource = oTicket.ViewAllBookedTickets();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }
    }
}
