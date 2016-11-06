using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.BanHang;
using BusinessLogic;
//Nhóm chưa update BusinessLogic BanHang
namespace SRPHR_Solution.BanHang
{
    public partial class FormChitietHDBanle : Form
    {
        List<ChiTietHoaDonBanLe> ls = new List<ChiTietHoaDonBanLe>();
        BindingSource bd = new BindingSource();

        public FormChitietHDBanle()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChitietHDBanLe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void ChitietHDBanle_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBanLe n = new ChiTietHoaDonBanLe();
            n.MaHDBanLe = Convert.ToInt32(txtmahdbanle.Text.Trim());
            n.MaSP = Convert.ToInt32(txtmasp.Text.Trim());
            n.SoLuong = Convert.ToInt32(txtsoluong.Text.Trim());
            n.TenSP = txttensp.Text;
            n.GiamGia = txtgiamgia.Text;
            n.KhuyenMai = txtkhuyenmai.Text;
            n.DonGia = Convert.ToDecimal(txtdongia.Text.Trim());
            n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBanLe n = new ChiTietHoaDonBanLe();
            n.MaHDBanLe = Convert.ToInt32(txtmahdbanle.Text.Trim());
            n.MaSP = Convert.ToInt32(txtmasp.Text.Trim());
            n.SoLuong = Convert.ToInt32(txtsoluong.Text.Trim());
            n.TenSP = txttensp.Text;
            n.GiamGia = txtgiamgia.Text;
            n.KhuyenMai = txtkhuyenmai.Text;
            n.DonGia = Convert.ToDecimal(txtdongia.Text.Trim());
            n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonBanLe n = new ChiTietHoaDonBanLe();
            n.MaHDBanLe = Convert.ToInt32(txtmahdbanle.Text.Trim());
            n.MaSP = Convert.ToInt32(txtmasp.Text.Trim());
            n.SoLuong = Convert.ToInt32(txtsoluong.Text.Trim());
            n.TenSP = txttensp.Text;
            n.GiamGia = txtgiamgia.Text;
            n.KhuyenMai = txtkhuyenmai.Text;
            n.DonGia = Convert.ToDecimal(txtdongia.Text.Trim());
            n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }
    }
}
