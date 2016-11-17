namespace SRPHR_Solution.BaoCao
{
    partial class BCHDbanle
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
            this.vw_BCHDBanLeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_BCHDBanLeTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_BCHDBanLeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCHDBanLeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_BCHDBanLeBindingSource
            // 
            this.vw_BCHDBanLeBindingSource.DataMember = "vw_BCHDBanLe";
            this.vw_BCHDBanLeBindingSource.DataSource = this.DataSetbaocao1;
            this.vw_BCHDBanLeBindingSource.CurrentChanged += new System.EventHandler(this.vw_BCHDBanLeBindingSource_CurrentChanged);
            // 
            // DataSetbaocao1
            // 
            this.DataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.DataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tháng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Năm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Xem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(211, 49);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 23;
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "BÁO CÁO VỀ HÓA ĐƠN BÁN LẺ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_BCHDBanLeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRPHR_Solution.BaoCao.BCHDbanle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(936, 350);
            this.reportViewer1.TabIndex = 28;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // vw_BCHDBanLeTableAdapter
            // 
            this.vw_BCHDBanLeTableAdapter.ClearBeforeFill = true;
            // 
            // BCHDbanle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 472);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "BCHDbanle";
            this.Text = "BCHDbanle";
            this.Load += new System.EventHandler(this.BCHDbanle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_BCHDBanLeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetbaocao1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_BCHDBanLeBindingSource;
        private DataSetbaocao1 DataSetbaocao1;
        private DataSetbaocao1TableAdapters.vw_BCHDBanLeTableAdapter vw_BCHDBanLeTableAdapter;
    }
}