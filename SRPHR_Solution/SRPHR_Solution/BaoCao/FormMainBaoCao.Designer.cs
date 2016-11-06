namespace SRPHR_Solution.BaoCao
{
    partial class FormMainBaoCao
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
            this.btnloaibaocao = new System.Windows.Forms.Button();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnloaibaocao
            // 
            this.btnloaibaocao.Location = new System.Drawing.Point(68, 163);
            this.btnloaibaocao.Name = "btnloaibaocao";
            this.btnloaibaocao.Size = new System.Drawing.Size(120, 55);
            this.btnloaibaocao.TabIndex = 3;
            this.btnloaibaocao.Text = "Loại Báo Cáo";
            this.btnloaibaocao.UseVisualStyleBackColor = true;
            this.btnloaibaocao.Click += new System.EventHandler(this.btnloaibaocao_Click);
            // 
            // btnbaocao
            // 
            this.btnbaocao.Location = new System.Drawing.Point(68, 79);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(120, 49);
            this.btnbaocao.TabIndex = 2;
            this.btnbaocao.Text = "Báo Cáo";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xin Lựa Chọn Thông Tin Cần Xem!";
            // 
            // FormMainBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnloaibaocao);
            this.Controls.Add(this.btnbaocao);
            this.Name = "FormMainBaoCao";
            this.Text = "FormMainBaoCao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnloaibaocao;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.Label label1;
    }
}