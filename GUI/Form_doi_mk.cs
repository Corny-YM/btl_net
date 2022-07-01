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
    public partial class Form_doi_mk : Form
    {
        private string tk, mk;

        public Form_doi_mk()
        {
            InitializeComponent();
        }

        public Form_doi_mk(string tk_old, string mk_old)
        {
            InitializeComponent();
            tk = tk_old;
            mk = mk_old;
        }

        private void Form_doi_mk_Load(object sender, EventArgs e)
        {
            txt_tk.Text = tk;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if(txt_confirm.Text == txt_new.Text)
            {
                if (txt_old.Text == mk)
                {
                    DAL.D_admin obj = new DAL.D_admin();
                    obj.update(tk, txt_new.Text);
                    MessageBox.Show("Cập nhật mật khẩu thành công", "Successful");
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ sai!", "Error");
                }
            } else
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Error");
            }
        }
    }
}
