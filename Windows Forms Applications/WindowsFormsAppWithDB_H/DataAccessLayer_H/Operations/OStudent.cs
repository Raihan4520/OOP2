using DataAccessLayer_H.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_H.Operations
{
    public class OStudent
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H5TE73E\\SQLEXPRESS;Initial Catalog=DBConnectionTest;Integrated Security=True");
        public int Insert(EStudent eStudent)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into STable(Id, Name) values ('"+eStudent.Id+"', '"+eStudent.Name+"')", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public int Delete(EStudent eStudent)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from STable where Id = '"+eStudent.Id + "'", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public int Update(EStudent eStudent)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update STable set Name = '" + eStudent.Name + "' where Id = '" + eStudent.Id + "'", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public DataTable Show()
        {
            connection.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from STable", connection);
            cmd.Fill(tbl);
            connection.Close();
            return tbl;
        }
    }
}
