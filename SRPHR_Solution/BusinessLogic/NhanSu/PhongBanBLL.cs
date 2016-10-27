using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    public class PhongBanBLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public List<PhongBan> GetAllPhongBan()
        {
            List<PhongBan> phongBans = new List<PhongBan>();
            PhongBan tempPB;
            foreach(Tbl_PhongBan record in DB.Tbl_PhongBans)
            {
                tempPB = MyConvert.ToPhongBan(record);
                phongBans.Add(tempPB);
            }

            return phongBans;
        }

        public bool Add(PhongBan newPB)
        {
            try
            {
                Tbl_PhongBan newRecord = MyConvert.toTbl_PhongBan(newPB);
                DB.Tbl_PhongBans.InsertOnSubmit(newRecord);
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
                Tbl_PhongBan deleteRecord = DB.Tbl_PhongBans.Single(record => record.maPB == deleteID);
                DB.Tbl_PhongBans.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool UpDate(PhongBan updatePB)
        {
            try
            {
                Tbl_PhongBan updateRecord = DB.Tbl_PhongBans.Single(record => record.maPB == updatePB.MaPB);
                updateRecord.maPB = updatePB.MaPB;
                updateRecord.tenPB = updatePB.TenPB;
                updateRecord.diaDiem = updatePB.DiaDiem;
                updateRecord.soDT = updatePB.Sdt;

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
