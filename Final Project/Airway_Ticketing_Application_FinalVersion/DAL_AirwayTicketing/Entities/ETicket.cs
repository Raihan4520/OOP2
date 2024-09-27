using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_AirwayTicketing.Entities
{
    public class ETicket
    {
        public string FlightNo { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string FlightFrom { get; set; }
        public string FlightTo { get; set; }
        public string Price { get; set; }
        public string BookedBy { get; set; }
    }
}
