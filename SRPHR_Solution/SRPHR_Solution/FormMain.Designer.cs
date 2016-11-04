namespace SRPHR_Solution.PhanQuyen
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnformPhanquyen = new System.Windows.Forms.Button();
            this.btnformNhansu = new System.Windows.Forms.Button();
            this.btnformkhachhang = new System.Windows.Forms.Button();
            this.btnfromkho = new System.Windows.Forms.Button();
            this.btnfromcongno = new System.Windows.Forms.Button();
            this.btnformbaocao = new System.Windows.Forms.Button();
            this.btnFormBanHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnformPhanquyen);
            this.groupBox1.Controls.Add(this.btnformNhansu);
            this.groupBox1.Controls.Add(this.btnformkhachhang);
            this.groupBox1.Controls.Add(this.btnfromkho);
            this.groupBox1.Controls.Add(this.btnfromcongno);
            this.groupBox1.Controls.Add(this.btnformbaocao);
            this.groupBox1.Controls.Add(this.btnFormBanHang);
            this.groupBox1.Location = new System.Drawing.Point(263, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnformPhanquyen
            // 
            this.btnformPhanquyen.Location = new System.Drawing.Point(27, 224);
            this.btnformPhanquyen.Name = "btnformPhanquyen";
            this.btnformPhanquyen.Size = new System.Drawing.Size(106, 40);
            this.btnformPhanquyen.TabIndex = 11;
            this.btnformPhanquyen.Text = "Phân Quyền";
            this.btnformPhanquyen.UseVisualStyleBackColor = true;
            this.btnformPhanquyen.Click += new System.EventHandler(this.btnformPhanquyen_Click);
            // 
            // btnformNhansu
            // 
            this.btnformNhansu.Location = new System.Drawing.Point(207, 155);
            this.btnformNhansu.Name = "btnformNhansu";
            this.btnformNhansu.Size = new System.Drawing.Size(106, 40);
            this.btnformNhansu.TabIndex = 10;
            this.btnformNhansu.Text = "Nhân Sự";
            this.btnformNhansu.UseVisualStyleBackColor = true;
            // 
            // btnformkhachhang
            // 
            this.btnformkhachhang.Location = new System.Drawing.Point(207, 89);
            this.btnformkhachhang.Name = "btnformkhachhang";
            this.btnformkhachhang.Size = new System.Drawing.Size(106, 40);
            this.btnformkhachhang.TabIndex = 9;
            this.btnformkhachhang.Text = "Khách Hàng";
            this.btnformkhachhang.UseVisualStyleBackColor = true;
            // 
            // btnfromkho
            // 
            this.btnfromkho.Location = new System.Drawing.Point(27, 155);
            this.btnfromkho.Name = "btnfromkho";
            this.btnfromkho.Size = new System.Drawing.Size(106, 40);
            this.btnfromkho.TabIndex = 8;
            this.btnfromkho.Text = "Kho";
            this.btnfromkho.UseVisualStyleBackColor = true;
            // 
            // btnfromcongno
            // 
            this.btnfromcongno.Location = new System.Drawing.Point(27, 89);
            this.btnfromcongno.Name = "btnfromcongno";
            this.btnfromcongno.Size = new System.Drawing.Size(106, 40);
            this.btnfromcongno.TabIndex = 7;
            this.btnfromcongno.Text = "      Công Nợ        Phòng Kế Hoạch";
            this.btnfromcongno.UseVisualStyleBackColor = true;
            // 
            // btnformbaocao
            // 
            this.btnformbaocao.Location = new System.Drawing.Point(207, 22);
            this.btnformbaocao.Name = "btnformbaocao";
            this.btnformbaocao.Size = new System.Drawing.Size(106, 40);
            this.btnformbaocao.TabIndex = 6;
            this.btnformbaocao.Text = "Báo Cáo";
            this.btnformbaocao.UseVisualStyleBackColor = true;
            // 
            // btnFormBanHang
            // 
            this.btnFormBanHang.Location = new System.Drawing.Point(27, 22);
            this.btnFormBanHang.Name = "btnFormBanHang";
            this.btnFormBanHang.Size = new System.Drawing.Size(106, 40);
            this.btnFormBanHang.TabIndex = 5;
            this.btnFormBanHang.Text = "Bán Hàng";
            this.btnFormBanHang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản :";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(133, 241);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.Location = new System.Drawing.Point(12, 241);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(75, 23);
            this.btndangxuat.TabIndex = 6;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndangxuat);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnformPhanquyen;
        private System.Windows.Forms.Button btnformNhansu;
        private System.Windows.Forms.Button btnformkhachhang;
        private System.Windows.Forms.Button btnfromkho;
        private System.Windows.Forms.Button btnfromcongno;
        private System.Windows.Forms.Button btnformbaocao;
        private System.Windows.Forms.Button btnFormBanHang;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}