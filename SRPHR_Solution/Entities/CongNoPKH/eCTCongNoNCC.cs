using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCTCongNoNCC
    {
         public string maNCC { get; set; }
        public string soTien { get; set; }
        public string maHD { get; set; }
        public string ghiChu { get; set; }
        public eCTCongNoNCC(string mancc, string sotien, string mahd, string ghichu)
        {
            this.maNCC = mancc;
            this.maHD = mahd;
            this.soTien = sotien;
            this.ghiChu = ghichu;

        }
        public override bool Equals(object obj)
        {
            eCTCongNoNCC encc = (eCTCongNoNCC)obj;
            return encc.Equals(encc.maNCC);
        }
        public override int GetHashCode()
        {
            return maNCC.GetHashCode();
        }
    }
}
