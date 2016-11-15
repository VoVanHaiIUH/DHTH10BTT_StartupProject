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
        //CTThamGiaDTNVBLL CTDaoTaoBLL;
        ////SubjectBLL subjectBLL;
        //DaoTaoBLL DaoTaoBLL;
        ////DBDataContext DB = new DBDataContext();
        //public FrmCTThamGiaDaoTaoNV()
        //{
        //    InitializeComponent();
        //    CTDaoTaoBLL = new CTThamGiaDTNVBLL();
        //    //subjectBLL = new SubjectBLL();
        //    DaoTaoBLL = new DaoTaoBLL();
        //}

        //private void FrmCTThamGiaDaoTaoNV_Load(object sender, EventArgs e)
        //{
        //    btnUpdate.Enabled = false;
        //    frmMenu f = (frmMenu)MdiParent;
        //    if (f.quyen < 1)
        //    {
        //        txtMaNV.Enabled = false;
        //    }


        //    cboCTDaoTao_Load();
        //    TViewSubject_Load();
        //    DGViewCTDaoTao_Load("CNDT-DT00");
        //    EnabledControls(false);
        //}
        //void cboCTDaoTao_Load()
        //{
        //    cbbMaKhoaDT.DataSource = CTDaoTaoBLL.GetAllDaoTao();
        //    cbbMaKhoaDT.ValueMember = "ID";
        //    cbbMaKhoaDT.DisplayMember = "FullName";
        //}
        //void TViewSubject_Load()
        //{
        //    treeViewDaoTao Nodes.Clear();
        //    TreeNode root = new TreeNode("Danh sách đề tài");
        //    List<Subject> subjectsFromDB = subjectBLL.GetSubjects();

        //    TreeNode newNode;
        //    foreach (Subject record in subjectsFromDB)
        //    {
        //        newNode = new TreeNode(record.Name);
        //        newNode.Tag = record.Id;
        //        root.Nodes.Add(newNode);
        //    }
        //    TViewSubject.Nodes.Add(root);
        //    TViewSubject.ExpandAll();
        //}
        //void DGViewCTDaoTao_Load(string subjectID)
        //{
        //    DGViewCTDaoTao.DataSource = CTDaoTaoBLL.GetCTDaoTaos(subjectID);
        //    DGViewCTDaoTao.ReadOnly = true;
        //}

        //#region Support Methods
        //private void EnabledControls(bool status)
        //{
        //    txtCTDaoTaoID.Enabled = status;
        //    cboCTDaoTao.Enabled = status;

        //    frmMenu f = (frmMenu)MdiParent;
        //    if (f.quyen >= 1)
        //    {
        //        txtScore.Enabled = status;
        //    }

        //    btnSave.Enabled = status;
        //    btnCancel.Enabled = status;

        //    btnAdd.Enabled = !status;
        //    //btnUpdate.Enabled = !status;
        //    btnDelete.Enabled = !status;

        //    TViewSubject.Enabled = !status;
        //}
        //private void ClearTextBox()
        //{
        //    txtCTDaoTaoID.Clear();
        //    cboCTDaoTao.Text = "";
        //    txtScore.Clear();
        //}


        //Guide tempGuide;
        //private void passingData()
        //{
        //    try
        //    {
        //        tempGuide = new Guide();
        //        tempGuide.SubjectID = TViewSubject.SelectedNode.Tag.ToString();
        //        tempGuide.CTDaoTaoID = txtCTDaoTaoID.Text;
        //    }
        //    catch { }

        //}
        //private void passingData1()
        //{
        //    tempGuide = new Guide();
        //    tempGuide.SubjectID = TViewSubject.SelectedNode.Tag.ToString();
        //    tempGuide.CTDaoTaoID = txtCTDaoTaoID.Text;
        //    try
        //    {
        //        tempGuide.Score = Int16.Parse(txtScore.Text);
        //    }
        //    catch { }

        //}


        //#endregion        int flag = 0; // thêm=0 sửa=1


        //private void DGViewCTDaoTao_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtCTDaoTaoID.Text = DGViewCTDaoTao.CurrentRow.Cells[0].Value.ToString();
        //    cboCTDaoTao.Text = DGViewCTDaoTao.CurrentRow.Cells[1].Value.ToString();
        //    txtScore.Text = guideBLL.GetScoreByCTDaoTaoID(txtCTDaoTaoID.Text).ToString();
        //}
        //int flag = 0;
        //#region Button Click Events
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
        //    cboCTDaoTao.Enabled = false;
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    EnabledControls(false);
        //}
        //private void btnSave_Click(object sender, EventArgs e)
        //{

        //    if (flag == 0)//thêm
        //    {
        //        passingData();
        //        if (guideBLL.AddNewGuide(tempGuide))
        //        {
        //            MessageBox.Show("Thêm thành công");
        //            DGViewCTDaoTao_Load(TViewSubject.SelectedNode.Tag.ToString());
        //        }
        //        else
        //            MessageBox.Show("Thêm thất bại");
        //    }
        //    else //sửa 
        //    {
        //        passingData1();
        //        if (guideBLL.Update(tempGuide))
        //            MessageBox.Show("Sửa thành công");
        //        else
        //            MessageBox.Show("Sửa thất bại");
        //    }
        //    frmGuide_Load(sender, e);
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult r = MessageBox.Show("Bạn có chắn chắn xoá hướng dẫn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (DialogResult.Yes == r)
        //    {
        //        passingData();
        //        if (guideBLL.Delete(tempGuide.SubjectID, tempGuide.CTDaoTaoID))
        //            MessageBox.Show("Xoá thành công");
        //        else
        //            MessageBox.Show("Xoá thất bại");
        //    }
        //    frmGuide_Load(sender, e);
        //}
        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (DialogResult.OK == r)
        //        this.Close();
        //}

        //#endregion

        //private void TViewSubject_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    if (TViewSubject.SelectedNode.Level != 0)
        //    {
        //        string selectedSubjectID = TViewSubject.SelectedNode.Tag.ToString();
        //        DGViewCTDaoTao.DataSource = CTDaoTaoBLL.GetCTDaoTaos(selectedSubjectID);
        //    }
        //}

        //private void cboCTDaoTao_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtCTDaoTaoID.Text = cboCTDaoTao.SelectedValue.ToString();
        //}

        //private void txtScore_TextChanged(object sender, EventArgs e)
        //{
        //    //Regex r = new Regex(@"^([0-9]|([1][0]))(\.\d{1,2})?$");

        //    //if (txtScore.TextLength>0)
        //    //{
        //    //    if (!r.IsMatch(txtScore.Text) || txtScore.TextLength>4)
        //    //    {
        //    //        MessageBox.Show("Bạn phải nhập theo đúng định dạng điểm từ 0-10 hoặc có thêm 2 chữ số thập phân ví dụ: \n8\n10\n8.25", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        //    //        txtScore.Clear();
        //    //    }

        //    //}
        //}

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
    }
}
