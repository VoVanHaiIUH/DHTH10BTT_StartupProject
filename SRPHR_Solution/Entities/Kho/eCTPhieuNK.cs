using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class eCTPhieuNK
    {
        public string _maPhieuQli { get; set; }
        public string _sTT { get; set; }
        public string _tenSP { get; set; }
        public string _soLuongQli { get; set; }
        public string _maSP { get; set; }
        public string _donVi { get; set; }




        public eCTPhieuNK(string maphieuqli, string stt, string tensp, string soluongqli, string masp, string donvi)
        {
            this._maPhieuQli = maphieuqli;
            this._sTT = stt;
            this._tenSP = tensp;
            this._soLuongQli = soluongqli;
            this._maSP = masp;
            this._donVi = donvi;
        }
        public override bool Equals(object newCTNK)
        {
            eCTPhieuNK ctnk = (eCTPhieuNK)newCTNK;
            return this._maPhieuQli.ToLower().Equals(ctnk._maPhieuQli.ToLower());
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
