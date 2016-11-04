using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class eSanPham
    {
        public string _maSP { get; set; }
        public string _teSP { get; set; }
        public string _moTa { get; set; }
        public string _ngaySX { get; set; }
        public string _hanSD { get; set; }
        public string _tenNhaPP { get; set; }
        public string _tenNhaSX { get; set; }
        public int _trangthai { get; set; }



        public eSanPham(string masp, string tensp, string mota, string ngaysx, string hansd, string tennhapp, string tennhasx, int trangthai)
        {
            this._hanSD = hansd;
            this._maSP = masp;
            this._moTa = mota;
            this._ngaySX = ngaysx;
            this._tenNhaPP = tennhapp;
            this._tenNhaSX = tennhasx;
            this._teSP = tensp;
            this._trangthai = trangthai;
        }
        #region Methods
        public override bool Equals(Object newSP)
        {
            eSanPham sp = (eSanPham)newSP;
            return this._maSP.ToLower().Equals(sp._maSP.ToLower());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
