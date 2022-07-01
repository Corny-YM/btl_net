using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace topic14.DAL
{
    public class D_phong_ban : Interfaces.show_data, Interfaces.itf_phong_ban
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
            cmd.CommandText = "phong_ban_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

        public void insert(string id_phong_ban, string ten,
                                  string ngay_thanh_lap, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "phong_ban_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_phong_ban", id_phong_ban);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@ngay_thanh_lap", ngay_thanh_lap);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.Parameters["@id_phong_ban"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ten"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_thanh_lap"].Direction = ParameterDirection.Input;
            cmd.Parameters["@status"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void update(string id_phong_ban, string ten,
                                  string ngay_thanh_lap, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "phong_ban_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_phong_ban", id_phong_ban);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@ngay_thanh_lap", ngay_thanh_lap);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.Parameters["@id_phong_ban"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ten"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_thanh_lap"].Direction = ParameterDirection.Input;
            cmd.Parameters["@status"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void delete(string id)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "phong_ban_delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters["@id"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public static DataTable find_data_id(string name)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "phong_ban_find_id";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters["@name"].Direction = ParameterDirection.Input;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable find_data_name(string name)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "phong_ban_find_name";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters["@name"].Direction = ParameterDirection.Input;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
