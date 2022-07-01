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
    public partial class Form_luong_nv : Form
    {
        public string stt;
        public Form_luong_nv()
        {
            InitializeComponent();
        }

        private void Form_luong_nv_Load(object sender, EventArgs e)
        {
            // hiện thị rõ nội dung - không bị che khuất
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Show Data
            DAL.D_luong_nv obj = new DAL.D_luong_nv();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;

            // Take suitable values
            DAL.D_luong_nv.get_values_id_nhan_su(cb_id_nhan_su);
            DAL.D_luong_nv.get_values_id_luong(cb_id_luong);
        }


        // Event - button
        private void btn_show_Click(object sender, EventArgs e)
        {
            DAL.D_luong_nv obj = new DAL.D_luong_nv();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            DAL.D_luong_nv obj = new DAL.D_luong_nv(); 
            obj.insert(cb_id_nhan_su.Text, cb_id_luong.Text,
                                  txt_thuong.Text, txt_ki_luat.Text, 
                                  txt_thang.Text, txt_status.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DAL.D_luong_nv obj = new DAL.D_luong_nv();
            obj.update(stt, cb_id_nhan_su.Text, cb_id_luong.Text,
                                  txt_thuong.Text, txt_ki_luat.Text,
                                  txt_thang.Text, txt_status.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DAL.D_luong_nv obj = new DAL.D_luong_nv();
            obj.delete(stt);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            TextBox[] arr_tb = new TextBox[] { txt_status, txt_ki_luat, txt_thang, txt_thuong };
            ComboBox[] arr_cb = new ComboBox[] { cb_id_nhan_su, cb_id_luong };
            BUS.Clear_TextBox.clear(arr_tb);
            BUS.Clear_comboBox.clear(arr_cb);
        }

        // Binding - stupid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                stt = row.Cells[0].Value.ToString();
                cb_id_nhan_su.Text = row.Cells[1].Value.ToString();
                cb_id_luong.Text = row.Cells[2].Value.ToString();
                txt_thuong.Text = row.Cells[3].Value.ToString();
                txt_ki_luat.Text = row.Cells[4].Value.ToString();
                txt_thang.Text = row.Cells[5].Value.ToString();
                txt_status.Text = row.Cells[6].Value.ToString();
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
