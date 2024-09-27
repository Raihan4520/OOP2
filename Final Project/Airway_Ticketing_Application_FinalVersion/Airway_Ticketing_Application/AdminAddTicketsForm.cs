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
    public partial class AdminAddTicketsForm : Form
    {
        public AdminAddTicketsForm()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }

        private void btnInsertTicket_Click(object sender, EventArgs e)
        {
            if (txtFlightNo.Text == "" || dtpDate.Text == "" || dtpTime.Text == "" || cbFrom.Text == "" || cbTo.Text==""|| txtPrice.Text=="")
            {
                MessageBox.Show("Insertion failed. Please fill up all the details.");
            }
            else
            {
                 ulong price = 0;
                 if(ulong.TryParse(txtPrice.Text, out price))
                 {
                    ETicket eTicket = new ETicket();
                    eTicket.FlightNo = txtFlightNo.Text;
                    eTicket.Date = dtpDate.Text;
                    eTicket.Time = dtpTime.Text;
                    eTicket.FlightFrom = cbFrom.Text;
                    eTicket.FlightTo = cbTo.Text;
                    eTicket.Price = txtPrice.Text;

                    OTicket oTicket = new OTicket();

                    int effectedRows = oTicket.TicketExist(eTicket);

                    if (effectedRows > 0)
                    {
                        MessageBox.Show("Insertion failed. This flight number already exhists.");
                    }
                    else
                    {
                        effectedRows = oTicket.AddTicket(eTicket);

                        if (effectedRows > 0)
                        {
                            MessageBox.Show("Inserted Successfully.");
                            txtFlightNo.Clear();
                            txtPrice.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert. Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to insert. Please enter a positive numeric value for price.");
                }
            }
        }

        private void AddTicketsForm_Load(object sender, EventArgs e)
        {
            dtpTime.CustomFormat = "HH:mm";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminHomeForm().Show();
            this.Hide();
        }
    }
}
