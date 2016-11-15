namespace SRPHR_Solution
{
    partial class FormDangKi
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
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxacnhanmk = new System.Windows.Forms.TextBox();
            this.btndangki = new System.Windows.Forms.Button();
            this.btntrolai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Location = new System.Drawing.Point(123, 18);
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(100, 20);
            this.txttentaikhoan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu :";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(123, 52);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(100, 20);
            this.txtmatkhau.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu :";
            // 
            // txtxacnhanmk
            // 
            this.txtxacnhanmk.Location = new System.Drawing.Point(123, 87);
            this.txtxacnhanmk.Name = "txtxacnhanmk";
            this.txtxacnhanmk.PasswordChar = '*';
            this.txtxacnhanmk.Size = new System.Drawing.Size(100, 20);
            this.txtxacnhanmk.TabIndex = 4;
            // 
            // btndangki
            // 
            this.btndangki.Location = new System.Drawing.Point(15, 19);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(75, 23);
            this.btndangki.TabIndex = 8;
            this.btndangki.Text = "Đăng kí";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // btntrolai
            // 
            this.btntrolai.Location = new System.Drawing.Point(137, 19);
            this.btntrolai.Name = "btntrolai";
            this.btntrolai.Size = new System.Drawing.Size(75, 23);
            this.btntrolai.TabIndex = 9;
            this.btntrolai.Text = "Trở lại";
            this.btntrolai.UseVisualStyleBackColor = true;
            this.btntrolai.Click += new System.EventHandler(this.btntrolai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã NV :";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(122, 121);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Kí";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntrolai);
            this.groupBox2.Controls.Add(this.btndangki);
            this.groupBox2.Location = new System.Drawing.Point(1, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 52);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // FormDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(242, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtxacnhanmk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormDangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangKi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxacnhanmk;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Button btntrolai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}