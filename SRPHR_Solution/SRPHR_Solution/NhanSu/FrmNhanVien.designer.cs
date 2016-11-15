namespace WindowsFormsApplication1
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpBoxNhanVien = new System.Windows.Forms.GroupBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lblĐiaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblNgayCapCMND = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtNgayCapCMND = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGViewNhanVien = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.grpBoxNhanVien.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 51);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(51, 15);
            this.lblHoTen.TabIndex = 8;
            this.lblHoTen.Text = "Họ tên :";
            // 
            // grpBoxNhanVien
            // 
            this.grpBoxNhanVien.Controls.Add(this.dateTimePickerNgayVaoLam);
            this.grpBoxNhanVien.Controls.Add(this.dateTimePickerNgaySinh);
            this.grpBoxNhanVien.Controls.Add(this.txtSoCMND);
            this.grpBoxNhanVien.Controls.Add(this.txtMaNV);
            this.grpBoxNhanVien.Controls.Add(this.lblSoCMND);
            this.grpBoxNhanVien.Controls.Add(this.lbTrangThai);
            this.grpBoxNhanVien.Controls.Add(this.lblĐiaChi);
            this.grpBoxNhanVien.Controls.Add(this.lblEmail);
            this.grpBoxNhanVien.Controls.Add(this.lblMaNV);
            this.grpBoxNhanVien.Controls.Add(this.lblSoDT);
            this.grpBoxNhanVien.Controls.Add(this.lblGioiTinh);
            this.grpBoxNhanVien.Controls.Add(this.lblNgayVaoLam);
            this.grpBoxNhanVien.Controls.Add(this.lblNgayCapCMND);
            this.grpBoxNhanVien.Controls.Add(this.lblNgaySinh);
            this.grpBoxNhanVien.Controls.Add(this.txtTrangThai);
            this.grpBoxNhanVien.Controls.Add(this.txtDiaChi);
            this.grpBoxNhanVien.Controls.Add(this.txtEmail);
            this.grpBoxNhanVien.Controls.Add(this.txtSoDT);
            this.grpBoxNhanVien.Controls.Add(this.lblHoTen);
            this.grpBoxNhanVien.Controls.Add(this.txtGioitinh);
            this.grpBoxNhanVien.Controls.Add(this.txtNgayCapCMND);
            this.grpBoxNhanVien.Controls.Add(this.txtHoTen);
            this.grpBoxNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.grpBoxNhanVien.Location = new System.Drawing.Point(213, 2);
            this.grpBoxNhanVien.Margin = new System.Windows.Forms.Padding(1);
            this.grpBoxNhanVien.Name = "grpBoxNhanVien";
            this.grpBoxNhanVien.Padding = new System.Windows.Forms.Padding(1);
            this.grpBoxNhanVien.Size = new System.Drawing.Size(1139, 130);
            this.grpBoxNhanVien.TabIndex = 20;
            this.grpBoxNhanVien.TabStop = false;
            this.grpBoxNhanVien.Text = "Thông tin nhân viên";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Enabled = false;
            this.txtSoCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCMND.Location = new System.Drawing.Point(475, 19);
            this.txtSoCMND.Margin = new System.Windows.Forms.Padding(1);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(234, 25);
            this.txtSoCMND.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(121, 19);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(228, 25);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Location = new System.Drawing.Point(363, 24);
            this.lblSoCMND.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(64, 15);
            this.lblSoCMND.TabIndex = 0;
            this.lblSoCMND.Text = "số CMND :";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(720, 78);
            this.lbTrangThai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(68, 15);
            this.lbTrangThai.TabIndex = 8;
            this.lbTrangThai.Text = "Trạng thái :";
            // 
            // lblĐiaChi
            // 
            this.lblĐiaChi.AutoSize = true;
            this.lblĐiaChi.Location = new System.Drawing.Point(720, 51);
            this.lblĐiaChi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblĐiaChi.Name = "lblĐiaChi";
            this.lblĐiaChi.Size = new System.Drawing.Size(50, 15);
            this.lblĐiaChi.TabIndex = 8;
            this.lblĐiaChi.Text = "Địa chỉ :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(363, 105);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email :";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(6, 24);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(87, 15);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên :";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(720, 24);
            this.lblSoDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(86, 15);
            this.lblSoDT.TabIndex = 8;
            this.lblSoDT.Text = "Số điện thoại :";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(363, 78);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(61, 15);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(6, 105);
            this.lblNgayVaoLam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(87, 15);
            this.lblNgayVaoLam.TabIndex = 8;
            this.lblNgayVaoLam.Text = "Ngày vào làm :";
            // 
            // lblNgayCapCMND
            // 
            this.lblNgayCapCMND.AutoSize = true;
            this.lblNgayCapCMND.Location = new System.Drawing.Point(363, 51);
            this.lblNgayCapCMND.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgayCapCMND.Name = "lblNgayCapCMND";
            this.lblNgayCapCMND.Size = new System.Drawing.Size(102, 15);
            this.lblNgayCapCMND.TabIndex = 8;
            this.lblNgayCapCMND.Text = "Ngày cấp CMND :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(6, 78);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(66, 15);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(812, 73);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(297, 25);
            this.txtTrangThai.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(812, 46);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(297, 25);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(475, 100);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(812, 19);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(1);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(297, 25);
            this.txtSoDT.TabIndex = 1;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Enabled = false;
            this.txtGioitinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioitinh.Location = new System.Drawing.Point(475, 73);
            this.txtGioitinh.Margin = new System.Windows.Forms.Padding(1);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(234, 25);
            this.txtGioitinh.TabIndex = 1;
            // 
            // txtNgayCapCMND
            // 
            this.txtNgayCapCMND.Enabled = false;
            this.txtNgayCapCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayCapCMND.Location = new System.Drawing.Point(475, 46);
            this.txtNgayCapCMND.Margin = new System.Windows.Forms.Padding(1);
            this.txtNgayCapCMND.Name = "txtNgayCapCMND";
            this.txtNgayCapCMND.Size = new System.Drawing.Size(234, 25);
            this.txtNgayCapCMND.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(121, 46);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(1);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(228, 25);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
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
            this.tableLayoutPanel1.Controls.Add(this.grpBoxNhanVien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGViewNhanVien, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 497);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // DGViewNhanVien
            // 
            this.DGViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGViewNhanVien, 2);
            this.DGViewNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewNhanVien.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGViewNhanVien.Location = new System.Drawing.Point(2, 135);
            this.DGViewNhanVien.Margin = new System.Windows.Forms.Padding(1);
            this.DGViewNhanVien.Name = "DGViewNhanVien";
            this.DGViewNhanVien.Size = new System.Drawing.Size(1350, 360);
            this.DGViewNhanVien.TabIndex = 0;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(121, 75);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(228, 23);
            this.dateTimePickerNgaySinh.TabIndex = 9;
            // 
            // dateTimePickerNgayVaoLam
            // 
            this.dateTimePickerNgayVaoLam.Location = new System.Drawing.Point(121, 103);
            this.dateTimePickerNgayVaoLam.Name = "dateTimePickerNgayVaoLam";
            this.dateTimePickerNgayVaoLam.Size = new System.Drawing.Size(228, 23);
            this.dateTimePickerNgayVaoLam.TabIndex = 9;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.grpBoxNhanVien.ResumeLayout(false);
            this.grpBoxNhanVien.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox grpBoxNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblNgayCapCMND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtNgayCapCMND;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lblĐiaChi;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.DataGridView DGViewNhanVien;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
    }
}