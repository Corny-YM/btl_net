
namespace topic14.GUI
{
    partial class Form_thong_tin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_hoc_van = new System.Windows.Forms.TextBox();
            this.txt_quoc_tich = new System.Windows.Forms.TextBox();
            this.txt_ton_giao = new System.Windows.Forms.TextBox();
            this.txt_dan_toc = new System.Windows.Forms.TextBox();
            this.txt_que_quan = new System.Windows.Forms.TextBox();
            this.txt_noi_sinh = new System.Windows.Forms.TextBox();
            this.cb_id_nhan_su = new System.Windows.Forms.ComboBox();
            this.txt_id_thong_tin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1072, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Trạng thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(703, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(703, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Học vấn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(703, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quốc tịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tôn giáo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dân tộc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quê quán:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nơi sinh:";
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
            this.label1.Text = "Mã thông tin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_hoc_van);
            this.groupBox1.Controls.Add(this.txt_quoc_tich);
            this.groupBox1.Controls.Add(this.txt_ton_giao);
            this.groupBox1.Controls.Add(this.txt_dan_toc);
            this.groupBox1.Controls.Add(this.txt_que_quan);
            this.groupBox1.Controls.Add(this.txt_noi_sinh);
            this.groupBox1.Controls.Add(this.cb_id_nhan_su);
            this.groupBox1.Controls.Add(this.txt_id_thong_tin);
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.btn_show);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1496, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(1209, 21);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(138, 31);
            this.txt_status.TabIndex = 40;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(878, 128);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(138, 31);
            this.txt_sdt.TabIndex = 39;
            // 
            // txt_hoc_van
            // 
            this.txt_hoc_van.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoc_van.Location = new System.Drawing.Point(878, 74);
            this.txt_hoc_van.Name = "txt_hoc_van";
            this.txt_hoc_van.Size = new System.Drawing.Size(138, 31);
            this.txt_hoc_van.TabIndex = 38;
            // 
            // txt_quoc_tich
            // 
            this.txt_quoc_tich.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quoc_tich.Location = new System.Drawing.Point(878, 20);
            this.txt_quoc_tich.Name = "txt_quoc_tich";
            this.txt_quoc_tich.Size = new System.Drawing.Size(138, 31);
            this.txt_quoc_tich.TabIndex = 37;
            // 
            // txt_ton_giao
            // 
            this.txt_ton_giao.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ton_giao.Location = new System.Drawing.Point(485, 128);
            this.txt_ton_giao.Name = "txt_ton_giao";
            this.txt_ton_giao.Size = new System.Drawing.Size(138, 31);
            this.txt_ton_giao.TabIndex = 36;
            // 
            // txt_dan_toc
            // 
            this.txt_dan_toc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dan_toc.Location = new System.Drawing.Point(485, 74);
            this.txt_dan_toc.Name = "txt_dan_toc";
            this.txt_dan_toc.Size = new System.Drawing.Size(138, 31);
            this.txt_dan_toc.TabIndex = 35;
            // 
            // txt_que_quan
            // 
            this.txt_que_quan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_que_quan.Location = new System.Drawing.Point(485, 21);
            this.txt_que_quan.Name = "txt_que_quan";
            this.txt_que_quan.Size = new System.Drawing.Size(138, 31);
            this.txt_que_quan.TabIndex = 34;
            // 
            // txt_noi_sinh
            // 
            this.txt_noi_sinh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noi_sinh.Location = new System.Drawing.Point(171, 129);
            this.txt_noi_sinh.Name = "txt_noi_sinh";
            this.txt_noi_sinh.Size = new System.Drawing.Size(138, 31);
            this.txt_noi_sinh.TabIndex = 33;
            // 
            // cb_id_nhan_su
            // 
            this.cb_id_nhan_su.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_id_nhan_su.FormattingEnabled = true;
            this.cb_id_nhan_su.Location = new System.Drawing.Point(171, 75);
            this.cb_id_nhan_su.Name = "cb_id_nhan_su";
            this.cb_id_nhan_su.Size = new System.Drawing.Size(138, 31);
            this.cb_id_nhan_su.TabIndex = 32;
            // 
            // txt_id_thong_tin
            // 
            this.txt_id_thong_tin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_thong_tin.Location = new System.Drawing.Point(171, 25);
            this.txt_id_thong_tin.Name = "txt_id_thong_tin";
            this.txt_id_thong_tin.Size = new System.Drawing.Size(138, 31);
            this.txt_id_thong_tin.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1496, 491);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form_thong_tin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 726);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_thong_tin";
            this.Text = "Form_thong_tin";
            this.Load += new System.EventHandler(this.Form_thong_tin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_id_thong_tin;
        private System.Windows.Forms.ComboBox cb_id_nhan_su;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_hoc_van;
        private System.Windows.Forms.TextBox txt_quoc_tich;
        private System.Windows.Forms.TextBox txt_ton_giao;
        private System.Windows.Forms.TextBox txt_dan_toc;
        private System.Windows.Forms.TextBox txt_que_quan;
        private System.Windows.Forms.TextBox txt_noi_sinh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}