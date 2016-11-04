using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.NhanSu;
using Entities.NhanSu;

namespace SRPHR_Solution.NhanSu
{
    public partial class ThemPB : Form
    {
           List<PhongBan> lpb= new List<PhongBan>();
           PhongBanBLL pbbll = new PhongBanBLL();
           BindingSource bd = new BindingSource();

        public ThemPB()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            
        }



        private void ThemPB_Load(object sender, EventArgs e)
        {

        }
    }
}
