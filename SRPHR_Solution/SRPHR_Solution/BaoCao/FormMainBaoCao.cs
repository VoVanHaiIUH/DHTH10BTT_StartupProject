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
    public partial class FormMainBaoCao : Form
    {
        public FormMainBaoCao()
        {
            InitializeComponent();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            //thoát form main
            Visible = false;
            ShowInTaskbar = false;
            
            //show form báo cáo
            FormBaoCao frmnew = new FormBaoCao();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void btnloaibaocao_Click(object sender, EventArgs e)
        {
            //thoát form main
            Visible = false;
            ShowInTaskbar = false;

            //show form báo cáo
             FormLoaiBaoCao frmnew = new FormLoaiBaoCao();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void FormMainBaoCao_Load(object sender, EventArgs e)
        { 

        }
    }
}
