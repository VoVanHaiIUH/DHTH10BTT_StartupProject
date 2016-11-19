using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.BanHang;
using BusinessLogic.BanHang;

//Nhóm chưa update BusinessLogic BanHang

namespace SRPHR_Solution.BanHang
{
    public partial class FormChitietHDBanle : Form
    {

        HoaDonBanLeBLL hdblBLL;
        CTHoaDonBanLeBLL cthdblBLL;
        BindingSource bd = new BindingSource();

        public FormChitietHDBanle()
        {
            InitializeComponent();
            cthdblBLL = new CTHoaDonBanLeBLL();
            hdblBLL = new HoaDonBanLeBLL();
        }

        void TViewSubject_Load()
        {
            treeViewCTHDBL.Nodes.Clear();
            TreeNode root = new TreeNode("Danh sách hóa đơn");
            List<HoaDonBanLe> subjectsFromDB = hdblBLL.GetAllHDBanLe();

            TreeNode newNode;
            foreach (HoaDonBanLe record in subjectsFromDB)
            {
                newNode = new TreeNode(record.NgayBan.ToString());
                newNode.Tag = record.SoHoaDon;
                root.Nodes.Add(newNode);
            }
            treeViewCTHDBL.Nodes.Add(root);
            treeViewCTHDBL.ExpandAll();
        }


        void DGViewCTHDBL_Load()
        {
            DGVCTHDBL.DataSource = cthdblBLL.GetAllCTHDBanLe();
            DGVCTHDBL.ReadOnly = true;

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChitietHDBanLe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void EnabledControls(bool status)
        {
            txtmahdbanle.Enabled = status;
            txtmasp.Enabled = status;
            txtsoluong.Enabled = status;
            txtdongia.Enabled = status;
            txtghichu.Enabled = status;

            btnluu.Enabled = status;
            btnxoa.Enabled = status;

            btnthem.Enabled = !status;
            btnsua.Enabled = !status;
            btnxoa.Enabled = !status;
        }

        private void ClearTextBox()
        {
            txtmahdbanle.Clear();
            txtmasp.Clear();
            txtsoluong.Clear();
            txtghichu.Clear();
            txtdongia.Clear();

        }

        ChiTietHoaDonBanLe tempCTHDBanLe;
        private ChiTietHoaDonBanLe passingData()
        {
            try
            {
                tempCTHDBanLe = new ChiTietHoaDonBanLe();
                tempCTHDBanLe.SoHoaDon = txtmahdbanle.Text;
                tempCTHDBanLe.MaSP = txtmasp.Text;
                tempCTHDBanLe.SoLuong = Convert.ToDouble(txtsoluong.Text);
                tempCTHDBanLe.GhiChu = txtghichu.Text;
                tempCTHDBanLe.DonGia = Convert.ToDecimal(txtghichu.Text);

                return tempCTHDBanLe;
            }
            catch { }
            return null;
        }



        int flag = 0;
        private void ChitietHDBanle_Load(object sender, EventArgs e)
        {
            DGViewCTHDBL_Load();
            EnabledControls(false);
            TViewSubject_Load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Button bt = (Button)sender;
            if (bt.Text.Equals("Thêm"))
            {
                EnabledControls(true);
                btnluu.Enabled = true;

                btnthem.Text = "Hủy";
            }
            else
            {
                ClearTextBox();
                EnabledControls(false);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int hideIndex = -1;
            foreach (DataGridViewRow dr in DGVCTHDBL.Rows)
            {
                if (dr.Cells[0].Value.ToString() == txtmahdbanle.Text)
                {
                    hideIndex = dr.Index;
                }
            }

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DGVCTHDBL.DataSource];
            currencyManager.SuspendBinding();

            DGVCTHDBL.Rows[hideIndex].Visible = false;

            currencyManager.ResumeBinding();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            EnabledControls(true);
            txtmahdbanle.Enabled = false;
            txtmasp.Enabled = false;
        }





        private void FormChitietHDBanle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void treeViewCTHDBL_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewCTHDBL.SelectedNode.Level != 0)
            {
                string selectedSubjectID = treeViewCTHDBL.SelectedNode.Tag.ToString();
                DGVCTHDBL.DataSource = cthdblBLL.ThemCTHDBanLe(selectedSubjectID);
            }
        }

        private void DGVCTHDBL_SelectionChanged(object sender, EventArgs e)
        {
            txtmahdbanle.Text = DGVCTHDBL.CurrentRow.Cells[1].Value.ToString();
            txtmasp.Text = DGVCTHDBL.CurrentRow.Cells[0].Value.ToString();
            txtsoluong.Text = DGVCTHDBL.CurrentRow.Cells[3].Value.ToString();
            txtdongia.Text = DGVCTHDBL.CurrentRow.Cells[4].Value.ToString();
            txtghichu.Text = DGVCTHDBL.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            passingData();
            ChiTietHoaDonBanLe cthdbl = new ChiTietHoaDonBanLe();

            cthdbl.SoHoaDon = txtmahdbanle.Text;
            cthdbl.MaSP = txtmasp.Text;
            cthdbl.SoLuong = Convert.ToDouble(txtsoluong.Text);
            cthdbl.GhiChu = txtghichu.Text;
            cthdbl.DonGia = Convert.ToDecimal(txtdongia.Text);


            int kq = cthdblBLL.ThemCTHDBanLe(cthdbl);
            if (kq == 0)
            {
                MessageBox.Show("Trùng mã hóa đơn !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (kq == 1) MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

     

     




    }

}
