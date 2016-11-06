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
    public partial class FormHDBanle : Form
    {
        List<ChiTietHoaDonBanLe> ls = new List<ChiTietHoaDonBanLe>();
        BindingSource bd = new BindingSource();

        public FormHDBanle()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
           
            FormChitietHDBanle frmctbanle = new FormChitietHDBanle();
            frmctbanle.Activate();
            frmctbanle.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HDBanLe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
         
            Visible = false;

            FormMainBH frmnew = new FormMainBH();
            frmnew.Activate();
            frmnew.ShowDialog();


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            HoaDonBanLe n = new HoaDonBanLe();
            n.MaHDBanLe = Convert.ToInt32(txtmahdbanle.Text.Trim());
            n.MaNV = Convert.ToInt32(txtmanv.Text.Trim());
            n.MaKH = Convert.ToInt32(txtmakh.Text.Trim());
            //n.NgayBanLe = dateTimePicker1.Text;
            n.TongTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }

        private void FormHDBanle_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            HoaDonBanLe n = new HoaDonBanLe();
            n.MaHDBanLe = Convert.ToInt32(txtmahdbanle.Text.Trim());
            n.MaNV = Convert.ToInt32(txtmanv.Text.Trim());
            n.MaKH = Convert.ToInt32(txtmakh.Text.Trim());
            //n.NgayBanLe = dateTimePicker1.Text;
            n.TongTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HoaDonBanLe n = new HoaDonBanLe();
            n.MaHDBanLe = Convert.ToInt32(txtmahdbanle.Text.Trim());
            n.MaNV = Convert.ToInt32(txtmanv.Text.Trim());
            n.MaKH = Convert.ToInt32(txtmakh.Text.Trim());
            //n.NgayBanLe = dateTimePicker1.Text;
            n.TongTien = Convert.ToDecimal(txtthanhtien.Text.Trim());
        }
    }
}
