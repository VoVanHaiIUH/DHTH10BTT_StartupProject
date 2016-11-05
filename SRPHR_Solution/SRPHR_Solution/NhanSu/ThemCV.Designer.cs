namespace SRPHR_Solution.NhanSu
{
    partial class ThemCV
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
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtHeso = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dataChucVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSửa = new System.Windows.Forms.Button();
            this.btnXóa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(126, 31);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(171, 20);
            this.txtMaCV.TabIndex = 0;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(126, 57);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(171, 20);
            this.txtTenCV.TabIndex = 0;
            // 
            // txtHeso
            // 
            this.txtHeso.Location = new System.Drawing.Point(126, 83);
            this.txtHeso.Name = "txtHeso";
            this.txtHeso.Size = new System.Drawing.Size(171, 20);
            this.txtHeso.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(126, 109);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(171, 20);
            this.txtNote.TabIndex = 0;
            // 
            // dataChucVu
            // 
            this.dataChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChucVu.Location = new System.Drawing.Point(322, 31);
            this.dataChucVu.Name = "dataChucVu";
            this.dataChucVu.Size = new System.Drawing.Size(333, 150);
            this.dataChucVu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ Số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ghi Chú";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(580, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSửa
            // 
            this.btnSửa.Location = new System.Drawing.Point(222, 205);
            this.btnSửa.Name = "btnSửa";
            this.btnSửa.Size = new System.Drawing.Size(75, 23);
            this.btnSửa.TabIndex = 18;
            this.btnSửa.Text = "Sửa";
            this.btnSửa.UseVisualStyleBackColor = true;
            this.btnSửa.Click += new System.EventHandler(this.btnSửa_Click);
            // 
            // btnXóa
            // 
            this.btnXóa.Location = new System.Drawing.Point(118, 205);
            this.btnXóa.Name = "btnXóa";
            this.btnXóa.Size = new System.Drawing.Size(75, 23);
            this.btnXóa.TabIndex = 17;
            this.btnXóa.Text = "Xóa";
            this.btnXóa.UseVisualStyleBackColor = true;
            this.btnXóa.Click += new System.EventHandler(this.btnXóa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ThemCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 251);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSửa);
            this.Controls.Add(this.btnXóa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataChucVu);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtHeso);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtMaCV);
            this.Name = "ThemCV";
            this.Text = "ThemCV";
            this.Load += new System.EventHandler(this.ThemCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtHeso;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridView dataChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSửa;
        private System.Windows.Forms.Button btnXóa;
        private System.Windows.Forms.Button btnAdd;
    }
}