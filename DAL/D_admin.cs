using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.DAL
{
    public class D_admin
    {
        // Thuoc tinh
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter adap;
        private static DataTable dt;

        private static MySqlDataReader reader;


        //Methods
        public DataTable show()
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "admin_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }


        public void insert(string tk, string mk)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "admin_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@mk", mk);

            cmd.Parameters["@tk"].Direction = ParameterDirection.Input;
            cmd.Parameters["@mk"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void update(string tk, string mk)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "admin_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@mk", mk);

            cmd.Parameters["@tk"].Direction = ParameterDirection.Input;
            cmd.Parameters["@mk"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void delete(string tk)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "admin_delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters["@tk"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }
    }
}
