using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.NhanSu;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
   
    

    public class KyLuatBLL
    {
        //SRPHRDataContext DB = new SRPHRDataContext();
        SRPHR1DataContext DB = new SRPHR1DataContext();
        public List<KyLuat> GetAllKyLuat()
        {
            List<KyLuat> kyLuats = new List<KyLuat>();
            KyLuat tempKL;
            foreach (Tbl_KyLuatNV record in DB.Tbl_KyLuatNVs)
            {
                tempKL = MyConvert.ToKyLuat(record);
                kyLuats.Add(tempKL);
            }
            return kyLuats;
        }

        public bool Add(KyLuat newKL)
        {
            try
            {
                Tbl_KyLuatNV newRecord = MyConvert.toTbl_KyLuat(newKL);
                DB.Tbl_KyLuatNVs.InsertOnSubmit(newRecord);
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
                Tbl_KyLuatNV deleteRecord = DB.Tbl_KyLuatNVs.Single(record => record.maKyLuat == deleteID);
                DB.Tbl_KyLuatNVs.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpDate(KyLuat updateKL)
        {
            try
            {
                Tbl_KyLuatNV updateRecord = DB.Tbl_KyLuatNVs.Single(record => record.maKyLuat == updateKL.MaKL);
                updateRecord.maKyLuat = updateKL.MaKL;
                updateRecord.hinhThucKL = updateKL.HinhThucKL;
                updateRecord.ghiChu = updateKL.GhiChu;

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

