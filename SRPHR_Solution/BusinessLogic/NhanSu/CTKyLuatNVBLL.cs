using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.NhanSu;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    
    public class CTKyLuatNVBLL
    {
        
        //SRPHRDataContext DB = new SRPHRDataContext();
        DataClasses1DataContext DB = new DataClasses1DataContext();
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
        public bool Delete(CTKyLuatNV deleteID)
        {
            try
            {
                Tbl_CTKyLuatNV deleteRecord = DB.Tbl_CTKyLuatNVs.Single(record => record.maNV == deleteID.MaNV && record.maKyLuat == deleteID.MaKyLuat);
                deleteRecord.maNV = deleteID.MaNV;
                deleteRecord.maKyLuat = deleteID.MaKyLuat;
                deleteRecord.ngayLap = deleteID.NgayLap;
                deleteRecord.ngayThiHanh = deleteID.NgayThiHanh;
                deleteRecord.ngayKetThuc = deleteID.NgayKetThuc;
                deleteRecord.mucDoKL = deleteID.MucDoKL;
                deleteRecord.lyDo = deleteID.LyDo;
                deleteRecord.ghiChu = deleteID.GhiChu;
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
        public List<CTKyLuatNV> GetAllCTKL()
        {
            List<CTKyLuatNV> ctkyluat = new List<CTKyLuatNV>();
            var e = DB.Tbl_CTKyLuatNVs.ToList();

            foreach (Tbl_CTKyLuatNV record in e)
            {
                CTKyLuatNV tempCT = new CTKyLuatNV();
                tempCT.MaNV = record.maNV;
                tempCT.MaKyLuat = record.maKyLuat;
                tempCT.NgayLap = record.ngayLap;
                tempCT.NgayThiHanh = record.ngayThiHanh;
                tempCT.NgayKetThuc = record.ngayKetThuc;
                tempCT.MucDoKL = record.mucDoKL;
                tempCT.LyDo = record.lyDo;
                tempCT.GhiChu = record.ghiChu;
                ctkyluat.Add(tempCT);
            }

            return ctkyluat;
        }
    }
}
