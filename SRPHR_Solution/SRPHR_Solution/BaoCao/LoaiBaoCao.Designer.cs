namespace SRPHR_Solution.BaoCao
{
    partial class LoaiBaoCao
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
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(148, 65);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(203, 20);
            this.txttenloai.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tên Loại";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(148, 39);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(203, 20);
            this.txtmaloai.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Loại";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 154);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(437, 94);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(77, 33);
            this.btnsua.TabIndex = 31;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(437, 202);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(78, 33);
            this.btnthoat.TabIndex = 29;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(437, 39);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(77, 33);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(437, 150);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(77, 33);
            this.btnxoa.TabIndex = 30;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(437, 258);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(78, 35);
            this.btnquaylai.TabIndex = 33;
            this.btnquaylai.Text = "Quay Lại ";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // LoaiBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 318);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.label1);
            this.Name = "LoaiBaoCao";
            this.Text = "LoaiBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnquaylai;
    }
}