using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.KhachHang;
using DataAccess;

namespace BusinessLogic.KhachHang
{
    public class TheThanhVienBLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();

        public List<eThethanhvien> GetAllTheThanhVien()
        {
            var dsthe = DB.Tbl_TheThanhViens.ToList();
            List<eThethanhvien> listThe = new List<eThethanhvien>();

            foreach (Tbl_TheThanhVien the_DAL in dsthe)
            {
                eThethanhvien ethe = new eThethanhvien();
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

        /* private eThethanhvien eThethanhvien()
         {
             throw new NotImplementedException();
         }*/



        public int AddThe(eThethanhvien the)
        {
            var mathe = DB.Tbl_TheThanhViens.Where(x => x.maThe == the.Makh).FirstOrDefault();
            if (mathe != null)
            {
                return 0;
            }
            Tbl_TheThanhVien khTmp = new Tbl_TheThanhVien();
            khTmp.maThe = the.Mathe;
            khTmp.maKH = the.Makh;
            khTmp.tongTien = Convert.ToDecimal(the.Tongtien);
            khTmp.ngayHetHan = the.Ngayhethan;
            khTmp.ngayLap = the.Ngaylap;
            khTmp.ghiChu = the.Ghichu;

            DB.Tbl_TheThanhViens.InsertOnSubmit(khTmp);
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

        public bool UpdateThe(eThethanhvien updateThe)
        {
            try
            {
                Tbl_TheThanhVien updateRecord = DB.Tbl_TheThanhViens.Single(record => record.maThe == updateThe.Mathe);

                updateRecord.maKH = updateThe.Makh;
                updateRecord.diemTichLuy = Convert.ToInt32(updateThe.Diemtichluy);
                updateRecord.ngayLap = updateThe.Ngaylap;
                updateRecord.ngayHetHan = updateThe.Ngayhethan;
                updateRecord.ghiChu = updateThe.Ghichu;
                updateRecord.tongTien = Convert.ToDecimal(updateThe.Tongtien);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
        public int setDiemTL(string ma, decimal tongTien)
        {

            try
            {
                Tbl_TheThanhVien ttv = DB.Tbl_TheThanhViens.Where(x => x.maThe == ma).FirstOrDefault();
                ttv.tongTien = tongTien;
                ttv.diemTichLuy = Convert.ToInt16(ttv.tongTien / 10000);

                return ttv.diemTichLuy;
            }
            catch (Exception)
            {

                return -1;
            }

        }
        //

        public int setDiemTL1(string ma, int diem)
        {

            try
            {
                Tbl_TheThanhVien ttv = DB.Tbl_TheThanhViens.Where(x => x.maThe == ma).FirstOrDefault();
                ttv.diemTichLuy = diem;
                //ttv.diemTichLuy = Convert.ToInt16(ttv.tongTien / 10000);

                return ttv.diemTichLuy;
            }
            catch (Exception)
            {

                return -1;
            }

        }

    }
}
