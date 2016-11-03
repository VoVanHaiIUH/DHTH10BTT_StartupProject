using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
   public class LichSuLamViecBLL
    {
       //SRPHRDataContext DB = new SRPHRDataContext();
       //public bool Add(LichSuLamViec newLSLV)
       //{
       //    try
       //    {
       //        Tbl_LichSuLamViec newRecord = DB.Tbl_LichSuLamViecs.Single(record => record.maNV == newLSLV.MaNV && record.maChucVu == newLSLV.MaChucVu && record.maPB == newLSLV.MaPB);
       //        newRecord.maNV = newLSLV.MaNV;
       //        newRecord.maPB = newLSLV.MaPB;
       //        newRecord.maChucVu = newLSLV.MaChucVu;
       //        newRecord.ngayBD = newLSLV.NgayBD;
       //        newRecord.ngayKT = newLSLV.NgayKT;
       //        DB.Tbl_LichSuLamViecs.InsertOnSubmit(newRecord);
       //        DB.SubmitChanges();
       //        return true;

       //    }
       //    catch
       //    {
       //        return false;
       //    }
       //}
       //public bool Delete(string deleteID)
       //{
       //    try
       //    {
       //        Tbl_LichSuLamViec deleteRecord = DB.Tbl_LichSuLamViecs.Single(record=>record.maNV==deleteID && record.maChucVu==deleteID && record.maPB==deleteID);
       //        DB.Tbl_LichSuLamViecs.DeleteOnSubmit(deleteRecord);
       //        DB.SubmitChanges();
       //        return true;
       //    }
       //    catch
       //    {
       //        return false;
       //    }
       //}
       // public bool UpDate(LichSuLamViec updateLSLV)
       //{
       //     try
       //     {
       //         Tbl_LichSuLamViec updateRecord = DB.Tbl_LichSuLamViecs.Single(record => record.maNV == updateLSLV.MaNV && record.maChucVu == updateLSLV.MaChucVu && record.maPB == updateLSLV.MaPB);
       //         updateRecord.maNV = updateLSLV.MaNV;
       //         updateRecord.maPB = updateLSLV.MaPB;
       //         updateRecord.maChucVu = updateLSLV.MaChucVu;
       //         updateRecord.ngayBD = updateLSLV.NgayBD;
       //         updateRecord.ngayKT = updateLSLV.NgayKT;
       //         DB.SubmitChanges();
       //         return true;

       //     }
       //     catch
       //     {
       //         return false;
       //     }
       //}
        SRPHRDataContext DB = new SRPHRDataContext();
        public bool Add(LichSuLamViec newLSLV)
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
        public bool UpDate(LichSuLamViec updateLSLV)
        {
            try
            {
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
    }
}
