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
    public partial class FrmChiTietKyLuat : Form
    {

        CTKyLuatNVBLL CTKLBLL;
        KyLuatBLL KyLuatBLL;
        ////GuideBLL guideBLL;
        //DB = new DBDataContext();
        //SR
        public FrmChiTietKyLuat()
        {
            InitializeComponent();
            CTKLBLL = new CTKyLuatNVBLL();
            KyLuatBLL = new KyLuatBLL();
        }

        private void FrmChiTietKyLuat_Load(object sender, EventArgs e)
        {
            DGViewQLChiTietKL_Load();
            TViewSubject_Load();
            EnabledControls(false);
        }

        void DGViewQLChiTietKL_Load()
        {
            dataGridViewChiTietKyLuat.DataSource = CTKLBLL.GetAllCTKL();
            dataGridViewChiTietKyLuat.ReadOnly = true;
            CobQLChiTietKL_Load();
        }

        void CobQLChiTietKL_Load()
        {
            cbbMaKL.DataSource = CTKLBLL.getMaKL();
            cbbHinhThucKyLuat.DataSource = CTKLBLL.getHT();
            cbbMucDo.DataSource = CTKLBLL.getMucDo();
        }

        void TViewSubject_Load()
        {
            treeViewKyLuat.Nodes.Clear();
            TreeNode root = new TreeNode("Danh sách kỷ luật");
            List<KyLuat> subjectsFromDB = KyLuatBLL.GetAllKyLuat();

            TreeNode newNode;
            foreach (KyLuat record in subjectsFromDB)
            {
                newNode = new TreeNode(record.HinhThucKL);
                newNode.Tag = record.MaKL;
                root.Nodes.Add(newNode);
            }
            treeViewKyLuat.Nodes.Add(root);
            treeViewKyLuat.ExpandAll();
        }

        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaNV.Enabled = status;
            txtLyDo.Enabled = status;
            txtGhiChu.Enabled = status;

            cbbHinhThucKyLuat.Enabled = status;
            cbbMaKL.Enabled = status;
            cbbMucDo.Enabled = status;



            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
            btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMaNV.Clear();
            txtLyDo.Clear();
            txtGhiChu.Clear();
        }


        CTKyLuatNV tempKyLuat;
        private CTKyLuatNV passingData()
        {
            try
            {
                tempKyLuat = new CTKyLuatNV();
                tempKyLuat.MaNV = txtMaNV.Text;
                tempKyLuat.MaKyLuat = cbbMaKL.Text;
                tempKyLuat.HinhThucKL = cbbHinhThucKyLuat.Text;
                tempKyLuat.NgayLap = dateTimePickerNgayLap.Value;
                tempKyLuat.NgayThiHanh = dateTimePickerNgayThiHanh.Value;
                tempKyLuat.NgayKetThuc = dateTimeNgayKetThuc.Value;
                tempKyLuat.MucDoKL = cbbMucDo.Text;
                tempKyLuat.LyDo = txtLyDo.Text;
                tempKyLuat.GhiChu = txtGhiChu.Text;
                return tempKyLuat;
            }
            catch { }
            return null;
        }

        private CTKyLuatNV passingData1()
        {
            //tempKyLuat = new CTKyLuatNV();
            //tempKyLuat.MaKyLuat = treeViewKyLuat.SelectedNode.Tag.ToString();
            //tempKyLuat.MaKyLuat = cbbMaKL.Text;
            //try
            //{
            //    tempKyLuat.MaNV = txtMaNV.Text;
            //    tempKyLuat.MaKyLuat = cbbMaKL.Text;
            //    tempKyLuat.HinhThucKL = cbbHinhThucKyLuat.Text;
            //    tempKyLuat.NgayLap = dateTimePickerNgayLap.Value;
            //    tempKyLuat.NgayThiHanh = dateTimePickerNgayThiHanh.Value;
            //    tempKyLuat.NgayKetThuc = dateTimeNgayKetThuc.Value;
            //    tempKyLuat.MucDoKL = cbbMucDo.Text;
            //    tempKyLuat.LyDo = txtLyDo.Text;
            //    tempKyLuat.GhiChu = txtGhiChu.Text;
            //    return tempKyLuat;
            //}
            //catch { }
            return null;
        }

        #endregion        int flag = 0; // thêm=0 sửa=1

        private void treeViewNhanVien_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewKyLuat.SelectedNode.Level != 0)
            {
                string selectedSubjectID = treeViewKyLuat.SelectedNode.Tag.ToString();
                dataGridViewChiTietKyLuat.DataSource = CTKLBLL.GetNhanVien(selectedSubjectID);
            }
        }

        private void dataGridViewChiTietKyLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewChiTietKyLuat_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[8].Value.ToString();
            cbbMaKL.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[7].Value.ToString();
            cbbHinhThucKyLuat.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[6].Value.ToString();
            dateTimePickerNgayLap.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerNgayThiHanh.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[4].Value.ToString();
            dateTimeNgayKetThuc.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[3].Value.ToString();
            cbbMucDo.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[2].Value.ToString();
            txtLyDo.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dataGridViewChiTietKyLuat.CurrentRow.Cells[0].Value.ToString();
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
            cbbHinhThucKyLuat.Enabled = false;
            cbbMaKL.Enabled = false;
            cbbMucDo.Enabled = false;
            txtMaNV.Enabled = false;          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnabledControls(false);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (flag == 0)//thêm
            {
                passingData();
                if (CTKLBLL.Add(passingData()))
                {
                    MessageBox.Show("Thêm thành công");
                    DGViewQLChiTietKL_Load();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                //passingData1();
                if (CTKLBLL.UpDate(passingData()))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            FrmChiTietKyLuat_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hướng dẫn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (DialogResult.Yes == r)
            //{
            //    passingData();
            //    if (CTKLBLL.Delete(tempKyLuat))
            //        MessageBox.Show("Xoá thành công");
            //    else
            //        MessageBox.Show("Xoá thất bại");
            //}
            //FrmChiTietKyLuat_Load(sender, e);
            int hideIndex = 0;
            foreach (DataGridViewRow dr in dataGridViewChiTietKyLuat.Rows)
            {
                if (dr.Cells[0].Value.ToString() == txtMaNV.Text)
                {
                    hideIndex = dr.Index;
                }
            }

            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridViewChiTietKyLuat.DataSource];
            currencyManager1.SuspendBinding();

            dataGridViewChiTietKyLuat.Rows[hideIndex].Visible = false;

            currencyManager1.ResumeBinding();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        #endregion

        private void dataGridViewChiTietKyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridViewChiTietKyLuat.DataSource];
            //currencyManager1.SuspendBinding();

            //dataGridViewChiTietKyLuat.Rows[e.RowIndex].Visible = false;

            //currencyManager1.ResumeBinding();
        }

        private void dateTimePickerNgayThiHanh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
