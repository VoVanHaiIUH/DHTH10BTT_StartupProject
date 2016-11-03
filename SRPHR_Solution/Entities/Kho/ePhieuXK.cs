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
        public string _ngayLapXuat { get; set; }
        public string _maNV { get; set; }

        public string _tinhTrang { get; set; }
        public ePhieuXK(string maphieuxuat, string ngaylapxuat, string manv, string tinhtrang)
        {
            this._maNV = manv;
            this._maPhieuXuat = _maPhieuXuat;
            this._ngayLapXuat = ngaylapxuat;
            this._tinhTrang = tinhtrang;
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
