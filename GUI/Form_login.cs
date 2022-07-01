using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic14.GUI
{
    public partial class Form_login : Form
    {
        // Thuoc tinh
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter adap;
        private static DataTable dt;

        private static MySqlDataReader reader;

        public Form_login()
        {
            InitializeComponent();

            txt_mk.PasswordChar = '*';
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            txt_tk.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool check = false;
            int status = 1;
            string tk = "";
            string mk = "";
            conn = DAL.DB_connection.get_connection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from admin";

            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(txt_tk.Text == reader.GetString("tk") && txt_mk.Text == reader.GetString("mk") )
                {
                    check = true;
                    tk = reader.GetString("tk");
                    mk = reader.GetString("mk");
                    if (reader.GetInt32("status") == 0)
                    {
                        status = 0;
                    } else
                    {
                        status = 1;
                    }
                }
            }
            conn.Close();                       

            if(check)
            {
                this.Hide();
                Form_main f = new Form_main(status, tk, mk);
                f.ShowDialog();
                this.Show();
            } 
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi đăng nhập");
            }

            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
