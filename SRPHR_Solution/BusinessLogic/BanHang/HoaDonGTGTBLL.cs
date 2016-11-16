using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.BanHang;
using DataAccess;

namespace BusinessLogic.BanHang
{
   public class HoaDonGTGTBLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();

        public List<HoaDonBanGTGT> GetAllHDBGTGT()
        {
            var updatebgtgt = DB.Tbl_HD_GTGTs.ToList();
            List<HoaDonBanGTGT> kq = new List<HoaDonBanGTGT>();

            foreach (Tbl_HD_GTGT tmp in updatebgtgt)
            {
                HoaDonBanGTGT p = new HoaDonBanGTGT();
                p.MsThue = tmp.msThue;
                p.HinhThucThanhToan = tmp.hinhthucThanhToan;
                p.NgaylapHoaDon = tmp.ngaylapHoaDon;
                p.SoHoaDon = tmp.soHoaDon;
                p.SoTaiKhoan = tmp.soTaiKhoan;
                p.ThanhTien = tmp.thanhTien;
                p.DvBanHang = tmp.dvBanHang;
                p.DvMuaHang = tmp.dvMuaHang;
                p.DiaChi = tmp.diaChi;
                kq.Add(p);
            }
            return kq;
        }
        public int ThemHDGTGT(HoaDonBanGTGT updategtgt)
        {
            var updategtgiatang = DB.Tbl_HD_GTGTs.Where(x => x.soHoaDon == Convert.ToString(updategtgt.SoHoaDon)).FirstOrDefault();
            if (updategtgiatang != null)
                return 0;
            Tbl_HD_GTGT update = new Tbl_HD_GTGT();
            update.soHoaDon = updategtgt.SoHoaDon;
            update.dvBanHang = updategtgt.DvBanHang;
            update.dvMuaHang = updategtgt.DvMuaHang;
            update.diaChi = updategtgt.DiaChi;
            update.hinhthucThanhToan = updategtgt.HinhThucThanhToan;
            update.soTaiKhoan = updategtgt.SoTaiKhoan;
            update.msThue = updategtgt.MsThue;
            update.ngaylapHoaDon = updategtgt.NgaylapHoaDon;
            update.thanhTien = updategtgt.ThanhTien;

            DB.Tbl_HD_GTGTs.InsertOnSubmit(update);
            DB.SubmitChanges();
            return 1;

        }
        public bool Update(HoaDonBanGTGT updategtgt)
        {
            try
            {
                Tbl_HD_GTGT update = DB.Tbl_HD_GTGTs.Single(tmp => tmp.soHoaDon == updategtgt.SoHoaDon);

                update.soHoaDon = updategtgt.SoHoaDon;
                update.dvBanHang = updategtgt.DvBanHang;
                update.dvMuaHang = updategtgt.DvMuaHang;
                update.diaChi = updategtgt.DiaChi;
                update.hinhthucThanhToan = updategtgt.HinhThucThanhToan;
                update.soTaiKhoan = updategtgt.SoTaiKhoan;
                update.msThue = updategtgt.MsThue;
                update.ngaylapHoaDon = updategtgt.NgaylapHoaDon;
                update.thanhTien = updategtgt.ThanhTien;

                DB.SubmitChanges();

                return true;

            }

            catch { return false; }
        }

        public static HoaDonBanGTGT HoaDonBanGTGT(Tbl_HD_GTGT tmp)
        {
            return new HoaDonBanGTGT(tmp.soHoaDon, tmp.dvBanHang, tmp.dvMuaHang, tmp.diaChi, tmp.hinhthucThanhToan, tmp.soTaiKhoan, tmp.msThue, tmp.ngaylapHoaDon, tmp.thanhTien);
        }

        public bool xoaclgd(HoaDonBanGTGT delid)
        {
            try
            {
                Tbl_HD_GTGT deletema = DB.Tbl_HD_GTGTs.Single(x => x.soHoaDon == delid.SoHoaDon);
                DB.Tbl_HD_GTGTs.DeleteOnSubmit(deletema);
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
