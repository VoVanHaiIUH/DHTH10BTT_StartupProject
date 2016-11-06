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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BaoCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            Visible = false;

            FormMainBaoCao frmnew = new FormMainBaoCao();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }
    }
}
