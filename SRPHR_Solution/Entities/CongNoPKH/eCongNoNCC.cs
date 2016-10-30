using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCongNoNCC
    {
        public string soPhieu { get; set; }
       public string maNCC { get; set; }
     public string ngayLap { get; set; }
       public string maNV { get; set; }
       public eCongNoNCC(string sophieu, string mancc, string ngaylap, string manv)
        {
           this.soPhieu=sophieu;
           this.maNCC=mancc;
             this.ngayLap=ngaylap;
            this.maNV=manv;
        }
        public override bool Equals(object obj)
       {
           eCongNoNCC encc = (eCongNoNCC)obj;
           return encc.Equals(encc.soPhieu);
        }
        public override int GetHashCode()
        {
           return soPhieu.GetHashCode();
       }
    }
}
