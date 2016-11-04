using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class ePhieuQLiKho
    {
        public string _maPhieuQli { get; set; }
        public string _ngayLapQLi { get; set; }
        public string _maNV { get; set; }
        public string _maKho { get; set; }
        public string _tinhTrang { get; set; }


        public ePhieuQLiKho(string maphieuqli, string ngaylapqli, string manv, string makho, string tinhtrang)
        {
            this._maPhieuQli = maphieuqli;
            this._ngayLapQLi = ngaylapqli;
            this._maNV = manv;
            this._maKho = makho;
            this._tinhTrang = tinhtrang;
        }
        public override bool Equals(object newPQLK)
        {
            ePhieuQLiKho pqlk = (ePhieuQLiKho)newPQLK;
            return this._maPhieuQli.ToLower().Equals(pqlk._maPhieuQli.ToLower());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
