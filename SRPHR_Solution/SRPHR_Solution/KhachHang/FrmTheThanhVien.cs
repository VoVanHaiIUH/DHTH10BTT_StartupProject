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
    public partial class FrmTheThanhVien : Form
    {
        List<eThethanhvien> listthetv;
        TheThanhVienBLL thetvbll;
        public FrmTheThanhVien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTheThanhVien_Load(object sender, EventArgs e)
        {
            listthetv = new List<eThethanhvien>();
            thetvbll = new TheThanhVienBLL();
            listthetv = thetvbll.GetAllTheThanhVien().ToList();
            LoadDataGridView(dgvthethanhvien, listthetv);
        }
        private void LoadDataGridView(DataGridView dgv, List<eThethanhvien> ls)
        {
            dgv.DataSource = ls;

        }

        private void btnthemthe_Click(object sender, EventArgs e)
        {

            string mathe = txtmathe.Text;


            eThethanhvien k = new eThethanhvien();
            k.Mathe = txtmathe.Text;
            k.Makh = txtmakh.Text;
            k.Diemtichluy = Convert.ToInt32(txtdiemtichluy.Text);
            k.Tongtien = Convert.ToInt32(txttongtien.Text);
            k.Ngaylap = Convert.ToDateTime(dtpngaylap.Text);
            k.Ngayhethan = Convert.ToDateTime(dtpngayhethan.Text);
            k.Ghichu = txtghichu.Text;




            int kq = thetvbll.AddThe(k);

            if (kq == 1)
            {
                MessageBox.Show("them thanh cong");
            }
            else
                MessageBox.Show("Thêm Thất Bại!Kiểm Tra Chùng Mã.");


            dgvthethanhvien.DataSource = thetvbll.GetAllTheThanhVien();
        }
        public void DisableTextbox(bool status)
        {
            txtmakh.ReadOnly = status;
            txtmathe.ReadOnly = status;
            txtdiemtichluy.ReadOnly = status;
            txtghichu.ReadOnly = status;
            txttongtien.ReadOnly = status;
            dtpngayhethan.Enabled = !status;
            dtpngaylap.Enabled = !status;
        }
        public void EnableButton(bool status)
        {
            btnthemthe.Enabled = status;
            btnsua.Enabled = status;
            btnLuu.Enabled = !status;
            btnthoat.Enabled = status;

        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "Sua")
            {
                EnableButton(false);
                btnsua.Enabled = true;
                btnsua.Text = "Bỏ qua";
                DisableTextbox(false);
                btnLuu.Enabled = true;
                txtmathe.ReadOnly = true;
                txtmakh.ReadOnly = true;
                txtdiemtichluy.ReadOnly = true;
                txtmathe.Focus();
            }
            else
            {
                EnableButton(true);
                btnLuu.Enabled = false;
                DisableTextbox(true);
                listthetv = thetvbll.GetAllTheThanhVien();
                LoadDataGridView(dgvthethanhvien, listthetv);
                btnsua.Text = "Sua";

            }

        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            txtmathe.Text = dgvthethanhvien.CurrentRow.Cells[3].Value.ToString();
            txtmakh.Text = dgvthethanhvien.CurrentRow.Cells[4].Value.ToString();
            txtdiemtichluy.Text = dgvthethanhvien.CurrentRow.Cells[5].Value.ToString();
            eThethanhvien kh = new eThethanhvien();
            kh.Makh = txtmakh.Text.Trim();
            kh.Mathe = txtmathe.Text.Trim();
            kh.Ghichu = txtghichu.Text.Trim();
            // kh.Diemtichluy = Convert.ToInt32(txtdiemtichluy.Text.Trim());
            kh.Tongtien = Convert.ToInt32(txttongtien.Text.Trim());
            kh.Ngayhethan = Convert.ToDateTime(dtpngayhethan.Text.Trim());
            kh.Ngaylap = Convert.ToDateTime(dtpngaylap.Text.Trim());
            bool kq = thetvbll.UpdateThe(kh);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để sửa!", "Thông báo!");

            }
            else
            {
                MessageBox.Show("Sửa thành công!", "Thông báo!");
                dgvthethanhvien.DataSource = thetvbll.GetAllTheThanhVien();
            }
            EnableButton(true);
            btnLuu.Enabled = true;
            DisableTextbox(true);
            btnsua.Text = "Sua";
        }

        private void dgvthethanhvien_SelectionChanged(object sender, EventArgs e)
        {
            dtpngayhethan.Text = dgvthethanhvien.CurrentRow.Cells[0].Value.ToString();
            dtpngaylap.Text = dgvthethanhvien.CurrentRow.Cells[1].Value.ToString();
            // txtghichu.Text = dgvthethanhvien.CurrentRow.Cells[2].Value.ToString();
            txtmathe.Text = dgvthethanhvien.CurrentRow.Cells[3].Value.ToString();
            txtmakh.Text = dgvthethanhvien.CurrentRow.Cells[4].Value.ToString();
            txtdiemtichluy.Text = dgvthethanhvien.CurrentRow.Cells[5].Value.ToString();
            txttongtien.Text = dgvthethanhvien.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnthemthe_Click_1(object sender, EventArgs e)
        {

        }
    }
}
