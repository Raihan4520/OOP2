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
    public class OTicket : IAdmin, IUser
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VIMFVO7\\SQLEXPRESS;Initial Catalog=DBAirwayTicketing;Integrated Security=True");
        public int AddTicket(ETicket eTicket)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into AllTicketsTable values('" + eTicket.FlightNo + "','" + eTicket.Date + "','" + eTicket.Time + "','" + eTicket.FlightFrom + "','" + eTicket.FlightTo + "','" + eTicket.Price + " Tk" + "',null)", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public int TicketExist(ETicket eTicket)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from AllTicketsTable where FlightNo = '"+ eTicket.FlightNo+"'", connection);
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
        public int UpdateTicket(ETicket eTicket)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update AllTicketsTable set Date = '"+eTicket.Date+"', Time = '"+eTicket.Time+"', FlightFrom = '"+eTicket.FlightFrom+"', FlightTo = '"+eTicket.FlightTo+ "', Price = '" + eTicket.Price + " Tk" +"' where FlightNo = '" + eTicket.FlightNo+"' ", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public int RemoveTicket(ETicket eTicket)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from AllTicketsTable where FlightNo = '"+eTicket.FlightNo+"'", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public DataTable ViewAllTickets(ETicket eTicket)
        {
            connection.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from AllTicketsTable", connection);
            cmd.Fill(tbl);
            connection.Close();
            return tbl;
        }
        public DataTable ViewAllTickets(EUser eUser)
        {
            connection.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select FlightNo, Date, Time, FlightFrom, FlightTo, Price from AllTicketsTable where BookedBy is null", connection);
            cmd.Fill(tbl);
            connection.Close();
            return tbl;
        }
        public DataTable SearchAvailableTickets(string flightFrom, string flightTo)
        {
            connection.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select FlightNo, Date, Time, FlightFrom, FlightTo, Price from AllTicketsTable where FlightFrom = '"+flightFrom+"' and FlightTo = '"+flightTo+"' and BookedBy is null", connection);
            cmd.Fill(tbl);
            connection.Close();
            return tbl;
        }
        public DataTable ViewAllBookedTickets()
        {
            connection.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from AllTicketsTable where BookedBy is not null", connection);
            cmd.Fill(tbl);
            connection.Close();
            return tbl;
        }
        public int BookTicket(ETicket eTicket)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update AllTicketsTable set BookedBy = '" + EUser.currentUsername + "' where FlightNo = '" + eTicket.FlightNo + "' ", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public DataTable ViewBookedTicketsByUser()
        {
            connection.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from AllTicketsTable where BookedBy = '"+EUser.currentUsername+"'", connection);
            cmd.Fill(tbl);
            connection.Close();
            return tbl;
        }
        public int CancelBooking(ETicket eTicket)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update AllTicketsTable set BookedBy = null where FlightNo = '" + eTicket.FlightNo + "' ", connection);
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
            return effectedRows;
        }
        public DataTable IsValidTicket(ETicket eTicket)
        {
            connection.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from AllTicketsTable where FlightNo = '" + eTicket.FlightNo + "'", connection);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
