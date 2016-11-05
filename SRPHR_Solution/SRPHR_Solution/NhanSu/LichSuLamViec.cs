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
    public partial class LichSuLamViec : Form
    {
        List<LSLamViec> lstls = new List<LSLamViec>();
        LichSuLamViecBLL lvbll = new LichSuLamViecBLL();
        BindingSource bd = new BindingSource();
        public LichSuLamViec()
        {
            InitializeComponent();
            loadofdata();
        }
        private void loadofdata()
        {
            lstls = lvbll.getAllLS();
            bd.DataSource = lstls;
            dataGridView1.DataSource = bd;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var lv = lvbll.Search1NhanVienbyMaNV(txtTimKiem.Text);
            if (lv == null)
                MessageBox.Show("Không có mã nhân viên!", "Thông báo!");
            else
                dataGridView1.DataSource = lv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
