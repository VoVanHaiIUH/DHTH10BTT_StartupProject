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
            // thoát form đăng nhập 
            Visible = false;
            ShowInTaskbar = false;

            // show form đăng kí
            FormDangKi frmdangki = new FormDangKi();
            frmdangki.Activate();
            frmdangki.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // thoát form đăng nhập 
            Visible = false;
            ShowInTaskbar = false;

            // show form Main
            FormMain frmnew = new FormMain();
            frmnew.Activate();
            frmnew.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
