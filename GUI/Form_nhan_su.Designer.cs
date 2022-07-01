
namespace topic14.GUI
{
    partial class Form_nhan_su
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_hop_dong = new System.Windows.Forms.TextBox();
            this.dtp_ngay_het_han = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngay_ky = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_vai_tro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_hon_nhan = new System.Windows.Forms.ComboBox();
            this.dtp_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.cb_gioi_tinh = new System.Windows.Forms.ComboBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_id_luong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_id_phong_ban = new System.Windows.Forms.ComboBox();
            this.txt_id_nhan_su = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.btn_show);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.txt_hop_dong);
            this.groupBox1.Controls.Add(this.dtp_ngay_het_han);
            this.groupBox1.Controls.Add(this.dtp_ngay_ky);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_vai_tro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_hon_nhan);
            this.groupBox1.Controls.Add(this.dtp_ngay_sinh);
            this.groupBox1.Controls.Add(this.cb_gioi_tinh);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_id_luong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_id_phong_ban);
            this.groupBox1.Controls.Add(this.txt_id_nhan_su);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1496, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân sự";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(1207, 184);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(138, 36);
            this.btn_clean.TabIndex = 30;
            this.btn_clean.Text = "Clear";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(27, 184);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(138, 36);
            this.btn_show.TabIndex = 29;
            this.btn_show.Text = "SHOW";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(898, 184);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 36);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(599, 184);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(138, 36);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(284, 184);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(138, 36);
            this.btn_insert.TabIndex = 26;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_hop_dong
            // 
            this.txt_hop_dong.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hop_dong.Location = new System.Drawing.Point(1239, 21);
            this.txt_hop_dong.Name = "txt_hop_dong";
            this.txt_hop_dong.Size = new System.Drawing.Size(138, 31);
            this.txt_hop_dong.TabIndex = 24;
            // 
            // dtp_ngay_het_han
            // 
            this.dtp_ngay_het_han.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngay_het_han.Location = new System.Drawing.Point(1239, 124);
            this.dtp_ngay_het_han.Name = "dtp_ngay_het_han";
            this.dtp_ngay_het_han.Size = new System.Drawing.Size(221, 31);
            this.dtp_ngay_het_han.TabIndex = 23;
            // 
            // dtp_ngay_ky
            // 
            this.dtp_ngay_ky.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngay_ky.Location = new System.Drawing.Point(1239, 69);
            this.dtp_ngay_ky.Name = "dtp_ngay_ky";
            this.dtp_ngay_ky.Size = new System.Drawing.Size(221, 31);
            this.dtp_ngay_ky.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1072, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ngày hết hạn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1072, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ngày ký:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1072, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hợp đồng: ";
            // 
            // txt_vai_tro
            // 
            this.txt_vai_tro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vai_tro.Location = new System.Drawing.Point(908, 129);
            this.txt_vai_tro.Name = "txt_vai_tro";
            this.txt_vai_tro.Size = new System.Drawing.Size(138, 31);
            this.txt_vai_tro.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(801, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Vai trò:";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Location = new System.Drawing.Point(908, 75);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(138, 31);
            this.txt_cmnd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(801, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "CMND*:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cb_hon_nhan
            // 
            this.cb_hon_nhan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hon_nhan.FormattingEnabled = true;
            this.cb_hon_nhan.Items.AddRange(new object[] {
            "Độc thân",
            "Kết hôn"});
            this.cb_hon_nhan.Location = new System.Drawing.Point(908, 25);
            this.cb_hon_nhan.Name = "cb_hon_nhan";
            this.cb_hon_nhan.Size = new System.Drawing.Size(138, 31);
            this.cb_hon_nhan.TabIndex = 14;
            // 
            // dtp_ngay_sinh
            // 
            this.dtp_ngay_sinh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngay_sinh.Location = new System.Drawing.Point(489, 75);
            this.dtp_ngay_sinh.Name = "dtp_ngay_sinh";
            this.dtp_ngay_sinh.Size = new System.Drawing.Size(306, 31);
            this.dtp_ngay_sinh.TabIndex = 13;
            this.dtp_ngay_sinh.ValueChanged += new System.EventHandler(this.dtp_ngay_sinh_ValueChanged);
            // 
            // cb_gioi_tinh
            // 
            this.cb_gioi_tinh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gioi_tinh.FormattingEnabled = true;
            this.cb_gioi_tinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Không rõ"});
            this.cb_gioi_tinh.Location = new System.Drawing.Point(489, 127);
            this.cb_gioi_tinh.Name = "cb_gioi_tinh";
            this.cb_gioi_tinh.Size = new System.Drawing.Size(182, 31);
            this.cb_gioi_tinh.TabIndex = 12;
            this.cb_gioi_tinh.SelectedIndexChanged += new System.EventHandler(this.cb_gioi_tinh_SelectedIndexChanged);
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(489, 26);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(236, 31);
            this.txt_ten.TabIndex = 10;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(801, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hôn nhân:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới tính:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ và tên:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã lương:";
            // 
            // cb_id_luong
            // 
            this.cb_id_luong.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_id_luong.FormattingEnabled = true;
            this.cb_id_luong.Location = new System.Drawing.Point(191, 129);
            this.cb_id_luong.Name = "cb_id_luong";
            this.cb_id_luong.Size = new System.Drawing.Size(138, 31);
            this.cb_id_luong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhân sự:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng ban:";
            // 
            // cb_id_phong_ban
            // 
            this.cb_id_phong_ban.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_id_phong_ban.FormattingEnabled = true;
            this.cb_id_phong_ban.Location = new System.Drawing.Point(191, 26);
            this.cb_id_phong_ban.Name = "cb_id_phong_ban";
            this.cb_id_phong_ban.Size = new System.Drawing.Size(138, 31);
            this.cb_id_phong_ban.TabIndex = 1;
            // 
            // txt_id_nhan_su
            // 
            this.txt_id_nhan_su.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_nhan_su.Location = new System.Drawing.Point(191, 75);
            this.txt_id_nhan_su.Name = "txt_id_nhan_su";
            this.txt_id_nhan_su.Size = new System.Drawing.Size(138, 31);
            this.txt_id_nhan_su.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1496, 491);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_nhan_su
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 726);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_nhan_su";
            this.Text = "Form_nhan_su";
            this.Load += new System.EventHandler(this.Form_nhan_su_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_hon_nhan;
        private System.Windows.Forms.DateTimePicker dtp_ngay_sinh;
        private System.Windows.Forms.ComboBox cb_gioi_tinh;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_id_luong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_id_phong_ban;
        private System.Windows.Forms.TextBox txt_id_nhan_su;
        private System.Windows.Forms.TextBox txt_hop_dong;
        private System.Windows.Forms.DateTimePicker dtp_ngay_het_han;
        private System.Windows.Forms.DateTimePicker dtp_ngay_ky;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_vai_tro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_clean;
    }
}