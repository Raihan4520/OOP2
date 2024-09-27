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
    public partial class UserSignupForm : Form
    {
        public UserSignupForm()
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
            if(txtUsername.Text == "" || txtCreditCardNumber.Text=="" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Sign up failed. Please fill up the form.");
            }
            else
            {
                EUser eUser = new EUser();
                eUser.Username = txtUsername.Text;
                eUser.CreditCardNo = txtCreditCardNumber.Text;
                eUser.Email = txtEmail.Text;
                eUser.Password = txtPassword.Text;

                OUser oUser = new OUser();

                string email = txtEmail.Text;
                if(oUser.IsValidEmail(email))
                {
                    ulong creditCardNo = 0;
                    if (ulong.TryParse(txtCreditCardNumber.Text, out creditCardNo))
                    {
                        int effectedRows = oUser.UserExist(eUser);
                        if (effectedRows > 0)
                        {
                            MessageBox.Show("Sign up failed. This username already exist.");
                        }
                        else
                        {
                            if (txtPassword.Text == txtConfirmPassword.Text)
                            {
                                effectedRows = oUser.UserSignup(eUser);

                                if (effectedRows > 0)
                                {
                                    MessageBox.Show("Signed up successfully.");
                                    txtUsername.Clear();
                                    txtCreditCardNumber.Clear();
                                    txtEmail.Clear();
                                    txtPassword.Clear();
                                    txtConfirmPassword.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Sign up failed. Please try again.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password confirmation failed. Please try again.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sign up failed. Please enter a valid credit card number.");
                    }
                }
                else
                {
                    MessageBox.Show("Sign up failed. Please enter a valid email address.");
                }
            }
        }
    }
}
