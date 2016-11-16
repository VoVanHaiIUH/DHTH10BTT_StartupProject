using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.KhachHang;
using DataAccess;

namespace BusinessLogic.KhachHang
{
    public class KhachHangBLL
    {

       SRPHRDataContext DB = new SRPHRDataContext();
        
        public List<Entities.KhachHang.KhachHang> GetAllKhachHang()
        {
            var dsKH = DB.Tbl_KhachHangs.ToList();
            List<Entities.KhachHang.KhachHang> listKh = new List<Entities.KhachHang.KhachHang>();

            foreach (Tbl_KhachHang kh_DAL in dsKH)
            {
                Entities.KhachHang.KhachHang ekh = new Entities.KhachHang.KhachHang();
                ekh.Makh = kh_DAL.maKH;
                ekh.Tenkh = kh_DAL.tenKH;
                ekh.Diachi = kh_DAL.diachi;
                ekh.Sodienthoai =kh_DAL.sodienthoai;
                ekh.Email = kh_DAL.email;
                ekh.Ngaycapcmnd = Convert.ToDateTime(kh_DAL.ngaycapCMND);
                ekh.Ngaysinh = Convert.ToDateTime(kh_DAL.ngaysinh);
                ekh.Trangthai = kh_DAL.trangthai;
                ekh.Gioitinh = kh_DAL.gioitinh;
                ekh.Nghenghiep = kh_DAL.nghenghiep;
                ekh.Socmnd = kh_DAL.soCMND;

                listKh.Add(ekh);
            }
            return listKh;
        }



        public bool AddKH(Entities.KhachHang.KhachHang kh)
        {
            try
            {
                Tbl_KhachHang newKHRecord =DB.Tbl_KhachHangs.Where(x=>x.maKH==kh.Makh).FirstOrDefault() ;
                if (newKHRecord != null)
                    //return 0;///trường hợp trùng

                newKHRecord = new Tbl_KhachHang();
                newKHRecord.maKH = kh.Makh;
                newKHRecord.tenKH = kh.Tenkh;
                newKHRecord.diachi = kh.Diachi;
                newKHRecord.soCMND = kh.Socmnd;
                newKHRecord.sodienthoai = kh.Sodienthoai;
                newKHRecord.gioitinh = kh.Gioitinh;
                newKHRecord.ngaycapCMND = kh.Ngaycapcmnd;
                newKHRecord.nghenghiep = kh.Nghenghiep;
                newKHRecord.ngaysinh = kh.Ngaysinh;
                newKHRecord.trangthai = kh.Trangthai;
                newKHRecord.email = kh.Email;
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
        public void UpDatekhachhang(string makh, string tenkh, string diachi, string email, string socmnd, string sodienthoai, string nghenghiep, string gioitinh, int trangthai, DateTime ngaycapcmnd, DateTime ngaysinh)
        {

            var khachhhang = DB.Tbl_KhachHangs.Where(x => x.maKH == makh);
            //cập nhật dữ liệu

            khachhhang.First().tenKH = tenkh;
            khachhhang.First().diachi = diachi;
            khachhhang.First().email = email;
            khachhhang.First().soCMND = socmnd;
            khachhhang.First().sodienthoai = sodienthoai;
            khachhhang.First().nghenghiep = nghenghiep;
            khachhhang.First().gioitinh = gioitinh;
            khachhhang.First().ngaycapCMND = Convert.ToDateTime(ngaycapcmnd);
            khachhhang.First().ngaysinh = Convert.ToDateTime(ngaysinh);
            khachhhang.First().trangthai = Convert.ToInt32(trangthai);
            DB.SubmitChanges();

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


        /* public bool quydoidiem(Entities.KhachHang.KhachHang kh, string maThe)
         {
             try
             {

                 Tbl_TheThanhVien ttv = DB.Tbl_TheThanhViens.Single(record => record.maThe == maThe);
                 ///trường hợp chưa có thẻ thành viên
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
         }
         //public bool doithuong(Entities.KhachHang.Thethanhvien ttv)
         //{
         //    if (ttv.Diemtichluy > 200){
         //        Tbl_CTHDBanLe giamgia=new Tbl_CTHDBanLe();

         //    }
         //    else if ()
         //        ;


         //}
         private decimal tinhTongTien()
         {
             throw new NotImplementedException();
         }



         public Entities.KhachHang.KhachHang tempKH { get; set; }*/
    }
}
