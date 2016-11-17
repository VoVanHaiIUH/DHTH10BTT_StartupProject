using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.KhachHang;
namespace SRPHR_Solution.KhachHang
{
    public partial class FrmDoiDiem : Form
    {
        TheThanhVienBLL ttvBLL = new TheThanhVienBLL();
        public FrmDoiDiem()
        {
            InitializeComponent();
        }

        private void FrmDoiDiem_Load(object sender, EventArgs e)
        {
        }
        private void btndoidiem_Click(object sender, EventArgs e)
        {
            txtDiemTichLuy.Text = ttvBLL.setDiemTL(txtMaThe.Text, Convert.ToDecimal(txtTongTien.Text)).ToString();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiThuong_Click(object sender, EventArgs e)
        {
            
            if(Convert.ToInt16(txtDiemTichLuy.Text)>=200)
            {
                DialogResult r=MessageBox.Show("ban co muon doi diem ko?","Congratulation!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    int d = ttvBLL.setDiemTL1(txtMaThe.Text, Convert.ToInt16(txtDiemTichLuy.Text) - 200);
                    if (d == -1)
                    {
                        MessageBox.Show("Loi");
                    }
                }
                else
                    MessageBox.Show("Đã cập nhật lại điểm tích luỹ.Phần quà của bạn đã được chuyển đi.");
            }
        }
    }
}
