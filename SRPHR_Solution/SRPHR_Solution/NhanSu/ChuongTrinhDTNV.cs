using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.NhanSu;
using BusinessLogic.NhanSu;

namespace SRPHR_Solution.NhanSu
{
    public partial class ChuongTrinhDTNV : Form
    {
         List<CTThamGiaDTNV> lst = new List<CTThamGiaDTNV>();
        CTThamGiaDTNVBLL ctdaotaonv = new CTThamGiaDTNVBLL();
        BindingSource bd = new BindingSource();
    
        public ChuongTrinhDTNV()
        {
            InitializeComponent();
        }
        private void loadofdata()
        {
            lst = ctdaotaonv.GetAllDaoTao();
            bd.DataSource = lst;
            dataCTDT.DataSource = bd;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            CTThamGiaDTNV ct = new CTThamGiaDTNV();
            ct.MaNV = txtMaNV.Text;
            ct.MaKhoaDT = txtMaKhoaDT.Text;
            ct.KetQua = txtKQ.Text;
            ct.NhanXet = txtNX.Text;
            bool kq = ctdaotaonv.Add(ct);
            if (kq == false)
            {
                MessageBox.Show("Không có mã nhân viên để thêm!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Thêm thành công!", "Thông báo!");
                dataCTDT.DataSource = ctdaotaonv.GetAllDaoTao();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            CTThamGiaDTNV ct = new CTThamGiaDTNV();
            ct.MaNV = txtMaNV.Text;
            ct.MaKhoaDT = txtMaKhoaDT.Text;
            ct.KetQua = txtKQ.Text;
            ct.NhanXet = txtNX.Text;
            bool kq = ctdaotaonv.UpDate(ct);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để sửa!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Sửa thành công!", "Thông báo!");
                dataCTDT.DataSource = ctdaotaonv.GetAllDaoTao();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            CTThamGiaDTNV ct = new CTThamGiaDTNV();
            ct.MaNV = txtMaNV.Text;
            ct.MaKhoaDT = txtMaKhoaDT.Text;
            ct.KetQua = txtKQ.Text;
            ct.NhanXet = txtNX.Text;
            bool kq = ctdaotaonv.Delete(ct);
            if (kq == false)
            {
                MessageBox.Show("Không có mã để xóa!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Thông báo!");
                dataCTDT.DataSource = ctdaotaonv.GetAllDaoTao();
            }
        }
    }
}
