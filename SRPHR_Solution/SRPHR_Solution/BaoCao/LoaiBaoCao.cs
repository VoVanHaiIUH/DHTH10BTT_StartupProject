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
    public partial class LoaiBaoCao : Form
    {
        public LoaiBaoCao()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoaiBaoCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult n = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (n == DialogResult.No)
                e.Cancel = true;
        }
    }
}
