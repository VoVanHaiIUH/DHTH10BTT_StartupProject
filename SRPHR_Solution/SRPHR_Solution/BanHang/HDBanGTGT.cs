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
//Nhóm chưa update BusinessLogic BanHang

namespace SRPHR_Solution.BanHang
{
    public partial class FormHDBanGTGT : Form
    {
        List<HoaDonBanGTGT> ls = new List<HoaDonBanGTGT>();
        BindingSource bd = new BindingSource();
        public FormHDBanGTGT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            //Visible = false;
            //ShowInTaskbar = false;

            FormChitietHDGTGT frmctgtgt = new FormChitietHDGTGT();
            frmctgtgt.Activate();
            frmctgtgt.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HDBanGTGT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void HDBanGTGT_Load(object sender, EventArgs e)
        {

        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            Visible = false;

            FormMainBH frmnew = new FormMainBH();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            HoaDonBanGTGT n = new HoaDonBanGTGT();
            n.MaHDGTGT = Convert.ToInt32(txtmahdgtgt.Text.Trim());
            n.MaKH = Convert.ToInt32(txtmakh.Text.Trim());
            n.MaNV = Convert.ToInt32(txtmanv.Text.Trim());
         // n.NgayBan = dtngayban.Text;
            n.TenDVBan = txttendvban.Text;
            n.TenDVMua = txttendvmua.Text;
            n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            HoaDonBanGTGT n = new HoaDonBanGTGT();
            n.MaHDGTGT = Convert.ToInt32(txtmahdgtgt.Text.Trim());
            n.MaKH = Convert.ToInt32(txtmakh.Text.Trim());
            n.MaNV = Convert.ToInt32(txtmanv.Text.Trim());
            // n.NgayBan = dtngayban.Text;
            n.TenDVBan = txttendvban.Text;
            n.TenDVMua = txttendvmua.Text;
            n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HoaDonBanGTGT n = new HoaDonBanGTGT();
            n.MaHDGTGT = Convert.ToInt32(txtmahdgtgt.Text.Trim());
            n.MaKH = Convert.ToInt32(txtmakh.Text.Trim());
            n.MaNV = Convert.ToInt32(txtmanv.Text.Trim());
            // n.NgayBan = dtngayban.Text;
            n.TenDVBan = txttendvban.Text;
            n.TenDVMua = txttendvmua.Text;
            n.ThanhTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }
    }
}
