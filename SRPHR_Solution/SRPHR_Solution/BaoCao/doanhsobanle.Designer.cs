﻿namespace SRPHR_Solution.BaoCao
{
    partial class doanhsobanle
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.vwDoanhSoBanLeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DoanhSoBanLeTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_DoanhSoBanLeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoanhSoBanLeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vwDoanhSoBanLeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRPHR_Solution.BaoCao.Doanhsobanle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(903, 301);
            this.reportViewer1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Năm:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Xem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "BÁO CÁO DOANH SỐ BÁN LẺ THEO THÁNG";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(461, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 32;
            // 
            // dataSetbaocao1
            // 
            this.dataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.dataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDoanhSoBanLeBindingSource
            // 
            this.vwDoanhSoBanLeBindingSource.DataMember = "vw_DoanhSoBanLe";
            this.vwDoanhSoBanLeBindingSource.DataSource = this.dataSetbaocao1;
            // 
            // vw_DoanhSoBanLeTableAdapter
            // 
            this.vw_DoanhSoBanLeTableAdapter.ClearBeforeFill = true;
            // 
            // doanhsobanle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 480);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "doanhsobanle";
            this.Text = "doanhsobanle";
            this.Load += new System.EventHandler(this.doanhsobanle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoanhSoBanLeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource vwDoanhSoBanLeBindingSource;
        private DataSetbaocao1 dataSetbaocao1;
        private DataSetbaocao1TableAdapters.vw_DoanhSoBanLeTableAdapter vw_DoanhSoBanLeTableAdapter;
    }
}