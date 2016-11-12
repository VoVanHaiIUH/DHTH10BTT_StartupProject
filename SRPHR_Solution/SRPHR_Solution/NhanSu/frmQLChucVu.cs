using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;

namespace GUI
{
    public partial class frmQuanLyChucVu : Form
    {
        StudentBLL studentBLL;
        public frmQuanLyChucVu()
        {
            InitializeComponent();
            studentBLL = new StudentBLL();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            DGViewStudent_Load();
            cboGender_Load();
            EnabledControls(false);
        }

        void DGViewStudent_Load()
        {
            DGViewChucVu.DataSource = studentBLL.GetStudents();
            DGViewChucVu.ReadOnly = true;
        }
        private void cboGender_Load()
        {
            cboGender.Items.Clear();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
        }

        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaCV.Enabled = status;
            txtTenCV.Enabled = status;
            cboGender.Enabled = status;
            DTPickerBirthDay.Enabled = status;
            txtGhiChu.Enabled = status;
            txtFacultyID.Enabled = status;

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
            cboGender.Text = "";
            DTPickerBirthDay.Text = "";
            txtGhiChu.Clear();
            txtFacultyID.Clear();
        }


        Person tempStudent;
        private void passingData()
        {
            tempStudent = new Person();
            tempStudent.Id = txtMaCV.Text;
            tempStudent.FullName = txtTenCV.Text;
            tempStudent.Gender = cboGender.SelectedText;
            tempStudent.Bithday = DTPickerBirthDay.Text;
            tempStudent.Address = txtGhiChu.Text;
            tempStudent.FacultyID = txtFacultyID.Text;
        }
        
        #endregion        int flag = 0; // thêm=0 sửa=1


        private void DGViewStudent_SelectionChanged(object sender, EventArgs e)
        {
            txtMaCV.Text = DGViewChucVu.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = DGViewChucVu.CurrentRow.Cells[1].Value.ToString();
            //DTPickerBirthDay.Text = DGViewStudent.CurrentRow.Cells[2].Value.ToString();
            cboGender.Text = DGViewChucVu.CurrentRow.Cells[3].Value.ToString();
            txtGhiChu.Text = DGViewChucVu.CurrentRow.Cells[4].Value.ToString();
            txtFacultyID.Text = DGViewChucVu.CurrentRow.Cells[5].Value.ToString();
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
                if (studentBLL.AddNewStudent(tempStudent))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                if (studentBLL.Update(tempStudent))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            frmStudent_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hoàng hoá " + txtTenCV.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                passingData();
                if (studentBLL.Delete(tempStudent.Id))
                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Xoá thất bại");
            }
            frmStudent_Load(sender, e);
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
