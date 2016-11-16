using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Kho;
using BusinessLogic.Kho;
using Entities.CongNoPKH;

namespace SRPHR_Solution.Kho
{
    public partial class ChiTietXuatKho : Form
    {
        NhanDuLieuTuPKH_BLL bllNhanDL;
        PhieuXK_BLL bllXK;
        List<eCTPhieuDNXK> listCTPXK;
        public ChiTietXuatKho()
        {
            InitializeComponent();
            bllXK = new PhieuXK_BLL();
            bllNhanDL = new NhanDuLieuTuPKH_BLL();
            listCTPXK = new List<eCTPhieuDNXK>();
            duadulieulencbb(cbbmaphieu);
            string map = cbbmaphieu.Text;
            listCTPXK = bllNhanDL.laydanhsachCTPhieuDNXKtheoMaphieu(map);
            Laydulieulendatatreeview(dgvCT, listCTPXK);
        }
        public void duadulieulencbb(ComboBox cb)
        {
            this.cbbmaphieu.DataSource = bllXK.laydanhsachphieuXuatKho();
            this.cbbmaphieu.DisplayMember = "_maPhieuXuat";
            this.cbbmaphieu.ValueMember = "_maPhieuXuat";
        }
        public void Laydulieulendatatreeview(DataGridView dgv, List<eCTPhieuDNXK> ls)
        {
            dgv.DataSource = ls;
        }
        private void ChiTietXuatKho_Load(object sender, EventArgs e)
        {

        }

        private void cbbmaphieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string map = cbbmaphieu.Text;
            listCTPXK = bllNhanDL.laydanhsachCTPhieuDNXKtheoMaphieu(map);
            Laydulieulendatatreeview(dgvCT, listCTPXK);
        }
    }
}
