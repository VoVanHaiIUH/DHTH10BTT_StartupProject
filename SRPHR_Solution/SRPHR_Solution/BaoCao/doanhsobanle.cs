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
    public partial class doanhsobanle : Form
    {
        public doanhsobanle()
        {
            InitializeComponent();
        }

        private void doanhsobanle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_DoanhSoBanLe' table. You can move, or remove it, as needed.
           // this.vw_DoanhSoBanLeTableAdapter.Fill(this.DataSetbaocao1.vw_DoanhSoBanLe);
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_DoanhSoBanSi' table. You can move, or remove it, as needed.
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.vw_DoanhSoBanLeTableAdapter.Fill(this.dataSetbaocao1.vw_DoanhSoBanLe, Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
