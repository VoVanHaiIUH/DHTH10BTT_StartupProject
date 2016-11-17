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
    public partial class BCHDbansi : Form
    {
        public BCHDbansi()
        {
            InitializeComponent();
        }

        private void BCHDbansi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetbaocao1.vw_BCHDBanSi' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_BCHDBanSi' table. You can move, or remove it, as needed.
           // this.vw_BCHDBanSiTableAdapter.Fill(this.DataSetbaocao1.vw_BCHDBanSi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
             this.vw_BCHDBanSiTableAdapter.Fill(this.dataSetbaocao1.vw_BCHDBanSi, Convert.ToDecimal(TextBox2.Text), Convert.ToDecimal(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
