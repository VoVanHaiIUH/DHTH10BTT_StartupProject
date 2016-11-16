using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPHR_Solution.NhanSu
{
    public partial class FrmLichSuLamViec : Form
    {
        public FrmLichSuLamViec()
        {
            InitializeComponent();
        }

        //LSLamViec LSLamViecBLL;
        //PhongBanBLL PhongBanBLL;
        //////GuideBLL guideBLL;
        ////DB = new DBDataContext();
        ////SR




        //void DGViewLSLV_Load()
        //{
        //    dataGridViewLichSuLamViec.DataSource = LSLVBLL.getAllLS();
        //    dataGridViewLichSuLamViec.ReadOnly = true;
        //    CobQLChiTietKL_Load();
        //}

        //void CobQLChiTietKL_Load()
        //{
        //    cbbMaPB.DataSource = LSLVBLL.getAllLS();
        //    cbbMaPB.DisplayMember = "HinhThucKL";
        //    cbbMaPB.ValueMember = "HinhThucKL";
        //}

        //void TViewSubject_Load()
        //{
        //    treeViewNhanVien.Nodes.Clear();
        //    TreeNode root = new TreeNode("Danh sách Phòng Ban");
        //    List<PhongBan> subjectsFromDB = PhongBanBLL.GetAllPhongBan();

        //    TreeNode newNode;
        //    foreach (PhongBan record in subjectsFromDB)
        //    {
        //        newNode = new TreeNode(record.TenPB);
        //        newNode.Tag = record.MaPB;
        //        root.Nodes.Add(newNode);
        //    }
        //    treeViewNhanVien.Nodes.Add(root);
        //    treeViewNhanVien.ExpandAll();
        //}

        //#region Support Methods
        //private void EnabledControls(bool status)
        //{
        //    txtMaNV.Enabled = status;
        //    dateTimePickerNgayBatDau.Enabled = status;
        //    dateTimePickerNgayKetThuc.Enabled = status;

        //    cbbMaCV.Enabled = status;
        //    cbbMaPB.Enabled = status;




        //    btnSave.Enabled = status;
        //    btnCancel.Enabled = status;
        //    btnAdd.Enabled = !status;
        //    btnUpdate.Enabled = !status;
        //    btnDelete.Enabled = !status;
        //}
        //private void ClearTextBox()
        //{
        //    txtMaNV.Clear();

        //}


        //LSLamViec tempLS;
        //private void passingData()
        //{
        //    try
        //    {
        //        tempLS = new LSLamViec();
        //        tempLS.MaNV = txtMaNV.Text;
        //        tempLS.NgayBD = Convert.ToDateTime(dateTimePickerNgayBatDau);
        //    }
        //    catch { }
        //}

        //private void passingData1()
        //{
        //    tempLS = new LSLamViec();
        //    tempLS.MaPB = treeViewNhanVien.SelectedNode.Tag.ToString();
        //    tempLS.MaPB = cbbMaPB.Text;
        //    try
        //    {
        //        //tempLS.Score = Int16.Parse(txtScore.Text);
        //    }
        //    catch { }
        //}
        //private void passingData2()
        //{
        //    tempLS = new LSLamViec();
        //    tempLS.MaChucVu = treeViewNhanVien.SelectedNode.Tag.ToString();
        //    tempLS.MaChucVu = cbbMaCV.Text;
        //    try
        //    {
        //        //tempLS.Score = Int16.Parse(txtScore.Text);
        //    }
        //    catch { }
        //}

        //#endregion        int flag = 0; // thêm=0 sửa=1

        //private void treeViewNhanVien_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    if (treeViewNhanVien.SelectedNode.Level != 0)
        //    {
        //        string selectedSubjectID = treeViewNhanVien.SelectedNode.Tag.ToString();
        //        dataGridViewLichSuLamViec.DataSource = LSLVBLL.GetNhanVien(selectedSubjectID);
        //    }
        //}

        //private void dataGridViewChiTietKyLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void dataGridViewLichSuLamViec_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtMaNV.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[0].Value.ToString();
        //    cbbMaPB.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[1].Value.ToString();
        //    cbbMaCV.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[2].Value.ToString();
        //    dateTimePickerNgayBatDau.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[3].Value.ToString();
        //    dateTimePickerNgayKetThuc.Text = dataGridViewLichSuLamViec.CurrentRow.Cells[4].Value.ToString();

        //}

        //int flag = 0;
        //public FrmLichSuLamViec()
        //{
        //    PhongBanBLL = new PhongBanBLL();
        //    LSLVBLL = new LichSuLamViecBLL();
        //    LSLamViecBLL = new LSLamViec();
        //    InitializeComponent();
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    passingData();
        //    if (flag == 0)//thêm
        //    {
        //        if (LSLVBLL.Add(tempLS))
        //            MessageBox.Show("Thêm thành công");
        //        else
        //            MessageBox.Show("Thêm thất bại");
        //    }
        //    else //sửa 
        //    {
        //        if (LSLVBLL.UpDate(tempLS))
        //            MessageBox.Show("Sửa thành công");
        //        else
        //            MessageBox.Show("Sửa thất bại");
        //    }
        //    FrmLichSuLamViec_Load(sender, e);
        //}

        //private void grpBoxStudentInfo_Enter(object sender, EventArgs e)
        //{

        //}

        //private void FrmLichSuLamViec_Load(object sender, EventArgs e)
        //{
        //    DGViewLSLV_Load();
        //    TViewSubject_Load();
        //    EnabledControls(false);
        //}
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    flag = 0;
        //    EnabledControls(true);
        //    ClearTextBox();
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    flag = 1;
        //    EnabledControls(true);
        //    txtMaNV.Enabled = false;
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    EnabledControls(false);
        //}


        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    //DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hoàng hoá " + txtTenPB.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    //if (DialogResult.Yes == r)
        //    //{
        //    //    passingData();
        //    //    if (PhongBanBLL.Delete(tempPhongBan.MaPB))
        //    //        MessageBox.Show("Xoá thành công");
        //    //    else
        //    //        MessageBox.Show("Xoá thất bại");
        //    //}
        //    //frmPhongBan_Load(sender, e);
        //    int hideIndex = -1;
        //    foreach (DataGridViewRow dr in dataGridViewLichSuLamViec.Rows)
        //    {
        //        if (dr.Cells[0].Value.ToString() == txtMaNV.Text)
        //        {
        //            hideIndex = dr.Index;
        //        }
        //    }

        //    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridViewLichSuLamViec.DataSource];
        //    currencyManager1.SuspendBinding();

        //    dataGridViewLichSuLamViec.Rows[hideIndex].Visible = false;

        //    currencyManager1.ResumeBinding();



        //    //frmPhongBan_Load(sender, e);
        //}
    }
}
