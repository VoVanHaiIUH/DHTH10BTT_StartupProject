using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class eCTQLKho
    {
        public string _maPhieuQL { get; set; }
        public string _sott { get; set; }
        public string _tensp { get; set; }
        public string _soluongql { get; set; }
        public string _masp { get; set; }
        public string _donvi { get; set; }



        public eCTQLKho(string _maPhieuQL, string _sott, string _tensp, string _soluongql, string masp, string donvi)
        {
            this._maPhieuQL = _maPhieuQL;
            this._sott = _sott;
            this._soluongql = _soluongql;
            this._tensp = _tensp;
            this._masp = _masp;
            this._donvi = _donvi;
        }
        public eCTQLKho()
        {
            this._maPhieuQL = "";
            this._sott = "";
            this._soluongql = "";
            this._tensp = "";
            this._masp = "";
            this._donvi = "";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
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

