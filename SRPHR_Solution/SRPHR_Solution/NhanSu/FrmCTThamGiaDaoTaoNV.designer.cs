namespace WindowsFormsApplication1
{
    partial class FrmCTThamGiaDaoTaoNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCTThamGiaDaoTaoNV));
            this.dataGridViewLichSuLamViec = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpBoxCTTGDaoTaoNV = new System.Windows.Forms.GroupBox();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.cbbMaKhoaDT = new System.Windows.Forms.ComboBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblMaKhoaDT = new System.Windows.Forms.Label();
            this.treeViewNhanVien = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichSuLamViec)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpBoxCTTGDaoTaoNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLichSuLamViec
            // 
            this.dataGridViewLichSuLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichSuLamViec.Location = new System.Drawing.Point(215, 137);
            this.dataGridViewLichSuLamViec.Name = "dataGridViewLichSuLamViec";
            this.dataGridViewLichSuLamViec.Size = new System.Drawing.Size(692, 288);
            this.dataGridViewLichSuLamViec.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxCTTGDaoTaoNV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeViewNhanVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewLichSuLamViec, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 429);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 130);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(2, 2);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(106, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(106, 88);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(2, 45);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(106, 45);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(2, 88);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Ẩn trạng thái";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // grpBoxCTTGDaoTaoNV
            // 
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.txtNhanXet);
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.cbbMaKhoaDT);
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.txtKetQua);
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.txtMaNV);
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.lblNhanXet);
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.lblMaNV);
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.lblKetQua);
            this.grpBoxCTTGDaoTaoNV.Controls.Add(this.lblMaKhoaDT);
            this.grpBoxCTTGDaoTaoNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCTTGDaoTaoNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxCTTGDaoTaoNV.ForeColor = System.Drawing.Color.Blue;
            this.grpBoxCTTGDaoTaoNV.Location = new System.Drawing.Point(213, 2);
            this.grpBoxCTTGDaoTaoNV.Margin = new System.Windows.Forms.Padding(1);
            this.grpBoxCTTGDaoTaoNV.Name = "grpBoxCTTGDaoTaoNV";
            this.grpBoxCTTGDaoTaoNV.Padding = new System.Windows.Forms.Padding(1);
            this.grpBoxCTTGDaoTaoNV.Size = new System.Drawing.Size(696, 130);
            this.grpBoxCTTGDaoTaoNV.TabIndex = 20;
            this.grpBoxCTTGDaoTaoNV.TabStop = false;
            this.grpBoxCTTGDaoTaoNV.Text = "Chi Tiết Tham Gia Đào Tạo Nhân Viên";
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Location = new System.Drawing.Point(479, 19);
            this.txtNhanXet.Multiline = true;
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(207, 79);
            this.txtNhanXet.TabIndex = 14;
            // 
            // cbbMaKhoaDT
            // 
            this.cbbMaKhoaDT.FormattingEnabled = true;
            this.cbbMaKhoaDT.Location = new System.Drawing.Point(118, 48);
            this.cbbMaKhoaDT.Name = "cbbMaKhoaDT";
            this.cbbMaKhoaDT.Size = new System.Drawing.Size(260, 23);
            this.cbbMaKhoaDT.TabIndex = 13;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(118, 73);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(1);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(260, 25);
            this.txtKetQua.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(118, 19);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(260, 25);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Location = new System.Drawing.Point(407, 51);
            this.lblNhanXet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.Size = new System.Drawing.Size(64, 15);
            this.lblNhanXet.TabIndex = 12;
            this.lblNhanXet.Text = "Nhận xét :";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(6, 24);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(90, 15);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên :";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(6, 78);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(56, 15);
            this.lblKetQua.TabIndex = 8;
            this.lblKetQua.Text = "Kết quả :";
            // 
            // lblMaKhoaDT
            // 
            this.lblMaKhoaDT.AutoSize = true;
            this.lblMaKhoaDT.Location = new System.Drawing.Point(6, 51);
            this.lblMaKhoaDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaKhoaDT.Name = "lblMaKhoaDT";
            this.lblMaKhoaDT.Size = new System.Drawing.Size(106, 15);
            this.lblMaKhoaDT.TabIndex = 8;
            this.lblMaKhoaDT.Text = "Mã Khoa đào tạo :";
            // 
            // treeViewNhanVien
            // 
            this.treeViewNhanVien.Location = new System.Drawing.Point(4, 137);
            this.treeViewNhanVien.Name = "treeViewNhanVien";
            this.treeViewNhanVien.Size = new System.Drawing.Size(204, 288);
            this.treeViewNhanVien.TabIndex = 29;
            // 
            // FrmCTThamGiaDaoTaoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 429);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCTThamGiaDaoTaoNV";
            this.Text = "FrmChiTietThamGiaDaoTaoNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichSuLamViec)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpBoxCTTGDaoTaoNV.ResumeLayout(false);
            this.grpBoxCTTGDaoTaoNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewLichSuLamViec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpBoxCTTGDaoTaoNV;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblNhanXet;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblMaKhoaDT;
        private System.Windows.Forms.TreeView treeViewNhanVien;
        private System.Windows.Forms.ComboBox cbbMaKhoaDT;
    }
}