using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eHDBanSi
    {
        public string maHD { get; set; }
        public string ngayLap { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public string ghiChu { get; set; }
        public eHDBanSi(string maHD, string ngaylap, string maKH, string maNV, string ghichu)
        {
            this.maHD = maHD;
            this.ngayLap = ngaylap;
            this.maKH = maKH;
            this.maNV = maNV;
            this.ghiChu = ghichu;
        }

        public eHDBanSi()
        {
            // TODO: Complete member initialization
        }
        public override int GetHashCode()
        {
            return maKH.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            eNhaCungCap ncc = (eNhaCungCap)obj;
            return maKH.ToLower().Equals(ncc.maNCC);
        }
    }

}
