using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace topic14.DAL
{
    public class DB_connection
    {
        public static MySqlConnection get_connection()
        {
            string str = "Server=localhost; Database=team19topic14; " +
            "Port=3306; User ID= root; Password=; convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(str);
            return conn;
        }
    }
}
