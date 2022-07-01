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
    public class D_nhan_su : Interfaces.show_data, Interfaces.itf_nhan_su
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
            cmd.CommandText = "nhan_su_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

        public void insert(string id_phong_ban, string id_nhan_su,
                            string id_luong, string ho_ten,
                            string ngay_sinh, string gioi_tinh,
                            string tt_hon_nhan, string cmnd,
                            string vai_tro, string hop_dong,
                            string ngay_ky, string ngay_het_han)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "nhan_su_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_phong_ban", id_phong_ban);
            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@id_luong", id_luong);
            cmd.Parameters.AddWithValue("@ho_ten", ho_ten);
            cmd.Parameters.AddWithValue("@ngay_sinh", ngay_sinh);
            cmd.Parameters.AddWithValue("@gioi_tinh", gioi_tinh);
            cmd.Parameters.AddWithValue("@tt_hon_nhan", tt_hon_nhan);
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@vai_tro", vai_tro);
            cmd.Parameters.AddWithValue("@hop_dong", hop_dong);
            cmd.Parameters.AddWithValue("@ngay_ky", ngay_ky);
            cmd.Parameters.AddWithValue("@ngay_het_han", ngay_het_han);

            cmd.Parameters["@id_phong_ban"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_luong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ho_ten"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_sinh"].Direction = ParameterDirection.Input;
            cmd.Parameters["@gioi_tinh"].Direction = ParameterDirection.Input;
            cmd.Parameters["@tt_hon_nhan"].Direction = ParameterDirection.Input;
            cmd.Parameters["@cmnd"].Direction = ParameterDirection.Input;
            cmd.Parameters["@vai_tro"].Direction = ParameterDirection.Input;
            cmd.Parameters["@hop_dong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_ky"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_het_han"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }


        public void update(string id_phong_ban, string id_nhan_su,
                            string id_luong, string ho_ten,
                            string ngay_sinh, string gioi_tinh,
                            string tt_hon_nhan, string cmnd,
                            string vai_tro, string hop_dong,
                            string ngay_ky, string ngay_het_han)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "nhan_su_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_phong_ban", id_phong_ban);
            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@id_luong", id_luong);
            cmd.Parameters.AddWithValue("@ho_ten", ho_ten);
            cmd.Parameters.AddWithValue("@ngay_sinh", ngay_sinh);
            cmd.Parameters.AddWithValue("@gioi_tinh", gioi_tinh);
            cmd.Parameters.AddWithValue("@tt_hon_nhan", tt_hon_nhan);
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@vai_tro", vai_tro);
            cmd.Parameters.AddWithValue("@hop_dong", hop_dong);
            cmd.Parameters.AddWithValue("@ngay_ky", ngay_ky);
            cmd.Parameters.AddWithValue("@ngay_het_han", ngay_het_han);

            cmd.Parameters["@id_phong_ban"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_luong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ho_ten"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_sinh"].Direction = ParameterDirection.Input;
            cmd.Parameters["@gioi_tinh"].Direction = ParameterDirection.Input;
            cmd.Parameters["@tt_hon_nhan"].Direction = ParameterDirection.Input;
            cmd.Parameters["@cmnd"].Direction = ParameterDirection.Input;
            cmd.Parameters["@vai_tro"].Direction = ParameterDirection.Input;
            cmd.Parameters["@hop_dong"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_ky"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ngay_het_han"].Direction = ParameterDirection.Input;

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
            cmd.CommandText = "nhan_su_delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters["@id"].Direction = ParameterDirection.Input;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }


        public static DataTable find_data(int id)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "nhan_su_find_id";
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

        public static DataTable find_data(string name)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "nhan_su_find_name";
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


        // Take value from foregin key
        public static void get_values_id_phong_ban(ComboBox obj)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "phong_ban_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                obj.Items.Add(reader.GetString("id_phong_ban"));
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
