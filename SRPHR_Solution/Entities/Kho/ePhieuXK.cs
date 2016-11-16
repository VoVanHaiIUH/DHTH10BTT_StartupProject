using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class ePhieuXK
    {
        public string _maPhieuXuat { get; set; }
        public DateTime _ngayLapXuat { get; set; }
        public string _maNV { get; set; }
        public string _tinhTrang { get; set; }
        public string _maKho { get; set; }

        public ePhieuXK()
        {
            this._maNV = "";
            this._maPhieuXuat = "";
            this._ngayLapXuat = DateTime.Now;
            this._tinhTrang = "";
            this._maKho = "";
        }

        public ePhieuXK(string maphieuxuat, DateTime ngaylapxuat, string manv, string tinhtrang, string makho)
        {
            this._maNV = manv;
            this._maPhieuXuat = _maPhieuXuat;
            this._ngayLapXuat = ngaylapxuat;
            this._tinhTrang = tinhtrang;
            this._maKho = makho;
        }
        #region Methods manhanvien
        public override bool Equals(Object newXK)
        {
            ePhieuXK xk = (ePhieuXK)newXK;
            return this._maPhieuXuat.ToLower().Equals(xk._maPhieuXuat.ToLower());
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
