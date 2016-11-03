using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCTCongNoNCC
    {
         public string soPhieu { get; set; }
       public string soTien { get; set; }
       public string maHD { get; set; }
        public string ghiChu { get; set; }
        public eCTCongNoNCC(string sophieu, string mahd, string sotien, string ghichu)
       {
           this.soPhieu= soPhieu;
        
           this.soTien = sotien;
           this.maHD = maHD;
            this.ghiChu = ghichu;

        }
         public override bool Equals(object obj)
        {
           eCTCongNoNCC encc = (eCTCongNoNCC)obj;
            return encc.Equals(encc.soPhieu);
       }
        public override int GetHashCode()
       {
             return soPhieu.GetHashCode();
        }
    }
}
