using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.KhachHang;
using DataAccess;

namespace BusinessLogic.KhachHang
{
    public class Convert
    {
        public static Entities.KhachHang.KhachHang tokhachhang(Tbl_KhachHang record)
        {
            return new Entities.KhachHang.KhachHang(record.maKH, record.tenKH, record.diachi, record.ngaysinh, record.email, record.soCMND,
                record.sodienthoai, record.trangthai, record.ngaycapCMND, record.gioitinh, record.nghenghiep);
        }
        public static Tbl_KhachHang totbl_khachhang(Entities.KhachHang.KhachHang nhanvien)
        {
            Tbl_KhachHang record = new Tbl_KhachHang();

            record.maKH = nhanvien.Makh;
            record.tenKH = nhanvien.Tenkh;
            record.diachi = nhanvien.Diachi;
            record.ngaysinh = nhanvien.Ngaysinh;
            record.email = nhanvien.Email;
            record.soCMND = nhanvien.Socmnn;
            record.sodienthoai = nhanvien.Sodienthoai;
            record.trangthai = nhanvien.Trangthai;
            record.ngaycapCMND = nhanvien.Ngaycap;
            record.gioitinh = nhanvien.Gioitinh;
            record.nghenghiep = nhanvien.Nghenghiep;

            return record;
        }
    }
}
