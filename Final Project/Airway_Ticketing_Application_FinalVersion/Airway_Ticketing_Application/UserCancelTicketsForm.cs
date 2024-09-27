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
    public partial class UserCancelTicketsForm : Form
    {
        public UserCancelTicketsForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (txtFlightNo.Text == "")
            {
                MessageBox.Show("Please enter a flight number.");
            }
            else
            {
                ETicket eTicket = new ETicket();
                eTicket.FlightNo = txtFlightNo.Text;

                OTicket oTicket = new OTicket();
                DataTable dt = new DataTable();
                dt = oTicket.IsValidTicket(eTicket);

                if (dt.Rows.Count > 0)
                {
                    if(dt.Rows[0]["BookedBy"].ToString()==EUser.currentUsername)
                    {
                        int effectedRows = oTicket.CancelBooking(eTicket);

                        if (effectedRows > 0)
                        {
                            MessageBox.Show("Booking cancelled successfully.");
                            txtFlightNo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel booking. Please enter a valid flight number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel booking. Please enter a valid flight number.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to cancel booking. Please enter a valid flight number.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }
}
