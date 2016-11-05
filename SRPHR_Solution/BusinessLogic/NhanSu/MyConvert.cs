using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.NhanSu;
using Entities.NhanSu;
using DataAccess;
namespace BusinessLogic.NhanSu
{
    public class myconvert
    {
        #region convert to entities
        public static NhanVien tonhanvien(Tbl_NhanVien record)
        {
            return new NhanVien(record.maNV, record.hoTen, record.ngaySinh, record.ngayVaoLam, record.soCMND, record.ngayCapCMND,
                record.gioiTinh, record.email, record.soDT, record.diaChi, record.trangThai.Value);
        }

        public static PhongBan tophongban(Tbl_PhongBan record)
        {
            return new PhongBan(record.maPB, record.tenPB, record.diaDiem, record.soDT);
        }

        public static ChucVu tochucvu(Tbl_ChucVu record)
        {
            return new ChucVu(record.maChucVu, record.tenCV, record.heSo, record.ghiChu);
        }

        public static KyLuat tokyluat(Tbl_KyLuatNV record)
        {
            return new KyLuat(record.maKyLuat, record.hinhThucKL, record.ghiChu);
        }
        public static DaoTao todaotao(Tbl_DaoTaoNV record)
        {
            return new DaoTao(record.maKhoaDT, record.tenKhoaDT, record.ngayBD, record.ngayKT, record.diaDiem, record.hinhthucDT, (decimal)record.chiPhi);
        }
        #endregion

        #region convert to objects of database
        public static Tbl_NhanVien totbl_nhanvien(NhanVien nhanvien)
        {
            Tbl_NhanVien record = new Tbl_NhanVien();

            record.maNV = nhanvien.MaNV;
            record.hoTen = nhanvien.HoTen;
            record.ngaySinh = nhanvien.NgaySinh;
            record.ngayVaoLam = nhanvien.NgayVaoLam;
            record.soCMND = nhanvien.SoCMND;
            record.ngayCapCMND = nhanvien.NgayCapCMND;
            record.gioiTinh = nhanvien.GioiTinh;
            record.email = nhanvien.Email;
            record.soDT = nhanvien.SDT;
            record.diaChi = nhanvien.DiaChi;
            record.trangThai = nhanvien.TrangThai;

            return record;
        }

        public static Tbl_PhongBan totbl_phongban(PhongBan phongban)
        {
            Tbl_PhongBan record = new Tbl_PhongBan();
            record.maPB = phongban.MaPB;
            record.tenPB = phongban.TenPB;
            record.diaDiem = phongban.DiaDiem;
            record.soDT = phongban.Sdt;

            return record;
        }

        public static Tbl_ChucVu totbl_chucvu(ChucVu chucvu)
        {
            Tbl_ChucVu record = new Tbl_ChucVu();
            record.maChucVu = chucvu.MaCV;
            record.tenCV = chucvu.TenCV;
            record.heSo = chucvu.HeSo;
            record.ghiChu = chucvu.GhiChu;

            return record;
        }

        public static Tbl_KyLuatNV totbl_kyluat(KyLuat kyluat)
        {
            Tbl_KyLuatNV record = new Tbl_KyLuatNV();
            record.maKyLuat = kyluat.MaKL;
            record.hinhThucKL = kyluat.HinhThucKL;
            record.ghiChu = kyluat.GhiChu;
            return record;
        }

        public static Tbl_DaoTaoNV totbl_daotao(DaoTao daotao)
        {
            Tbl_DaoTaoNV record = new Tbl_DaoTaoNV();
            record.maKhoaDT = daotao.MaKhoaDT;
            record.tenKhoaDT = daotao.TenKhoaDT;
            record.ngayBD = daotao.NgayBD;
            record.ngayKT = daotao.NgayKT;
            record.diaDiem = daotao.Diadiem;
            record.hinhthucDT = daotao.HinhThucDT;
            record.chiPhi = record.chiPhi;
            return record;
        }
        #endregion

    }
}
