using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic14.DAL
{
    public class D_cham_cong : Interfaces.itf_cham_cong
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
            cmd.CommandText = "cham_cong_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

        public void insert(string id_nhan_su, string thang, string ngay_cong)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "cham_cong_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@thang", thang);
            cmd.Parameters.AddWithValue("@ngay_cong", ngay_cong);

            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@thang"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_cong"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void update(string id_nhan_su, string thang, string ngay_cong)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "cham_cong_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@thang", thang);
            cmd.Parameters.AddWithValue("@ngay_cong", ngay_cong);

            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@thang"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_cong"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public void delete(string id_nhan_su, string thang)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "cham_cong_delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@thang", thang);
            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@thang"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }

        public DataTable find(string id)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "cham_cong_find";
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
    }
}
