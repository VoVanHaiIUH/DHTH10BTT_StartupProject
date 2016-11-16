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
using SRPHR_Solution.CongNoPKH;
using SRPHR_Solution.BanHang;
using SRPHR_Solution.BaoCao;
using SRPHR_Solution.NhanSu;

namespace SRPHR_Solution.PhanQuyen
{
    public partial class FormMain : Form
    {
        public string _message;
        
        //public string Message
        //{
        //    get { return _message; }
        //    set { _message = value; }
        //}

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
                unenablechucnang();
                pq = taikhoanbll.GetPQbyID(txttaikhoan.Text);
                EnableChucNang(pq);
                eThongTinTaiKhoan info = taikhoanbll.laythongtin1taikhoan(txttaikhoan.Text);
                txtmanv.Text = info.Manv1;
                txtnhomtk.Text = info.Nhom1;


            }
           
                
                
        }
        private void EnableChucNang(string pq)
        {
            string[] s = new string[6];
            s = taikhoanbll.ChuyenChuoithanhmang(pq);

            if (s[6] == "1" || s[7] == "1" || s[8] == "1" || s[9] == "1" || s[0] == "1")
                btnFormBanHang.Enabled = true;
            
            if (s[10] == "1" || s[11] == "1" || s[12] == "1" || s[13] == "1" || s[1] == "1")
                btnFormBanHang.Enabled = true;

            if (s[14] == "1" || s[15] == "1" || s[16] == "1" || s[17] == "1" || s[2] == "1")
                btnFormBanHang.Enabled = true;

            if (s[18] == "1" || s[19] == "1" || s[20] == "1" || s[21] == "1" || s[3] == "1")
                btnFormBanHang.Enabled = true;

            if (s[22] == "1" || s[23] == "1" || s[24] == "1" || s[25] == "1" || s[4] == "1")
                btnFormBanHang.Enabled = true;

            if (s[26] == "1" || s[27] == "1" || s[28] == "1" || s[29] == "1" || s[5] == "1")
                btnFormBanHang.Enabled = true;
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

        private void btnfromcongno_Click(object sender, EventArgs e)
        {
            QuanLyPhongKeHoach frmnew = new QuanLyPhongKeHoach();
            frmnew.ShowDialog();
        }

        private void btnFormBanHang_Click(object sender, EventArgs e)
        {
            string s=taikhoanbll.GetPQbyID(_message).Substring(6,4);
            FormMainBH frmnew = new FormMainBH();
            frmnew.PQMainBH = s;
            frmnew.ShowDialog();
           

        }

    
        private void btnformbaocao_Click(object sender, EventArgs e)
        {
            FormMainBaoCao frmnew = new FormMainBaoCao();
            frmnew.ShowDialog();
        }

        private void btnformNhansu_Click(object sender, EventArgs e)
        {
            frmMenu frmMENU = new frmMenu();
            frmMENU.ShowDialog();
        }
        private void unenablechucnang()
        {
            btnFormBanHang.Enabled = false;
            btnformbaocao.Enabled = false;
            btnformkhachhang.Enabled = false;
            btnformcongno.Enabled = false;
            btnformNhansu.Enabled = false;
            btnformkho.Enabled = false;
        }
    }
}
