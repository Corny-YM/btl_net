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
    public partial class Form_thong_tin : Form
    {
        public Form_thong_tin()
        {
            InitializeComponent();
        }

        private void Form_thong_tin_Load(object sender, EventArgs e)
        {
            // hiện thị rõ nội dung - không bị che khuất
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Show Data
            DAL.D_thong_tin obj = new DAL.D_thong_tin();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;

            // Take suitable values
            DAL.D_thong_tin.get_values_id_nhan_su(cb_id_nhan_su);
        }


        // Event - Button
        private void btn_show_Click(object sender, EventArgs e)
        {
            DAL.D_thong_tin obj = new DAL.D_thong_tin();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            DAL.D_thong_tin obj = new DAL.D_thong_tin();
            obj.insert(txt_id_thong_tin.Text, cb_id_nhan_su.Text, txt_noi_sinh.Text,
                                   txt_que_quan.Text, txt_dan_toc.Text,
                                   txt_ton_giao.Text, txt_quoc_tich.Text,
                                   txt_hoc_van.Text, txt_sdt.Text, txt_status.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DAL.D_thong_tin obj = new DAL.D_thong_tin();
            obj.update(txt_id_thong_tin.Text, cb_id_nhan_su.Text, txt_noi_sinh.Text,
                                   txt_que_quan.Text, txt_dan_toc.Text,
                                   txt_ton_giao.Text, txt_quoc_tich.Text,
                                   txt_hoc_van.Text, txt_sdt.Text, txt_status.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DAL.D_thong_tin obj = new DAL.D_thong_tin();
            obj.delete(txt_id_thong_tin.Text);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            TextBox[] arr_tb = new TextBox[] {txt_id_thong_tin, txt_noi_sinh,
                                            txt_que_quan, txt_dan_toc,
                                            txt_ton_giao, txt_quoc_tich,
                                            txt_hoc_van, txt_sdt, txt_status };
            ComboBox[] arr_cb = new ComboBox[] { cb_id_nhan_su };

            BUS.Clear_TextBox.clear(arr_tb);
            BUS.Clear_comboBox.clear(arr_cb);
        }

        // Binding - Stupid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_id_thong_tin.Text = row.Cells[0].Value.ToString();
                cb_id_nhan_su.Text = row.Cells[1].Value.ToString();
                txt_noi_sinh.Text = row.Cells[2].Value.ToString();
                txt_que_quan.Text = row.Cells[3].Value.ToString();
                txt_dan_toc.Text = row.Cells[4].Value.ToString();
                txt_ton_giao.Text = row.Cells[5].Value.ToString();
                txt_hoc_van.Text = row.Cells[6].Value.ToString();
                txt_quoc_tich.Text = row.Cells[7].Value.ToString();
                txt_sdt.Text = row.Cells[8].Value.ToString();
                txt_status.Text = row.Cells[9].Value.ToString();
            }
        }
    }
}
