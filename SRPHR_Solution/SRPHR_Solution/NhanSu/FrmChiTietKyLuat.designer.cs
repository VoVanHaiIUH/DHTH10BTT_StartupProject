namespace WindowsFormsApplication1
{
    partial class FrmChiTietKyLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietKyLuat));
            this.dateTimePickerNgayThiHanh = new System.Windows.Forms.DateTimePicker();
            this.cbbHinhThucKyLuat = new System.Windows.Forms.ComboBox();
            this.cbbMaKL = new System.Windows.Forms.ComboBox();
            this.labelNgayThiHanh = new System.Windows.Forms.Label();
            this.dataGridViewChiTietKyLuat = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbbMucDo = new System.Windows.Forms.ComboBox();
            this.cbbMaCV = new System.Windows.Forms.ComboBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblMaChucVu = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHinhThucKL = new System.Windows.Forms.Label();
            this.lblMaKL = new System.Windows.Forms.Label();
            this.treeViewNhanVien = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietKyLuat)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpBoxStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerNgayThiHanh
            // 
            this.dateTimePickerNgayThiHanh.Location = new System.Drawing.Point(435, 46);
            this.dateTimePickerNgayThiHanh.Name = "dateTimePickerNgayThiHanh";
            this.dateTimePickerNgayThiHanh.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerNgayThiHanh.TabIndex = 14;
            // 
            // cbbHinhThucKyLuat
            // 
            this.cbbHinhThucKyLuat.FormattingEnabled = true;
            this.cbbHinhThucKyLuat.Location = new System.Drawing.Point(118, 75);
            this.cbbHinhThucKyLuat.Name = "cbbHinhThucKyLuat";
            this.cbbHinhThucKyLuat.Size = new System.Drawing.Size(214, 23);
            this.cbbHinhThucKyLuat.TabIndex = 13;
            // 
            // cbbMaKL
            // 
            this.cbbMaKL.FormattingEnabled = true;
            this.cbbMaKL.Location = new System.Drawing.Point(118, 48);
            this.cbbMaKL.Name = "cbbMaKL";
            this.cbbMaKL.Size = new System.Drawing.Size(214, 23);
            this.cbbMaKL.TabIndex = 13;
            // 
            // labelNgayThiHanh
            // 
            this.labelNgayThiHanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNgayThiHanh.AutoSize = true;
            this.labelNgayThiHanh.Location = new System.Drawing.Point(341, 49);
            this.labelNgayThiHanh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNgayThiHanh.Name = "labelNgayThiHanh";
            this.labelNgayThiHanh.Size = new System.Drawing.Size(93, 15);
            this.labelNgayThiHanh.TabIndex = 12;
            this.labelNgayThiHanh.Text = "Ngày Thi Hành :";
            // 
            // dataGridViewChiTietKyLuat
            // 
            this.dataGridViewChiTietKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietKyLuat.Location = new System.Drawing.Point(215, 137);
            this.dataGridViewChiTietKyLuat.Name = "dataGridViewChiTietKyLuat";
            this.dataGridViewChiTietKyLuat.Size = new System.Drawing.Size(936, 306);
            this.dataGridViewChiTietKyLuat.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxStudentInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeViewNhanVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewChiTietKyLuat, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1155, 449);
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
            // grpBoxStudentInfo
            // 
            this.grpBoxStudentInfo.Controls.Add(this.txtGhiChu);
            this.grpBoxStudentInfo.Controls.Add(this.dateTimePickerNgayThiHanh);
            this.grpBoxStudentInfo.Controls.Add(this.dateTimePickerNgayLap);
            this.grpBoxStudentInfo.Controls.Add(this.cbbMucDo);
            this.grpBoxStudentInfo.Controls.Add(this.cbbMaCV);
            this.grpBoxStudentInfo.Controls.Add(this.cbbHinhThucKyLuat);
            this.grpBoxStudentInfo.Controls.Add(this.cbbMaKL);
            this.grpBoxStudentInfo.Controls.Add(this.txtLyDo);
            this.grpBoxStudentInfo.Controls.Add(this.txtMaNV);
            this.grpBoxStudentInfo.Controls.Add(this.lblLyDo);
            this.grpBoxStudentInfo.Controls.Add(this.lblMucDo);
            this.grpBoxStudentInfo.Controls.Add(this.labelNgayThiHanh);
            this.grpBoxStudentInfo.Controls.Add(this.lblGhiChu);
            this.grpBoxStudentInfo.Controls.Add(this.lblNgayLap);
            this.grpBoxStudentInfo.Controls.Add(this.lblMaChucVu);
            this.grpBoxStudentInfo.Controls.Add(this.lblMaNV);
            this.grpBoxStudentInfo.Controls.Add(this.lblHinhThucKL);
            this.grpBoxStudentInfo.Controls.Add(this.lblMaKL);
            this.grpBoxStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxStudentInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpBoxStudentInfo.Location = new System.Drawing.Point(213, 2);
            this.grpBoxStudentInfo.Margin = new System.Windows.Forms.Padding(1);
            this.grpBoxStudentInfo.Name = "grpBoxStudentInfo";
            this.grpBoxStudentInfo.Padding = new System.Windows.Forms.Padding(1);
            this.grpBoxStudentInfo.Size = new System.Drawing.Size(940, 130);
            this.grpBoxStudentInfo.TabIndex = 20;
            this.grpBoxStudentInfo.TabStop = false;
            this.grpBoxStudentInfo.Text = "Chi tiết kỷ luật";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(706, 24);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(224, 88);
            this.txtGhiChu.TabIndex = 15;
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(435, 16);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerNgayLap.TabIndex = 14;
            // 
            // cbbMucDo
            // 
            this.cbbMucDo.FormattingEnabled = true;
            this.cbbMucDo.Location = new System.Drawing.Point(435, 75);
            this.cbbMucDo.Name = "cbbMucDo";
            this.cbbMucDo.Size = new System.Drawing.Size(200, 23);
            this.cbbMucDo.TabIndex = 13;
            // 
            // cbbMaCV
            // 
            this.cbbMaCV.FormattingEnabled = true;
            this.cbbMaCV.Location = new System.Drawing.Point(118, 103);
            this.cbbMaCV.Name = "cbbMaCV";
            this.cbbMaCV.Size = new System.Drawing.Size(214, 23);
            this.cbbMaCV.TabIndex = 13;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Enabled = false;
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(435, 102);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(1);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(200, 20);
            this.txtLyDo.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(118, 19);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(214, 25);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblLyDo
            // 
            this.lblLyDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(341, 106);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(42, 15);
            this.lblLyDo.TabIndex = 12;
            this.lblLyDo.Text = "Lý do :";
            // 
            // lblMucDo
            // 
            this.lblMucDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Location = new System.Drawing.Point(341, 79);
            this.lblMucDo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(56, 15);
            this.lblMucDo.TabIndex = 12;
            this.lblMucDo.Text = "Mức độ :";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(643, 58);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(55, 15);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "Ghi chú :";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(341, 22);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(63, 15);
            this.lblNgayLap.TabIndex = 12;
            this.lblNgayLap.Text = "Ngày Lập :";
            // 
            // lblMaChucVu
            // 
            this.lblMaChucVu.AutoSize = true;
            this.lblMaChucVu.Location = new System.Drawing.Point(6, 106);
            this.lblMaChucVu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaChucVu.Name = "lblMaChucVu";
            this.lblMaChucVu.Size = new System.Drawing.Size(77, 15);
            this.lblMaChucVu.TabIndex = 8;
            this.lblMaChucVu.Text = "Mã chức vụ :";
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
            // lblHinhThucKL
            // 
            this.lblHinhThucKL.AutoSize = true;
            this.lblHinhThucKL.Location = new System.Drawing.Point(6, 78);
            this.lblHinhThucKL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHinhThucKL.Name = "lblHinhThucKL";
            this.lblHinhThucKL.Size = new System.Drawing.Size(108, 15);
            this.lblHinhThucKL.TabIndex = 8;
            this.lblHinhThucKL.Text = "Hình thức kỷ luật :";
            // 
            // lblMaKL
            // 
            this.lblMaKL.AutoSize = true;
            this.lblMaKL.Location = new System.Drawing.Point(6, 51);
            this.lblMaKL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaKL.Name = "lblMaKL";
            this.lblMaKL.Size = new System.Drawing.Size(68, 15);
            this.lblMaKL.TabIndex = 8;
            this.lblMaKL.Text = "Mã Kỷ Luật";
            // 
            // treeViewNhanVien
            // 
            this.treeViewNhanVien.Location = new System.Drawing.Point(4, 137);
            this.treeViewNhanVien.Name = "treeViewNhanVien";
            this.treeViewNhanVien.Size = new System.Drawing.Size(204, 306);
            this.treeViewNhanVien.TabIndex = 29;
            // 
            // FrmChiTietKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmChiTietKyLuat";
            this.Text = "FrmChiTietKyLuat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietKyLuat)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpBoxStudentInfo.ResumeLayout(false);
            this.grpBoxStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThiHanh;
        private System.Windows.Forms.ComboBox cbbHinhThucKyLuat;
        private System.Windows.Forms.ComboBox cbbMaKL;
        private System.Windows.Forms.Label labelNgayThiHanh;
        private System.Windows.Forms.DataGridView dataGridViewChiTietKyLuat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpBoxStudentInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblHinhThucKL;
        private System.Windows.Forms.Label lblMaKL;
        private System.Windows.Forms.TreeView treeViewNhanVien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbbMucDo;
        private System.Windows.Forms.ComboBox cbbMaCV;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblMaChucVu;
        private System.Windows.Forms.TextBox txtLyDo;
    }
}