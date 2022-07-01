using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace topic14.GUI
{
    public partial class Cal_salary : Form
    {
        // Thuoc tinh
        private string id_phong_ban;
        private string id_nhan_su;
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter adap;
        private static DataTable dt;

        private static MySqlDataReader reader;

        public Cal_salary()
        {
            InitializeComponent();
        }

        private DataTable show_data()
        {
            conn = DAL.DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "cal_salary_show";
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            adap = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adap.Fill(dt);
            conn.Close();

            return dt;
        }

        private void Cal_salary_Load(object sender, EventArgs e)
        {
            // hiện thị rõ nội dung - không bị che khuất
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView1.DataSource = show_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex]; // lấy giá trị dòng hiện tại đang click
                id_phong_ban = row.Cells[0].Value.ToString();
                id_nhan_su = row.Cells[2].Value.ToString();
            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(id_nhan_su);
            if (id_nhan_su != "")
            {
                conn = DAL.DB_connection.get_connection();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "cal_salary_per";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_nhan_su);
                cmd.Parameters["@id"].Direction = ParameterDirection.Input;
                conn.Open();
                reader = cmd.ExecuteReader();

                // 2345
                int luong_co_ban = 0;
                int thuong = 0;
                int ky_luat = 0;
                while (reader.Read())
                {
                    luong_co_ban = Convert.IsDBNull(reader[6]) ? 0 : reader.GetInt32(6);
                    thuong = Convert.IsDBNull(reader[4]) ? 0 : reader.GetInt32(4);
                    ky_luat = Convert.IsDBNull(reader[5]) ? 0 : reader.GetInt32(5);
                }
                conn.Close();
                int sum = luong_co_ban + thuong - ky_luat;
                txt_sum.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Select 1 row. Please!");
            }
        }

        private void btn_cal_dept_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(id_phong_ban);
            if (id_phong_ban != "")
            {
                conn = DAL.DB_connection.get_connection();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "cal_salary_dept";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_phong_ban);
                cmd.Parameters["@id"].Direction = ParameterDirection.Input;
                conn.Open();
                reader = cmd.ExecuteReader();

                // 2345
                int luong_co_ban = 0;
                int thuong = 0;
                int ky_luat = 0;
                while (reader.Read())
                {
                    luong_co_ban = Convert.IsDBNull(reader[4]) ? 0 : reader.GetInt32(4);
                    thuong = Convert.IsDBNull(reader[2]) ? 0 : reader.GetInt32(2);
                    ky_luat = Convert.IsDBNull(reader[3]) ? 0 : reader.GetInt32(3);
                }
                conn.Close();
                int sum = luong_co_ban + thuong - ky_luat;
                txt_sum.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Select 1 row. Please!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
