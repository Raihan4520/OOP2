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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*Person p = new Person();
            p.Name = txtUsername.Text;
            //MessageBox.Show(p.Name);
            listInfo.Items.Add(p.Name);*/

            string username = "Raihan";
            string password = "123";
            if(txtUsername.Text == username && txtPassword.Text == password)
            {
                //MessageBox.Show("Successfully logged in.");
                new HomeForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password maybe incorrect.");
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignupForm().Show();
            this.Hide();
        }
    }
}
