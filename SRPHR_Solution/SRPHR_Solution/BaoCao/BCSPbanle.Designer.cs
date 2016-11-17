namespace SRPHR_Solution.BaoCao
{
    partial class BCSPbanle
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_BCSPBanLeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.vw_baocaokhuyenmaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vw_baocaokhuyenmaiTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_baocaokhuyenmaiTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vw_BCSPBanLeTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_BCSPBanLeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCSPBanLeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_baocaokhuyenmaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_BCSPBanLeBindingSource
            // 
            this.vw_BCSPBanLeBindingSource.DataMember = "vw_BCSPBanLe";
            this.vw_BCSPBanLeBindingSource.DataSource = this.DataSetbaocao1;
            // 
            // DataSetbaocao1
            // 
            this.DataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.DataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_baocaokhuyenmaiBindingSource
            // 
            this.vw_baocaokhuyenmaiBindingSource.DataMember = "vw_baocaokhuyenmai";
            this.vw_baocaokhuyenmaiBindingSource.DataSource = this.DataSetbaocao1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.vw_BCSPBanLeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRPHR_Solution.BaoCao.BCSPbanle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(94, 130);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(654, 246);
            this.reportViewer1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Năm:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Xem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "BÁO CÁO VỀ CÁC SẢN PHẨM BÁN LẺ THEO THÁNG";
            // 
            // vw_baocaokhuyenmaiTableAdapter
            // 
            this.vw_baocaokhuyenmaiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(423, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // vw_BCSPBanLeTableAdapter
            // 
            this.vw_BCSPBanLeTableAdapter.ClearBeforeFill = true;
            // 
            // BCSPbanle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 445);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "BCSPbanle";
            this.Text = "BCSPbanle";
            this.Load += new System.EventHandler(this.BCSPbanle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCSPBanLeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_baocaokhuyenmaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vw_baocaokhuyenmaiBindingSource;
        private DataSetbaocao1 DataSetbaocao1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_BCSPBanLeBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DataSetbaocao1TableAdapters.vw_baocaokhuyenmaiTableAdapter vw_baocaokhuyenmaiTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private DataSetbaocao1TableAdapters.vw_BCSPBanLeTableAdapter vw_BCSPBanLeTableAdapter;
    }
}