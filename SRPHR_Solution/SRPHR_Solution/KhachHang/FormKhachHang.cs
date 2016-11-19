using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.KhachHang;
using BusinessLogic.KhachHang;
using System.Data.Linq;

namespace SRPHR_Solution.KhachHang
{

    public partial class FormKhachHang : Form
    {
        List<eKhachHang> listKH;
        KhachHangBLL khbll;

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            listKH = new List<eKhachHang>();
            khbll = new KhachHangBLL();
            listKH = khbll.GetAllKhachHang().ToList();
            LoadDataGridView(dgvKhachHang, listKH);

        }
        private void LoadDataGridView(DataGridView dgv, List<eKhachHang> ls)
        {
            dgv.DataSource = ls;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;



            eKhachHang k = new eKhachHang();
            k.Makh = txtMaKH.Text;
            k.Tenkh = txtTenKH.Text;
            k.Diachi = txtDiaChi.Text;
            k.Ngaysinh = Convert.ToDateTime(dtpngaysinh.Text);
            k.Ngaycapcmnd = Convert.ToDateTime(dtpngaycapcmnd.Text);
            k.Trangthai = Convert.ToInt32(txtTrangThai.Text);
            k.Nghenghiep = txtNgheNghiep.Text;
            k.Email = txtEmail.Text;
            k.Sodienthoai = txtSDT.Text;
            k.Socmnd = txtCMND.Text;
            k.Gioitinh = txtGioiTinh.Text;




            int kq = khbll.AddKH(k);

            if (kq == 1)
            {
                MessageBox.Show("them thanh cong");
            }
            else
                MessageBox.Show("Thêm Thất Bại!Kiểm Tra Chùng Mã.");


            dgvKhachHang.DataSource = khbll.GetAllKhachHang();
        }
        public void DisableTextbox(bool status)
        {
            txtMaKH.ReadOnly = status;
            txtTenKH.ReadOnly = status;
            txtCMND.ReadOnly = status;
            txtDiaChi.ReadOnly = status;
            txtEmail.ReadOnly = status;
            txtGioiTinh.ReadOnly = status;
            dtpngaycapcmnd.Enabled = !status;
            txtNgheNghiep.ReadOnly = status;
            txtSDT.ReadOnly = status;
            txtTrangThai.ReadOnly = status;
            dtpngaysinh.Enabled = !status;
        }
        public void EnableButton(bool status)
        {
            btnThem.Enabled = status;
            btnSua.Enabled = status;
            btnLuu.Enabled = !status;
            //btnDoiDiem.Enabled = status;
            btnExit.Enabled = status;

        }





        private void btnluu_Click(object sender, EventArgs e)
        {
            /*string makh = txtMaKH.Text;
            if (makh != null)
            {
                khbll.UpDatekhachhang(makh, txtTenKH.Text, txtDiaChi.Text, txtEmail.Text, txtCMND.Text, txtSDT.Text, txtNgheNghiep.Text, txtGioiTinh.Text, Convert.ToInt32(txtTrangThai.Text), Convert.ToDateTime(dtpngaycapcmnd.Text), Convert.ToDateTime(dtpngaysinh.Text));
                MessageBox.Show("Sửa xong !!");
                EnableButton(true);
                btnluu.Enabled = false;
                DisableTextbox(true);

                listKH = khbll.GetAllKhachHang();
                LoadDataGridView(dgvKhachHang,listKH);
                btnSua.Text = "Sửa";
            }
            else { MessageBox.Show("bạn chưa chọn vào sản phẩm cần sửa thông tin!"); }*/
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            eKhachHang kh = new eKhachHang();
            kh.Makh = txtMaKH.Text.Trim();
            kh.Tenkh = txtTenKH.Text.Trim();
            kh.Diachi = txtDiaChi.Text.Trim();
            kh.Email = txtEmail.Text.Trim();
            kh.Gioitinh = txtGioiTinh.Text.Trim();
            kh.Nghenghiep = txtNgheNghiep.Text.Trim();
            kh.Socmnd = txtCMND.Text.Trim();
            kh.Sodienthoai = txtSDT.Text.Trim();
            kh.Trangthai = Convert.ToInt32(txtTrangThai.Text.Trim());
            kh.Ngaycapcmnd = Convert.ToDateTime(dtpngaycapcmnd.Text.Trim());
            kh.Ngaysinh = Convert.ToDateTime(dtpngaysinh.Text.Trim());
            bool kq = khbll.UpDatekhachhang(kh);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để sửa!", "Thông báo!");

            }
            else
            {
                MessageBox.Show("Sửa thành công!", "Thông báo!");
                dgvKhachHang.DataSource = khbll.GetAllKhachHang();
            }
            EnableButton(true);
            btnLuu.Enabled = true;
            DisableTextbox(true);

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // int kq = khbll.UpDatekhachhang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text,txtEmail.Text, txtCMND.Text,txtSDT.Text,txtNgheNghiep.Text,txtGioiTinh.Text, Convert.ToInt32(txtTrangThai.Text),Convert.ToDateTime( dtpngaycapcmnd.Text),Convert.ToDateTime(dtpngaysinh.Text));

            if (btnSua.Text == "Sửa")
            {
                EnableButton(false);
                btnSua.Enabled = true;
                btnSua.Text = "Bỏ qua";
                DisableTextbox(false);
                btnLuu.Enabled = true;
                txtMaKH.ReadOnly = true;
                txtMaKH.Focus();
            }
            else
            {
                EnableButton(true);
                btnLuu.Enabled = false;
                DisableTextbox(true);
                listKH = khbll.GetAllKhachHang();
                LoadDataGridView(dgvKhachHang, listKH);
                btnSua.Text = "Sửa";

            }
        }

        private void dgvKhachHang_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {

        }



        private void dtpngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnthemthe_Click(object sender, EventArgs e)
        {
            FrmTheThanhVien frm1 = new FrmTheThanhVien();
            frm1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                txtMaKH.Text = e.Row.Cells["Makh"].Value.ToString();
                txtTenKH.Text = e.Row.Cells["Tenkh"].Value.ToString();
                txtDiaChi.Text = e.Row.Cells["Diachi"].Value.ToString();
                dtpngaysinh.Text = e.Row.Cells["Ngaysinh"].Value.ToString();
                txtEmail.Text = e.Row.Cells["Email"].Value.ToString();
                txtCMND.Text = e.Row.Cells["Socmnd"].Value.ToString();
                txtSDT.Text = e.Row.Cells["Sodienthoai"].Value.ToString();
                txtNgheNghiep.Text = e.Row.Cells["Nghenghiep"].Value.ToString();
                txtGioiTinh.Text = e.Row.Cells["Gioitinh"].Value.ToString();
                dtpngaycapcmnd.Text = e.Row.Cells["Ngaycapcmnd"].Value.ToString();
                txtTrangThai.Text = e.Row.Cells["Trangthai"].Value.ToString();
            }
        }

        /* private void btntimbansikh_Click(object sender, EventArgs e)
         {
             string hd = txttimmahdbansikh.Text;
             string nv = txttimmahdbansikh.Text;
             string kh = txttimmahdbansikh.Text;
             hdbs = blbs.Getall(hd, nv, kh);
             dgvhdbansikh.DataSource = hdbs;


         }*/
    }
}
