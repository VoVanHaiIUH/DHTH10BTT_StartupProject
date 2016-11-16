using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class ePhieuNK
    {
        public string _maPhieuNhap { get; set; }
        public DateTime _ngayLapNhap { get; set; }
        public string _maNV { get; set; }
        public string _msKho { get; set; }
        public string _tinhTrang { get; set; }



        public ePhieuNK()
        {
            this._maNV = "";
            this._maPhieuNhap = "";
            this._msKho = "";
            this._ngayLapNhap = DateTime.Now;
            this._tinhTrang = "";
        }
        public ePhieuNK(string maphieunhap, DateTime ngaylap, string manv, string mskho, string tinhtrang)
        {
            this._maNV = manv;
            this._maPhieuNhap = maphieunhap;
            this._msKho = mskho;
            this._ngayLapNhap = ngaylap;
            this._tinhTrang = tinhtrang;
        }
        #region Methods manhanvien
        //public override bool Equals(Object newNK)
        //{
        //    ePhieuNK nk = (ePhieuNK)newNK;
        //    return this._maPhieuNhap.ToLower().Equals(nk._maPhieuNhap.ToLower());
        //}
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
