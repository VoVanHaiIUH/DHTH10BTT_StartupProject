using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPHR_Solution.PhanQuyen
{
    public partial class FormMain : Form
    {
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
            Visible = false;
            ShowInTaskbar = false;

            // show form đăng nhập
            FormDangnhap frmnew = new FormDangnhap();
            frmnew.Activate();
            frmnew.Show();
        }

        private void btnformPhanquyen_Click(object sender, EventArgs e)
        {
            // thoát form main 
            Visible = false;
            ShowInTaskbar = false;

            // show form PQ
            FormPhanQuyen frmnew = new FormPhanQuyen();
            frmnew.Activate();
            frmnew.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;

        }
    }
}
