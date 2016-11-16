using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCTMuaHangNCC
    {
        public string maHD { get; set; }
        public int maSP { get; set; }
        public float soluong { get; set; }
        public string dongiaMua { get; set; }
        public string ghiChu { get; set; }
        public eCTMuaHangNCC(string maHD, int maSP, float soluong, string dongiaMua, string ghiChu)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soluong = soluong;
            this.dongiaMua = dongiaMua;
            this.ghiChu = ghiChu;
        }

        public eCTMuaHangNCC()
        {
            // TODO: Complete member initialization
        }
        public override int GetHashCode()
        {
            return maHD.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            eNhaCungCap ncc = (eNhaCungCap)obj;
            return maHD.ToLower().Equals(ncc.maNCC);
        }
    }
}
