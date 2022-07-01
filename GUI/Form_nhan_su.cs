using System;
using System.Collections;
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
    public partial class Form_nhan_su : Form
    {
        public Form_nhan_su()
        {
            InitializeComponent();
        }

        private void Form_nhan_su_Load(object sender, EventArgs e)
        {
            // hiện thị rõ nội dung - không bị che khuất
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Show Data
            DAL.D_nhan_su obj = new DAL.D_nhan_su();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;

            // Take suitable values
            DAL.D_nhan_su.get_values_id_phong_ban(cb_id_phong_ban);
            DAL.D_nhan_su.get_values_id_luong(cb_id_luong);
        }


        // Binding Data to TextBox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cb_id_phong_ban.Text = row.Cells[0].Value.ToString();
                txt_id_nhan_su.Text = row.Cells[1].Value.ToString();
                cb_id_luong.Text = row.Cells[2].Value.ToString();
                txt_ten.Text = row.Cells[3].Value.ToString();
                dtp_ngay_sinh.Text = row.Cells[4].Value.ToString();
                cb_gioi_tinh.Text = row.Cells[5].Value.ToString();
                cb_hon_nhan.Text = row.Cells[6].Value.ToString();
                txt_cmnd.Text = row.Cells[7].Value.ToString();
                txt_vai_tro.Text = row.Cells[8].Value.ToString();
                txt_hop_dong.Text = row.Cells[9].Value.ToString();
                dtp_ngay_ky.Text = row.Cells[10].Value.ToString();
                dtp_ngay_het_han.Text = row.Cells[11].Value.ToString();
            }
        }


        // Event - Button
        private void btn_show_Click(object sender, EventArgs e)
        {
            DAL.D_nhan_su obj = new DAL.D_nhan_su();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            var date_born = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_sinh);
            var date_sign = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_ky);
            var date_expire = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_het_han);

            //DAL.D_nhan_su obj = new DAL.D_nhan_su();
            DAL.D_nhan_su obj = new DAL.D_nhan_su(); 
            obj.insert(cb_id_phong_ban.Text, txt_id_nhan_su.Text,
                        cb_id_luong.Text, txt_ten.Text,
                        date_born, cb_gioi_tinh.Text,
                        cb_hon_nhan.Text, txt_cmnd.Text,
                        txt_vai_tro.Text, txt_hop_dong.Text,
                        date_sign, date_expire);
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var date_born = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_sinh);
            var date_sign = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_ky);
            var date_expire = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_het_han);

            DAL.D_nhan_su obj = new DAL.D_nhan_su();
            obj.update(cb_id_phong_ban.Text, txt_id_nhan_su.Text,
                        cb_id_luong.Text, txt_ten.Text,
                        date_born, cb_gioi_tinh.Text,
                        cb_hon_nhan.Text, txt_cmnd.Text,
                        txt_vai_tro.Text, txt_hop_dong.Text,
                        date_sign, date_expire);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DAL.D_nhan_su obj = new DAL.D_nhan_su();
            obj.delete(txt_id_nhan_su.Text);
        }


        private void btn_clean_Click(object sender, EventArgs e)
        {
            TextBox[] arr_tb = new TextBox[] {txt_cmnd, txt_hop_dong, txt_id_nhan_su, 
                                           txt_ten, txt_vai_tro };
            ComboBox[] arr_cb = new ComboBox[] {cb_gioi_tinh, cb_hon_nhan, cb_id_luong, cb_id_phong_ban };
            BUS.Clear_TextBox.clear(arr_tb);
            BUS.Clear_comboBox.clear(arr_cb);
        }

        // Don't care
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void dtp_ngay_sinh_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void cb_gioi_tinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
