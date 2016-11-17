using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPHR_Solution.BaoCao
{
    public partial class MainBaoCao : Form
    {
        public MainBaoCao()
        {
            InitializeComponent();
        }
        public void loadcombobox()
        {
            comboBox1.Items.Add("báo cáo chi tiết sản phẩm");
            comboBox1.Items.Add("báo cáo về các đợt khuyến mãi");
            comboBox1.Items.Add("báo cáo nhân viên bị kỷ luật theo tháng");
            comboBox1.Items.Add("báo cáo về các sản phẩm bán lẻ theo tháng");
            comboBox1.Items.Add("báo cáo về các sản phẩm bán sỉ theo tháng");
           // comboBox1.Items.Add("báo cáo sản phẩm theo tháng");
            comboBox1.Items.Add("báo cáo về hóa đơn bán lẻ");
            comboBox1.Items.Add("báo cáo về hóa đơn bán sỉ");
            comboBox1.Items.Add("báo cáo doanh số bán lẻ");
            comboBox1.Items.Add("báo cáo doanh số bán sỉ");
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.SelectedItem.ToString();

            if (a == "báo cáo chi tiết sản phẩm")
            {
                this.Hide();
                baocaochitietsanpham frm = new baocaochitietsanpham();
                frm.ShowDialog();
                this.Show();
               
               
               
            }
            if (a == "báo cáo về các đợt khuyến mãi")
            {
                this.Hide();
                BCkhuyenmai frm = new BCkhuyenmai();
                frm.ShowDialog();
                this.Show();
            }
            if (a == "báo cáo nhân viên bị kỷ luật theo tháng")
            {
                this.Hide();
                BCNVkyluat frm = new BCNVkyluat();
                frm.ShowDialog();
                this.Show();
            }
            if (a == "báo cáo về các sản phẩm bán lẻ theo tháng")
            {
                this.Hide();
                BCSPbanle frm = new BCSPbanle();
                frm.ShowDialog();
                this.Show();
            }
            if (a == "báo cáo về các sản phẩm bán sỉ theo tháng")
            {
                this.Hide();
                BCSPbansi frm = new BCSPbansi();
                frm.ShowDialog();
                this.Show();
            }
            if (a == "báo cáo về hóa đơn bán lẻ")
            {
                this.Hide();
                BCHDbanle frm = new BCHDbanle();
                frm.ShowDialog();
                this.Show();
            }
            if (a == "báo cáo về hóa đơn bán sỉ")
            {
                this.Hide();
                BCHDbansi frm = new BCHDbansi();
                frm.ShowDialog();
                this.Show();
            }
            if (a == "báo cáo doanh số bán lẻ")
            {
                this.Hide();
                doanhsobanle frm = new doanhsobanle();
                frm.ShowDialog();
                this.Show();
            }
            if (a == "báo cáo doanh số bán sỉ")
            {
                this.Hide();
                doanhsobansi frm = new doanhsobansi();
                frm.ShowDialog();
                this.Show();
                
            }       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////comboBox1.Items.Clear();
            //if (comboBox1.SelectedItem == Convert.ToString("báo cáo doanh số bán sỉ"))
            //{
            //    doanhsobansi b = new doanhsobansi();
            //    b.ShowDialog(this);
            //}
        }

        private void MainBaoCao_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }
    }
}
