namespace SRPHR_Solution.KhachHang
{
    partial class FrmTheThanhVien
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
        //

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnthemthe = new System.Windows.Forms.Button();
            this.dgvthethanhvien = new System.Windows.Forms.DataGridView();
            this.txtmathe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtdiemtichluy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
            this.dtpngayhethan = new System.Windows.Forms.DateTimePicker();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthethanhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thẻ";
            // 
            // btnthemthe
            // 
            this.btnthemthe.Location = new System.Drawing.Point(52, 353);
            this.btnthemthe.Name = "btnthemthe";
            this.btnthemthe.Size = new System.Drawing.Size(75, 23);
            this.btnthemthe.TabIndex = 1;
            this.btnthemthe.Text = "THEM";
            this.btnthemthe.UseVisualStyleBackColor = true;
            this.btnthemthe.Click += new System.EventHandler(this.btnthemthe_Click_1);
            // 
            // dgvthethanhvien
            // 
            this.dgvthethanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthethanhvien.Location = new System.Drawing.Point(3, 2);
            this.dgvthethanhvien.Name = "dgvthethanhvien";
            this.dgvthethanhvien.Size = new System.Drawing.Size(666, 190);
            this.dgvthethanhvien.TabIndex = 2;
            this.dgvthethanhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtmathe
            // 
            this.txtmathe.Location = new System.Drawing.Point(116, 206);
            this.txtmathe.Name = "txtmathe";
            this.txtmathe.Size = new System.Drawing.Size(100, 20);
            this.txtmathe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm tích luỹ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(281, 353);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(116, 241);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(100, 20);
            this.txtmakh.TabIndex = 3;
            // 
            // txtdiemtichluy
            // 
            this.txtdiemtichluy.Location = new System.Drawing.Point(116, 286);
            this.txtdiemtichluy.Name = "txtdiemtichluy";
            this.txtdiemtichluy.Size = new System.Drawing.Size(100, 20);
            this.txtdiemtichluy.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(497, 202);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(100, 20);
            this.txttongtien.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày hết hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày lập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ghi chú";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(497, 319);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(100, 20);
            this.txtghichu.TabIndex = 3;
            // 
            // dtpngaylap
            // 
            this.dtpngaylap.Location = new System.Drawing.Point(481, 237);
            this.dtpngaylap.Name = "dtpngaylap";
            this.dtpngaylap.Size = new System.Drawing.Size(200, 20);
            this.dtpngaylap.TabIndex = 4;
            // 
            // dtpngayhethan
            // 
            this.dtpngayhethan.Location = new System.Drawing.Point(481, 283);
            this.dtpngayhethan.Name = "dtpngayhethan";
            this.dtpngayhethan.Size = new System.Drawing.Size(200, 20);
            this.dtpngayhethan.TabIndex = 4;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(172, 353);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(400, 353);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FrmTheThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 388);
            this.Controls.Add(this.dtpngayhethan);
            this.Controls.Add(this.dtpngaylap);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.txtdiemtichluy);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.txtmathe);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvthethanhvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnthemthe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTheThanhVien";
            this.Text = "FrmTheThanhVien";
            this.Load += new System.EventHandler(this.FrmTheThanhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthethanhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthemthe;
        private System.Windows.Forms.DataGridView dgvthethanhvien;
        private System.Windows.Forms.TextBox txtmathe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtdiemtichluy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.DateTimePicker dtpngayhethan;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
    }
}