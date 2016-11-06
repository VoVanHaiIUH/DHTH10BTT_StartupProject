using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.PhanQuyen;
using BusinessLogic.PhanQuyen;

namespace SRPHR_Solution.PhanQuyen
{
    public partial class FormMain : Form
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        TaiKhoanBLL taikhoanbll = new TaiKhoanBLL();
        public FormMain()
        {
            InitializeComponent();
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
          
                this.Close();
                Application.Exit();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            // thoát form main 
            //Visible = false;
            //ShowInTaskbar = false;

            // show form đăng nhập
            FormDangnhap frmnew = new FormDangnhap();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void btnformPhanquyen_Click(object sender, EventArgs e)
        {


            // show form PQ
            FormPhanQuyen frmnew = new FormPhanQuyen();
            frmnew.Activate();
            frmnew.ShowDialog();
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
          

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txttaikhoan.Text = _message;
            if (txttaikhoan.Text != "admin")
            {
                btnformPhanquyen.Visible = false;
                string pq = "";
                pq = taikhoanbll.GetPQbyID(txttaikhoan.Text);
                EnableChucNang(pq);
                eThongTinTaiKhoan info= taikhoanbll.laythongtin1taikhoan(txttaikhoan.Text);
                txtmanv.Text = info.Manv1;
                txtnhomtk.Text = info.Nhom1;

            }
        }
        private void EnableChucNang(string pq)
        {
            string[] s = new string[6];
            s = taikhoanbll.ChuyenChuoithanhmang(pq);
            if (s[0] == "1")
                btnFormBanHang.Enabled = true;
            else
                btnFormBanHang.Enabled = false;
            if (s[1] == "1")
                btnformbaocao.Enabled = true;
            else
                btnformbaocao.Enabled = false;
            if (s[2] == "1")
                btnfromcongno.Enabled = true;
            else
                btnfromcongno.Enabled = false;
            if (s[3] == "1")
                btnformkhachhang.Enabled = true;
            else
                btnformkhachhang.Enabled = false;
            if (s[4] == "1")
                btnfromkho.Enabled = true;
            else
                btnfromkho.Enabled = false;
            if (s[5] == "1")
                btnformNhansu.Enabled = true;
            else
                btnformNhansu.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            showchinhsua();
        }
        private void showchinhsua()
        {
            lbmk.Visible = true;
            txtnhomtk.Visible = false;
            lbnhomtk.Visible = false;
            lbnhaplaimk.Visible = true;
            txtnhaplaimk.Visible = true;
            txtmk.Visible = true;
            btndangxuat.Visible = false;
            btnsua.Visible = false;
            btnthoat.Visible = false;
            btnluu.Visible = true;
            btnhuy.Visible = true;
            txtmanv.ReadOnly = false;
        }
        private void thoatshow()
        {
            lbmk.Visible = false;
            txtnhomtk.Visible = true;
            lbnhomtk.Visible = true;
            lbnhaplaimk.Visible = false;
            txtnhaplaimk.Visible = false;
            txtmk.Visible = false;
            btndangxuat.Visible = true;
            btnsua.Visible = true;
            btnthoat.Visible = true;
            btnluu.Visible = false;
            btnhuy.Visible = false;
            txtmanv.ReadOnly = true;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            thoatshow();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int kq = taikhoanbll.chinhsuathongtintk(txtmk.Text, txtmanv.Text, txttaikhoan.Text);
            if(kq==1)
            {
                MessageBox.Show("Sửa thành công!");
                thoatshow();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }
    }
}
