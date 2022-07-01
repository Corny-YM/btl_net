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
    public class D_luong_nv : Interfaces.show_data, Interfaces.itf_luong_nv
    {
        // Thuoc tinh
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter adap;
        private static DataTable dt;

        private static MySqlDataReader reader;


        // Methods
        public DataTable show()
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "luong_nv_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

        public void insert(string id_nhan_su, string id_luong,
                                string thuong, string ki_luat,
                                string thang, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "luong_nv_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@id_luong", id_luong);
            cmd.Parameters.AddWithValue("@thuong", thuong);
            cmd.Parameters.AddWithValue("@ki_luat", ki_luat);
            cmd.Parameters.AddWithValue("@thang", thang);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_luong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@thuong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ki_luat"].Direction = ParameterDirection.Input;
            cmd.Parameters["@thang"].Direction = ParameterDirection.Input;
            cmd.Parameters["@status"].Direction = ParameterDirection.Input;


            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void update(string stt, string id_nhan_su, string id_luong,
                                string thuong, string ki_luat,
                                string thang, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "luong_nv_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stt", stt);
            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@id_luong", id_luong);
            cmd.Parameters.AddWithValue("@thuong", thuong);
            cmd.Parameters.AddWithValue("@ki_luat", ki_luat);
            cmd.Parameters.AddWithValue("@thang", thang);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.Parameters["@stt"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_luong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@thuong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ki_luat"].Direction = ParameterDirection.Input;
            cmd.Parameters["@thang"].Direction = ParameterDirection.Input;
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
            cmd.CommandText = "luong_nv_delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters["@id"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }


        // Take value from foregin key
        public static void get_values_id_nhan_su(ComboBox obj)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "nhan_su_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                obj.Items.Add(reader.GetInt32("id_nhan_su"));
            }
            conn.Close();
        }

        public static void get_values_id_luong(ComboBox obj)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "bang_luong_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                obj.Items.Add(reader.GetInt32("id_luong"));
            }
            conn.Close();
        }
    }
}
