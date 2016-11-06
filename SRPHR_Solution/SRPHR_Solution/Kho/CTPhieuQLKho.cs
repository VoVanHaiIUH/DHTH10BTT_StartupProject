using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Kho;
using BusinessLogic.Kho;

namespace SRPHR_Solution.Kho
{
    public partial class CTPhieuQLKho : Form
    {
        List<eCTQLKho> lst = new List<eCTQLKho>();
        CTPQLKho_BLL ctqlkBLL = new CTPQLKho_BLL();
        BindingSource bds = new BindingSource();

        public CTPhieuQLKho()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            lst = ctqlkBLL.getAllCTPhieuQLKho();
            bds.DataSource = lst;
            dataCTPQLK.DataSource = bds;
        }

        private void CTPhieuQLKho_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            eCTQLKho ect = new eCTQLKho();
            ect._maPhieuQL = txtmaphieu.Text;
            ect._sott = txtstt.Text;
            ect._masp = txtmasp.Text;
            ect._tensp = txttensp.Text;
            ect._soluongql = txtsoluong.Text;
            ect._donvi = txtdonvi.Text;
            bool kq = ctqlkBLL.AddAllCTPQLKho(ect);
            if (kq == false)
            {
                MessageBox.Show("Không có mã phiếu để thêm!", "Thông báo!");

            }
            else
            {
                MessageBox.Show("Thêm thành công!", "Thông báo!");
                dataCTPQLK.DataSource = ctqlkBLL.getAllCTPhieuQLKho();
            }



        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            eCTQLKho ect = new eCTQLKho();
            ect._maPhieuQL = txtmaphieu.Text;
            ect._sott = txtstt.Text;
            ect._masp = txtmasp.Text;
            ect._tensp = txttensp.Text;
            ect._soluongql = txtsoluong.Text;
            ect._donvi = txtdonvi.Text;
            bool kq = ctqlkBLL.UpdateCTPQLKho(ect);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để sửa", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Sửa thành công!", "Thông báo!");
                dataCTPQLK.DataSource = ctqlkBLL.getAllCTPhieuQLKho();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            eCTQLKho ect = new eCTQLKho();
            ect._maPhieuQL = txtmaphieu.Text;
            ect._sott = txtstt.Text;
            ect._masp = txtmasp.Text;
            ect._tensp = txttensp.Text;
            ect._soluongql = txtsoluong.Text;
            ect._donvi = txtdonvi.Text;
            bool kq = ctqlkBLL.DeleteCTPhieuQLK(ect);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để Xóa", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Thông báo!");
                dataCTPQLK.DataSource = ctqlkBLL.getAllCTPhieuQLKho();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
