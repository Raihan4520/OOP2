using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_AirwayTicketing.Entities
{
    public class EUser
    {
        public static string currentUsername;
        public static string currentUserCreditCardNo;
        public static string currentUserEmail;
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CreditCardNo { get; set; }
    }
}
