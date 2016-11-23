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
    public partial class FrmNhanVien : Form
    {
        NhanVienBLL NhanVienBLL;
        public FrmNhanVien()
        {
            InitializeComponent();
            NhanVienBLL = new NhanVienBLL();
        }


        void DGViewQLNhanVien_Load()
        {
            DGViewNhanVien.DataSource = NhanVienBLL.GetAllNhanVien();
            DGViewNhanVien.ReadOnly = true;
        }


        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaNV.Enabled = status;
            txtHoTen.Enabled = status;
            txtSoCMND.Enabled = status;
            txtEmail.Enabled = status;
            txtGioitinh.Enabled = status;
            txtSoDT.Enabled = status;
            txtDiaChi.Enabled = status;
            txtTrangThai.Enabled = status;

            dateTimePickerNgaySinh.Enabled = status;
            dateTimePickerNgayVaoLam.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;

            btnAdd.Enabled = !status;
            btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSoCMND.Clear();
            txtEmail.Clear();
            txtGioitinh.Clear();
            txtSoDT.Clear();
            txtDiaChi.Clear();
            txtTrangThai.Clear();
        }


        NhanVien tempNhanVien;
        private void passingData()
        {
            tempNhanVien = new NhanVien();
            tempNhanVien.MaNV = txtMaNV.Text;
            tempNhanVien.HoTen = txtHoTen.Text;
            tempNhanVien.SoCMND = txtSoCMND.Text;
            tempNhanVien.NgayCapCMND = Convert.ToDateTime(dateTimePickerNgayCap.Text);
            tempNhanVien.GioiTinh = txtGioitinh.Text;
            tempNhanVien.Email = txtEmail.Text;
            tempNhanVien.NgaySinh = Convert.ToDateTime(dateTimePickerNgaySinh.Value);
            tempNhanVien.NgayVaoLam = Convert.ToDateTime(dateTimePickerNgayVaoLam.Value);

            tempNhanVien.SDT = txtSoDT.Text;
            tempNhanVien.DiaChi = txtDiaChi.Text;
            tempNhanVien.TrangThai = Int16.Parse(txtTrangThai.Text);
        }

        #endregion        int flag = 0; // thêm=0 sửa=1


        private void DGViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = DGViewNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = DGViewNhanVien.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerNgaySinh.Text = DGViewNhanVien.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerNgayVaoLam.Text = DGViewNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSoCMND.Text = DGViewNhanVien.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerNgayCap.Text = DGViewNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtGioitinh.Text = DGViewNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = DGViewNhanVien.CurrentRow.Cells[7].Value.ToString();
            //txtSoDT.Text = DGViewNhanVien.CurrentRow.Cells[8].Value.ToString();
            txtDiaChi.Text = DGViewNhanVien.CurrentRow.Cells[9].Value.ToString();
            txtTrangThai.Text = DGViewNhanVien.CurrentRow.Cells[10].Value.ToString();
            
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
            txtMaNV.Enabled = false;
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
                if (NhanVienBLL.Add(tempNhanVien))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                if (NhanVienBLL.Update(tempNhanVien))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            FrmNhanVien_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hoàng hoá " + txtHoTen.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (DialogResult.Yes == r)
            //{
            //    passingData();
            //    if (NhanVienBLL.Delete(tempNhanVien.MaNV))
            //        MessageBox.Show("Xoá thành công");
            //    else
            //        MessageBox.Show("Xoá thất bại");
            //}
            //frmNhanVien_Load(sender, e);
            int hideIndex = -1;
            foreach (DataGridViewRow dr in DGViewNhanVien.Rows)
            {
                if (dr.Cells[0].Value.ToString() == txtMaNV.Text)
                {
                    hideIndex = dr.Index;
                }
            }

            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGViewNhanVien.DataSource];
            currencyManager1.SuspendBinding();

            DGViewNhanVien.Rows[hideIndex].Visible = false;

            currencyManager1.ResumeBinding();



            //frmNhanVien_Load(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        #endregion

        private void DGViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dfgffbvgfb
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DGViewNhanVien.DataSource];
            currencyManager1.SuspendBinding();

            DGViewNhanVien.Rows[e.RowIndex].Visible = false;

            currencyManager1.ResumeBinding();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DGViewQLNhanVien_Load();
            EnabledControls(false);
        }

        
        
        private void grpBoxNhanVien_Enter(object sender, EventArgs e)
        {

        }
    }
}
