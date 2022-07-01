using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic14
{
    public partial class Form_main : Form
    {
        private int status;
        private string tk, mk;
        public Form_main()
        {
            InitializeComponent();
        }

        public Form_main(int status_value, string tk_value, string mk_value)
        {
            status = status_value;
            tk = tk_value;
            mk = mk_value;
            InitializeComponent();
        }

        private void add_form(Form value)
        {
            this.pnlContent.Controls.Clear(); // Làm rỗng nội dung panel 
            value.TopLevel = false; // không quan tâm
            value.AutoScroll = true; // không quan tâm
            value.Dock = DockStyle.Fill; // form ngoài sẽ lập đầy nội dung của panel 
            value.FormBorderStyle = FormBorderStyle.None; // xóa viền của form được add vào
            this.pnlContent.Controls.Add(value); // câu lệnh để add form thành nội dung của panel
            value.Show(); // hiển thị cái form đó ra trong panel
        } // Method combine another form to this

        private void Form_main_Load(object sender, EventArgs e)
        {
            if(status == 0)
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
            } 
            else if (status == 1)
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.BackColor = Color.LightGray;
            }
            // Max screen view
            WindowState = FormWindowState.Maximized;
        }



        // STRIP MENU ITEMS CLICK
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            string path = @"D:\VisualStudio\ProjectVS\topic14\Resources\a76b83e74a2cbc72e53d.jpg";
            Image img = Image.FromFile(path);
            pictureBox1.Image = img;
            pnlContent.Controls.Add(pictureBox1);
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_nhan_su f_nhan_su = new GUI.Form_nhan_su();
            add_form(f_nhan_su);
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_phong_ban f_phong_ban = new GUI.Form_phong_ban();
            add_form(f_phong_ban);
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_bang_luong f_bang_luong = new GUI.Form_bang_luong();
            add_form(f_bang_luong);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_thong_tin f_thong_tin = new GUI.Form_thong_tin();
            add_form(f_thong_tin);
        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_luong_nv f_luong_nv = new GUI.Form_luong_nv();
            add_form(f_luong_nv);
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_cham_cong f_cham_cong = new GUI.Form_cham_cong();
            add_form(f_cham_cong);
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Find_form obj = new GUI.Find_form();
            add_form(obj);
        }

        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Cal_salary obj = new GUI.Cal_salary();
            add_form(obj);
        }

        private void nhânSựLàmViệcTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Report_form_month_work obj = new GUI.Report_form_month_work();
            add_form(obj);
        }

        private void danhSáchNhânViênTheoPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Report_form_nsu_pban obj = new GUI.Report_form_nsu_pban();
            add_form(obj);
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_quan_ly_tai_khoan obj = new GUI.Form_quan_ly_tai_khoan();
            obj.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Form_doi_mk obj = new GUI.Form_doi_mk(tk, mk);
            obj.ShowDialog();
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            //GUI.Form_login obj = new GUI.Form_login();
            //obj.Show();
            // Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
