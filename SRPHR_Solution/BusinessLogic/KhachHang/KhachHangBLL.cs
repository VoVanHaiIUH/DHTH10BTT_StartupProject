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
            List<Entities.KhachHang.KhachHang> nhanViens = new List<Entities.KhachHang.KhachHang>();
            Entities.KhachHang.KhachHang tempNV;
            foreach (Tbl_KhachHang record in DB.Tbl_KhachHangs)
            {
                tempNV = Convert.tokhachhang(record);
                nhanViens.Add(tempNV);
            }

            return nhanViens;
        }



        public bool Add(Entities.KhachHang.KhachHang newNV)
        {
            try
            {
                Tbl_KhachHang newRecord = Convert.totbl_khachhang(newNV);

                DB.Tbl_KhachHangs.InsertOnSubmit(newRecord);
                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
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

        public bool Update(Entities.KhachHang.KhachHang updateNV)
        {
            try
            {
                Tbl_KhachHang updateRecord = DB.Tbl_KhachHangs.Single(record => record.maKH == updateNV.Makh);

                updateRecord.maKH = updateNV.Makh;
                updateRecord.tenKH = updateNV.Tenkh;
                updateRecord.diachi = updateNV.Diachi;
                updateRecord.email = updateNV.Email;
                updateRecord.gioitinh = updateNV.Gioitinh;
                updateRecord.ngaycapCMND = updateNV.Ngaycap;
                updateRecord.ngaysinh = updateNV.Ngaysinh;
                updateRecord.nghenghiep = updateNV.Nghenghiep;
                updateRecord.soCMND = updateNV.Socmnn;
                updateRecord.sodienthoai = updateNV.Sodienthoai;
                updateRecord.trangthai = updateNV.Trangthai;

                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
        public bool quydoidiem(Entities.KhachHang.KhachHang kh, string maThe)
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

        
    }
}
