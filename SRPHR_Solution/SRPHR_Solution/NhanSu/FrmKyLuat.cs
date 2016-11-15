using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.NhanSu;
using BusinessLogic.NhanSu;

namespace SRPHR_Solution.NhanSu
{
    public partial class FrmKyLuat : Form
    {
        public FrmKyLuat()
        {
            InitializeComponent();
            KyLuatBLL = new KyLuatBLL();
        }
        KyLuatBLL KyLuatBLL;

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            DGViewQLKyLuat_Load();
            EnabledControls(false);
        }

        void DGViewQLKyLuat_Load()
        {
            DGViewKyLuat.DataSource = KyLuatBLL.GetAllKyLuat();
            DGViewKyLuat.ReadOnly = true;
        }


        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaKL.Enabled = status;
            txtTenKL.Enabled = status;
            txtGhiChu.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;

            btnAdd.Enabled = !status;
            btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMaKL.Clear();
            txtTenKL.Clear();
            txtGhiChu.Clear();
        }


        KyLuat tempKyLuat;
        private void passingData()
        {
            tempKyLuat = new KyLuat();
            tempKyLuat.MaKL = txtMaKL.Text;
            tempKyLuat.HinhThucKL = txtTenKL.Text;
            tempKyLuat.GhiChu = txtGhiChu.Text;

        }

        #endregion        int flag = 0; // thêm=0 sửa=1


        private void DGViewKyLuat_SelectionChanged(object sender, EventArgs e)
        {
            txtMaKL.Text = DGViewKyLuat.CurrentRow.Cells[0].Value.ToString();
            txtTenKL.Text = DGViewKyLuat.CurrentRow.Cells[1].Value.ToString();
            //DTPickerBirthDay.Text = DGViewKyLuat.CurrentRow.Cells[2].Value.ToString();
            txtGhiChu.Text = DGViewKyLuat.CurrentRow.Cells[2].Value.ToString();
        }
        int flag = 0;
        #region Button Click Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            EnabledControls(true);
            ClearTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = 1;
            EnabledControls(true);
            txtMaKL.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnabledControls(false);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            passingData();
            if (flag == 0)//thêm
            {
                if (KyLuatBLL.Add(tempKyLuat))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                if (KyLuatBLL.UpDate(tempKyLuat))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            frmKyLuat_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hoàng hoá " + txtTenKL.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                passingData();
                if (KyLuatBLL.Delete(tempKyLuat.MaKL))
                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Xoá thất bại");
            }
            frmKyLuat_Load(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }
        //jsdn
        #endregion

        private void DGViewKyLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpBoxKyLuat_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int hideIndex = -1;
            foreach (DataGridViewRow dr in DGViewKyLuat.Rows)
            {
                if (dr.Cells[0].Value.ToString() == txtMaKL.Text)
                {
                    hideIndex = dr.Index;
                }
            }

            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGViewKyLuat.DataSource];
            currencyManager1.SuspendBinding();

            DGViewKyLuat.Rows[hideIndex].Visible = false;

            currencyManager1.ResumeBinding();

        }
    }
}
