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
    public partial class doanhsobansi : Form
    {
        public doanhsobansi()
        {
            InitializeComponent();
        }

        private void doanhsobansi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_DoanhSoBanSi' table. You can move, or remove it, as needed.
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.vw_DoanhSoBanSiTableAdapter.Fill(this.DataSetbaocao1.vw_DoanhSoBanSi, Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
