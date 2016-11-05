using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SRPHR_Solution.BanHang
{
    public partial class HDBanGTGT : Form
    {
        public HDBanGTGT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            ChitietHDGTGT frmctgtgt = new ChitietHDGTGT();
            frmctgtgt.Activate();
            frmctgtgt.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HDBanGTGT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void HDBanGTGT_Load(object sender, EventArgs e)
        {

        }
    }
}
