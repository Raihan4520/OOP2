using DAL_AirwayTicketing.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_AirwayTicketing.Operations
{
    public class OUser
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VIMFVO7\\SQLEXPRESS;Initial Catalog=DBAirwayTicketing;Integrated Security=True");
        public int UserSignup(EUser eUser)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTable values('"+eUser.Username+"', '"+eUser.Email+"', '"+eUser.Password+"', '"+eUser.CreditCardNo+"')", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public int UserExist(EUser eUser)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from UserTable where Username = '" + eUser.Username + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                return 1;
            }
            else
            {
                connection.Close();
                return 0;
            }
        }
        public DataTable UserAuthentication(string username, string password)
        {
            connection.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from UserTable where Username = '" + username + "' and Password = '" + password + "'", connection);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            connection.Close();
            return dt;
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var e = new System.Net.Mail.MailAddress(email);
                return e.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
