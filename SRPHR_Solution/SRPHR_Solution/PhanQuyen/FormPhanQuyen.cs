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
using Entities.PhanQuyen;
using BusinessLogic.PhanQuyen;

namespace SRPHR_Solution.PhanQuyen
{
    public partial class FormPhanQuyen : Form
    {
        public FormPhanQuyen()
        {
            InitializeComponent();
        }
        TaiKhoanBLL taikhoanbll = new TaiKhoanBLL();

        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            // thoát form PQ
            //Visible = false;
            //ShowInTaskbar = false;

            // show form QLPQ
            FormQL frmnew = new FormQL();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            // thoát form QLPQ
           Visible = false;
            //ShowInTaskbar = false;

            // show form PQ
            FormMain frmnew = new FormMain();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void FormPhanQuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (r == DialogResult.No)
            //    e.Cancel = true;
            Application.Exit();
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taikhoanbll.laythongtintatcataikhoan();
        }
    }
}
