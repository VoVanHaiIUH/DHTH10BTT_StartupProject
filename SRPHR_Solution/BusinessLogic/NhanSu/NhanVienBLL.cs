
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.NhanSu;

namespace BusinessLogic.NhanSu
{
    public class NhanVienBLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            NhanVien tempNV;
            foreach (Tbl_NhanVien record in DB.Tbl_NhanViens)
            {
                tempNV = MyConvert.ToNhanVien(record);
                nhanViens.Add(tempNV);
            }

            return nhanViens;
        }



        public bool Add(NhanVien newNV)
        {
            try
            {
                Tbl_NhanVien newRecord = MyConvert.ToTbl_NhanVien(newNV);

                DB.Tbl_NhanViens.InsertOnSubmit(newRecord);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Delete(string deleteID)
        {
            try
            {
                Tbl_NhanVien deleteRecord = DB.Tbl_NhanViens.Single(record => record.maNV == deleteID);

                DB.Tbl_NhanViens.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Update(NhanVien updateNV)
        {
            try
            {
                Tbl_NhanVien updateRecord = DB.Tbl_NhanViens.Single(record => record.maNV == updateNV.MaNV);

                updateRecord.maNV        = updateNV.MaNV;
                updateRecord.hoTen       = updateNV.HoTen;
                updateRecord.ngaySinh    = updateNV.NgaySinh;
                updateRecord.ngayVaoLam  = updateNV.NgayVaoLam;
                updateRecord.soCMND      = updateNV.SoCMND;
                updateRecord.ngayCapCMND = updateNV.NgayCapCMND;
                updateRecord.gioiTinh    = updateNV.GioiTinh;
                updateRecord.email       = updateNV.Email;
                updateRecord.soDT        = updateNV.SDT;
                updateRecord.diaChi      = updateNV.DiaChi;
                updateRecord.trangThai   = updateNV.TrangThai;

                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
    }
}
