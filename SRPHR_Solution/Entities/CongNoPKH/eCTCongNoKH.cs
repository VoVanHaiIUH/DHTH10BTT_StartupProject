using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCTCongNoKH
    {
        public string maKH { get; set; }
        public string soTien { get; set; }
        public string soPhieu { get; set; }
        public string ghiChu { get; set; }
        public eCTCongNoKH(string makh,string sotien,string sophieu,string ghichu)
        {
            this.maKH = makh;
            this.soPhieu = sophieu;
            this.soTien = sotien;
            this.ghiChu = ghichu;

        }
        public override bool Equals(object obj)
        {
            eCTCongNoKH encc = (eCTCongNoKH)obj;
            return encc.Equals(encc.maKH);
        }
        public override int GetHashCode()
        {
            return maKH.GetHashCode();
        }
    }
}
