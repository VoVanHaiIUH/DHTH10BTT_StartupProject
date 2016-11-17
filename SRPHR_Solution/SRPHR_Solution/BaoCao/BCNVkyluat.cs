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
    public partial class BCNVkyluat : Form
    {
        public BCNVkyluat()
        {
            InitializeComponent();
        }

        private void BCNVkyluat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_BCKyLuat' table. You can move, or remove it, as needed.
            //this.vw_BCKyLuatTableAdapter.Fill(this.DataSetbaocao1.vw_BCKyLuat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vw_BCKyLuatTableAdapter.Fill(this.DataSetbaocao1.vw_BCKyLuat,Convert.ToDecimal(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
