using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.KhachHang;
using DataAccess;

namespace BusinessLogic.KhachHang
{
    class TheThanhVienBLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();

        public List<eThethanhvien> GetAllTheThanhVien()
        {
            var dsthe = DB.Tbl_TheThanhViens.ToList();
            List<eThethanhvien> listThe = new List<eThethanhvien>();

            foreach (Tbl_TheThanhVien the_DAL in dsthe)
            {
                eThethanhvien ethe = eThethanhvien();
                ethe.Mathe = the_DAL.maThe;
                ethe.Ngayhethan = Convert.ToDateTime(the_DAL.ngayHetHan);
                ethe.Makh = the_DAL.maKH;
                ethe.Ghichu = the_DAL.ghiChu;
                ethe.Ngaylap = Convert.ToDateTime(the_DAL.ngayLap);
                ethe.Tongtien = (float)the_DAL.tongTien;

                listThe.Add(ethe);
            }
            return listThe;
        }

        private eThethanhvien eThethanhvien()
        {
            throw new NotImplementedException();
        }



        public int AddThe(eThethanhvien the)
        {
            var mathe = DB.Tbl_TheThanhViens.Where(x => x.maThe == the.Makh).FirstOrDefault();
            if (mathe != null)
            {
                return 0;
            }
            Tbl_TheThanhVien khTmp = new Tbl_TheThanhVien();
            khTmp.maThe = the.Mathe

            DB.Tbl_KhachHangs.InsertOnSubmit(khTmp);
            DB.SubmitChanges();
            return 1;
        }

        /*public bool Delete(string deleteID)
        {
            try
            {
                Tbl_KhachHang deleteRecord = DB.Tbl_KhachHangs.Single(record => record.maKH == deleteID);

                DB.Tbl_KhachHangs.DeleteOnSubmit(deleteRecord);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }*/

        public bool UpdateThe(Entities.KhachHang.eThethanhvien updateThe)
        {
            try
            {
                Tbl_TheThanhVien updateRecord = DB.Tbl_TheThanhViens.Single(record => record.maThe == updateThe.Mathe);

                updateRecord.maKH = updateThe.Makh;
                updateRecord.diemTichLuy = updateThe.Diemtichluy;
                updateRecord.ngayLap = updateThe.Ngaylap;
                updateRecord.ngayHetHan = updateThe.Ngayhethan;
                updateRecord.ghiChu = updateThe.Ghichu;
                updateRecord.tongTien = Convert.ToDecimal(updateThe.Tongtien);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
        /* public bool quydoidiem(Entities.KhachHang.eKhachHang kh, string maThe)
         {
             try
             {

                 Tbl_TheThanhVien ttv = DB.Tbl_TheThanhViens.Single(record => record.maThe == maThe);
                 ///tru?ng h?p chua có th? thành viên
                 if (ttv == null)
                 {
                     Tbl_TheThanhVien newTheTV = new Tbl_TheThanhVien();
                     newTheTV.maThe = maThe;
                     newTheTV.maKH = kh.Makh;
                     newTheTV.tongTien = tinhTongTien();

                     newTheTV.diemTichLuy = (int)newTheTV.tongTien / 1000;

                     DB.Tbl_TheThanhViens.InsertOnSubmit(newTheTV);
                     DB.SubmitChanges();
                 }
                 else
                 {
                     ttv.diemTichLuy += (int)tinhTongTien() / 1000;
                     DB.SubmitChanges();
                   
                 }
                 return true;
             }
             catch (Exception)
             {
                 return false;
             }
         }*/
    }
}
