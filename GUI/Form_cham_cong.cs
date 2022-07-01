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
    public partial class Form_cham_cong : Form
    {
        public Form_cham_cong()
        {
            InitializeComponent();
        }

        private void Form_cham_cong_Load(object sender, EventArgs e)
        {
            cb_thang.SelectedIndex = 0;

            DAL.D_cham_cong obj = new DAL.D_cham_cong();
            dataGridView1.DataSource = obj.show();

            DAL.D_cham_cong.get_values_id_nhan_su(cb_id_nhan_su);
        }

        // Event click buttons
        private void btn_show_Click(object sender, EventArgs e)
        {
            DAL.D_cham_cong obj = new DAL.D_cham_cong();
            dataGridView1.DataSource = obj.show();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            DAL.D_cham_cong obj = new DAL.D_cham_cong();
            obj.insert(cb_id_nhan_su.Text, cb_thang.Text, txt_ngay_cong.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DAL.D_cham_cong obj = new DAL.D_cham_cong();
            obj.update(cb_id_nhan_su.Text, cb_thang.Text, txt_ngay_cong.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DAL.D_cham_cong obj = new DAL.D_cham_cong();
            obj.delete(cb_id_nhan_su.Text, cb_thang.Text);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            DAL.D_cham_cong obj = new DAL.D_cham_cong();
            dataGridView1.DataSource = obj.find(txt_find.Text);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            TextBox[] arr_tb = new TextBox[] {txt_ngay_cong, txt_find };
            ComboBox[] arr_cb = new ComboBox[] { cb_id_nhan_su };
            BUS.Clear_TextBox.clear(arr_tb);
            BUS.Clear_comboBox.clear(arr_cb);
            cb_thang.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cb_id_nhan_su.Text = row.Cells[0].Value.ToString();
                cb_thang.Text = row.Cells[1].Value.ToString();
                txt_ngay_cong.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
