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
    public partial class KyLuatForm : Form
    {
        List<KyLuat> lkl = new List<KyLuat>();
        KyLuatBLL klbll = new KyLuatBLL();
        BindingSource bd = new BindingSource();
        public KyLuatForm()
        {
            InitializeComponent();
            loadGrid();
        }
        private void loadGrid()
        {
            lkl = klbll.GetAllNhanVien();
            bd.DataSource = lkl;
            dataKyLuat.DataSource = bd;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KyLuat kl = new KyLuat();
                kl.MaKL = txtMaKL.Text;
                kl.HinhThucKL = txtHTKL.Text;
                kl.GhiChu = txtGhiChu.Text;
                klbll.Add(kl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string makl = txtMaKL.Text;
                klbll.Delete(makl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KyLuat kl = new KyLuat();
                kl.MaKL = txtMaKL.Text;
                kl.HinhThucKL = txtHTKL.Text;
                kl.GhiChu = txtGhiChu.Text;
                klbll.UpDate(kl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataKyLuat_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataKyLuat.SelectedRows.Count > 0 && dataKyLuat.SelectedRows.Count <= dataKyLuat.Rows.Count)
            {
                txtMaKL.Text = e.Row.Cells["MaKL"].Value.ToString();
                txtHTKL.Text = e.Row.Cells["HinhThucKL"].Value.ToString();
                txtGhiChu.Text = e.Row.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}
