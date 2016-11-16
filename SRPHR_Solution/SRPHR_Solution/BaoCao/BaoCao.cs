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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string PQBC;
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            trangthaiPQ(PQBC);
        }
        private void trangthaiPQ(string pq)
        {
            if (pq.Substring(0, 1) == "1")
                btnthem.Enabled = true;
            else
                btnthem.Enabled = false;

            if (pq.Substring(1, 1) == "1")
                btnxoa.Enabled = true;
            else
                btnxoa.Enabled = false;

            if (pq.Substring(2, 1) == "1")
                btnsua.Enabled = true;
            else
                btnsua.Enabled = false;


        }
    }
}
