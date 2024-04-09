using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan.Account
{
    internal class Connection
    {
        private static string sqlConnection = @"Data Source=DAT\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(sqlConnection);
        }
    }
}
