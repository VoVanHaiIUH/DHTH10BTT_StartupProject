using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.BanHang;
using Entities.BanHang;


//Nhóm chưa update BusinessLogic BanHang

namespace SRPHR_Solution.BanHang
{
    public partial class FormHDBanle : Form
    {
        List<ChiTietHoaDonBanLe> ls = new List<ChiTietHoaDonBanLe>();
        BindingSource bd = new BindingSource();
        HoaDonBanLeBLL hdblbll;

        public FormHDBanle()
        {
            InitializeComponent();
            hdblbll = new HoaDonBanLeBLL();
        }

        void DGViewHDBL_Load()
        {
            DGViewHDBL.DataSource = hdblbll.GetAllHDBanLe();
            DGViewHDBL.ReadOnly = true;
        }

        private void btnxem_Click(object sender, EventArgs e)
        {

            FormChitietHDBanle frmctbanle = new FormChitietHDBanle();
            frmctbanle.Activate();
            frmctbanle.Show();
        }

        private void EnabledControls(bool status)
        {
            txtmahdbanle.Enabled = status;
            txtmakh.Enabled = status;
            txtmanv.Enabled = status;
            DTNgayBanHDBL.Enabled = status;
            txttongtien.Enabled = status;

            btnluu.Enabled = status;
            btnxoa.Enabled = status;

            btnthem.Enabled = !status;
            btnsua.Enabled = !status;
            btnxoa.Enabled = !status;
        }

        private void ClearTextBox()
        {
            txtmahdbanle.Clear();
            txtmakh.Clear();
            txtmanv.Clear();
            DTNgayBanHDBL.Text = "";
            txttongtien.Clear();

        }

        HoaDonBanLe tempHDBanLe;
        private void passingData()
        {
            tempHDBanLe = new HoaDonBanLe();
            tempHDBanLe.SoHoaDon = txtmahdbanle.Text;
            tempHDBanLe.MaKH = txtmakh.Text;
            tempHDBanLe.MaNV = txtmanv.Text;
            tempHDBanLe.TongTien = Convert.ToDecimal(txttongtien.Text);
            tempHDBanLe.NgayBan = DTNgayBanHDBL.Value;

        }

        int flag = 0;

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
            flag = 1;
            EnabledControls(true);
            txtmahdbanle.Enabled = false;
        }

        private void FormHDBanle_Load(object sender, EventArgs e)
        {
            DGViewHDBL_Load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Button bt = (Button)sender;
            if (bt.Text.Equals("Thêm"))
            {
                EnabledControls(true);
                btnluu.Enabled = true;

                btnthem.Text = "Hủy";
            }
            else
            {
                ClearTextBox();
                EnabledControls(false);
            }


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //passingData();
            //if (flag == 0)//thêm
            //{
            //    if (hdblbll.ThemHDBanLe(tempHDBanLe))
            //        MessageBox.Show("Thêm thành công");
            //    else
            //        MessageBox.Show("Thêm thất bại");
            //}
            //else //sửa 
            //{
            //    if (studentBLL.Update(tempStudent))
            //        MessageBox.Show("Sửa thành công");
            //    else
            //        MessageBox.Show("Sửa thất bại");
            //}
            //frmStudent_Load(sender, e);
        }
    }
}
