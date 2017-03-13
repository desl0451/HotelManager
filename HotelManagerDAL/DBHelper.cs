using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace HotelManagerDAL
{
    public class DBHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["conn"].ToString();
        public static SqlConnection connection = new SqlConnection(connString);
    }
}
