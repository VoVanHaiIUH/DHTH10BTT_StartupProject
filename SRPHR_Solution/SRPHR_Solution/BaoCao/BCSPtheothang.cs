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
    public partial class BCSPtheothang : Form
    {
        public BCSPtheothang()
        {
            InitializeComponent();
        }

        private void BCSPtheothang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetbaocao1.vw_BCSPtheothang' table. You can move, or remove it, as needed.
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vw_BCSPtheothangTableAdapter.Fill(this.DataSetbaocao1.vw_BCSPtheothang, Convert.ToDecimal(textBox1.Text));

            this.reportViewer1.RefreshReport();
        }
         private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
