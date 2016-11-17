namespace SRPHR_Solution.BaoCao
{
    partial class baocaochitietsanpham
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.tblSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SanPhamTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.Tbl_SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblSanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRPHR_Solution.BaoCao.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(613, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetbaocao1
            // 
            this.dataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.dataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSanPhamBindingSource
            // 
            this.tblSanPhamBindingSource.DataMember = "Tbl_SanPham";
            this.tblSanPhamBindingSource.DataSource = this.dataSetbaocao1;
            // 
            // tbl_SanPhamTableAdapter
            // 
            this.tbl_SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // baocaochitietsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "baocaochitietsanpham";
            this.Text = "baocaochitietsanpham";
            this.Load += new System.EventHandler(this.baocaochitietsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetbaocao1 dataSetbaocao1;
        private System.Windows.Forms.BindingSource tblSanPhamBindingSource;
        private DataSetbaocao1TableAdapters.Tbl_SanPhamTableAdapter tbl_SanPhamTableAdapter;
    }
}