using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    public class ChucVuBLL
    {
    //    //SRPHRDataContext DB = new SRPHRDataContext();
    //    //public List<ChucVu> GetAllChucVu()
    //    //{
    //    //    List<ChucVu> chucVus = new List<ChucVu>();
    //    //    ChucVu tempCV;
    //    //    foreach (Tbl_ChucVu record in DB.Tbl_ChucVus)
    //    //    {
    //    //        tempCV = MyConvert.ToChucVu(record);
    //    //        chucVus.Add(tempCV);
    //    //    }

    //    //    return chucVus;
    //    //}

    //    //public bool Add(ChucVu newCV)
    //    //{
    //    //    try
    //    //    {
    //    //        Tbl_ChucVu newRecord = MyConvert.toTbl_ChucVu(newCV);
    //    //        DB.Tbl_ChucVus.InsertOnSubmit(newRecord);
    //    //        DB.SubmitChanges();

    //    //        return true;
    //    //    }
    //    //    catch
    //    //    {
    //    //        return false;
    //    //    }
    //    //}
    //    //public bool Delete(string deleteID)
    //    //{
    //    //    try
    //    //    {
    //    //        Tbl_ChucVu deleteRecord = DB.Tbl_ChucVus.Single(record => record.maChucVu == deleteID);
    //    //        DB.Tbl_ChucVus.DeleteOnSubmit(deleteRecord);
    //    //        DB.SubmitChanges();

    //    //        return true;
    //    //    }
    //    //    catch
    //    //    {
    //    //        return false;
    //    //    }
    //    //}

    //    //public bool UpDate(ChucVu updatePB)
    //    //{
    //    //    try
    //    //    {
    //    //        Tbl_ChucVu updateRecord = DB.Tbl_ChucVus.Single(record => record.maChucVu == updatePB.MaCV);
    //    //        updateRecord.maChucVu = updatePB.MaCV;
    //    //        updateRecord.tenCV = updatePB.TenCV;
    //    //        updateRecord.heSo = updatePB.HeSo;
    //    //        updateRecord.ghiChu = updatePB.GhiChu;

    //    //        DB.SubmitChanges();

    //    //        return true;

    //    //    }
    //    //    catch
    //    //    {
    //    //        return false;
    //    //    }
    //    //}
    //    SRPHRDataContext DB = new SRPHRDataContext();
    //    public List<ChucVu> GetAllChucVu()
    //    {
    //        List<ChucVu> chucVus = new List<ChucVu>();
    //        ChucVu tempCV;
    //        foreach (Tbl_ChucVu record in DB.Tbl_ChucVus)
    //        {
    //            tempCV = MyConvert.ToChucVu(record);
    //            chucVus.Add(tempCV);
    //        }

    //        return chucVus;
    //    }

    //    public bool Add(ChucVu newCV)
    //    {
    //        try
    //        {
    //            Tbl_ChucVu newRecord = MyConvert.toTbl_ChucVu(newCV);
    //            DB.Tbl_ChucVus.InsertOnSubmit(newRecord);
    //            DB.SubmitChanges();

    //            return true;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }
    //    public bool Delete(string deleteID)
    //    {
    //        try
    //        {
    //            Tbl_ChucVu deleteRecord = DB.Tbl_ChucVus.Single(record => record.maChucVu == deleteID);
    //            DB.Tbl_ChucVus.DeleteOnSubmit(deleteRecord);
    //            DB.SubmitChanges();

    //            return true;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }

    //    public bool UpDate(ChucVu updatePB)
    //    {
    //        try
    //        {
    //            Tbl_ChucVu updateRecord = DB.Tbl_ChucVus.Single(record => record.maChucVu == updatePB.MaCV);
    //            updateRecord.maChucVu = updatePB.MaCV;
    //            updateRecord.tenCV = updatePB.TenCV;
    //            updateRecord.heSo = updatePB.HeSo;
    //            updateRecord.ghiChu = updatePB.GhiChu;

    //            DB.SubmitChanges();

    //            return true;

    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }
    }
}
