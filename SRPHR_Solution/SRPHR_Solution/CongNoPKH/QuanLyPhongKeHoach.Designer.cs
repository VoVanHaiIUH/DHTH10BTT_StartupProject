namespace SRPHR_Solution.CongNoPKH
{
    partial class QuanLyPhongKeHoach
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
            this.btnBanSi = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnNKho = new System.Windows.Forms.Button();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.btnCongNo = new System.Windows.Forms.Button();
            this.btnMuaHangNCC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBanSi
            // 
            this.btnBanSi.Location = new System.Drawing.Point(90, 299);
            this.btnBanSi.Name = "btnBanSi";
            this.btnBanSi.Size = new System.Drawing.Size(75, 23);
            this.btnBanSi.TabIndex = 0;
            this.btnBanSi.Text = "Bán Sỉ";
            this.btnBanSi.UseVisualStyleBackColor = true;
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Location = new System.Drawing.Point(590, 299);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(75, 23);
            this.btnXuatKho.TabIndex = 1;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.UseVisualStyleBackColor = true;
            // 
            // btnNKho
            // 
            this.btnNKho.Location = new System.Drawing.Point(491, 299);
            this.btnNKho.Name = "btnNKho";
            this.btnNKho.Size = new System.Drawing.Size(75, 23);
            this.btnNKho.TabIndex = 2;
            this.btnNKho.Text = "Nhập kho";
            this.btnNKho.UseVisualStyleBackColor = true;
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Location = new System.Drawing.Point(399, 299);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(75, 23);
            this.btnKhuyenMai.TabIndex = 3;
            this.btnKhuyenMai.Text = "Khuyến mãi ";
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // btnCongNo
            // 
            this.btnCongNo.Location = new System.Drawing.Point(318, 299);
            this.btnCongNo.Name = "btnCongNo";
            this.btnCongNo.Size = new System.Drawing.Size(75, 23);
            this.btnCongNo.TabIndex = 4;
            this.btnCongNo.Text = "Công nợ";
            this.btnCongNo.UseVisualStyleBackColor = true;
            // 
            // btnMuaHangNCC
            // 
            this.btnMuaHangNCC.Location = new System.Drawing.Point(171, 299);
            this.btnMuaHangNCC.Name = "btnMuaHangNCC";
            this.btnMuaHangNCC.Size = new System.Drawing.Size(141, 23);
            this.btnMuaHangNCC.TabIndex = 5;
            this.btnMuaHangNCC.Text = "Mua hàng từ NCC";
            this.btnMuaHangNCC.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 225);
            this.dataGridView1.TabIndex = 6;
            // 
            // QuanLyPhongKeHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMuaHangNCC);
            this.Controls.Add(this.btnCongNo);
            this.Controls.Add(this.btnKhuyenMai);
            this.Controls.Add(this.btnNKho);
            this.Controls.Add(this.btnXuatKho);
            this.Controls.Add(this.btnBanSi);
            this.Name = "QuanLyPhongKeHoach";
            this.Text = "QuanLyPhongKeHoach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanSi;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnNKho;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.Button btnCongNo;
        private System.Windows.Forms.Button btnMuaHangNCC;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}