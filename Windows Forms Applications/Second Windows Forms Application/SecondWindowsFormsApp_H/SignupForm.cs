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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Sign up failed. Please fill up the form.");
            }
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    MessageBox.Show("Successfully signed up.");
                }
                else
                {
                    MessageBox.Show("Invalid passwords. Try again.");
                }
            }
        }
    }
}
