using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCongNoKH
    {
       public string soPhieu { get; set; }
       public string maKH { get; set; }
       public string ngayLap { get; set; }
        public string maNV { get; set; }
         public eCongNoKH(string sophieu, string makh, string ngaylap, string manv)
         {
            this.soPhieu=sophieu;
             this.maKH=makh;
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
