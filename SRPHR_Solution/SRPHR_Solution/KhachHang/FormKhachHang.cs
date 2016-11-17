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
            btnDoiDiem.Enabled = status;
            btnDoiThuong.Enabled = status;
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
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            dtpngaysinh.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtCMND.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtNgheNghiep.Text = dgvKhachHang.CurrentRow.Cells[7].Value.ToString();
            txtGioiTinh.Text = dgvKhachHang.CurrentRow.Cells[8].Value.ToString();
            dtpngaycapcmnd.Text = dgvKhachHang.CurrentRow.Cells[9].Value.ToString();
            txtTrangThai.Text = dgvKhachHang.CurrentRow.Cells[10].Value.ToString();
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
