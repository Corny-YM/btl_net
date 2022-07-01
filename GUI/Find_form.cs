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
    public partial class Find_form : Form
    {
        public Find_form()
        {
            InitializeComponent();
        }

        private void Find_form_Load(object sender, EventArgs e)
        {
            // hiện thị rõ nội dung - không bị che khuất
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // show data
            DAL.D_nhan_su obj = new DAL.D_nhan_su();
            DataTable  dt =obj.show();
            dataGridView1.DataSource = dt;
        }
        // Dont care
        private void radio_btn_id_CheckedChanged(object sender, EventArgs e)
        {

        }


        // nhan_su
        private void btn_show_Click(object sender, EventArgs e)
        {
            // show data
            DAL.D_nhan_su obj = new DAL.D_nhan_su();
            DataTable dt = obj.show();
            dataGridView1.DataSource = dt;
        }
        private void btn_find_Click(object sender, EventArgs e)
        {
            if(radio_btn_id.Checked)
            {
                int value = int.Parse(txt_find.Text);
                DataTable dt = DAL.D_nhan_su.find_data(value);
                dataGridView1.DataSource = dt;
            } 
            else if(radio_btn_name.Checked)
            {
                string value = txt_find.Text;
                DataTable dt = DAL.D_nhan_su.find_data(value);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Select options");
            }
        }

        // thong_tin
        private void button1_Click(object sender, EventArgs e)
        {
            DAL.D_thong_tin obj = new DAL.D_thong_tin();
            DataTable dt = obj.show();
            dataGridView2.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = DAL.D_thong_tin.find_data(textBox1.Text);
            dataGridView2.DataSource = dt;
        }

        // phong_ban
        private void button3_Click(object sender, EventArgs e)
        {
            DAL.D_phong_ban obj = new DAL.D_phong_ban();
            DataTable dt = obj.show();
            dataGridView3.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                string id = textBox2.Text;
                DataTable dt = DAL.D_phong_ban.find_data_id(id);
                dataGridView3.DataSource = dt;
            }
            else if(radioButton1.Checked)
            {
                string name = textBox2.Text;
                DataTable dt = DAL.D_phong_ban.find_data_name(name);
                dataGridView3.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Select options");
            }
        }

        // bang_luong
        private void button5_Click(object sender, EventArgs e)
        {
            DAL.D_bang_luong obj = new DAL.D_bang_luong();
            DataTable dt = obj.show();
            dataGridView4.DataSource = dt;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text;
            DataTable dt = DAL.D_bang_luong.find_data(id);
            dataGridView4.DataSource = dt;
        }
    }
}
