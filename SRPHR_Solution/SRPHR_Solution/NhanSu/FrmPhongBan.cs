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
    public partial class FrmPhongBan : Form
    {
        PhongBanBLL PhongBanBLL;
        public FrmPhongBan()
        {
            InitializeComponent();
            PhongBanBLL = new PhongBanBLL();
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            DGViewQLPhongBan_Load();
            EnabledControls(false);
        }

        void DGViewQLPhongBan_Load()
        {
            DGViewPhongBan.DataSource = PhongBanBLL.GetAllPhongBan();
            DGViewPhongBan.ReadOnly = true;
        }


        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaPB.Enabled = status;
            txtTenPB.Enabled = status;
            txtDiadiem.Enabled = status;
            txtSoDT.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;

            btnAdd.Enabled = !status;
            btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtDiadiem.Clear();
            txtSoDT.Clear();
        }


        PhongBan tempPhongBan;
        private void passingData()
        {
            tempPhongBan = new PhongBan();
            tempPhongBan.MaPB = txtMaPB.Text;
            tempPhongBan.TenPB = txtTenPB.Text;
            tempPhongBan.DiaDiem = txtDiadiem.Text;
            tempPhongBan.Sdt = txtSoDT.Text;
        }

        #endregion        int flag = 0; // thêm=0 sửa=1


        private void DGViewPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            txtMaPB.Text = DGViewPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPB.Text = DGViewPhongBan.CurrentRow.Cells[1].Value.ToString();
            //DTPickerBirthDay.Text = DGViewPhongBan.CurrentRow.Cells[2].Value.ToString();
            txtDiadiem.Text = DGViewPhongBan.CurrentRow.Cells[2].Value.ToString();

            txtSoDT.Text = DGViewPhongBan.CurrentRow.Cells[3].Value.ToString();
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
            txtMaPB.Enabled = false;
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
                if (PhongBanBLL.Add(tempPhongBan))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                if (PhongBanBLL.UpDate(tempPhongBan))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            frmPhongBan_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hoàng hoá " + txtTenPB.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (DialogResult.Yes == r)
            //{
            //    passingData();
            //    if (PhongBanBLL.Delete(tempPhongBan.MaPB))
            //        MessageBox.Show("Xoá thành công");
            //    else
            //        MessageBox.Show("Xoá thất bại");
            //}
            //frmPhongBan_Load(sender, e);
            int hideIndex = -1;
            foreach (DataGridViewRow dr in DGViewPhongBan.Rows)
            {
                if (dr.Cells[0].Value.ToString() == txtMaPB.Text)
                {
                    hideIndex = dr.Index;
                }
            }

            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGViewPhongBan.DataSource];
            currencyManager1.SuspendBinding();

            DGViewPhongBan.Rows[hideIndex].Visible = false;

            currencyManager1.ResumeBinding();



            //frmPhongBan_Load(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        #endregion

        private void DGViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGViewPhongBan.DataSource];
            currencyManager1.SuspendBinding();

            DGViewPhongBan.Rows[e.RowIndex].Visible = false;

            currencyManager1.ResumeBinding();
        }

        private void grpBoxPhongBan_Enter(object sender, EventArgs e)
        {

        }
    }
}
