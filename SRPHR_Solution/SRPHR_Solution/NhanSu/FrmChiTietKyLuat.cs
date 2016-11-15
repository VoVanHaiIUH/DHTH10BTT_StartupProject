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
        //CTKyLuatNVBLL CTKLBLL;
        //KyLuatBLL KyLuatBLL;
        ////GuideBLL guideBLL;
        ////DBDataContext DB = new DBDataContext();
        //SR
        //public frmGuide()
        //{
        //    InitializeComponent();
        //    studentBLL = new StudentBLL();
        //    subjectBLL = new SubjectBLL();
        //    guideBLL = new GuideBLL();
        //}

        //private void frmGuide_Load(object sender, EventArgs e)
        //{
        //    btnUpdate.Enabled = false;
        //    frmMenu f = (frmMenu)MdiParent;
        //    if (f.quyen < 1)
        //    {
        //        txtScore.Enabled = false;
        //    }


        //    cboStudent_Load();
        //    TViewSubject_Load();
        //    DGViewStudent_Load("CNDT-DT00");
        //    EnabledControls(false);
        //}
        //void cboStudent_Load()
        //{
        //    cboStudent.DataSource = studentBLL.GetStudents();
        //    cboStudent.ValueMember = "ID";
        //    cboStudent.DisplayMember = "FullName";
        //}
        //void TViewSubject_Load()
        //{
        //    TViewSubject.Nodes.Clear();
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
        //void DGViewStudent_Load(string subjectID)
        //{
        //    DGViewStudent.DataSource = studentBLL.GetStudents(subjectID);
        //    DGViewStudent.ReadOnly = true;
        //}

        //#region Support Methods
        //private void EnabledControls(bool status)
        //{
        //    txtStudentID.Enabled = status;
        //    cboStudent.Enabled = status;

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
        //    txtStudentID.Clear();
        //    cboStudent.Text = "";
        //    txtScore.Clear();
        //}


        //Guide tempGuide;
        //private void passingData()
        //{
        //    try
        //    {
        //        tempGuide = new Guide();
        //        tempGuide.SubjectID = TViewSubject.SelectedNode.Tag.ToString();
        //        tempGuide.StudentID = txtStudentID.Text;
        //    }
        //    catch { }

        //}
        //private void passingData1()
        //{
        //    tempGuide = new Guide();
        //    tempGuide.SubjectID = TViewSubject.SelectedNode.Tag.ToString();
        //    tempGuide.StudentID = txtStudentID.Text;
        //    try
        //    {
        //        tempGuide.Score = Int16.Parse(txtScore.Text);
        //    }
        //    catch { }

        //}


        //#endregion        int flag = 0; // thêm=0 sửa=1


        //private void DGViewStudent_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtStudentID.Text = DGViewStudent.CurrentRow.Cells[0].Value.ToString();
        //    cboStudent.Text = DGViewStudent.CurrentRow.Cells[1].Value.ToString();
        //    txtScore.Text = guideBLL.GetScoreByStudentID(txtStudentID.Text).ToString();
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
        //    cboStudent.Enabled = false;
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
        //            DGViewStudent_Load(TViewSubject.SelectedNode.Tag.ToString());
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
        //        if (guideBLL.Delete(tempGuide.SubjectID, tempGuide.StudentID))
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
        //        DGViewStudent.DataSource = studentBLL.GetStudents(selectedSubjectID);
        //    }
        //}

        //private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtStudentID.Text = cboStudent.SelectedValue.ToString();
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

        private void FrmChiTietKyLuat_Load(object sender, EventArgs e)
        {

        }

        private void treeViewNhanVien_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridViewChiTietKyLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
