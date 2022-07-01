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
    public partial class Form_bang_luong : Form
    {
        public Form_bang_luong()
        {
            InitializeComponent();
        }

        private void Form_bang_luong_Load(object sender, EventArgs e)
        {
            // hiện thị rõ nội dung - không bị che khuất
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Show Data
            DAL.D_bang_luong obj = new DAL.D_bang_luong();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;
        }

        // Binding data - stupid
        private void binding_data_input(DataGridViewRow row)
        {
            DAL.D_bang_luong obj = new DAL.D_bang_luong();
            string id = row.Cells[0].Value.ToString();
            DataTable dt = DAL.D_bang_luong.find_data(id);
            dt.AcceptChanges();

            // Clear binding          
            txt_id_luong.DataBindings.Clear();
            txt_luong_co_ban.DataBindings.Clear();
            dtp_ngay_nhap.DataBindings.Clear();
            txt_status.DataBindings.Clear();

            // Create binding - id_luong	luong_co_ban	ngay_nhap	status
            txt_id_luong.DataBindings.Add("Text", dt, "id_luong", false, DataSourceUpdateMode.OnPropertyChanged);
            txt_luong_co_ban.DataBindings.Add("Text", dt, "luong_co_ban", false, DataSourceUpdateMode.OnPropertyChanged);
            dtp_ngay_nhap.DataBindings.Add("Text", dt, "ngay_nhap", false, DataSourceUpdateMode.OnPropertyChanged);
            txt_status.DataBindings.Add("Text", dt, "status", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                binding_data_input(row);
            }
        }

        // Event - Button
        private void btn_show_Click(object sender, EventArgs e)
        {
            // Show Data
            DAL.D_bang_luong obj = new DAL.D_bang_luong();
            DataTable value = obj.show();
            dataGridView1.DataSource = value;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string date_input = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_nhap);
            DAL.D_bang_luong obj = new DAL.D_bang_luong(); 
            obj.insert(txt_id_luong.Text, txt_luong_co_ban.Text, 
                                    date_input, txt_status.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string date_input = BUS.handle_date.formDate_yy_mm_dd(dtp_ngay_nhap);
            DAL.D_bang_luong obj = new DAL.D_bang_luong();
            obj.update(txt_id_luong.Text, txt_luong_co_ban.Text,
                                    date_input, txt_status.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DAL.D_bang_luong obj = new DAL.D_bang_luong();
            obj.delete(txt_id_luong.Text);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            TextBox[] arr_tb = new TextBox[] {txt_id_luong, txt_luong_co_ban, txt_status};
            BUS.Clear_TextBox.clear(arr_tb);
        }






        // DOn't care
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
