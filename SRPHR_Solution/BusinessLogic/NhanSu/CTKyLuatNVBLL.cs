using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    
    public class CTKyLuatNVBLL
    {
        // SRPHRDataContext DB = new SRPHRDataContext();
        //public bool Add(CTKyLuatNV newCTKL)
        // {
        //    try
        //    {
        //        Tbl_CTKyLuatNV newRecord = DB.Tbl_CTKyLuatNVs.Single(record => record.maNV == newCTKL.MaNV && record.maKyLuat == newCTKL.MaKyLuat);
        //        newRecord.maNV = newCTKL.MaNV;
        //        newRecord.maKyLuat = newCTKL.MaKyLuat;
        //        newRecord.ngayLap = newCTKL.NgayLap;
        //        newRecord.ngayThiHanh = newCTKL.NgayThiHanh;
        //        newRecord.ngayKetThuc = newCTKL.NgayKetThuc;
        //        newRecord.mucDoKL = newCTKL.MucDoKL;
        //        newRecord.lyDo = newCTKL.LyDo;
        //        newRecord.ghiChu = newCTKL.GhiChu;
        //        DB.Tbl_CTKyLuatNVs.InsertOnSubmit(newRecord);
        //        DB.SubmitChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        // }
        //public bool Delete(string deleteID)
        //{
        //    try
        //    {
        //        Tbl_CTKyLuatNV deleteRecord = DB.Tbl_CTKyLuatNVs.Single(record => record.maNV == deleteID && record.maKyLuat == deleteID);
        //        DB.Tbl_CTKyLuatNVs.DeleteOnSubmit(deleteRecord);
        //        DB.SubmitChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //public bool UpDate(CTKyLuatNV updateCTKL)
        //{
        //    try
        //    {
        //        Tbl_CTKyLuatNV updateRecord = DB.Tbl_CTKyLuatNVs.Single(record => record.maNV == updateCTKL.MaNV && record.maKyLuat == updateCTKL.MaKyLuat);
        //        updateRecord.maNV = updateCTKL.MaNV;
        //        updateRecord.maKyLuat = updateCTKL.MaKyLuat;
        //        updateRecord.ngayLap = updateCTKL.NgayLap;
        //        updateRecord.ngayThiHanh = updateCTKL.NgayThiHanh;
        //        updateRecord.ngayKetThuc = updateCTKL.NgayKetThuc;
        //        updateRecord.mucDoKL = updateCTKL.MucDoKL;
        //        updateRecord.lyDo = updateCTKL.LyDo;
        //        updateRecord.ghiChu = updateCTKL.GhiChu;
        //        DB.SubmitChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        SRPHRDataContext DB = new SRPHRDataContext();
        public bool Add(CTKyLuatNV newCTKL)
        {
            try
            {
                Tbl_CTKyLuatNV newRecord = DB.Tbl_CTKyLuatNVs.Single(record => record.maNV == newCTKL.MaNV && record.maKyLuat == newCTKL.MaKyLuat);
                newRecord.maNV = newCTKL.MaNV;
                newRecord.maKyLuat = newCTKL.MaKyLuat;
                newRecord.ngayLap = newCTKL.NgayLap;
                newRecord.ngayThiHanh = newCTKL.NgayThiHanh;
                newRecord.ngayKetThuc = newCTKL.NgayKetThuc;
                newRecord.mucDoKL = newCTKL.MucDoKL;
                newRecord.lyDo = newCTKL.LyDo;
                newRecord.ghiChu = newCTKL.GhiChu;
                DB.Tbl_CTKyLuatNVs.InsertOnSubmit(newRecord);
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
                Tbl_CTKyLuatNV deleteRecord = DB.Tbl_CTKyLuatNVs.Single(record => record.maNV == deleteID && record.maKyLuat == deleteID);
                DB.Tbl_CTKyLuatNVs.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpDate(CTKyLuatNV updateCTKL)
        {
            try
            {
                Tbl_CTKyLuatNV updateRecord = DB.Tbl_CTKyLuatNVs.Single(record => record.maNV == updateCTKL.MaNV && record.maKyLuat == updateCTKL.MaKyLuat);
                updateRecord.maNV = updateCTKL.MaNV;
                updateRecord.maKyLuat = updateCTKL.MaKyLuat;
                updateRecord.ngayLap = updateCTKL.NgayLap;
                updateRecord.ngayThiHanh = updateCTKL.NgayThiHanh;
                updateRecord.ngayKetThuc = updateCTKL.NgayKetThuc;
                updateRecord.mucDoKL = updateCTKL.MucDoKL;
                updateRecord.lyDo = updateCTKL.LyDo;
                updateRecord.ghiChu = updateCTKL.GhiChu;
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
