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
namespace GUI
{
    public partial class frmQuanLyChucVu : Form
    {
        ChucVuBLL ChucVuBLL;
        public frmQuanLyChucVu()
        {
            InitializeComponent();
            ChucVuBLL = new ChucVuBLL();
        }

        private void frmQLChucVu_Load(object sender, EventArgs e)
        {
            DGViewQLChucVu_Load();
            EnabledControls(false);
        }

        void DGViewQLChucVu_Load()
        {
            DGViewChucVu.DataSource = ChucVuBLL.GetAllChucVu();
            DGViewChucVu.ReadOnly = true;
        }
        

        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaCV.Enabled = status;
            txtTenCV.Enabled = status;
            txtGhiChu.Enabled = status;
            txtHeSo.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;

            btnAdd.Enabled = !status;
            btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtGhiChu.Clear();
            txtHeSo.Clear();
        }


        ChucVu tempChucVu;
        private void passingData()
        {
            tempChucVu = new ChucVu();
            tempChucVu.MaCV = txtMaCV.Text;
            tempChucVu.TenCV = txtTenCV.Text;
            tempChucVu.HeSo =Convert.ToDecimal( txtHeSo.Text);
            tempChucVu.GhiChu = txtGhiChu.Text;
        }
        
        #endregion        int flag = 0; // thêm=0 sửa=1


        private void DGViewChucVu_SelectionChanged(object sender, EventArgs e)
        {
            txtMaCV.Text = DGViewChucVu.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = DGViewChucVu.CurrentRow.Cells[1].Value.ToString();
            //DTPickerBirthDay.Text = DGViewChucVu.CurrentRow.Cells[2].Value.ToString();
            txtHeSo.Text = DGViewChucVu.CurrentRow.Cells[2].Value.ToString();

            txtGhiChu.Text = DGViewChucVu.CurrentRow.Cells[4].Value.ToString();
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
            txtMaCV.Enabled = false;
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
                if (ChucVuBLL.Add(tempChucVu))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                if (ChucVuBLL.UpDate(tempChucVu))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            frmQLChucVu_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hoàng hoá " + txtTenCV.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                passingData();
                if (ChucVuBLL.Delete(tempChucVu.MaCV))
                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Xoá thất bại");
            }
            frmQLChucVu_Load(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        #endregion

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
