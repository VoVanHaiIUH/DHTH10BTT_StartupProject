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

        BindingSource bd = new BindingSource();
        HoaDonBanLeBLL hdblbll = new HoaDonBanLeBLL();
        List<HoaDonBanLe> lhdbl = new List<HoaDonBanLe>();

        public FormHDBanle()
        {
            InitializeComponent();
            lhdbl = hdblbll.GetAllHDBanLe();
            loaddatagridview(lhdbl, DGViewHDBL);
        }
        private void loaddatagridview(List<HoaDonBanLe> lhdbl, DataGridView dtgv)
        {
            dtgv.DataSource = lhdbl;
        }
        void DGViewHDBL_Load()
        {


        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

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
            EnabledControls(false);
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
            int hideIndex = -1;
            foreach (DataGridViewRow dr in DGViewHDBL.Rows)
            {
                if (dr.Cells[0].Value.ToString() == txtmahdbanle.Text)
                {
                    hideIndex = dr.Index;
                }
            }

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DGViewHDBL.DataSource];
            currencyManager.SuspendBinding();

            DGViewHDBL.Rows[hideIndex].Visible = false;

            currencyManager.ResumeBinding();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            passingData();
            HoaDonBanLe hdbl = new HoaDonBanLe();

            hdbl.SoHoaDon = txtmahdbanle.Text;
            hdbl.MaKH = txtmakh.Text;
            hdbl.MaNV = txtmanv.Text;
            hdbl.NgayBan = DTNgayBanHDBL.Value;
            hdbl.TongTien = Convert.ToDecimal(txttongtien.Text);

            int kq = hdblbll.ThemHDBanLe(hdbl);
            if (kq == 0)
            {
                MessageBox.Show("Trùng mã hóa đơn !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (kq == 1) MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void DGViewHDBL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DGViewHDBL.DataSource];
            currencyManager.SuspendBinding();

            DGViewHDBL.Rows[e.RowIndex].Visible = false;

            currencyManager.ResumeBinding();
        }

        private void DGViewHDBL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormHDBanle_Load_1(object sender, EventArgs e)
        {

        }






    }
}
