using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NhanSu
{
    public class LichSuLamViec
    {
        //#region Property
        //    private string _maNV;
        //    private string _maPB;
        //    private string _maChucVu;
        //    private DateTime _ngayBD;
        //    private DateTime _ngayKT;
        //#endregion
        //#region Get Set Property
        //    public DateTime NgayKT
        //    {
        //        get { return _ngayKT; }
        //        set { _ngayKT = value; }
        //    }
        //    public DateTime NgayBD
        //    {
        //        get { return _ngayBD; }
        //        set { _ngayBD = value; }
        //    }
        //    public string MaPB
        //    {
        //        get { return _maPB; }
        //        set { _maPB = value; }
        //    }

        //    public string MaNV
        //    {
        //        get { return _maNV; }
        //        set { _maNV = value; }
        //    }
        //    public string MaChucVu
        //    {
        //        get { return _maChucVu; }
        //        set { _maChucVu = value; }
        //    }
        //#endregion
        //#region Constructor
        //    public LichSuLamViec(string maNV, string maPB, string maChucVu, DateTime ngayBD, DateTime ngayKT)
        //    {
        //        MaNV = maNV;
        //        MaPB = maPB;
        //        MaChucVu = maChucVu;
        //        NgayBD = ngayBD;
        //        NgayKT = ngayKT;
        //    }
        //#endregion
        //#region Methods
        //    public override bool Equals(Object newNV)
        //    {
        //        LichSuLamViec nv = (LichSuLamViec)newNV;
        //        return this.MaNV.ToLower().Equals(nv.MaNV.ToLower());
        //    }
        //    public override int GetHashCode()
        //    {
        //        return base.GetHashCode();
        //    }
        //    public override string ToString()
        //    {
        //        return base.ToString();
        //    }
        //#endregion
        #region Property
        private string _maNV;
        private string _maPB;
        private string _maChucVu;
        private DateTime _ngayBD;
        private DateTime _ngayKT;
        #endregion
        #region Get Set Property
        public DateTime NgayKT
        {
            get { return _ngayKT; }
            set { _ngayKT = value; }
        }
        public DateTime NgayBD
        {
            get { return _ngayBD; }
            set { _ngayBD = value; }
        }
        public string MaPB
        {
            get { return _maPB; }
            set { _maPB = value; }
        }

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        public string MaChucVu
        {
            get { return _maChucVu; }
            set { _maChucVu = value; }
        }
        #endregion
        #region Constructor
        public LichSuLamViec(string maNV, string maPB, string maChucVu, DateTime ngayBD, DateTime ngayKT)
        {
            MaNV = maNV;
            MaPB = maPB;
            MaChucVu = maChucVu;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
        }
        #endregion
        #region Methods
        public override bool Equals(Object newNV)
        {
            LichSuLamViec nv = (LichSuLamViec)newNV;
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
