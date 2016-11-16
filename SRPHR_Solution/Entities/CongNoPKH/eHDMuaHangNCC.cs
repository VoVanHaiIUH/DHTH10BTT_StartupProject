using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eHDMuaHangNCC
    {
        public string maHD { get; set; }
        public string tenHD { get; set; }
        public string ngayLap { get; set; }
        public string maNCC { get; set; }
        public string maNV { get; set; }
        public string noidung { get; set; }

        public eHDMuaHangNCC(string maHD, string ngaylap, string maKH, string maNV, string ghichu, string tenHD)
        {
            this.maHD = maHD;
            this.ngayLap = ngaylap;
            this.maNCC = maNCC;
            this.maNV = maNV;
            this.noidung = noidung;
            this.tenHD = tenHD;
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
