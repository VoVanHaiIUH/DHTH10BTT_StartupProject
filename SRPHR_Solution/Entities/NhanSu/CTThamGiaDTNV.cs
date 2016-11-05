using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NhanSu
{
    public class CTThamGiaDTNV
    {
        //#region property
        //private string _maNV;
        //private string _maKhoaDT;
        //private string _ketQua;
        //private string _nhanXet;
        //#endregion

        //#region property get set
        //public string NhanXet
        //{
        //    get { return _nhanXet; }
        //    set { _nhanXet = value; }
        //}

        //public string KetQua
        //{
        //    get { return _ketQua; }
        //    set { _ketQua = value; }
        //}

        //public string MaKhoaDT
        //{
        //    get { return _maKhoaDT; }
        //    set { _maKhoaDT = value; }
        //}

        //public string MaNV
        //{
        //    get { return _maNV; }
        //    set { _maNV = value; }
        //}
        //#endregion
        //#region constructor
        //public CTThamGiaDTNV(string maNV,string maKhoaDT,string ketQua,string nhanXet)
        //{
        //    MaNV = maNV;
        //    MaKhoaDT = maKhoaDT;
        //    KetQua = ketQua;
        //    NhanXet = nhanXet;
        //}
        //#endregion

        //#region Methods manhanvien
        //public override bool Equals(Object newNV)
        //{
        //    CTThamGiaDTNV nv = (CTThamGiaDTNV)newNV;
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
        #region property
        private string _maNV;
        private string _maKhoaDT;
        private string _ketQua;
        private string _nhanXet;
        #endregion

        #region property get set
        public string NhanXet
        {
            get { return _nhanXet; }
            set { _nhanXet = value; }
        }

        public string KetQua
        {
            get { return _ketQua; }
            set { _ketQua = value; }
        }

        public string MaKhoaDT
        {
            get { return _maKhoaDT; }
            set { _maKhoaDT = value; }
        }

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        #endregion
        #region constructor
        public CTThamGiaDTNV(string maNV, string maKhoaDT, string ketQua, string nhanXet)
        {
            MaNV = maNV;
            MaKhoaDT = maKhoaDT;
            KetQua = ketQua;
            NhanXet = nhanXet;
        }
        public CTThamGiaDTNV()
        {
            MaNV = "";
            MaKhoaDT = "";
            KetQua = "";
            NhanXet = "";
        }
        #endregion

        #region Methods manhanvien
        public override bool Equals(Object newNV)
        {
            CTThamGiaDTNV nv = (CTThamGiaDTNV)newNV;
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
