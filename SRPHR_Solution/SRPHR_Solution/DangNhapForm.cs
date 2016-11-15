using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRPHR_Solution.PhanQuyen;
using BusinessLogic.PhanQuyen;

namespace SRPHR_Solution
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }
  
        private void btndangki_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            // show form đăng kí
            FormDangKi frmdangki = new FormDangKi();
            frmdangki.ShowDialog(); 
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            
            TaiKhoanBLL taikhoanbll= new TaiKhoanBLL();
            int kq = taikhoanbll.KiemTraDangNhap(txtid.Text, txtpass.Text);
            if (kq == 0)
                MessageBox.Show("Sai ID hoặc Password !", "Thông báo");
            else 
            {

                Visible = false;
                ShowInTaskbar = false;
                // show form Main
                FormMain frmnew = new FormMain();
                frmnew.Message = txtid.Text;
                frmnew.ShowDialog();

            }

           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void FormDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                TaiKhoanBLL taikhoanbll = new TaiKhoanBLL();
                int kq = taikhoanbll.KiemTraDangNhap(txtid.Text, txtpass.Text);
                if (kq == 0)
                    MessageBox.Show("Sai ID hoặc Password !", "Thông báo");
                else
                {

                    Visible = false;
                    ShowInTaskbar = false;
                    // show form Main
                    FormMain frmnew = new FormMain();
                    frmnew.Message = txtid.Text;
                    frmnew.ShowDialog();

                }
            }
        }
    }
}
