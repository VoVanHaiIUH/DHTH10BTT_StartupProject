using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPHR_Solution.BanHang
{
    public partial class FormMainBH : Form
    {
        public FormMainBH()
        {
            InitializeComponent();
        }

        private void FormMainBH_Load(object sender, EventArgs e)
        { 

        }

        private void btnhdgtgt_Click(object sender, EventArgs e)
        {
            //thoát form main
            Visible = false;
            ShowInTaskbar = false;

            //show form báo cáo
            FormHDBanGTGT frmnew = new FormHDBanGTGT();
            frmnew.Activate();
            frmnew.ShowDialog();
        }

        private void btnhdbanle_Click(object sender, EventArgs e)
        {
            //thoát form main
            Visible = false;
            ShowInTaskbar = false;

            //show form báo cáo
            FormHDBanle frmnew = new FormHDBanle();
            frmnew.Activate();
            frmnew.ShowDialog();
        }
    }
}
