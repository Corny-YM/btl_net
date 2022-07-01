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
    public partial class Form_quan_ly_tai_khoan : Form
    {
        private string tk;
        public Form_quan_ly_tai_khoan()
        {
            InitializeComponent();
        }

        private void Form_quan_ly_tai_khoan_Load(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
            current_data();
        }

        // method
        private void current_data()
        {
            DAL.D_admin obj = new DAL.D_admin();
            dataGridView1.DataSource = obj.show();
        }

        // event
        private void btn_add_Click(object sender, EventArgs e)
        {
            DAL.D_admin obj = new DAL.D_admin();
            obj.insert(txt_tk.Text, txt_mk.Text);
            current_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DAL.D_admin obj = new DAL.D_admin();
            obj.delete(tk);
            current_data();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            TextBox[] arr = new TextBox[] { txt_mk, txt_tk };
            BUS.Clear_TextBox.clear(arr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tk = row.Cells[0].Value.ToString();
                txt_tk.Text = row.Cells[0].Value.ToString();
                txt_mk.Text = row.Cells[1].Value.ToString();

                btn_delete.Enabled = true;
            }
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tk_MouseDown(object sender, MouseEventArgs e)
        {
            btn_delete.Enabled = false;
        }
    }
}
