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

namespace SRPHR_Solution.Kho
{
    public partial class PQLKho : Form
    {
        List<ePhieuQLiKho> lst = new List<ePhieuQLiKho>();
        PhieuQLKho_BLL pqlkBLL = new PhieuQLKho_BLL();
        BindingSource bds = new BindingSource();
        public PQLKho()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            lst = pqlkBLL.getAllPQLKho();
            bds.DataSource = lst;
            dataPQLK.DataSource = bds;

        }

        private void PQLKho_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ePhieuQLiKho qlk = new ePhieuQLiKho();
            qlk._maPhieuQli = txtmphieu.Text;
            qlk._ngayLapQLi = txtngaylap.Text;
            qlk._maNV = txtmanv.Text;
            qlk._maKho = txtmakho.Text;
            qlk._tinhTrang = txttinhtrang.Text;
            bool kq = pqlkBLL.AddAllPhieuQLK(qlk);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để thêm", "Thông báo!");

            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo!");
                dataPQLK.DataSource = pqlkBLL.getAllPQLKho();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ePhieuQLiKho qlk = new ePhieuQLiKho();
            qlk._maPhieuQli = txtmphieu.Text;
            qlk._ngayLapQLi = txtngaylap.Text;
            qlk._maNV = txtmanv.Text;
            qlk._maKho = txtmakho.Text;
            qlk._tinhTrang = txttinhtrang.Text;
            bool kq = pqlkBLL.UpDatePhieuQLK(qlk);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để sửa!", "Thông báo!");

            }
            else
            {
                MessageBox.Show("Sửa thành công!", "Thông báo!");
                dataPQLK.DataSource = pqlkBLL.getAllPQLKho();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            ePhieuQLiKho qlk = new ePhieuQLiKho();
            qlk._maPhieuQli = txtmphieu.Text;
            qlk._ngayLapQLi = txtngaylap.Text;
            qlk._maNV = txtmanv.Text;
            qlk._maKho = txtmakho.Text;
            qlk._tinhTrang = txttinhtrang.Text;
            bool kq = pqlkBLL.DeletePhieuQLK(qlk);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để xóa!", "Thông báo!");

            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Thông báo!");
                dataPQLK.DataSource = pqlkBLL.getAllPQLKho();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
