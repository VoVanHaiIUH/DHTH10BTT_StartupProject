namespace WindowsFormsApplication1
{
    partial class FrmDaoTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDaoTao));
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.grpBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtMakhoa = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblChiphi = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblHinhThucDaoTao = new System.Windows.Forms.Label();
            this.txtChiphi = new System.Windows.Forms.TextBox();
            this.txtHinhthucdaotao = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGViewDaoTao = new System.Windows.Forms.DataGridView();
            this.grpBoxStudentInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewDaoTao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(6, 51);
            this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(63, 15);
            this.lblTenKhoa.TabIndex = 8;
            this.lblTenKhoa.Text = "Tên khoa :";
            // 
            // grpBoxStudentInfo
            // 
            this.grpBoxStudentInfo.Controls.Add(this.dateTimePickerNgayketthuc);
            this.grpBoxStudentInfo.Controls.Add(this.dateTimePickerNgaybatdau);
            this.grpBoxStudentInfo.Controls.Add(this.txtDiaDiem);
            this.grpBoxStudentInfo.Controls.Add(this.txtMakhoa);
            this.grpBoxStudentInfo.Controls.Add(this.lblDiaDiem);
            this.grpBoxStudentInfo.Controls.Add(this.lblMaKhoa);
            this.grpBoxStudentInfo.Controls.Add(this.lblNgayKetThuc);
            this.grpBoxStudentInfo.Controls.Add(this.lblChiphi);
            this.grpBoxStudentInfo.Controls.Add(this.lblNgayBatDau);
            this.grpBoxStudentInfo.Controls.Add(this.lblHinhThucDaoTao);
            this.grpBoxStudentInfo.Controls.Add(this.lblTenKhoa);
            this.grpBoxStudentInfo.Controls.Add(this.txtChiphi);
            this.grpBoxStudentInfo.Controls.Add(this.txtHinhthucdaotao);
            this.grpBoxStudentInfo.Controls.Add(this.txtTenKhoa);
            this.grpBoxStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxStudentInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpBoxStudentInfo.Location = new System.Drawing.Point(213, 2);
            this.grpBoxStudentInfo.Margin = new System.Windows.Forms.Padding(1);
            this.grpBoxStudentInfo.Name = "grpBoxStudentInfo";
            this.grpBoxStudentInfo.Padding = new System.Windows.Forms.Padding(1);
            this.grpBoxStudentInfo.Size = new System.Drawing.Size(844, 130);
            this.grpBoxStudentInfo.TabIndex = 20;
            this.grpBoxStudentInfo.TabStop = false;
            this.grpBoxStudentInfo.Text = "Thông tin đào tạo";
            // 
            // dateTimePickerNgayketthuc
            // 
            this.dateTimePickerNgayketthuc.Location = new System.Drawing.Point(118, 99);
            this.dateTimePickerNgayketthuc.Name = "dateTimePickerNgayketthuc";
            this.dateTimePickerNgayketthuc.Size = new System.Drawing.Size(260, 23);
            this.dateTimePickerNgayketthuc.TabIndex = 9;
            // 
            // dateTimePickerNgaybatdau
            // 
            this.dateTimePickerNgaybatdau.Location = new System.Drawing.Point(118, 75);
            this.dateTimePickerNgaybatdau.Name = "dateTimePickerNgaybatdau";
            this.dateTimePickerNgaybatdau.Size = new System.Drawing.Size(260, 23);
            this.dateTimePickerNgaybatdau.TabIndex = 9;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Enabled = false;
            this.txtDiaDiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(507, 19);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(260, 25);
            this.txtDiaDiem.TabIndex = 0;
            // 
            // txtMakhoa
            // 
            this.txtMakhoa.Enabled = false;
            this.txtMakhoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakhoa.Location = new System.Drawing.Point(118, 19);
            this.txtMakhoa.Margin = new System.Windows.Forms.Padding(1);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.Size = new System.Drawing.Size(260, 25);
            this.txtMakhoa.TabIndex = 0;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(388, 24);
            this.lblDiaDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(63, 15);
            this.lblDiaDiem.TabIndex = 0;
            this.lblDiaDiem.Text = "Địa điểm :";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(6, 24);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(60, 15);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã khoa :";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(6, 105);
            this.lblNgayKetThuc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(91, 15);
            this.lblNgayKetThuc.TabIndex = 8;
            this.lblNgayKetThuc.Text = "Ngày kết thúc :";
            // 
            // lblChiphi
            // 
            this.lblChiphi.AutoSize = true;
            this.lblChiphi.Location = new System.Drawing.Point(388, 78);
            this.lblChiphi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChiphi.Name = "lblChiphi";
            this.lblChiphi.Size = new System.Drawing.Size(50, 15);
            this.lblChiphi.TabIndex = 8;
            this.lblChiphi.Text = "Chi phí :";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(6, 78);
            this.lblNgayBatDau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(86, 15);
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Ngày bắt đầu :";
            // 
            // lblHinhThucDaoTao
            // 
            this.lblHinhThucDaoTao.AutoSize = true;
            this.lblHinhThucDaoTao.Location = new System.Drawing.Point(388, 51);
            this.lblHinhThucDaoTao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHinhThucDaoTao.Name = "lblHinhThucDaoTao";
            this.lblHinhThucDaoTao.Size = new System.Drawing.Size(113, 15);
            this.lblHinhThucDaoTao.TabIndex = 8;
            this.lblHinhThucDaoTao.Text = "Hình thức đào tạo :";
            // 
            // txtChiphi
            // 
            this.txtChiphi.Enabled = false;
            this.txtChiphi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiphi.Location = new System.Drawing.Point(507, 73);
            this.txtChiphi.Margin = new System.Windows.Forms.Padding(1);
            this.txtChiphi.Name = "txtChiphi";
            this.txtChiphi.Size = new System.Drawing.Size(260, 25);
            this.txtChiphi.TabIndex = 1;
            // 
            // txtHinhthucdaotao
            // 
            this.txtHinhthucdaotao.Enabled = false;
            this.txtHinhthucdaotao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhthucdaotao.Location = new System.Drawing.Point(507, 46);
            this.txtHinhthucdaotao.Margin = new System.Windows.Forms.Padding(1);
            this.txtHinhthucdaotao.Name = "txtHinhthucdaotao";
            this.txtHinhthucdaotao.Size = new System.Drawing.Size(260, 25);
            this.txtHinhthucdaotao.TabIndex = 1;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Enabled = false;
            this.txtTenKhoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Location = new System.Drawing.Point(118, 46);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(260, 25);
            this.txtTenKhoa.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxStudentInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGViewDaoTao, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1059, 472);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // DGViewDaoTao
            // 
            this.DGViewDaoTao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGViewDaoTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGViewDaoTao, 2);
            this.DGViewDaoTao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewDaoTao.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGViewDaoTao.Location = new System.Drawing.Point(2, 135);
            this.DGViewDaoTao.Margin = new System.Windows.Forms.Padding(1);
            this.DGViewDaoTao.Name = "DGViewDaoTao";
            this.DGViewDaoTao.Size = new System.Drawing.Size(1055, 335);
            this.DGViewDaoTao.TabIndex = 0;
            // 
            // FrmDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmDaoTao";
            this.Text = "FrmDaoTao";
            this.Load += new System.EventHandler(this.FrmDaoTao_Load);
            this.grpBoxStudentInfo.ResumeLayout(false);
            this.grpBoxStudentInfo.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewDaoTao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.GroupBox grpBoxStudentInfo;
        private System.Windows.Forms.TextBox txtMakhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGViewDaoTao;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayketthuc;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaybatdau;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblChiphi;
        private System.Windows.Forms.Label lblHinhThucDaoTao;
        private System.Windows.Forms.TextBox txtChiphi;
        private System.Windows.Forms.TextBox txtHinhthucdaotao;
    }
}