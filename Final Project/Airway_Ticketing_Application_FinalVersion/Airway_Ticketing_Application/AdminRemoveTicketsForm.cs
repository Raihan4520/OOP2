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
    public partial class AdminRemoveTicketsForm : Form
    {
        public AdminRemoveTicketsForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }

        private void btnRemoveTicket_Click(object sender, EventArgs e)
        {
            if(txtFlightNo.Text=="")
            {
                MessageBox.Show("Please enter a flight number.");
            }
            else
            {
                ETicket eTicket = new ETicket();
                eTicket.FlightNo = txtFlightNo.Text;

                OTicket oTicket = new OTicket();
                int effectedRows = oTicket.RemoveTicket(eTicket);

                if (effectedRows > 0)
                {
                    MessageBox.Show("Removed successfully.");
                    txtFlightNo.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to remove. Please enter a valid flight number.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }
    }
}
