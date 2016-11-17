namespace SRPHR_Solution.BaoCao
{
    partial class BCSPtheothang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.vw_BCSPtheothangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_BCSPtheothangTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_BCSPtheothangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCSPtheothangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.vw_BCSPtheothangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRPHR_Solution.BaoCao.BCSPtheothang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(127, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(610, 246);
            this.reportViewer1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "BÁO CÁO SẢN PHẨM THEO THÁNG";
            // 
            // DataSetbaocao1
            // 
            this.DataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.DataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_BCSPtheothangBindingSource
            // 
            this.vw_BCSPtheothangBindingSource.DataMember = "vw_BCSPtheothang";
            this.vw_BCSPtheothangBindingSource.DataSource = this.DataSetbaocao1;
            // 
            // vw_BCSPtheothangTableAdapter
            // 
            this.vw_BCSPtheothangTableAdapter.ClearBeforeFill = true;
            // 
            // BCSPtheothang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BCSPtheothang";
            this.Text = "BCSPtheothang";
            this.Load += new System.EventHandler(this.BCSPtheothang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCSPtheothangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vw_BCSPtheothangBindingSource;
        private DataSetbaocao1 DataSetbaocao1;
        private DataSetbaocao1TableAdapters.vw_BCSPtheothangTableAdapter vw_BCSPtheothangTableAdapter;
    }
}