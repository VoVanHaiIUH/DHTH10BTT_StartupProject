using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.NhanSu;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    public class LichSuLamViecBLL
    {

        //SRPHRDataContext DB = new SRPHRDataContext();
        DataClasses1DataContext DB = new DataClasses1DataContext();
        public bool Add(LSLamViec newLSLV)
        {
            try
            {
                Tbl_LichSuLamViec newRecord = DB.Tbl_LichSuLamViecs.Single(record => record.maNV == newLSLV.MaNV && record.maChucVu == newLSLV.MaChucVu && record.maPB == newLSLV.MaPB);
                newRecord.maNV = newLSLV.MaNV;
                newRecord.maPB = newLSLV.MaPB;
                newRecord.maChucVu = newLSLV.MaChucVu;
                newRecord.ngayBD = newLSLV.NgayBD;
                newRecord.ngayKT = newLSLV.NgayKT;
                DB.Tbl_LichSuLamViecs.InsertOnSubmit(newRecord);
                DB.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string deleteID)
        {
            try
            {
                Tbl_LichSuLamViec deleteRecord = DB.Tbl_LichSuLamViecs.Single(record => record.maNV == deleteID && record.maChucVu == deleteID && record.maPB == deleteID);
                DB.Tbl_LichSuLamViecs.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpDate(LSLamViec updateLSLV)
        {
            try
            {
                Tbl_NhanVien tempNV = DB.Tbl_NhanViens.Single(record => record.maNV == updateLSLV.MaNV);
                Tbl_LichSuLamViec updateRecord = DB.Tbl_LichSuLamViecs.Single(record => record.maNV == updateLSLV.MaNV && record.maChucVu == updateLSLV.MaChucVu && record.maPB == updateLSLV.MaPB);
                updateRecord.maNV = updateLSLV.MaNV;
                updateRecord.maPB = updateLSLV.MaPB;
                updateRecord.maChucVu = updateLSLV.MaChucVu;
                updateRecord.ngayBD = updateLSLV.NgayBD;
                updateRecord.ngayKT = updateLSLV.NgayKT;
                DB.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public List<LSLamViec> getAllLS()
        {
            List<LSLamViec> lstls = new List<LSLamViec>();
            foreach (Tbl_LichSuLamViec item in DB.Tbl_LichSuLamViecs)
            {
                LSLamViec ls = new LSLamViec();
                ls.MaNV = item.maNV;
                ls.MaChucVu = item.maChucVu;
                ls.MaPB = item.maPB;
                ls.NgayBD = item.ngayBD;
                ls.NgayKT = (DateTime)item.ngayKT;
                lstls.Add(ls);
            }
            return lstls;
        }
        public List<LSLamViec> GetNhanVien(string mals)
        {
            int i = mals.Length;
            List<LSLamViec> lstcd = new List<LSLamViec>();
            var rct = (from a in DB.Tbl_LichSuLamViecs
                       where a.maNV.Substring(0, i) == mals
                       select new LSLamViec
                       {
                           MaNV = a.maNV,
                           MaChucVu = a.maChucVu,
                           MaPB = a.maPB,
                           NgayBD = a.ngayBD,
                           NgayKT = (DateTime)a.ngayKT,
                       });
            lstcd = rct.ToList();
            return lstcd;
        }
        public List<LSLamViec> Search1NhanVienbyMaNV(string mals)
        {
            int i = mals.Length;
            List<LSLamViec> lstcd = new List<LSLamViec>();
            var rct = (from a in DB.Tbl_LichSuLamViecs
                       where a.maNV.Substring(0, i) == mals
                       select new LSLamViec
                       {
                           MaNV = a.maNV,
                           MaChucVu = a.maChucVu,
                           MaPB = a.maPB,
                           NgayBD = a.ngayBD,
                           NgayKT = (DateTime)a.ngayKT,

                       });
            lstcd = rct.ToList();
            return lstcd;
        }
        public IEnumerable<string> getMaPB()
        {
            var ma = (from cv in DB.Tbl_PhongBans
                      select cv.maPB);
            return ma;
        }

        public IEnumerable<string> getMaCV()
        {
            var ma = (from cv in DB.Tbl_ChucVus
                      select cv.maChucVu);
            return ma;
        }
       
    }
}
