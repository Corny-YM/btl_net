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
    public partial class Form_phong_ban : Form
    {
        public Form_phong_ban()
        {
            InitializeComponent();
        }

        private void Form_phong_ban_Load(object sender, EventArgs e)
        {
            // hiện thị rõ nội dung - không bị che khuất
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Show Data
            DAL.D_phong_ban obj = new DAL.D_phong_ban();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;
        }


        // Event - Button
        private void btn_show_Click(object sender, EventArgs e)
        {
            DAL.D_phong_ban obj = new DAL.D_phong_ban();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string date_create = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_thanh_lap);
            DAL.D_phong_ban obj = new DAL.D_phong_ban();
            obj.insert(txt_id_phong_ban.Text, txt_ten.Text, date_create, txt_status.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string date_create = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_thanh_lap);
            DAL.D_phong_ban obj = new DAL.D_phong_ban();
            obj.update(txt_id_phong_ban.Text, txt_ten.Text, date_create, txt_status.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DAL.D_phong_ban obj = new DAL.D_phong_ban();
            obj.delete(txt_id_phong_ban.Text);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            TextBox[] arr_tb = new TextBox[] {txt_id_phong_ban, txt_status, txt_ten };
            BUS.Clear_TextBox.clear(arr_tb);
        }

        //Binding - stupid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_id_phong_ban.Text = row.Cells[0].Value.ToString();
                txt_ten.Text = row.Cells[1].Value.ToString();
                dtp_ngay_thanh_lap.Text = row.Cells[2].Value.ToString();
                txt_status.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
