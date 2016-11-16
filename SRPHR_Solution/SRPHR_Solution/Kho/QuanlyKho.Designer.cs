namespace SRPHR_Solution.Kho
{
    partial class QuanlyKho
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
            this.btnCNKho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhieuQlyKho = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnQlyPhieuNK = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenKho = new System.Windows.Forms.Label();
            this.treeViewKho = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnCNKho
            // 
            this.btnCNKho.Location = new System.Drawing.Point(51, 312);
            this.btnCNKho.Name = "btnCNKho";
            this.btnCNKho.Size = new System.Drawing.Size(95, 23);
            this.btnCNKho.TabIndex = 17;
            this.btnCNKho.Text = "Cập nhật Kho";
            this.btnCNKho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách các Kho";
            // 
            // btnPhieuQlyKho
            // 
            this.btnPhieuQlyKho.Location = new System.Drawing.Point(510, 243);
            this.btnPhieuQlyKho.Name = "btnPhieuQlyKho";
            this.btnPhieuQlyKho.Size = new System.Drawing.Size(75, 48);
            this.btnPhieuQlyKho.TabIndex = 15;
            this.btnPhieuQlyKho.Text = "Phiếu Quản Lý Kho";
            this.btnPhieuQlyKho.UseVisualStyleBackColor = true;
            this.btnPhieuQlyKho.Click += new System.EventHandler(this.btnPhieuQlyKho_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Location = new System.Drawing.Point(348, 243);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(75, 48);
            this.btnXuatKho.TabIndex = 13;
            this.btnXuatKho.Text = "Quản Lý Phiếu Xuất Kho";
            this.btnXuatKho.UseVisualStyleBackColor = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnQlyPhieuNK
            // 
            this.btnQlyPhieuNK.Location = new System.Drawing.Point(207, 243);
            this.btnQlyPhieuNK.Name = "btnQlyPhieuNK";
            this.btnQlyPhieuNK.Size = new System.Drawing.Size(75, 48);
            this.btnQlyPhieuNK.TabIndex = 14;
            this.btnQlyPhieuNK.Text = "Quản Lý Phiếu Nhập Kho";
            this.btnQlyPhieuNK.UseVisualStyleBackColor = true;
            this.btnQlyPhieuNK.Click += new System.EventHandler(this.btnQlyPhieuNK_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(205, 163);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(75, 13);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(205, 105);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblTenKho
            // 
            this.lblTenKho.AutoSize = true;
            this.lblTenKho.Location = new System.Drawing.Point(202, 56);
            this.lblTenKho.Name = "lblTenKho";
            this.lblTenKho.Size = new System.Drawing.Size(48, 13);
            this.lblTenKho.TabIndex = 10;
            this.lblTenKho.Text = "Tên Kho";
            // 
            // treeViewKho
            // 
            this.treeViewKho.Location = new System.Drawing.Point(27, 56);
            this.treeViewKho.Name = "treeViewKho";
            this.treeViewKho.Size = new System.Drawing.Size(136, 235);
            this.treeViewKho.TabIndex = 9;
            this.treeViewKho.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewKho_AfterSelect);
            // 
            // QuanlyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 376);
            this.Controls.Add(this.btnCNKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPhieuQlyKho);
            this.Controls.Add(this.btnXuatKho);
            this.Controls.Add(this.btnQlyPhieuNK);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenKho);
            this.Controls.Add(this.treeViewKho);
            this.Name = "QuanlyKho";
            this.Text = "QuanlyKho";
            this.Load += new System.EventHandler(this.QuanlyKho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCNKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhieuQlyKho;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnQlyPhieuNK;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenKho;
        private System.Windows.Forms.TreeView treeViewKho;
    }
}