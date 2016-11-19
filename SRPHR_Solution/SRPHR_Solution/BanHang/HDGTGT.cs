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
using BusinessLogic.BanHang;
//Nhóm chưa update BusinessLogic BanHang

namespace SRPHR_Solution.BanHang
{
    public partial class FormHDGTGT : Form
    {
        public string PQHDGTGT;
        HoaDonGTGTBLL hdgtbll;
        List<HoaDonBanGTGT> lhdgtgt;
        //List<ChiTietHDGTGT> ls = new List<ChiTietHDGTGT>();
        BindingSource bd = new BindingSource();
        public FormHDGTGT()
        {
            InitializeComponent();
            hdgtbll = new HoaDonGTGTBLL();
            lhdgtgt = new List<HoaDonBanGTGT>();


            loaddatagridview(lhdgtgt, dataGridView1);
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
            HoaDonBanGTGT n = new HoaDonBanGTGT();
            //ChiTietHDGTGT n = new ChiTietHDGTGT();
            n.SoHoaDon = txtsohd.Text.Trim();
            n.DiaChi = txtdiachigt.Text.Trim();
            n.DvBanHang = txtdvban.Text.Trim();
            n.ThanhTien = Convert.ToDecimal(textBox1.Text.Trim());
            n.DvMuaHang = txtdvmua.Text.Trim();
            n.HinhThucThanhToan = txthinhthuc.Text.Trim();
            n.MsThue = Convert.ToInt32(txtmasothue.Text.Trim());
            n.NgaylapHoaDon = Convert.ToDateTime(txtngaylap.Text.Trim());
            n.SoTaiKhoan = txtsotaikhoan.Text.Trim();
            int kq = hdgtbll.ThemHDGTGT(n);
            if (kq == 0)
            {
                MessageBox.Show("Trùng mã hóa đơn !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (kq == 1) MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            dataGridView1.DataSource = hdgtbll.GetAllHDBGTGT();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HoaDonBanGTGT n1 = new HoaDonBanGTGT();
            n1.SoHoaDon = txtsohd.Text.Trim();
            n1.DiaChi = txtdiachigt.Text.Trim();
            n1.DvBanHang = txtdvban.Text.Trim();
            n1.ThanhTien = Convert.ToDecimal(textBox1.Text.Trim());
            n1.DvMuaHang = txtdvmua.Text.Trim();
            n1.HinhThucThanhToan = txthinhthuc.Text.Trim();
            n1.MsThue = Convert.ToInt32(txtmasothue.Text.Trim());
            n1.NgaylapHoaDon = Convert.ToDateTime(txtngaylap.Text.Trim());
            n1.SoTaiKhoan = txtsotaikhoan.Text.Trim();
            bool kq = hdgtbll.xoaclgd(n1);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để xóa!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Thông báo!");
                dataGridView1.DataSource = hdgtbll.GetAllHDBGTGT();
            }
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            HoaDonBanGTGT n2 = new HoaDonBanGTGT();
            n2.SoHoaDon = txtsohd.Text.Trim();
            n2.DiaChi = txtdiachigt.Text.Trim();
            n2.DvBanHang = txtdvban.Text.Trim();
            n2.ThanhTien = Convert.ToDecimal(textBox1.Text.Trim());
            n2.DvMuaHang = txtdvmua.Text.Trim();
            n2.HinhThucThanhToan = txthinhthuc.Text.Trim();
            n2.MsThue = Convert.ToInt32(txtmasothue.Text.Trim());
            n2.NgaylapHoaDon = Convert.ToDateTime(txtngaylap.Text.Trim());
            n2.SoTaiKhoan = txtsotaikhoan.Text.Trim();
            bool kq = hdgtbll.Update(n2);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để sửa!", "Thông báo!");

            }
            else
            {
                MessageBox.Show("Sửa thành công!", "Thông báo!");
                dataGridView1.DataSource = hdgtbll.GetAllHDBGTGT();
            }
        }
        private void trangthaiPQ(string pq)
        {
            /*if (pq.Substring(0, 1) == "1")
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
                btnsua.Enabled = false;*/

        }

        private void FormHDGTGT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        int flag = 0;
        private void loaddatagridview(List<HoaDonBanGTGT> lhdgtgt, DataGridView dtgv)
        {
            lhdgtgt = hdgtbll.GetAllHDBGTGT();
            bd.DataSource = lhdgtgt;
            dataGridView1.DataSource = bd;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
