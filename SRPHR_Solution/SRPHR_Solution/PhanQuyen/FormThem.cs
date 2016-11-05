using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPHR_Solution.PhanQuyen
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            // thoát form QLPQ
            Visible = false;
            ShowInTaskbar = false;

            // show form PQ
            FormPhanQuyen frmnew = new FormPhanQuyen();
            frmnew.Activate();
            frmnew.Show();
        }
    }
}
