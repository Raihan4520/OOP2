using DAL_AirwayTicketing.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_AirwayTicketing.Operations
{
    interface IUser
    {
        DataTable SearchAvailableTickets(string flightFrom, string flightTo);
        int BookTicket(ETicket eTicket);
        DataTable ViewBookedTicketsByUser();
        int CancelBooking(ETicket eTicket);
    }
}
