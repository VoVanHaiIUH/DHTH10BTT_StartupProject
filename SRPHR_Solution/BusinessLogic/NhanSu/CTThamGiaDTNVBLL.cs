using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.NhanSu;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    public class CTThamGiaDTNVBLL
    {
        
        //SRPHRDataContext DB = new SRPHRDataContext();
        DataClasses1DataContext DB = new DataClasses1DataContext();
        public bool Add(CTThamGiaDTNV newCTTGDT)
        {
            try
            {
                //Tbl_CTThamGiaDTNV newRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == newCTTGDT.MaNV && record.maKhoaDT == newCTTGDT.MaKhoaDT);
                Tbl_NhanVien tempnhanvien = DB.Tbl_NhanViens.Single(record => record.maNV == newCTTGDT.MaNV);
                Tbl_CTThamGiaDTNV newRecord = new Tbl_CTThamGiaDTNV();
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
                //Tbl_CTThamGiaDTNV updateRecord = DB.Tbl_CTThamGiaDTNVs.Single(record => record.maNV == updateCTDTNV.MaNV && record.maKhoaDT == updateCTDTNV.MaKhoaDT);
                Tbl_NhanVien tempnhanvien = DB.Tbl_NhanViens.Single(record => record.maNV == updateCTDTNV.MaNV);
                Tbl_CTThamGiaDTNV updateRecord = new Tbl_CTThamGiaDTNV();
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
        public List<CTThamGiaDTNV> GetAllCTDaoTao()
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
        public List<CTThamGiaDTNV> GetCTDaoTaoByMaDaoTao(string madt)
        {
            var dsct = DB.Tbl_CTThamGiaDTNVs.Where(x => x.maKhoaDT == madt).ToList();
            List<CTThamGiaDTNV> ls = new List<CTThamGiaDTNV>();

            foreach (Tbl_CTThamGiaDTNV cttemp in dsct)
            {
                CTThamGiaDTNV ct = new CTThamGiaDTNV();
                ct.MaKhoaDT = cttemp.maKhoaDT;
                ct.MaNV = cttemp.maNV;
                ct.KetQua = cttemp.ketQua;
                ct.NhanXet = cttemp.nhanXet;
                ls.Add(ct);
            }
            return ls;
        }
        public IEnumerable<string> getMaNV()
        {

            var ma = (from cv in DB.Tbl_NhanViens
                      select cv.maNV);
            return ma;
        }
    }
}
