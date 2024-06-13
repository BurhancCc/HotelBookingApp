using HotelBookingsWeb.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnbDesktop.Common
{
    static class Global
    {
        private static System_User _loggeduser = null;

        public static System_User Loggeduser
        {
            get { return _loggeduser; }
            set { _loggeduser = value; }
        }

        public static string admin = "admin";
        public static string customer = "customer";
    }
}
