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
    public partial class baocaochitietsanpham : Form
    {
        public baocaochitietsanpham()
        {
            InitializeComponent();
        }

        private void baocaochitietsanpham_Load(object sender, EventArgs e)
        {
           
           
            // TODO: This line of code loads data into the 'dataSetbaocao1.Tbl_SanPham' table. You can move, or remove it, as needed.
            this.tbl_SanPhamTableAdapter.Fill(this.dataSetbaocao1.Tbl_SanPham);

            this.reportViewer1.RefreshReport();
        }

    }
}
