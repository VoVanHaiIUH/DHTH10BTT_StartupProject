using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            k.Tenkh = txtTenKH.Text;
            k.Diachi = txtDiaChi.Text;
            k.Ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
            k.Ngaycapcmnd = Convert.ToDateTime(txtNgaycap.Text);
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





        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int kq = khbll.Update(txtMaKH.Text, txtTenKH.Text, txtEmail.Text, Convert.ToInt32(txtGioiTinh.Text), txtCMND.Text, txtDiaChi.Text, Convert.ToDateTime(txtNgaycap.Text), Convert.ToDateTime(txtNgaySinh), txtEmail.Text, txtNgheNghiep.Text, txtSDT.Text);

            if (kq == 1)
            {

                dgvKhachHang.DataSource = khbll.GetAllKhachHang();
                MessageBox.Show("Sua xong!!!");
            }
            else
            {
                MessageBox.Show("sửa thât bại.Không được sửa mã dv!");
            }

        }

    }
}
