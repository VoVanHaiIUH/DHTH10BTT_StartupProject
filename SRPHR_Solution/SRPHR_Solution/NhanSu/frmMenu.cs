using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRPHR_Solution.NhanSu;
namespace SRPHR_Solution.NhanSu
{
    
    public partial class frmMenu : Form
    {
        public int quyen;
        public frmMenu()
        {
            InitializeComponent();
        }

        

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongBan frmPhongBan = new FrmPhongBan();
            frmPhongBan.MdiParent = this;
            frmPhongBan.Show();
        }

        private void chiTiếtĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCTThamGiaDaoTaoNV frmCT = new FrmCTThamGiaDaoTaoNV();
            frmCT.MdiParent = this;
            frmCT.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNV = new FrmNhanVien();
            frmNV.MdiParent = this;
            frmNV.Show();
        }
    }
}
