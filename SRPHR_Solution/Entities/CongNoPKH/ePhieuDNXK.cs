using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class ePhieuDNXK
    {

        public string soPDNXK { get; set; }
        public string maNV { get; set; }
        public string ngayLap { get; set; }
        public string maKho { get; set; }
        public ePhieuDNXK()
        {
            this.soPDNXK = "";
            this.maNV = "";
            this.ngayLap = "";
            this.maKho = "";
        }
        public ePhieuDNXK(string soPDNXK, string maNV, string ngayLap, string maKho)
        {
            this.soPDNXK = soPDNXK;
            this.maNV = maNV;
            this.ngayLap = ngayLap;
            this.maKho = maKho;
        }
        public override int GetHashCode()
        {
            return soPDNXK.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            ePhieuDNXK pdnxk = (ePhieuDNXK)obj;
            return pdnxk.Equals(pdnxk.soPDNXK);
        }
    }
}