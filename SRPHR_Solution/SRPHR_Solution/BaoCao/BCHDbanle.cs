using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPHR_Solution.BaoCao
{
    public partial class BCHDbanle : Form
    {
        public BCHDbanle()
        {
            InitializeComponent();
        }

        private void BCHDbanle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_BCHDBanLe' table. You can move, or remove it, as needed.
           // this.vw_BCHDBanLeTableAdapter.Fill(this.DataSetbaocao1.vw_BCHDBanLe);
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_BCHDBanLe' table. You can move, or remove it, as needed.


           // this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.vw_BCHDBanLeTableAdapter.Fill(this.DataSetbaocao1.vw_BCHDBanLe,Convert.ToDecimal(TextBox2.Text),Convert.ToDecimal(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void vw_BCHDBanLeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
