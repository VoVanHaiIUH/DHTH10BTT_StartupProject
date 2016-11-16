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
using SRPHR_Solution.PhanQuyen;

namespace SRPHR_Solution
{
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        private void btntrolai_Click(object sender, EventArgs e)
        {
            // thoát form đăng kí
            Visible = false;
            ShowInTaskbar = false;

            // show form đăng nhập
            FormDangnhap frmdangnhap = new FormDangnhap();
            frmdangnhap.Activate();
            frmdangnhap.Show();
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            if(txtmatkhau.Text!=txtxacnhanmk.Text)
            {
                MessageBox.Show("Lỗi nhập lại mật khẩu không chính xác!");
            }
            else
            {
                eTaiKhoan tk = new eTaiKhoan();
                tk.ID1 = txttentaikhoan.Text;
                tk.Manv1 = txtmanv.Text;
                tk.Nhom1 = "";
                tk.Password1 = txtmatkhau.Text;
                int kq = tkbll.them1taikhoan(tk);
                if (kq == 0)
                    MessageBox.Show("Tên tài khoản đã có người sử dụng!");
                else
                {
                    
                    MessageBox.Show("Đăng kí thành công!");
                    this.Close();
                    
                    FormMain frmnew = new FormMain();
                    frmnew._message= txttentaikhoan.Text;
                    frmnew.ShowDialog(); 

                }
            }
        }
    }
}
