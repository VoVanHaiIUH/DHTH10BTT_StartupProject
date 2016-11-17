namespace SRPHR_Solution.BaoCao
{
    partial class MainBaoCao
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSetbaocao1 = new SRPHR_Solution.BaoCao.DataSetbaocao1();
            this.dataSetbaocao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.vwbaocaokhuyenmaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_baocaokhuyenmaiTableAdapter = new SRPHR_Solution.BaoCao.DataSetbaocao1TableAdapters.vw_baocaokhuyenmaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwbaocaokhuyenmaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataSetbaocao1
            // 
            this.dataSetbaocao1.DataSetName = "DataSetbaocao1";
            this.dataSetbaocao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetbaocao1BindingSource
            // 
            this.dataSetbaocao1BindingSource.DataSource = this.dataSetbaocao1;
            this.dataSetbaocao1BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vwbaocaokhuyenmaiBindingSource
            // 
            this.vwbaocaokhuyenmaiBindingSource.DataMember = "vw_baocaokhuyenmai";
            this.vwbaocaokhuyenmaiBindingSource.DataSource = this.dataSetbaocao1BindingSource;
            // 
            // vw_baocaokhuyenmaiTableAdapter
            // 
            this.vw_baocaokhuyenmaiTableAdapter.ClearBeforeFill = true;
            // 
            // MainBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 75);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainBaoCao";
            this.Text = "MainBaoCao";
            this.Load += new System.EventHandler(this.MainBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbaocao1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwbaocaokhuyenmaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private DataSetbaocao1 dataSetbaocao1;
        private System.Windows.Forms.BindingSource dataSetbaocao1BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vwbaocaokhuyenmaiBindingSource;
        private DataSetbaocao1TableAdapters.vw_baocaokhuyenmaiTableAdapter vw_baocaokhuyenmaiTableAdapter;
    }
}