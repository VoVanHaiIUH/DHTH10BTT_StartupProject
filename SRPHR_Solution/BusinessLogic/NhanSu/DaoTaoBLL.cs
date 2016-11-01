using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    //public class DaoTaoBLL
    //{
    //    SRPHRDataContext DB = new SRPHRDataContext();
    //    public List<DaoTao> GetAllNhanVien()
    //    {
    //        List<DaoTao> daoTaos = new List<DaoTao>();
    //        DaoTao tempNV;
    //        foreach (Tbl_DaoTaoNV record in DB.Tbl_DaoTaoNVs)
    //        {
    //            tempNV = MyConvert.ToDaoTao(record);
    //            daoTaos.Add(tempNV);
    //        }

    //        return daoTaos;
    //    }

    //    public bool Add(DaoTao newDT)
    //    {
    //        try
    //        {
    //            Tbl_DaoTaoNV newRecord = MyConvert.toTbl_DaoTao(newDT);

    //            DB.Tbl_DaoTaoNVs.InsertOnSubmit(newRecord);
    //            DB.SubmitChanges();

    //            return true;
    //        }
    //        catch { return false; }
    //    }

    //    public bool Delete(string deleteID)
    //    {
    //        try
    //        {
    //            Tbl_DaoTaoNV deleteRecord = DB.Tbl_DaoTaoNVs.Single(record => record.maKhoaDT == deleteID);

    //            DB.Tbl_DaoTaoNVs.DeleteOnSubmit(deleteRecord);
    //            DB.SubmitChanges();

    //            return true;
    //        }
    //        catch { return false; }
    //    }

    //    public bool Update(DaoTao updateDT)
    //    {
    //        try
    //        {
    //            Tbl_DaoTaoNV updateRecord = DB.Tbl_DaoTaoNVs.Single(record => record.maKhoaDT == updateDT.MaKhoaDT);

    //            updateRecord.maKhoaDT = updateDT.MaKhoaDT;
    //            updateRecord.tenKhoaDT = updateDT.TenKhoaDT;
    //            updateRecord.ngayBD = updateDT.NgayBD;
    //            updateRecord.ngayKT = updateDT.NgayKT;
    //            updateRecord.diaDiem= updateDT.Diadiem;
    //            updateRecord.hinhthucDT = updateDT.HinhThucDT;
    //            updateRecord.chiPhi = updateDT.Chiphi;

    //            DB.SubmitChanges();

    //            return true;
    //        }
    //        catch { return false; }
    //    }
    //}



    public class DaoTaoBLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public List<DaoTao> GetAllNhanVien()
        {
            List<DaoTao> daoTaos = new List<DaoTao>();
            DaoTao tempNV;
            foreach (Tbl_DaoTaoNV record in DB.Tbl_DaoTaoNVs)
            {
                tempNV = MyConvert.ToDaoTao(record);
                daoTaos.Add(tempNV);
            }

            return daoTaos;
        }

        public bool Add(DaoTao newDT)
        {
            try
            {
                Tbl_DaoTaoNV newRecord = MyConvert.toTbl_DaoTao(newDT);

                DB.Tbl_DaoTaoNVs.InsertOnSubmit(newRecord);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Delete(string deleteID)
        {
            try
            {
                Tbl_DaoTaoNV deleteRecord = DB.Tbl_DaoTaoNVs.Single(record => record.maKhoaDT == deleteID);

                DB.Tbl_DaoTaoNVs.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Update(DaoTao updateDT)
        {
            try
            {
                Tbl_DaoTaoNV updateRecord = DB.Tbl_DaoTaoNVs.Single(record => record.maKhoaDT == updateDT.MaKhoaDT);

                updateRecord.maKhoaDT = updateDT.MaKhoaDT;
                updateRecord.tenKhoaDT = updateDT.TenKhoaDT;
                updateRecord.ngayBD = updateDT.NgayBD;
                updateRecord.ngayKT = updateDT.NgayKT;
                updateRecord.diaDiem = updateDT.Diadiem;
                updateRecord.hinhthucDT = updateDT.HinhThucDT;
                updateRecord.chiPhi = updateDT.Chiphi;

                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
    }
}
