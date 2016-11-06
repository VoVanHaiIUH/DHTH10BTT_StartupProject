namespace SRPHR_Solution.BanHang
{
    partial class FormMainBH
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
            this.btnhdgtgt = new System.Windows.Forms.Button();
            this.btnhdbanle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhdgtgt
            // 
            this.btnhdgtgt.Location = new System.Drawing.Point(71, 104);
            this.btnhdgtgt.Name = "btnhdgtgt";
            this.btnhdgtgt.Size = new System.Drawing.Size(156, 58);
            this.btnhdgtgt.TabIndex = 0;
            this.btnhdgtgt.Text = "Thông tin Hóa Đơn Bán GTGT";
            this.btnhdgtgt.UseVisualStyleBackColor = true;
            this.btnhdgtgt.Click += new System.EventHandler(this.btnhdgtgt_Click);
            // 
            // btnhdbanle
            // 
            this.btnhdbanle.Location = new System.Drawing.Point(71, 187);
            this.btnhdbanle.Name = "btnhdbanle";
            this.btnhdbanle.Size = new System.Drawing.Size(156, 65);
            this.btnhdbanle.TabIndex = 1;
            this.btnhdbanle.Text = "Thông Tin Hóa Đơn Bán Lẻ";
            this.btnhdbanle.UseVisualStyleBackColor = true;
            this.btnhdbanle.Click += new System.EventHandler(this.btnhdbanle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xin Lựa Chọn Thông Tin Cần Xem!";
            // 
            // FormMainBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhdbanle);
            this.Controls.Add(this.btnhdgtgt);
            this.Name = "FormMainBH";
            this.Text = "FormMainBH";
            this.Load += new System.EventHandler(this.FormMainBH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhdgtgt;
        private System.Windows.Forms.Button btnhdbanle;
        private System.Windows.Forms.Label label1;
    }
}