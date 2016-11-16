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
    public partial class ChiTietNhapKho : Form
    {
        NhanDuLieuTuPKH_BLL bllNhanDL;
        PhieuNK_BLL bllNK;
        List<eCTPhieuDNNK> listCTPNK;
        public ChiTietNhapKho()
        {
            InitializeComponent();
            bllNK = new PhieuNK_BLL();
            bllNhanDL = new NhanDuLieuTuPKH_BLL();
            listCTPNK = new List<eCTPhieuDNNK>();
            duadulieulencbb(cbbmaphieu);
            string map = cbbmaphieu.Text;
            listCTPNK = bllNhanDL.laydanhsachCTPhieuDNNKtheoMaphieu(map);
            Laydulieulendatatreeview(dgvCT, listCTPNK);
        }

        private void ChiTietNhapKho_Load(object sender, EventArgs e)
        {

        }
        public void Laydulieulendatatreeview(DataGridView dgv, List<eCTPhieuDNNK> ls)
        {
            dgv.DataSource = ls;
        }
        public void duadulieulencbb(ComboBox cb)
        {
            this.cbbmaphieu.DataSource = bllNK.laydanhsachphieuNhapKho();
            this.cbbmaphieu.DisplayMember = "_maPhieuNhap";
            this.cbbmaphieu.ValueMember = "_maPhieuNhap";
        }

        private void cbbmaphieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string map = cbbmaphieu.Text;
            listCTPNK = bllNhanDL.laydanhsachCTPhieuDNNKtheoMaphieu(map);
            Laydulieulendatatreeview(dgvCT, listCTPNK);
        }
    }
}
