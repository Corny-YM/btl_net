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
    public class D_thong_tin : Interfaces.show_data, Interfaces.itf_thong_tin
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
            cmd.CommandText = "thong_tin_show";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }

        public void insert(string id_thong_tin, string id_nhan_su,
                                string noi_sinh, string que_quan,
                                string dan_toc, string ton_giao,
                                string quoc_tich, string hoc_van,
                                string sdt, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "thong_tin_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_thong_tin", id_thong_tin);
            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@noi_sinh", noi_sinh);
            cmd.Parameters.AddWithValue("@que_quan", que_quan);
            cmd.Parameters.AddWithValue("@dan_toc", dan_toc);
            cmd.Parameters.AddWithValue("@ton_giao", ton_giao);
            cmd.Parameters.AddWithValue("@quoc_tich", quoc_tich);
            cmd.Parameters.AddWithValue("@hoc_van", hoc_van);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@status", status);


            cmd.Parameters["@id_thong_tin"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@noi_sinh"].Direction = ParameterDirection.Input;
            cmd.Parameters["@que_quan"].Direction = ParameterDirection.Input;
            cmd.Parameters["@dan_toc"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ton_giao"].Direction = ParameterDirection.Input;
            cmd.Parameters["@quoc_tich"].Direction = ParameterDirection.Input;
            cmd.Parameters["@hoc_van"].Direction = ParameterDirection.Input;
            cmd.Parameters["@sdt"].Direction = ParameterDirection.Input;
            cmd.Parameters["@status"].Direction = ParameterDirection.Input;


            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
        }


        public void update(string id_thong_tin, string id_nhan_su,
                                string noi_sinh, string que_quan,
                                string dan_toc, string ton_giao,
                                string quoc_tich, string hoc_van,
                                string sdt, string status)
        {
            conn = DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "thong_tin_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_thong_tin", id_thong_tin);
            cmd.Parameters.AddWithValue("@id_nhan_su", id_nhan_su);
            cmd.Parameters.AddWithValue("@noi_sinh", noi_sinh);
            cmd.Parameters.AddWithValue("@que_quan", que_quan);
            cmd.Parameters.AddWithValue("@dan_toc", dan_toc);
            cmd.Parameters.AddWithValue("@ton_giao", ton_giao);
            cmd.Parameters.AddWithValue("@quoc_tich", quoc_tich);
            cmd.Parameters.AddWithValue("@hoc_van", hoc_van);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@status", status);


            cmd.Parameters["@id_thong_tin"].Direction = ParameterDirection.Input;
            cmd.Parameters["@id_nhan_su"].Direction = ParameterDirection.Input;
            cmd.Parameters["@noi_sinh"].Direction = ParameterDirection.Input;
            cmd.Parameters["@que_quan"].Direction = ParameterDirection.Input;
            cmd.Parameters["@dan_toc"].Direction = ParameterDirection.Input;
            cmd.Parameters["@ton_giao"].Direction = ParameterDirection.Input;
            cmd.Parameters["@quoc_tich"].Direction = ParameterDirection.Input;
            cmd.Parameters["@hoc_van"].Direction = ParameterDirection.Input;
            cmd.Parameters["@sdt"].Direction = ParameterDirection.Input;
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
            cmd.CommandText = "thong_tin_delete";
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
            cmd.CommandText = "thong_tin_find";
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
