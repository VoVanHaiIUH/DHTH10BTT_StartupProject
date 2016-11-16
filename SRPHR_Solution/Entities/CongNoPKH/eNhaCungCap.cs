using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eNhaCungCap
    {
        public string maNCC { get; set; }
        public string tenNCC { get; set; }
        public string diaChi { get; set; }
        public string sDT { get; set; }
        public string email { get; set; }
        public eNhaCungCap(string ma, string ten, string dc, string sdt, string email)
        {
            this.maNCC = ma;
            this.tenNCC = ten;
            this.diaChi = dc;
            this.sDT = sdt;
            this.email = email;
        }

        public eNhaCungCap()
        {
            // TODO: Complete member initialization
        }
        public override int GetHashCode()
        {
            return maNCC.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            eNhaCungCap ncc = (eNhaCungCap)obj;
            return maNCC.ToLower().Equals(ncc.maNCC);
        }
    }
}
