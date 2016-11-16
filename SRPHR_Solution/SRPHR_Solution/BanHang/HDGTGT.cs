using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entities.BanHang;
using SRPHR_Solution.BanHang;
//Nhóm chưa update BusinessLogic BanHang

namespace SRPHR_Solution.BanHang
{
    public partial class FormHDGTGT : Form
    {
        public string PQHDGTGT;
        
        //List<ChiTietHDGTGT> ls = new List<ChiTietHDGTGT>();
        BindingSource bd = new BindingSource();
        public FormHDGTGT()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChitietHDGTGT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void ChitietHDGTGT_Load(object sender, EventArgs e)
        {
            
            trangthaiPQ(PQHDGTGT);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //ChiTietHDGTGT n = new ChiTietHDGTGT();
            //n.MaHDGTGT = Convert.ToInt32(txtmahdgtgt.Text.Trim());
            //n.MaSP = Convert.ToInt32(txtmasp.Text.Trim());
            //n.SoLuong = Convert.ToInt32(txtsoluong.Text.Trim());
            //n.MaThue = Convert.ToInt32(txtmathue.Text.Trim());
            //n.ThueGTGT = Convert.ToInt32(txtthuegtgt.Text.Trim());
            //n.TenDVMua = txttendvmua.Text;
            //n.DiaChi = txtdiachi.Text;
            //n.TenSP = txttensp.Text;
            //n.GiamGia = txtgiamgia.Text;
            //n.KhuyenMai = txtkhuyenmai.Text;
            //n.DonGia = Convert.ToDecimal(txtdongia.Text.Trim());
            //n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
            //n.TongTien = Convert.ToDecimal(txttongtien.Text.Trim());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            //ChiTietHDGTGT n = new ChiTietHDGTGT();
            //n.MaHDGTGT = Convert.ToInt32(txtmahdgtgt.Text.Trim());
            //n.MaSP = Convert.ToInt32(txtmasp.Text.Trim());
            //n.SoLuong = Convert.ToInt32(txtsoluong.Text.Trim());
            //n.MaThue = Convert.ToInt32(txtmathue.Text.Trim());
            //n.ThueGTGT = Convert.ToInt32(txtthuegtgt.Text.Trim());
            //n.TenDVMua = txttendvmua.Text;
            //n.DiaChi = txtdiachi.Text;
            //n.TenSP = txttensp.Text;
            //n.GiamGia = txtgiamgia.Text;
            //n.KhuyenMai = txtkhuyenmai.Text;
            //n.DonGia = Convert.ToDecimal(txtdongia.Text.Trim());
            //n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
            //n.TongTien = Convert.ToDecimal(txttongtien.Text.Trim());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //ChiTietHDGTGT n = new ChiTietHDGTGT();
            //n.MaHDGTGT = Convert.ToInt32(txtmahdgtgt.Text.Trim());
            //n.MaSP = Convert.ToInt32(txtmasp.Text.Trim());
            //n.SoLuong = Convert.ToInt32(txtsoluong.Text.Trim());
            //n.MaThue = Convert.ToInt32(txtmathue.Text.Trim());
            //n.ThueGTGT = Convert.ToInt32(txtthuegtgt.Text.Trim());
            //n.TenDVMua = txttendvmua.Text;
            //n.DiaChi = txtdiachi.Text;
            //n.TenSP = txttensp.Text;
            //n.GiamGia = txtgiamgia.Text;
            //n.KhuyenMai = txtkhuyenmai.Text;
            //n.DonGia = Convert.ToDecimal(txtdongia.Text.Trim());
            //n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
            //n.TongTien = Convert.ToDecimal(txttongtien.Text.Trim());
        }
        private void trangthaiPQ(string pq)
        {
            if (pq.Substring(0, 1) == "1")
                btnthem.Enabled = true;
            else
                btnthem.Enabled = false;

            if (pq.Substring(1, 1) == "1")
                btnxoa.Enabled = true;
            else
                btnxoa.Enabled = false;

            if (pq.Substring(2, 1) == "1")
                btnsua.Enabled = true;
            else
                btnsua.Enabled = false;

            
        }
    }
}
