using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class ePhieuDNNK
    {
        public string soPDNNK { get; set; }
        public string maNV { get; set; }
        public string ngayLapphieu { get; set; }
        public string maKho { get; set; }
        public ePhieuDNNK(string soPDNNK, string maNV, string ngayLapphieu, string maKho)
        {
            this.soPDNNK = soPDNNK;
            this.maNV = maNV;
            this.ngayLapphieu = ngayLapphieu;
            this.maKho = maKho;
        }
        public override int GetHashCode()
        {
            return soPDNNK.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            ePhieuDNNK pdnnk = (ePhieuDNNK)obj;
            return pdnnk.Equals(pdnnk.soPDNNK);
        }
    }
}


