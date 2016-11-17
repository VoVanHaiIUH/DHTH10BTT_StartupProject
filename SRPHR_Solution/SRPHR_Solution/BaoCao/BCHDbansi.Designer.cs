namespace SRPHR_Solution.BaoCao
{
    partial class BCHDbansi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vwBCHDBanSiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.vw_BCHDBanSiTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_BCHDBanSiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwBCHDBanSiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwBCHDBanSiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRPHR_Solution.BaoCao.BCHDbansi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(936, 350);
            this.reportViewer1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Năm:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Xem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(208, 58);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "BÁO CÁO VỀ HÓA ĐƠN BÁN SỈ";
            // 
            // vwBCHDBanSiBindingSource
            // 
            this.vwBCHDBanSiBindingSource.DataMember = "vw_BCHDBanSi";
            this.vwBCHDBanSiBindingSource.DataSource = this.dataSetbaocao1;
            // 
            // dataSetbaocao1
            // 
            this.dataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.dataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_BCHDBanSiTableAdapter
            // 
            this.vw_BCHDBanSiTableAdapter.ClearBeforeFill = true;
            // 
            // BCHDbansi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 499);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "BCHDbansi";
            this.Text = "BCHDbansi";
            this.Load += new System.EventHandler(this.BCHDbansi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwBCHDBanSiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DataSetbaocao1 dataSetbaocao1;
        private System.Windows.Forms.BindingSource vwBCHDBanSiBindingSource;
        private DataSetbaocao1TableAdapters.vw_BCHDBanSiTableAdapter vw_BCHDBanSiTableAdapter;
    }
}