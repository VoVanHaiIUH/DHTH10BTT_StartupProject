namespace SRPHR_Solution.KhachHang
{
    partial class FrmDoiDiem
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
        //doi diem

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.btndoidiem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnDoiThuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm tích luỹ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(401, 31);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(159, 71);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(159, 30);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(100, 20);
            this.txtMaThe.TabIndex = 2;
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.Location = new System.Drawing.Point(159, 123);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(100, 20);
            this.txtDiemTichLuy.TabIndex = 2;
            // 
            // btndoidiem
            // 
            this.btndoidiem.Location = new System.Drawing.Point(190, 183);
            this.btndoidiem.Name = "btndoidiem";
            this.btndoidiem.Size = new System.Drawing.Size(75, 23);
            this.btndoidiem.TabIndex = 3;
            this.btndoidiem.Text = "đổi điểm";
            this.btndoidiem.UseVisualStyleBackColor = true;
            this.btndoidiem.Click += new System.EventHandler(this.btndoidiem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(309, 183);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnDoiThuong
            // 
            this.btnDoiThuong.Location = new System.Drawing.Point(84, 183);
            this.btnDoiThuong.Name = "btnDoiThuong";
            this.btnDoiThuong.Size = new System.Drawing.Size(75, 23);
            this.btnDoiThuong.TabIndex = 3;
            this.btnDoiThuong.Text = "Doi Thuong";
            this.btnDoiThuong.UseVisualStyleBackColor = true;
            this.btnDoiThuong.Click += new System.EventHandler(this.btnDoiThuong_Click);
            // 
            // FrmDoiDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 268);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnDoiThuong);
            this.Controls.Add(this.btndoidiem);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtDiemTichLuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoiDiem";
            this.Text = "FrmDoiDiem";
            this.Load += new System.EventHandler(this.FrmDoiDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.Button btndoidiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnDoiThuong;
    }
}