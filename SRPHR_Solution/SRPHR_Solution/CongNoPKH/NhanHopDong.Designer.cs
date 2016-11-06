namespace SRPHR_Solution.CongNoPKH
{
    partial class NhanHopDong
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
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaCa = new System.Windows.Forms.TextBox();
            this.btnNhan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(63, 62);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(78, 13);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên Sản Phẩm";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(63, 112);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(53, 13);
            this.lbSoLuong.TabIndex = 1;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(63, 176);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(39, 13);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Giá Cả";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(139, 59);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(100, 20);
            this.txtTenSP.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(139, 105);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtGiaCa
            // 
            this.txtGiaCa.Location = new System.Drawing.Point(139, 169);
            this.txtGiaCa.Name = "txtGiaCa";
            this.txtGiaCa.Size = new System.Drawing.Size(100, 20);
            this.txtGiaCa.TabIndex = 5;
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(139, 221);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "Nhận";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 169);
            this.dataGridView1.TabIndex = 7;
            // 
            // NhanHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 330);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.txtGiaCa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbTenSP);
            this.Name = "NhanHopDong";
            this.Text = "NhanHopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaCa;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}