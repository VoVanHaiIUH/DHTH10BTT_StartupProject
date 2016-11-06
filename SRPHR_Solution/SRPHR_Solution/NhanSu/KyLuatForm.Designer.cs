namespace SRPHR_Solution.NhanSu
{
    partial class KyLuatForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSửa = new System.Windows.Forms.Button();
            this.btnXóa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataKyLuat = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtHTKL = new System.Windows.Forms.TextBox();
            this.txtMaKL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataKyLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(364, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSửa
            // 
            this.btnSửa.Location = new System.Drawing.Point(261, 252);
            this.btnSửa.Name = "btnSửa";
            this.btnSửa.Size = new System.Drawing.Size(75, 23);
            this.btnSửa.TabIndex = 60;
            this.btnSửa.Text = "Sửa";
            this.btnSửa.UseVisualStyleBackColor = true;
            this.btnSửa.Click += new System.EventHandler(this.btnSửa_Click);
            // 
            // btnXóa
            // 
            this.btnXóa.Location = new System.Drawing.Point(157, 252);
            this.btnXóa.Name = "btnXóa";
            this.btnXóa.Size = new System.Drawing.Size(75, 23);
            this.btnXóa.TabIndex = 59;
            this.btnXóa.Text = "Xóa";
            this.btnXóa.UseVisualStyleBackColor = true;
            this.btnXóa.Click += new System.EventHandler(this.btnXóa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ghi Chú ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Hình Thức Kỷ Luật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã Kỷ Luật ";
            // 
            // dataKyLuat
            // 
            this.dataKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKyLuat.Location = new System.Drawing.Point(457, 47);
            this.dataKyLuat.Name = "dataKyLuat";
            this.dataKyLuat.Size = new System.Drawing.Size(366, 228);
            this.dataKyLuat.TabIndex = 52;
            this.dataKyLuat.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(188, 99);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(222, 20);
            this.txtNote.TabIndex = 48;
            // 
            // txtHTKL
            // 
            this.txtHTKL.Location = new System.Drawing.Point(188, 73);
            this.txtHTKL.Name = "txtHTKL";
            this.txtHTKL.Size = new System.Drawing.Size(222, 20);
            this.txtHTKL.TabIndex = 51;
            // 
            // txtMaKL
            // 
            this.txtMaKL.Location = new System.Drawing.Point(188, 47);
            this.txtMaKL.Name = "txtMaKL";
            this.txtMaKL.Size = new System.Drawing.Size(222, 20);
            this.txtMaKL.TabIndex = 47;
            // 
            // KyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 335);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSửa);
            this.Controls.Add(this.btnXóa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataKyLuat);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtHTKL);
            this.Controls.Add(this.txtMaKL);
            this.Name = "KyLuat";
            this.Text = "KyLuat";
            ((System.ComponentModel.ISupportInitialize)(this.dataKyLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSửa;
        private System.Windows.Forms.Button btnXóa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataKyLuat;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtHTKL;
        private System.Windows.Forms.TextBox txtMaKL;
    }
}