using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NhanSu
{
    public class CTKyLuatNV
    {
        //#region Property
        //private string _maNV;
        //private string _maKyLuat;
        //private string _hinhThucKL;
        //private DateTime _ngayLap;
        //private DateTime _ngayThiHanh;
        //private DateTime _ngayKetThuc;
        //private string _mucDoKL;
        //private string _lyDo;
        //private string _ghiChu;
        //#endregion
        //#region property get set
        //public string GhiChu
        //{
        //    get { return _ghiChu; }
        //    set { _ghiChu = value; }
        //}

        //public string LyDo
        //{
        //    get { return _lyDo; }
        //    set { _lyDo = value; }
        //}

        //public string MucDoKL
        //{
        //    get { return _mucDoKL; }
        //    set { _mucDoKL = value; }
        //}

        //public DateTime NgayKetThuc
        //{
        //    get { return _ngayKetThuc; }
        //    set { _ngayKetThuc = value; }
        //}

        //public DateTime NgayThiHanh
        //{
        //    get { return _ngayThiHanh; }
        //    set { _ngayThiHanh = value; }
        //}

        //public DateTime NgayLap
        //{
        //    get { return _ngayLap; }
        //    set { _ngayLap = value; }
        //}

        //public string HinhThucKL
        //{
        //    get { return _hinhThucKL; }
        //    set { _hinhThucKL = value; }
        //}
        //public string MaKyLuat
        //{
        //    get { return _maKyLuat; }
        //    set { _maKyLuat = value; }
        //}

        //public string MaNV
        //{
        //    get { return _maNV; }
        //    set { _maNV = value; }
        //}
        //#endregion
        //#region Constructor
        //public CTKyLuatNV(string maNV, string maKyLuat, string hinhThucKL, DateTime ngayLap, DateTime ngayThiHanh, DateTime ngayKetThuc, string mucDoKL, string lyDo, string ghiChu)
        //{
        //    MaNV = maNV;
        //    MaKyLuat = maKyLuat;
        //    HinhThucKL = hinhThucKL;
        //    NgayLap = ngayLap;
        //    NgayThiHanh = ngayThiHanh;
        //    NgayKetThuc = ngayKetThuc;
        //    MucDoKL = mucDoKL;
        //    LyDo = lyDo;
        //    GhiChu = ghiChu;
        //}
        //#endregion
        //#region Methods manhanvien
        //public override bool Equals(Object newNV)
        //{
        //    CTKyLuatNV nv = (CTKyLuatNV)newNV;
        //    return this.MaNV.ToLower().Equals(nv.MaNV.ToLower());
        //}
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        //#endregion
        #region Property
        private string _maNV;
        private string _maKyLuat;
        private string _hinhThucKL;
        private DateTime _ngayLap;
        private DateTime _ngayThiHanh;
        private DateTime _ngayKetThuc;
        private string _mucDoKL;
        private string _lyDo;
        private string _ghiChu;
        #endregion
        #region property get set
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }

        public string MucDoKL
        {
            get { return _mucDoKL; }
            set { _mucDoKL = value; }
        }

        public DateTime NgayKetThuc
        {
            get { return _ngayKetThuc; }
            set { _ngayKetThuc = value; }
        }

        public DateTime NgayThiHanh
        {
            get { return _ngayThiHanh; }
            set { _ngayThiHanh = value; }
        }

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }

        public string HinhThucKL
        {
            get { return _hinhThucKL; }
            set { _hinhThucKL = value; }
        }
        public string MaKyLuat
        {
            get { return _maKyLuat; }
            set { _maKyLuat = value; }
        }

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        #endregion
        #region Constructor
        public CTKyLuatNV(string maNV, string maKyLuat, string hinhThucKL, DateTime ngayLap, DateTime ngayThiHanh, DateTime ngayKetThuc, string mucDoKL, string lyDo, string ghiChu)
        {
            MaNV = maNV;
            MaKyLuat = maKyLuat;
            HinhThucKL = hinhThucKL;
            NgayLap = ngayLap;
            NgayThiHanh = ngayThiHanh;
            NgayKetThuc = ngayKetThuc;
            MucDoKL = mucDoKL;
            LyDo = lyDo;
            GhiChu = ghiChu;
        }
        #endregion
        #region Methods manhanvien
        public override bool Equals(Object newNV)
        {
            CTKyLuatNV nv = (CTKyLuatNV)newNV;
            return this.MaNV.ToLower().Equals(nv.MaNV.ToLower());
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
