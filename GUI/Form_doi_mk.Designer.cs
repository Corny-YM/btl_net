
namespace topic14.GUI
{
    partial class Form_doi_mk
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_old = new System.Windows.Forms.TextBox();
            this.txt_new = new System.Windows.Forms.TextBox();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác nhập lại mật khẩu:";
            // 
            // txt_old
            // 
            this.txt_old.Font = new System.Drawing.Font("Roboto Mono", 12F);
            this.txt_old.Location = new System.Drawing.Point(330, 62);
            this.txt_old.Name = "txt_old";
            this.txt_old.Size = new System.Drawing.Size(282, 34);
            this.txt_old.TabIndex = 1;
            // 
            // txt_new
            // 
            this.txt_new.Font = new System.Drawing.Font("Roboto Mono", 12F);
            this.txt_new.Location = new System.Drawing.Point(330, 112);
            this.txt_new.Name = "txt_new";
            this.txt_new.Size = new System.Drawing.Size(282, 34);
            this.txt_new.TabIndex = 2;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Font = new System.Drawing.Font("Roboto Mono", 12F);
            this.txt_confirm.Location = new System.Drawing.Point(330, 163);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(282, 34);
            this.txt_confirm.TabIndex = 3;
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Roboto Mono", 12F);
            this.btn_change.Location = new System.Drawing.Point(408, 221);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(204, 45);
            this.btn_change.TabIndex = 6;
            this.btn_change.Text = "Đổi mật khẩu";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tài khoản:";
            // 
            // txt_tk
            // 
            this.txt_tk.Enabled = false;
            this.txt_tk.Font = new System.Drawing.Font("Roboto Mono", 12F);
            this.txt_tk.Location = new System.Drawing.Point(150, 6);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(282, 34);
            this.txt_tk.TabIndex = 7;
            // 
            // Form_doi_mk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 273);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.txt_new);
            this.Controls.Add(this.txt_old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form_doi_mk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_doi_mk";
            this.Load += new System.EventHandler(this.Form_doi_mk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_old;
        private System.Windows.Forms.TextBox txt_new;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tk;
    }
}