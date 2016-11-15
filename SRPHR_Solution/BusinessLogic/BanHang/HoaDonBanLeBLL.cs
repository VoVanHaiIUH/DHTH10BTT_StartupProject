using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.BanHang;

namespace BusinessLogic.BanHang
{
    public class HoaDonBanLeBLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();

        public List<HoaDonBanLe> GetAllHDBanLe()
        {
            var hdbl = DB.Tbl_HDBanLes.ToList();
            List<HoaDonBanLe> kq = new List<HoaDonBanLe>();
            HoaDonBanLe p;
            foreach (Tbl_HDBanLe tmp in hdbl)
            {
                p = HoaDonBanLe(tmp);
                kq.Add(p);
            }
            return kq;
        }

        public int ThemHDBanLe(HoaDonBanLe hdbl)
        {
            var hdbanle = DB.Tbl_HDBanLes.Where(x => x.soHoaDon == hdbl.SoHoaDon).FirstOrDefault();
            if (hdbanle != null)
                return 0;
            Tbl_HDBanLe hd = new Tbl_HDBanLe();
            hd.soHoaDon = hdbl.SoHoaDon;
            hd.maKH = hdbl.MaKH;
            hd.maNV = hdbl.MaNV;
            hd.ghiChu = hdbl.GhiChu;
            hd.ngayBan = hdbl.NgayBan;

            DB.Tbl_HDBanLes.InsertOnSubmit(hd);
            DB.SubmitChanges();
            return 1;
        }

        public int XoaHDBanLe(HoaDonBanLe hdbl)
        {
            Tbl_HDBanLe tbhdbl = new Tbl_HDBanLe();
            tbhdbl = DB.Tbl_HDBanLes.Where(x => x.soHoaDon == hdbl.SoHoaDon).FirstOrDefault();
            if (tbhdbl != null)
                return 0;
            tbhdbl.soHoaDon = hdbl.SoHoaDon;
            tbhdbl.maKH = hdbl.MaKH;
            tbhdbl.maNV = hdbl.MaNV;
            tbhdbl.ghiChu = hdbl.GhiChu;
            tbhdbl.ngayBan = hdbl.NgayBan;

            DB.Tbl_HDBanLes.DeleteOnSubmit(tbhdbl);
            DB.SubmitChanges();
            return 1;
        }

        public bool Update(HoaDonBanLe hdbl)
        {
            try
            {
                Tbl_HDBanLe update = DB.Tbl_HDBanLes.Single(tmp => tmp.soHoaDon == hdbl.SoHoaDon);

                update.soHoaDon = hdbl.SoHoaDon;
                update.maKH = hdbl.MaKH;
                update.maNV = hdbl.MaNV;
                update.ghiChu = hdbl.GhiChu;
                update.ngayBan = hdbl.NgayBan;

                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }

        public static HoaDonBanLe HoaDonBanLe(Tbl_HDBanLe tmp)
        {
            return new HoaDonBanLe(tmp.soHoaDon, tmp.maKH, tmp.maNV, tmp.ghiChu, tmp.ngayBan);

        }
    }
}
