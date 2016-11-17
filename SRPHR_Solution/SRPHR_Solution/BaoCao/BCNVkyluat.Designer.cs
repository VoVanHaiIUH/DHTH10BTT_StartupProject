namespace SRPHR_Solution.BaoCao
{
    partial class BCNVkyluat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.vw_BCKyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_BCKyLuatTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_BCKyLuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCKyLuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vw_BCKyLuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRPHR_Solution.BaoCao.BCNVkyluat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 147);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(763, 276);
            this.reportViewer1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "BÁO CÁO NHÂN VIÊN BỊ KỶ LUẬT THEO THÁNG";
            // 
            // DataSetbaocao1
            // 
            this.DataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.DataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_BCKyLuatBindingSource
            // 
            this.vw_BCKyLuatBindingSource.DataMember = "vw_BCKyLuat";
            this.vw_BCKyLuatBindingSource.DataSource = this.DataSetbaocao1;
            // 
            // vw_BCKyLuatTableAdapter
            // 
            this.vw_BCKyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // BCNVkyluat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BCNVkyluat";
            this.Text = "BCNVkyluat";
            this.Load += new System.EventHandler(this.BCNVkyluat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCKyLuatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_BCKyLuatBindingSource;
        private DataSetbaocao1 DataSetbaocao1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSetbaocao1TableAdapters.vw_BCKyLuatTableAdapter vw_BCKyLuatTableAdapter;
    }
}