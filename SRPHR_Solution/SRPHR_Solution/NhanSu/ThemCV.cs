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
    public partial class ThemCV : Form
    {
        List<ChucVu> lcv = new List<ChucVu>();
        ChucVuBLL cvbll = new ChucVuBLL();
        BindingSource bd = new BindingSource();

        public ThemCV()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            lcv = cvbll.GetAllChucVu();
            bd.DataSource = lcv;
            dataChucVu.DataSource = bd;
        }



        private void ThemCV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            loadGrid();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();

            cv.MaCV = txtMaCV.Text;
            cv.TenCV = txtTenCV.Text;
            cv.HeSo = Convert.ToDecimal(txtHeso.Text);
            cv.GhiChu = txtNote.Text;
            bool b = cvbll.Add(cv);
        }




        private void ThemCV_Load(object sender, EventArgs e)
        {

        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();

            cv.MaCV = txtMaCV.Text;
            cv.TenCV = txtTenCV.Text;
            cv.HeSo = Convert.ToDecimal(txtHeso.Text);
            cv.GhiChu = txtNote.Text;
            //bool b = cvbll.Delete(cv);
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();

            cv.MaCV = txtMaCV.Text;
            cv.TenCV = txtTenCV.Text;
            cv.HeSo = Convert.ToDecimal(txtHeso.Text);
            cv.GhiChu = txtNote.Text;
            bool b = cvbll.UpDate(cv);
        }

        
    }
}
