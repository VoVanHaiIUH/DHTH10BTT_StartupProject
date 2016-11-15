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
    public partial class FrmCTThamGiaDaoTaoNV : Form
    {
        CTThamGiaDTNVBLL CTDaoTaoBLL;
        //SubjectBLL subjectBLL;
        DaoTaoBLL DaoTaoBLL;
        NhanVienBLL nhanVienBLL;
        //DBDataContext DB = new DBDataContext();
        public FrmCTThamGiaDaoTaoNV()
        {
            InitializeComponent();
            CTDaoTaoBLL = new CTThamGiaDTNVBLL();
            //subjectBLL = new SubjectBLL();
            DaoTaoBLL = new DaoTaoBLL();
        }

        private void FrmCTThamGiaDaoTaoNV_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            frmMenu f = (frmMenu)MdiParent;
            if (f.quyen < 1)
            {
                txtMaKhoaDT.Enabled = false;
            }


            cboMaNV_Load();
            TViewDaoTao_Load();
            DGViewCTDaoTao_Load("CNDT-DT00");
            EnabledControls(false);
        }
        void cboMaNV_Load()
        {
            cbbMaNV.DataSource =nhanVienBLL.GetAllNhanVien();
            cbbMaNV.ValueMember = "maNV";
            cbbMaNV.DisplayMember = "hoTen";
        }
        void TViewDaoTao_Load()
        {
            treeViewDaoTao.Nodes.Clear();
            TreeNode root = new TreeNode("Danh sách Chi Tiết Đào Tạo");
            List<DaoTao> DaoTaosFromDB = DaoTaoBLL.GetAllDaoTao();

            TreeNode newNode;
            foreach (DaoTao record in DaoTaosFromDB)
            {
                newNode = new TreeNode(record.TenKhoaDT);
                newNode.Tag = record.MaKhoaDT;
                root.Nodes.Add(newNode);
            }
            treeViewDaoTao.Nodes.Add(root);
            treeViewDaoTao.ExpandAll();
        }
        void DGViewCTDaoTao_Load(string madt)
        {
            dataGridViewCTDaoTao.DataSource = CTDaoTaoBLL.GetCTDaoTaoByMaDaoTao(madt);
            dataGridViewCTDaoTao.ReadOnly = true;
        }

        #region Support Methods
        private void EnabledControls(bool status)
        {
            txtMaKhoaDT.Enabled = status;
            cbbMaNV.Enabled = status;

            frmMenu f = (frmMenu)MdiParent;
            if (f.quyen >= 1)
            {
                txtMaKhoaDT.Enabled = status;
            }

            btnSave.Enabled = status;
            btnCancel.Enabled = status;

            btnAdd.Enabled = !status;
            //btnUpdate.Enabled = !status;
            btnDelete.Enabled = !status;

            treeViewDaoTao.Enabled = !status;
        }
        private void ClearTextBox()
        {
            txtMaKhoaDT.Clear();
            cbbMaNV.Text = "";
            txtKetQua.Clear();
            txtNhanXet.Clear();
        }


        CTThamGiaDTNV tempCTDaoTao;
        private void passingData()
        {
            try
            {
                tempCTDaoTao = new CTThamGiaDTNV();
                tempCTDaoTao.MaKhoaDT = treeViewDaoTao.SelectedNode.Tag.ToString();
                tempCTDaoTao.MaKhoaDT = txtMaKhoaDT.Text;
            }
            catch { }

        }
        private void passingData1()
        {
            tempCTDaoTao = new CTThamGiaDTNV();
            tempCTDaoTao.MaKhoaDT = treeViewDaoTao.SelectedNode.Tag.ToString();
            tempCTDaoTao.MaKhoaDT = treeViewDaoTao.Text;
            try
            {
                tempCTDaoTao.KetQua = txtKetQua.Text;
            }
            catch { }

        }


        #endregion        int flag = 0; // thêm=0 sửa=1


        private void DGViewCTDaoTao_SelectionChanged(object sender, EventArgs e)
        {
            txtMaKhoaDT.Text = dataGridViewCTDaoTao.CurrentRow.Cells[0].Value.ToString();
            cbbMaNV.Text = dataGridViewCTDaoTao.CurrentRow.Cells[1].Value.ToString();
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
            cbbMaNV.Enabled = false;
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
                if (CTDaoTaoBLL.Add(tempCTDaoTao))
                {
                    MessageBox.Show("Thêm thành công");
                    DGViewCTDaoTao_Load(treeViewDaoTao.SelectedNode.Tag.ToString());
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else //sửa 
            {
                passingData1();
                if (CTDaoTaoBLL.UpDate(tempCTDaoTao))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            FrmCTThamGiaDaoTaoNV_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hướng dẫn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (DialogResult.Yes == r)
            //{
            //    passingData();
            //    if (guideBLL.Delete(tempGuide.SubjectID, tempGuide.CTDaoTaoID))
            //        MessageBox.Show("Xoá thành công");
            //    else
            //        MessageBox.Show("Xoá thất bại");
            //}
            //frmGuide_Load(sender, e);
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
            if (treeViewDaoTao.SelectedNode.Level != 0)
            {
                string selectedMaDaoTao = treeViewDaoTao.SelectedNode.Tag.ToString();
                dataGridViewCTDaoTao.DataSource = CTDaoTaoBLL.GetCTDaoTaoByMaDaoTao(selectedMaDaoTao);
            }
        }

        private void cboCTDaoTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKhoaDT.Text = cbbMaNV.SelectedValue.ToString();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            //Regex r = new Regex(@"^([0-9]|([1][0]))(\.\d{1,2})?$");

            //if (txtScore.TextLength>0)
            //{
            //    if (!r.IsMatch(txtScore.Text) || txtScore.TextLength>4)
            //    {
            //        MessageBox.Show("Bạn phải nhập theo đúng định dạng điểm từ 0-10 hoặc có thêm 2 chữ số thập phân ví dụ: \n8\n10\n8.25", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //        txtScore.Clear();
            //    }

            //}
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

        private void grpBoxCTTGDaoTaoNV_Enter(object sender, EventArgs e)
        {

        }

        private void treeViewDaoTao_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
