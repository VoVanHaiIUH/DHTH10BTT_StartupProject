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

        public List<Entities.KhachHang.eKhachHang> GetAllKhachHang()
        {
            var dsKH = DB.Tbl_KhachHangs.ToList();
            List<Entities.KhachHang.eKhachHang> listKh = new List<Entities.KhachHang.eKhachHang>();

            foreach (Tbl_KhachHang kh_DAL in dsKH)
            {
                Entities.KhachHang.eKhachHang ekh = new Entities.KhachHang.eKhachHang();
                ekh.Makh = kh_DAL.maKH;
                ekh.Tenkh = kh_DAL.tenKH;
                ekh.Diachi = kh_DAL.diachi;
                ekh.Sodienthoai = kh_DAL.sodienthoai;
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



        public int AddKH(eKhachHang kh)
        {

            var makhachhang = DB.Tbl_KhachHangs.Where(x => x.maKH == kh.Makh).FirstOrDefault();
            if (makhachhang != null)
            {
                return 0;
            }
            Tbl_KhachHang khTmp = new Tbl_KhachHang();
            khTmp.maKH = kh.Makh;
            khTmp.tenKH = kh.Tenkh;
            khTmp.diachi = kh.Diachi;
            khTmp.soCMND = kh.Socmnd;
            khTmp.sodienthoai = kh.Sodienthoai;
            khTmp.gioitinh = kh.Gioitinh;
            khTmp.ngaycapCMND = kh.Ngaycapcmnd;
            khTmp.nghenghiep = kh.Nghenghiep;
            khTmp.ngaysinh = kh.Ngaysinh;
            khTmp.trangthai = kh.Trangthai;
            khTmp.email = kh.Email;

            DB.Tbl_KhachHangs.InsertOnSubmit(khTmp);
            DB.SubmitChanges();
            return 1;



        }


        public bool UpDatekhachhang(eKhachHang kh)
        {
            try
            {
                Tbl_KhachHang update = DB.Tbl_KhachHangs.Single(tmp => tmp.maKH == kh.Makh);

                update.maKH = kh.Makh;
                update.tenKH = kh.Tenkh;
                update.diachi = kh.Diachi;
                update.email = kh.Email;
                update.gioitinh = kh.Gioitinh;
                update.nghenghiep = kh.Nghenghiep;
                update.soCMND = kh.Socmnd;
                update.sodienthoai = kh.Sodienthoai;
                update.trangthai = kh.Trangthai;
                update.ngaycapCMND = kh.Ngaycapcmnd;
                update.ngaysinh = kh.Ngaysinh;

                DB.SubmitChanges();

                return true;

            }

            catch { return false; }
        }


        /*  public void UpDatekhachhang(string makh, string tenkh, string diachi, string email, string socmnd, string sodienthoai, string nghenghiep, string gioitinh, int trangthai, DateTime ngaycapcmnd, DateTime ngaysinh)
          {

              var khachhhang = DB.Tbl_KhachHangs.Where(x => x.maKH == makh);
              //cập nhật dữ liệu

              khachhhang.FirstOrDefault().tenKH = tenkh;
              khachhhang.FirstOrDefault().diachi = diachi;
              khachhhang.FirstOrDefault().email = email;
              khachhhang.FirstOrDefault().soCMND = socmnd;
              khachhhang.FirstOrDefault().sodienthoai = sodienthoai;
              khachhhang.FirstOrDefault().nghenghiep = nghenghiep;
              khachhhang.FirstOrDefault().gioitinh = gioitinh;
              khachhhang.FirstOrDefault().ngaycapCMND = Convert.ToDateTime(ngaycapcmnd);
              khachhhang.FirstOrDefault().ngaysinh = Convert.ToDateTime(ngaysinh);
              khachhhang.FirstOrDefault().trangthai = Convert.ToInt32(trangthai);
              DB.SubmitChanges();

          }

          /*   public bool quydoidiem(Entities.KhachHang.eKhachHang kh, string maThe)
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
             }*/
        //public bool doithuong(Entities.KhachHang.Thethanhvien ttv)
        //{
        //    if (ttv.Diemtichluy > 200){
        //        Tbl_CTHDBanLe giamgia=new Tbl_CTHDBanLe();

        //    }
        //    else if ()
        //        ;


        //}




    }
}
