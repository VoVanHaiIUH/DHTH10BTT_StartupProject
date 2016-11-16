using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.CongNoPKH;
using BusinessLogic.CongNoPKH;

namespace SRPHR_Solution.CongNoPKH
{
    public partial class QuanLyPhongKeHoach : Form
    {
        public QuanLyPhongKeHoach()
        {
            InitializeComponent();
            nccbll = new NhaCungCap_BLL();
            ncc = new List<eNhaCungCap>();
            loaddataintreeview(ncc, treeView1);
            spbll = new SanPham_BLL();
            sp = new List<eSanPham>();
            sp = spbll.getallsanpham();
            loaddatagridviewsp(sp, dgvSanPham);
            EnableButton(true);
        }
       
        NhaCungCap_BLL nccbll;
        List<eNhaCungCap> ncc;
        SanPham_BLL spbll;
        List<eSanPham> sp;
        BindingSource bds = new BindingSource();
        public void loadvaogrid(string masp)
        {
            sp = spbll.getbymasanpham(masp);
            bds.DataSource = sp;
            dgvSanPham.DataSource = bds;
        }
        public void loaddataintreeview(List<eNhaCungCap> ncc, TreeView tv)
        {
            tv.Nodes.Clear();
            TreeNode n;
            foreach (eNhaCungCap tmp in nccbll.getAllNCC())
            {
                n = new TreeNode(tmp.tenNCC);
                n.Tag = tmp.maNCC;
                tv.Nodes.Add(n);

            }
        }
        public void loaddatagridviewsp(List<eSanPham> sp, DataGridView dtgvsp)
        {
            sp = spbll.getallsanpham();
            bds.DataSource = sp;
            dgvSanPham.DataSource = bds;
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dgvkhuyenmai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntimsp_Click(object sender, EventArgs e)
        {

        }

        private void btnThoatsp_Click(object sender, EventArgs e)
        {

        }

        private void btnSuasp_Click(object sender, EventArgs e)
        {

        }

        private void btnLuusp_Click(object sender, EventArgs e)
        {

        }

        private void btnThemsp_Click(object sender, EventArgs e)
        {

        }

        private void btnthemncc_Click(object sender, EventArgs e)
        {

        }

        private void cbtt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPham_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemsp_Click_1(object sender, EventArgs e)
        {
            eSanPham b = new eSanPham();
            b.maSP = txtmaspsp.Text;
            b.tenSP = txtTenSP.Text;
            b.moTa = txtMoTa.Text;
            b.ngaySX = Convert.ToDateTime(dtpnsxsp.Text);
            b.hanSD = Convert.ToDateTime(dtphsdsp.Text);
            b.tenNhaPP = txtNhaPhanPhoi.Text;
            b.tenNhaSX = txtNhaSXuat.Text;
            b.trangthai = Convert.ToInt32(cbtt.SelectedItem.ToString());
            int m = spbll.ThemSanPham(b);
            if (m == 0) MessageBox.Show("Trùng mã !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                if (m == 1) MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                loaddatagridviewsp(sp, dgvSanPham);
            }
            btnLuusp.Enabled = false;
            btnSuasp.Enabled = true;
            btnthemncc.Enabled = true;
        }

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            string masp = (string)((TreeView)sender).SelectedNode.Tag;
            if (spbll.getbymasanpham(masp).Count() == 0)
            {
                MessageBox.Show("Trong nha cung cap  không có san pham", "Thong bao!");
                loaddatagridviewsp(sp, dgvSanPham);
            }
            else
            {
                loadvaogrid(masp);
            }
        }

        private void dgvSanPham_RowStateChanged_1(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                eSanPham tth = (eSanPham)bds.Current;
                txtmaspsp.Text = e.Row.Cells["maSP"].Value.ToString();
                txtTenSP.Text = e.Row.Cells["tenSP"].Value.ToString();
                txtMoTa.Text = e.Row.Cells["moTa"].Value.ToString();
                dtpnsxsp.Text = e.Row.Cells["ngaySX"].Value.ToString();
                dtphsdsp.Text = e.Row.Cells["hanSD"].Value.ToString();
                txtNhaPhanPhoi.Text = e.Row.Cells["tenNhaPP"].Value.ToString();
                txtNhaSXuat.Text = e.Row.Cells["tenNhaSX"].Value.ToString();
                cbtt.SelectedItem = e.Row.Cells["trangthai"].Value.ToString();

            }
        }
        public void EnableButton(bool status)
        {
            btnThemsp.Enabled = status;
            btnSuasp.Enabled = status;
            btnLuusp.Enabled = !status;

        }
        public void DisableTextbox(bool status)
        {
            txtmaspsp.ReadOnly = status;
            txtMoTa.ReadOnly = status;
            txtNhaPhanPhoi.ReadOnly = status;
            txtTenSP.ReadOnly = status;
            dtphsdsp.Enabled = !status;
            dtpnsxsp.Enabled = !status;
            cbtt.Enabled = !status;
            txtNhaSXuat.ReadOnly = status;
        }
        private void btnSuasp_Click_1(object sender, EventArgs e)
        {
            if (btnSuasp.Text == "Sửa")
            {
                EnableButton(false);
                btnSuasp.Enabled = true;
                btnSuasp.Text = "Bỏ qua";
                DisableTextbox(false);
                btnLuusp.Enabled = true;
                txtmaspsp.ReadOnly = true;
                txtmaspsp.Focus();
            }
            else
            {
                EnableButton(true);
                btnLuusp.Enabled = false;
                DisableTextbox(true);
                sp = spbll.getallsanpham();
                loaddatagridviewsp(sp, dgvSanPham);
                btnSuasp.Text = "Sửa";

            }
        }

        private void btnLuusp_Click_1(object sender, EventArgs e)
        {
            string masp = txtmaspsp.Text;
            if (masp != null)
            {
                spbll.UpDateSanPham(masp, txtTenSP.Text, txtMoTa.Text, Convert.ToDateTime(dtpnsxsp.Text), Convert.ToDateTime(dtphsdsp.Text), txtNhaPhanPhoi.Text, txtNhaSXuat.Text, Convert.ToInt32(cbtt.SelectedItem.ToString()));
                MessageBox.Show("Sửa xong !!");
                EnableButton(true);
                btnLuusp.Enabled = false;
                DisableTextbox(true);

                sp = spbll.getallsanpham();
                loaddatagridviewsp(sp, dgvSanPham);
                btnSuasp.Text = "Sửa";
            }
            else { MessageBox.Show("bạn chưa chọn vào sản phẩm cần sửa thông tin!"); }
        }

        private void btntimsp_Click_1(object sender, EventArgs e)
        {
            string masp = txttimsp.Text;
            sp = spbll.getalltim(masp);
            dgvSanPham.DataSource = sp;
        }

        private void btnthemncc_Click_1(object sender, EventArgs e)
        {
            frmnhacungcap frm = new frmnhacungcap();
            frm.ShowDialog();
            loaddataintreeview(ncc, treeView1);
        }

        private void QuanLyPhongKeHoach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoatsp_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvhdbansikh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
