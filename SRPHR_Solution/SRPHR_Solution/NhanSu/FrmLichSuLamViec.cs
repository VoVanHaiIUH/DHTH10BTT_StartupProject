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
    public partial class FrmLichSuLamViec : Form
    {
        LichSuLamViecBLL LSLVBLL;
        PhongBanBLL PhongBanBLL;
        
        public FrmLichSuLamViec()
        {

            InitializeComponent();
             LSLVBLL = new LichSuLamViecBLL();
            PhongBanBLL = new PhongBanBLL();
            
        }

       
        void cbo_Load()
        {
            cbbMaPB.DataSource = LSLVBLL.getMaPB();
            cbbMaCV.DataSource = LSLVBLL.getMaCV();
            
        }
        void TViewPhongBan_Load()
        {
            treeViewNhanVien.Nodes.Clear();
            TreeNode root = new TreeNode("Danh sách Phòng Ban");
            List<PhongBan> PhongBansFromDB = PhongBanBLL.GetAllPhongBan();

            TreeNode newNode;
            foreach (PhongBan record in PhongBansFromDB)
            {
                newNode = new TreeNode(record.TenPB);
                newNode.Tag = record.MaPB;
                root.Nodes.Add(newNode);
            }
            treeViewNhanVien.Nodes.Add(root);
            treeViewNhanVien.ExpandAll();
        }
        void DGViewLSLV_Load()
        {
            dataGridViewLichSuLamViec.DataSource = LSLVBLL.getAllLS();
            dataGridViewLichSuLamViec.ReadOnly = true;
            cbo_Load();
        }

        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaNV.Enabled = status;
            cbbMaPB.Enabled = status;
            cbbMaCV.Enabled = status;

            //frmMenu f = (frmMenu)MdiParent;
            

            btnSave.Enabled = status;
            btnCancel.Enabled = status;

            btnAdd.Enabled = !status;
            btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;

            treeViewNhanVien.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMaNV.Clear();
            cbbMaPB.Text = "";
            cbbMaCV.Text="";
            
        }


        LSLamViec tempLSLV;
        public LSLamViec passingData()
        {
            try
            {
                tempLSLV = new LSLamViec();
                tempLSLV.MaNV = treeViewNhanVien.SelectedNode.Tag.ToString();
                tempLSLV.MaNV = txtMaNV.Text;
                tempLSLV.MaPB = cbbMaPB.Text;
                tempLSLV.MaChucVu = cbbMaCV.Text;
                tempLSLV.NgayBD = dateTimePickerNgayBatDau.Value;
                tempLSLV.NgayKT = dateTimePickerNgayKetThuc.Value;
            }
            catch { }
            return null;

        }
        private void passingData1()
        {
            //tempLSLV = new LichSuLamViec();
            //tempLSLV.MaKhoaDT = treeViewPhongBan.SelectedNode.Tag.ToString();
            //tempLSLV.MaKhoaDT = treeViewPhongBan.Text;
            //tempLSLV.KetQua = txtKetQua.Text;
            //tempLSLV.NhanXet = txtNhanXet.Text;
            //tempLSLV.MaNV = cbbMaNV.SelectedValue.ToString();
            //try
            //{
            //    tempLSLV.KetQua = txtKetQua.Text;
            //}
            //catch { }

        }


        #endregion        //int flag = 0; // thêm=0 sửa=1


        
        int flag = 0;
        #region Button Click Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            EnabledControls(true);
            //ClearTextBox();
            txtMaNV.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = 1;
            EnabledControls(true);
            cbbMaPB.Enabled = false;
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
                if (LSLVBLL.Add(passingData()))
                {
                    MessageBox.Show("Thêm thành công");
                    DGViewLSLV_Load();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                //passingData1();
                if (LSLVBLL.UpDate(passingData()))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            FrmLichSuLamViec_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hướng dẫn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (DialogResult.Yes == r)
            //{
            //    passingData();
            //    if (guideBLL.Delete(tempGuide.SubjectID, tempGuide.LSLVID))
            //        MessageBox.Show("Xoá thành công");
            //    else
            //        MessageBox.Show("Xoá thất bại");
            //}
            //frmGuide_Load(sender, e);
            int hideIndex = -1;
            foreach (DataGridViewRow dr in dataGridViewLichSuLamViec.Rows)
            {
                if (dr.Cells[2].Value.ToString() == txtMaNV.Text)
                {
                    hideIndex = dr.Index;
                }
            }

            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridViewLichSuLamViec.DataSource];
            currencyManager1.SuspendBinding();

            dataGridViewLichSuLamViec.Rows[hideIndex].Visible = false;

            currencyManager1.ResumeBinding();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        #endregion

        private void TViewSubject_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewNhanVien.SelectedNode.Level != 0)
            {
                string selectedSubjectID = treeViewNhanVien.SelectedNode.Tag.ToString();
                dataGridViewLichSuLamViec.DataSource = LSLVBLL.GetNhanVien(selectedSubjectID);
            }
        }

        private void cboLSLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = cbbMaPB.SelectedValue.ToString();
        }


        private void FrmLichSuLamViec_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            //frmMenu f = (frmMenu)MdiParent;
            //cboMaNV_Load();
           // cbbMaPB.DataSource = LSLVBLL.getMaPB();
            TViewPhongBan_Load();
            DGViewLSLV_Load();
            EnabledControls(false);
        }

        private void cbbMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = cbbMaCV.SelectedValue.ToString();
        }

        private void dataGridViewLichSuLamViec_SelectionChanged_1(object sender, EventArgs e)
        {
            txtMaNV.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[3].Value.ToString();
            cbbMaPB.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[2].Value.ToString();
           dateTimePickerNgayBatDau.Text =dataGridViewLichSuLamViec.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerNgayKetThuc.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[0].Value.ToString();
            cbbMaCV.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[4].Value.ToString();
        }

        //private void txtScore_Leave(object sender, EventArgs e)
        //{
        //    Regex r = new Regex(@"^([0-9]|([1][0]))(\.\d{1,2})?$");

        //    if (txtScore.TextLength > 0)
        //    {
        //        if (!r.IsMatch(txtScore.Text))
        //        {
        //            MessageBox.Show("Bạn phải nhập theo đúng định dạng điểm từ 0-10 hoặc có thêm 2 chữ số thập phân ví dụ: \n8\n10\n8.25", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        //            txtScore.Clear();
        //        }

        //    }
        //    try
        //    {
        //        if (double.Parse(txtScore.Text) > 10)
        //        {
        //            txtScore.Text = "10";
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

    }
}
