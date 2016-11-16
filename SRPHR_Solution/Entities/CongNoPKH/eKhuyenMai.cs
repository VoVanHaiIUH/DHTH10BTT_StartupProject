using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eKhuyenMai
    {
        public string msDotKM { get; set; }
        public string tenDotKM { get; set; }
        public DateTime ngayBD { get; set; }
        public DateTime ngayKT { get; set; }
        public string ghiChu { get; set; }

        public eKhuyenMai(string msDotKM, string tenDotKM, DateTime ngayBD,DateTime ngayKT, string ghiChu)
        {
            this.msDotKM = msDotKM;
            this.tenDotKM = tenDotKM;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.ghiChu = ghiChu;
        }
        public override int GetHashCode()
        {
            return msDotKM.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            eKhuyenMai km = (eKhuyenMai)obj;
            return km.Equals(km.msDotKM);
        }
        public eKhuyenMai()
        {

        }
    }
}
