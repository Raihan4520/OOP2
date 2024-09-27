using DAL_AirwayTicketing.Entities;
using DAL_AirwayTicketing.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airway_Ticketing_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string adminUsername = "admin";
            const string adminPassword = "admin";
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            OUser oUser = new OUser();
            DataTable dt = new DataTable();
            dt = oUser.UserAuthentication(username, password);

            if(dt.Rows.Count>0)
            {
                EUser.currentUsername = dt.Rows[0]["Username"].ToString();
                EUser.currentUserCreditCardNo = dt.Rows[0]["CreditCardNo"].ToString();
                EUser.currentUserEmail = dt.Rows[0]["Email"].ToString();
                new UserHomeForm().Show();
                this.Hide();
            }
            else if (txtUsername.Text.Trim() == adminUsername && txtPassword.Text.Trim() == adminPassword)
            {
                new AdminHomeForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password maybe incorrect.");
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserSignupForm().Show();
            this.Hide();
        }
    }
}
