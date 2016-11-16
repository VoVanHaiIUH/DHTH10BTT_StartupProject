namespace SRPHR_Solution.CongNoPKH
{
    partial class frmnhacungcap
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
            this.btnthoatncc = new System.Windows.Forms.Button();
            this.btnluuncc = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthoatncc
            // 
            this.btnthoatncc.Location = new System.Drawing.Point(288, 249);
            this.btnthoatncc.Name = "btnthoatncc";
            this.btnthoatncc.Size = new System.Drawing.Size(75, 23);
            this.btnthoatncc.TabIndex = 37;
            this.btnthoatncc.Text = "Thoát";
            this.btnthoatncc.UseVisualStyleBackColor = true;
            this.btnthoatncc.Click += new System.EventHandler(this.btnthoatncc_Click);
            // 
            // btnluuncc
            // 
            this.btnluuncc.Location = new System.Drawing.Point(135, 249);
            this.btnluuncc.Name = "btnluuncc";
            this.btnluuncc.Size = new System.Drawing.Size(75, 23);
            this.btnluuncc.TabIndex = 38;
            this.btnluuncc.Text = "Lưu";
            this.btnluuncc.UseVisualStyleBackColor = true;
            this.btnluuncc.Click += new System.EventHandler(this.btnluuncc_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(143, 172);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(285, 20);
            this.txtMail.TabIndex = 32;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(143, 134);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(285, 20);
            this.txtphone.TabIndex = 33;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(143, 102);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 20);
            this.txtAddress.TabIndex = 34;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(143, 65);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(285, 20);
            this.txtTenNCC.TabIndex = 35;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(143, 30);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(285, 20);
            this.txtMaNCC.TabIndex = 36;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(69, 172);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 13);
            this.lblMail.TabIndex = 27;
            this.lblMail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(35, 134);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 28;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(7, 65);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(100, 13);
            this.lblTenNCC.TabIndex = 29;
            this.lblTenNCC.Text = "Tên Nhà cung cấp:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(61, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 13);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(8, 30);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(96, 13);
            this.lblMaNCC.TabIndex = 31;
            this.lblMaNCC.Text = "Mã Nhà cung cấp:";
            // 
            // frmnhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 302);
            this.Controls.Add(this.btnthoatncc);
            this.Controls.Add(this.btnluuncc);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTenNCC);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMaNCC);
            this.Name = "frmnhacungcap";
            this.Text = "FormNhaCungCap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoatncc;
        private System.Windows.Forms.Button btnluuncc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMaNCC;
    }
}