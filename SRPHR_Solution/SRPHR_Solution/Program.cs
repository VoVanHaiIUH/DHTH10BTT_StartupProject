using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRPHR_Solution.PhanQuyen;
using SRPHR_Solution.BanHang;
using SRPHR_Solution.NhanSu;
namespace SRPHR_Solution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormDangnhap());
            //Application.Run(new FormHDGTGT());
            Application.Run(new frmMenu());
        }
    }
}
