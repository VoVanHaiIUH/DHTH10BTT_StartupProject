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
    public partial class ThemPB : Form
    {
           List<PhongBan> lpb= new List<PhongBan>();
           PhongBanBLL pbbll = new PhongBanBLL();
           BindingSource bd = new BindingSource();

        public ThemPB()
        {
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            lpb = pbbll.GetAllPhongBan();
            bd.DataSource = lpb;
            dataPhongban.DataSource = bd;
        }

        private void ThemPB_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PhongBan pb = new PhongBan();
                pb.MaPB = txtMaPB.Text;
                pb.TenPB = txtTenPB.Text;
                pb.DiaDiem = txtDiaDiem.Text;
                pb.Sdt = txtSdt.Text;
                pbbll.Add(pb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            try
            {
                string mapb = txtMaPB.Text;
                pbbll.Delete(mapb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataPhongban_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataPhongban.SelectedRows.Count > 0 && dataPhongban.SelectedRows.Count <= dataPhongban.Rows.Count)
            {
                txtMaPB.Text = e.Row.Cells["MaPB"].Value.ToString();
                txtTenPB.Text = e.Row.Cells["TenPB"].Value.ToString();
                txtDiaDiem.Text = e.Row.Cells["DiaDiem"].Value.ToString();
                txtSdt.Text = e.Row.Cells["Sdt"].Value.ToString();
            }
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            try
            {
                PhongBan pb = new PhongBan();
                pb.MaPB = txtMaPB.Text;
                pb.TenPB = txtTenPB.Text;
                pb.DiaDiem = txtDiaDiem.Text;
                pb.Sdt = txtSdt.Text;
                pbbll.UpDate(pb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
