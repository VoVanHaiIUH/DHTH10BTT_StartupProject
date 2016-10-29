using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCTHDBanSi
    {
        public string maHD { get; set; }
        public string maSP { get; set; }
        public float soluong { get; set; }
        public string dongiaBan { get; set; }
        public string ghiChu { get; set; }
        public eCTHDBanSi(string maHD, string maSP, float soluong, string dongiaBan, string ghiChu)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soluong = soluong;
            this.dongiaBan = dongiaBan;
            this.ghiChu = ghiChu;
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
