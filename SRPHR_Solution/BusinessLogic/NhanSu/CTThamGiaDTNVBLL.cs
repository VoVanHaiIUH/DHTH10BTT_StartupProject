using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    public class CTThamGiaDTNVBLL
    {
        //SRPHRDataContext DB = new SRPHRDataContext();
        //public bool Add(CTThamGiaDTNV newCTTGDT)
        //{
        //    try
        //    {
        //        Tbl_CTThamGiaDTNV newRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == newCTTGDT.MaNV && record.maKhoaDT == newCTTGDT.MaKhoaDT);
        //        newRecord.maNV = newCTTGDT.MaNV;
        //        newRecord.maKhoaDT = newCTTGDT.MaKhoaDT;
        //        newRecord.nhanXet = newCTTGDT.NhanXet;
        //        newRecord.ketQua = newCTTGDT.KetQua;
        //        DB.Tbl_CTThamGiaDTNVs.InsertOnSubmit(newRecord);
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
        //        Tbl_CTThamGiaDTNV deleteRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == deleteID && record.maKhoaDT == deleteID);
        //        DB.Tbl_CTThamGiaDTNVs.DeleteOnSubmit(deleteRecord);
        //        DB.SubmitChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //public bool UpDate(CTThamGiaDTNV updateCTDTNV)
        //{
        //    try
        //    {
        //        Tbl_CTThamGiaDTNV updateRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == updateCTDTNV.MaNV && record.maKhoaDT == updateCTDTNV.MaKhoaDT);
        //        updateRecord.maNV = updateCTDTNV.MaNV;
        //        updateRecord.maKhoaDT = updateCTDTNV.MaKhoaDT;
        //        updateRecord.nhanXet = updateCTDTNV.NhanXet;
        //        updateRecord.ketQua = updateCTDTNV.KetQua;
        //        DB.SubmitChanges();
        //        return true;
            
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        SRPHRDataContext DB = new SRPHRDataContext();
        public bool Add(CTThamGiaDTNV newCTTGDT)
        {
            try
            {
                Tbl_CTThamGiaDTNV newRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == newCTTGDT.MaNV && record.maKhoaDT == newCTTGDT.MaKhoaDT);
                newRecord.maNV = newCTTGDT.MaNV;
                newRecord.maKhoaDT = newCTTGDT.MaKhoaDT;
                newRecord.nhanXet = newCTTGDT.NhanXet;
                newRecord.ketQua = newCTTGDT.KetQua;
                DB.Tbl_CTThamGiaDTNVs.InsertOnSubmit(newRecord);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(CTThamGiaDTNV deleteID)
        {
            try
            {
                Tbl_CTThamGiaDTNV deleteRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == deleteID.MaNV && record.maKhoaDT == deleteID.MaKhoaDT);
                deleteRecord.maNV = deleteID.MaNV;
                deleteRecord.maKhoaDT = deleteID.MaKhoaDT;
                deleteRecord.nhanXet = deleteID.NhanXet;
                deleteRecord.ketQua = deleteID.KetQua;
                DB.Tbl_CTThamGiaDTNVs.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpDate(CTThamGiaDTNV updateCTDTNV)
        {
            try
            {
                Tbl_CTThamGiaDTNV updateRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == updateCTDTNV.MaNV && record.maKhoaDT == updateCTDTNV.MaKhoaDT);
                updateRecord.maNV = updateCTDTNV.MaNV;
                updateRecord.maKhoaDT = updateCTDTNV.MaKhoaDT;
                updateRecord.nhanXet = updateCTDTNV.NhanXet;
                updateRecord.ketQua = updateCTDTNV.KetQua;
                DB.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public List<CTThamGiaDTNV> GetAllDaoTao()
        {
            List<CTThamGiaDTNV> lst = new List<CTThamGiaDTNV>();
            foreach (Tbl_CTThamGiaDTNV item in DB.Tbl_CTThamGiaDTNVs)
            {
                CTThamGiaDTNV cttg = new CTThamGiaDTNV();
                cttg.MaNV = item.maNV;
                cttg.MaKhoaDT = item.maKhoaDT;
                cttg.KetQua = item.ketQua;
                cttg.NhanXet = item.nhanXet;
                lst.Add(cttg);
            }
            return lst;
        }
    }
}
