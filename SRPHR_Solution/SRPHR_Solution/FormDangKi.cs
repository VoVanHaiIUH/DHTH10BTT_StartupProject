using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPHR_Solution
{
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }

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

        }
    }
}
