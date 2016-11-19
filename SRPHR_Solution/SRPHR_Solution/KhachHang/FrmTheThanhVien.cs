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
        TheThanhVienBLL ttvBLL = new TheThanhVienBLL();
        //
        List<eThethanhvien> listthetv;
        TheThanhVienBLL thetvbll;
        public FrmTheThanhVien()
        {
            InitializeComponent();
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


            // txtdiemtichluy.Text = diemTL.ToString();

            eThethanhvien k = new eThethanhvien();
            k.Mathe = txtmathe.Text;
            k.Makh = txtmakh.Text;
            k.Diemtichluy += Convert.ToInt32(txttongtien.Text) / 10000; ///đổi điểm
            k.Tongtien = Convert.ToInt32(txttongtien.Text);
            //k.Ngaylap = Convert.ToDateTime(dtpngaylap.Text);
            k.Ngayhethan = Convert.ToDateTime(dtpngaylap.Text);
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
                dtpngaylap.Enabled = false;
                txtmathe.ReadOnly = true;
                txtmakh.ReadOnly = true;
              
                txtdiemtichluy.ReadOnly = true;
                txttongtien.Focus();
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
            int dtl = Convert.ToInt32(dgvthethanhvien.CurrentRow.Cells["Tongtien"].Value.ToString());
            eThethanhvien kh = new eThethanhvien();
            txtmathe.Text = dgvthethanhvien.CurrentRow.Cells[3].Value.ToString();
            txtmakh.Text = dgvthethanhvien.CurrentRow.Cells[4].Value.ToString();
            kh.Tongtien = dtl + Convert.ToInt32(txttongtien.Text.Trim());
            kh.Diemtichluy = (dtl + Convert.ToInt32(txttongtien.Text)) / 10000; ///đổi điểm
            txtdiemtichluy.Text = ((Convert.ToInt32(txttongtien.Text) / 10000) + Convert.ToInt32(dgvthethanhvien.CurrentRow.Cells["Diemtichluy"].Value.ToString())).ToString();


            kh.Makh = txtmakh.Text.Trim();
            kh.Mathe = txtmathe.Text.Trim();
            kh.Ghichu = txtghichu.Text.Trim();
            // kh.Diemtichluy = Convert.ToInt32(txtdiemtichluy.Text.Trim());

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
                kh.Diemtichluy += Convert.ToInt32(txttongtien.Text) / 10000;
                dgvthethanhvien.DataSource = thetvbll.GetAllTheThanhVien();

            }
            EnableButton(true);
            btnLuu.Enabled = true;
            DisableTextbox(true);
            btnsua.Text = "Sua";
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvthethanhvien_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvthethanhvien.SelectedRows.Count > 0)
            {
                dtpngayhethan.Text = e.Row.Cells["ngayhethan"].Value.ToString();
                dtpngaylap.Text = e.Row.Cells["ngaylap"].Value.ToString();
                // txtghichu.Text = e.CurrentRow.Cells[2].Value.ToString();
                txtmathe.Text = e.Row.Cells["mathe"].Value.ToString();
                txtmakh.Text = e.Row.Cells["makh"].Value.ToString();
                txtdiemtichluy.Text = e.Row.Cells["diemtichluy"].Value.ToString();
                txttongtien.Text = e.Row.Cells["tongtien"].Value.ToString();
            }
        }

        private void btnDoiThuong_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt16(txtdiemtichluy.Text) >= 200)
            {
                DialogResult r = MessageBox.Show("ban co muon doi diem ko?", "Congratulation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    //eThethanhvien kh = new eThethanhvien();
                    //int d = ttvBLL.setDiemTL1(txtmathe.Text, Convert.ToInt16(txtdiemtichluy.Text) - 200);
                    int d = thetvbll.setDiemTL1(txtmathe.Text, Convert.ToInt16(txtdiemtichluy.Text) - 200);

                    txtdiemtichluy.Text = d.ToString();

                    if (d == -1)
                    {
                        MessageBox.Show("Loi");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật lại điểm tích luỹ.Phần quà của bạn đã được chuyển đi.");



                    }

                    listthetv = thetvbll.GetAllTheThanhVien();
                    LoadDataGridView(dgvthethanhvien, listthetv);
                    dgvthethanhvien.DataSource = thetvbll.GetAllTheThanhVien();
                }


                else
                {
                    MessageBox.Show("diem tich luy nho hon 200");
                }

            }
        }
    }
}
