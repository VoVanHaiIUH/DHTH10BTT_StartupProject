using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.NhanSu;
using Entities.NhanSu;

namespace SRPHR_Solution
{
    public partial class NhanSu : Form
    {
        List<NhanVien> lnv = new List<NhanVien>();
        NhanVienBLL nvbll = new NhanVienBLL();
        BindingSource bd = new BindingSource();
        public NhanSu()
        {
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            lnv = nvbll.GetAllNhanVien();
            bd.DataSource = lnv;
            dataGridNhânViên.DataSource = bd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtTên.Text;
            nv.NgaySinh = Convert.ToDateTime(txtNgaySinh);
            nv.SoCMND = txtCMND.Text;
            nv.SDT = txtSđt.Text;
            nv.TrangThai = Convert.ToInt32(txtTrangThai);
            nv.Email = txtMail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.GioiTinh = txtGT.Text;
            nv.NgayVaoLam = Convert.ToDateTime(txtNgayVaoLam);
            nv.NgayCapCMND = Convert.ToDateTime(txtNCCMND);
            bool m = nvbll.Add(nv);
            if(m!=true)
                 {
                     MessageBox.Show("Nhập sai !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                 }
            else 

            {
                MessageBox.Show("Thêm thành Công!", "Thông báo!");
                dataGridNhânViên.DataSource = nvbll.GetAllNhanVien();
            }
           


        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtTên.Text;
            nv.NgaySinh = Convert.ToDateTime(txtNgaySinh);
            nv.SoCMND = txtCMND.Text;
            nv.SDT = txtSđt.Text;
            nv.TrangThai = Convert.ToInt32(txtTrangThai);
            nv.Email = txtMail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.GioiTinh = txtGT.Text;
            nv.NgayVaoLam = Convert.ToDateTime(txtNgayVaoLam);
            nv.NgayCapCMND = Convert.ToDateTime(txtNCCMND);
            //bool m = nvbll.Delete(nv);
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtTên.Text;
            nv.NgaySinh = Convert.ToDateTime(txtNgaySinh);
            nv.SoCMND = txtCMND.Text;
            nv.SDT = txtSđt.Text;
            nv.TrangThai = Convert.ToInt32(txtTrangThai);
            nv.Email = txtMail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.GioiTinh = txtGT.Text;
            nv.NgayVaoLam = Convert.ToDateTime(txtNgayVaoLam);
            nv.NgayCapCMND = Convert.ToDateTime(txtNCCMND);
            bool m = nvbll.Update(nv);
            if(m!=true)
                MessageBox.Show("Không tìm có mã trên!", "Thông Báo!");
            else
            {
                MessageBox.Show("Sửa thành Công!", "Thông báo!");
                dataGridNhânViên.DataSource = nvbll.GetAllNhanVien();
            }
        }

        private void NhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanSu_Load(object sender, EventArgs e)
        {

        }

    }
}
