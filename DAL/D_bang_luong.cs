using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace topic14.DAL
{
    public class D_bang_luong : Interfaces.show_data, Interfaces.itf_bang_luong
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
            cmd.CommandText = "bang_luong_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

        public void insert(string id_luong, string luong_co_ban,
                                  string ngay_nhap, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "bang_luong_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_luong", id_luong);
            cmd.Parameters.AddWithValue("@luong_co_ban", luong_co_ban);
            cmd.Parameters.AddWithValue("@ngay_nhap", ngay_nhap);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.Parameters["@id_luong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@luong_co_ban"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_nhap"].Direction = ParameterDirection.Input;
            cmd.Parameters["@status"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void update(string id_luong, string luong_co_ban,
                                  string ngay_nhap, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "bang_luong_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_luong", id_luong);
            cmd.Parameters.AddWithValue("@luong_co_ban", luong_co_ban);
            cmd.Parameters.AddWithValue("@ngay_nhap", ngay_nhap);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.Parameters["@id_luong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@luong_co_ban"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_nhap"].Direction = ParameterDirection.Input;
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
            cmd.CommandText = "bang_luong_delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters["@id"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public static DataTable find_data(string id)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "bang_luong_find";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters["@id"].Direction = ParameterDirection.Input;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
