using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.CongNoPKH;
using BusinessLogic.CongNoPKH;

namespace SRPHR_Solution.CongNoPKH
{
    public partial class frmnhacungcap : Form
    {
        public frmnhacungcap()
        {
            InitializeComponent();
        }
        NhaCungCap_BLL nccbll = new NhaCungCap_BLL();
        private void btnluuncc_Click(object sender, EventArgs e)
        {
            eNhaCungCap a = new eNhaCungCap();

            a.maNCC = txtMaNCC.Text;
            a.tenNCC = txtTenNCC.Text;
            a.diaChi = txtAddress.Text;
            a.sDT = txtphone.Text;
            a.email = txtMail.Text;
            int m = nccbll.themNCC(a);
            if (m == 0) MessageBox.Show("Trùng mã !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else if (m == 1) MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnthoatncc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
