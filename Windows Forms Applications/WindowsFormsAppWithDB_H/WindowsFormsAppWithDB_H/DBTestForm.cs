using DataAccessLayer_H.Entities;
using DataAccessLayer_H.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWithDB_H
{
    public partial class DBTestForm : Form
    {
        public DBTestForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EStudent eStudent = new EStudent();
            eStudent.Id = txtId.Text;
            eStudent.Name = txtName.Text;

            OStudent oStudent = new OStudent();
            int effectedRows = oStudent.Insert(eStudent);
            if(effectedRows > 0)
            {
                MessageBox.Show("Inserted Successfully");
                txtId.Text = "";
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EStudent eStudent = new EStudent();
            eStudent.Id = txtId.Text;
            eStudent.Name = txtName.Text;

            OStudent oStudent = new OStudent();
            int effectedRows = oStudent.Delete(eStudent);
            if (effectedRows > 0)
            {
                MessageBox.Show("Deleted Successfully");
                txtId.Text = "";
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EStudent eStudent = new EStudent();
            eStudent.Id = txtId.Text;
            eStudent.Name = txtName.Text;

            OStudent oStudent = new OStudent();
            int effectedRows = oStudent.Update(eStudent);
            if (effectedRows > 0)
            {
                MessageBox.Show("Update Successfully");
                txtId.Text = "";
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OStudent oStudent = new OStudent();
            dataGridView1.DataSource = oStudent.Show();
        }
    }
}
