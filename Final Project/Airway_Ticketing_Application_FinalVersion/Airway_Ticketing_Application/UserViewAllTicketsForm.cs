using DAL_AirwayTicketing.Entities;
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
    public partial class UserViewAllTicketsForm : Form
    {
        public UserViewAllTicketsForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }

        private void ViewAllTicketsUserForm_Load(object sender, EventArgs e)
        {
            EUser eUser = new EUser();
            OTicket oTicket = new OTicket();
            dgvAllTickets.DataSource = oTicket.ViewAllTickets(eUser);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }
}
