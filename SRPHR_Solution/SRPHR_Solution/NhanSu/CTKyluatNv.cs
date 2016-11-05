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

namespace SRPHR_Solution.NhanSu
{
    public partial class CTKyluatNv : Form
    {
        List<CTKyLuatNV> lstctkl = new List<CTKyLuatNV>();
        CTKyLuatNVBLL ctklbll = new CTKyLuatNVBLL();
        BindingSource bd = new BindingSource();
        public CTKyluatNv()
        {
            InitializeComponent();
            loadofdata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            CTKyLuatNV ctkl = new CTKyLuatNV();
            ctkl.MaNV = txtMaNV.Text;
            ctkl.MaKyLuat = txtMaKL.Text;
            ctkl.HinhThucKL = txtHTKL.Text;
            ctkl.LyDo = txtLyDo.Text;
            ctkl.GhiChu = txtGhiChu.Text;
            ctkl.MucDoKL = txtMucDo.Text;
            ctkl.NgayLap = Convert.ToDateTime(txtNgayLap.Text);
            ctkl.NgayKetThuc = Convert.ToDateTime(txtNgayKetThuc.Text);
            ctkl.NgayThiHanh = Convert.ToDateTime(txtNgayThiHanh.Text);
            bool kq = ctklbll.Add(ctkl);
            if (kq == false)
            {
                MessageBox.Show("Trùng mã !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Thêm Thành Công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dataGridView1.DataSource = ctklbll.GetAllCTKL();
            }
        }
        private void loadofdata()
        {
            lstctkl = ctklbll.GetAllCTKL();
            bd.DataSource = lstctkl;
            dataGridView1.DataSource = bd;


        }
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                CTKyLuatNV ctkl = (CTKyLuatNV)bd.Current;
                ctkl.MaNV = txtMaNV.Text;
                ctkl.MaKyLuat = txtMaKL.Text;
                ctkl.HinhThucKL = txtHTKL.Text;
                ctkl.LyDo = txtLyDo.Text;
                ctkl.GhiChu = txtGhiChu.Text;
                ctkl.MucDoKL = txtMucDo.Text;
                ctkl.NgayLap = Convert.ToDateTime(txtNgayLap.Text);
                ctkl.NgayKetThuc = Convert.ToDateTime(txtNgayKetThuc.Text);
                ctkl.NgayThiHanh = Convert.ToDateTime(txtNgayThiHanh.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            CTKyLuatNV ctkl = new CTKyLuatNV();
            ctkl.MaNV = txtMaNV.Text;
            ctkl.MaKyLuat = txtMaKL.Text;
            ctkl.HinhThucKL = txtHTKL.Text;
            ctkl.LyDo = txtLyDo.Text;
            ctkl.GhiChu = txtGhiChu.Text;
            ctkl.MucDoKL = txtMucDo.Text;
            ctkl.NgayLap = Convert.ToDateTime(txtNgayLap.Text);
            ctkl.NgayKetThuc = Convert.ToDateTime(txtNgayKetThuc.Text);
            ctkl.NgayThiHanh = Convert.ToDateTime(txtNgayThiHanh.Text);
            bool kq = ctklbll.Delete(ctkl);
            if (kq == false)
            {
                MessageBox.Show("Không thể xóa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Xóa Thành Công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dataGridView1.DataSource = ctklbll.GetAllCTKL();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            CTKyLuatNV ctkl = new CTKyLuatNV();
            ctkl.MaNV = txtMaNV.Text;
            ctkl.MaKyLuat = txtMaKL.Text;
            ctkl.HinhThucKL = txtHTKL.Text;
            ctkl.LyDo = txtLyDo.Text;
            ctkl.GhiChu = txtGhiChu.Text;
            ctkl.MucDoKL = txtMucDo.Text;
            ctkl.NgayLap = Convert.ToDateTime(txtNgayLap.Text);
            ctkl.NgayKetThuc = Convert.ToDateTime(txtNgayKetThuc.Text);
            ctkl.NgayThiHanh = Convert.ToDateTime(txtNgayThiHanh.Text);
            bool kq = ctklbll.UpDate(ctkl);
            if (kq == false)
            {
                MessageBox.Show("Không tìm thấy mã ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Sữa thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dataGridView1.DataSource = ctklbll.GetAllCTKL();
            }
        }

        
    }
}
