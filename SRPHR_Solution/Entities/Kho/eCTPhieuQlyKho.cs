using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class eCTPhieuQlyKho
    {
        public string _maPhieuQly { get; set; }
        public string _sTT { get; set; }
        public string _tenSP { get; set; }
        public int _soLuongQly { get; set; }
        public string _maSP { get; set; }
        public string _donVi { get; set; }
        public eCTPhieuQlyKho()
        {
            this._maPhieuQly = "";
            this._maSP = "";
            this._sTT = "";
            this._soLuongQly = 0;
            this._donVi = "";
            this._tenSP = "";
        }
        public eCTPhieuQlyKho(string maphieuqly, string stt, string tensp, int soluongqly, string masp, string donvi)
        {
            this._maPhieuQly = maphieuqly;
            this._maSP = masp;
            this._tenSP = tensp;
            this._sTT = stt;
            this._soLuongQly = soluongqly;
            this._donVi = donvi;
        }
        public override bool Equals(object newctpqlk)
        {
            eKho ctpqlk = (eKho)newctpqlk;
            return base.Equals(newctpqlk);
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
