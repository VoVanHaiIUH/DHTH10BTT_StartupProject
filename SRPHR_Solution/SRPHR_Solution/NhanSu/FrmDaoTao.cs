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

namespace WindowsFormsApplication1
{
    public partial class FrmDaoTao : Form
    {
        public FrmDaoTao()
        {
            InitializeComponent();
            DaoTaoBLL = new DaoTaoBLL();
        }
         DaoTaoBLL DaoTaoBLL;
        
        private void frmDaoTao_Load(object sender, EventArgs e)
        {
            DGViewQLDaoTao_Load();
            EnabledControls(false);
        }

        void DGViewQLDaoTao_Load()
        {
            DGViewDaoTao.DataSource = DaoTaoBLL.GetAllDaoTao();
            DGViewDaoTao.ReadOnly = true;
        }


        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMakhoa.Enabled = status;
            txtTenKhoa.Enabled = status;
            txtDiaDiem.Enabled = status;
            txtHinhthucdaotao.Enabled = status;
            dateTimePickerNgaybatdau.Enabled = status;
            dateTimePickerNgayketthuc.Enabled = status;
            txtChiphi.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;

            btnAdd.Enabled = !status;
            btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMakhoa.Clear();
            txtTenKhoa.Clear();
            txtDiaDiem.Clear();
            txtHinhthucdaotao.Clear();
        }


        DaoTao tempDaoTao;
        private void passingData()
        {
            tempDaoTao = new DaoTao();
            tempDaoTao.MaKhoaDT = txtMakhoa.Text;
            tempDaoTao.TenKhoaDT = txtTenKhoa.Text;
            tempDaoTao.Diadiem =txtDiaDiem.Text;
            tempDaoTao.HinhThucDT = txtHinhthucdaotao.Text;
            tempDaoTao.Chiphi = Convert.ToDecimal(txtChiphi.Text);
            tempDaoTao.NgayBD = Convert.ToDateTime(dateTimePickerNgaybatdau);
            tempDaoTao.NgayKT = Convert.ToDateTime(dateTimePickerNgayketthuc);

        }

        #endregion        int flag = 0; // thêm=0 sửa=1


        private void DGViewDaoTao_SelectionChanged(object sender, EventArgs e)
        {
            txtMakhoa.Text = DGViewDaoTao.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = DGViewDaoTao.CurrentRow.Cells[1].Value.ToString();
            //DTPickerBirthDay.Text = DGViewDaoTao.CurrentRow.Cells[2].Value.ToString();
            txtDiaDiem.Text = DGViewDaoTao.CurrentRow.Cells[2].Value.ToString();
            txtChiphi.Text = DGViewDaoTao.CurrentRow.Cells[3].Value.ToString();
            txtHinhthucdaotao.Text = DGViewDaoTao.CurrentRow.Cells[4].Value.ToString();
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
            txtMakhoa.Enabled = false;
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
                if (DaoTaoBLL.Add(tempDaoTao))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                if (DaoTaoBLL.Update(tempDaoTao))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            frmDaoTao_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hoàng hoá " + txtTenKhoa.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                passingData();
                if (DaoTaoBLL.Delete(tempDaoTao.MaKhoaDT))
                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Xoá thất bại");
            }
            frmDaoTao_Load(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        #endregion

        private void FrmDaoTao_Load(object sender, EventArgs e)
        {

        }
    }
}
