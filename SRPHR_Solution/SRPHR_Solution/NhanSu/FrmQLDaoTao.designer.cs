namespace WindowsFormsApplication1
{
    partial class FrmQLDaoTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLDaoTao));
            this.lblTenPB = new System.Windows.Forms.Label();
            this.txtDiadiem = new System.Windows.Forms.TextBox();
            this.grpBoxPhongBan = new System.Windows.Forms.GroupBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGViewPhongBan = new System.Windows.Forms.DataGridView();
            this.grpBoxPhongBan.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(6, 51);
            this.lblTenPB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(94, 15);
            this.lblTenPB.TabIndex = 8;
            this.lblTenPB.Text = "Tên phòng ban :";
            // 
            // txtDiadiem
            // 
            this.txtDiadiem.Enabled = false;
            this.txtDiadiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiadiem.Location = new System.Drawing.Point(118, 73);
            this.txtDiadiem.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiadiem.Name = "txtDiadiem";
            this.txtDiadiem.Size = new System.Drawing.Size(260, 25);
            this.txtDiadiem.TabIndex = 1;
            // 
            // grpBoxPhongBan
            // 
            this.grpBoxPhongBan.Controls.Add(this.txtSoDT);
            this.grpBoxPhongBan.Controls.Add(this.txtMaPB);
            this.grpBoxPhongBan.Controls.Add(this.lblSoDT);
            this.grpBoxPhongBan.Controls.Add(this.lblMaPB);
            this.grpBoxPhongBan.Controls.Add(this.lblDiaDiem);
            this.grpBoxPhongBan.Controls.Add(this.lblTenPB);
            this.grpBoxPhongBan.Controls.Add(this.txtDiadiem);
            this.grpBoxPhongBan.Controls.Add(this.txtTenPB);
            this.grpBoxPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxPhongBan.ForeColor = System.Drawing.Color.Blue;
            this.grpBoxPhongBan.Location = new System.Drawing.Point(213, 2);
            this.grpBoxPhongBan.Margin = new System.Windows.Forms.Padding(1);
            this.grpBoxPhongBan.Name = "grpBoxPhongBan";
            this.grpBoxPhongBan.Padding = new System.Windows.Forms.Padding(1);
            this.grpBoxPhongBan.Size = new System.Drawing.Size(878, 130);
            this.grpBoxPhongBan.TabIndex = 20;
            this.grpBoxPhongBan.TabStop = false;
            this.grpBoxPhongBan.Text = "Thông tin phòng ban";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(517, 46);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(1);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(260, 25);
            this.txtSoDT.TabIndex = 0;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Enabled = false;
            this.txtMaPB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPB.Location = new System.Drawing.Point(118, 19);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(260, 25);
            this.txtMaPB.TabIndex = 0;
            // 
            // lblSoDT
            // 
            this.lblSoDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(425, 51);
            this.lblSoDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(86, 15);
            this.lblSoDT.TabIndex = 12;
            this.lblSoDT.Text = "Số điện thoại :";
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(6, 24);
            this.lblMaPB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(91, 15);
            this.lblMaPB.TabIndex = 0;
            this.lblMaPB.Text = "Mã phòng ban :";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(6, 78);
            this.lblDiaDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(63, 15);
            this.lblDiaDiem.TabIndex = 8;
            this.lblDiaDiem.Text = "Địa điểm :";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Enabled = false;
            this.txtTenPB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPB.Location = new System.Drawing.Point(118, 46);
            this.txtTenPB.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(260, 25);
            this.txtTenPB.TabIndex = 1;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxPhongBan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGViewPhongBan, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 434);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // DGViewPhongBan
            // 
            this.DGViewPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGViewPhongBan, 2);
            this.DGViewPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewPhongBan.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGViewPhongBan.Location = new System.Drawing.Point(2, 135);
            this.DGViewPhongBan.Margin = new System.Windows.Forms.Padding(1);
            this.DGViewPhongBan.Name = "DGViewPhongBan";
            this.DGViewPhongBan.Size = new System.Drawing.Size(1089, 297);
            this.DGViewPhongBan.TabIndex = 0;
            // 
            // FrmQLDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmQLDaoTao";
            this.Text = "FrmQLPhongBan";
            this.grpBoxPhongBan.ResumeLayout(false);
            this.grpBoxPhongBan.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPhongBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.TextBox txtDiadiem;
        private System.Windows.Forms.GroupBox grpBoxPhongBan;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGViewPhongBan;
        private System.Windows.Forms.TextBox txtSoDT;
    }
}