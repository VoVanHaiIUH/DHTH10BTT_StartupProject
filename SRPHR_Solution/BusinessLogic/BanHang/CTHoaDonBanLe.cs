using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.BanHang;


namespace BusinessLogic.BanHang
{
    public class CTHoaDonBanLe
    {
        SRPHRDataContext DB = new SRPHRDataContext();

        public List<ChiTietHoaDonBanLe> GetAllCTHDBanLe()
        {
            var cthdbl = DB.Tbl_CTHDBanLes.ToList();
            List<ChiTietHoaDonBanLe> kq = new List<ChiTietHoaDonBanLe>();
            ChiTietHoaDonBanLe p;
            foreach (Tbl_CTHDBanLe tmp in cthdbl)
            {
                p = CTHDBL(tmp);
                kq.Add(p);
            }
            return kq;
        }

        public int ThemCTHDBanLe(ChiTietHoaDonBanLe cthdbl)
        {
            var cthdbanle = DB.Tbl_CTHDBanLes.Where(x => x.soHoaDon == cthdbl.SoHoaDon).FirstOrDefault();
            if (cthdbanle != null)
                return 0;
            Tbl_CTHDBanLe hd = new Tbl_CTHDBanLe();
            hd.soHoaDon = cthdbl.SoHoaDon;
            hd.maSP = cthdbl.MaSP;
            hd.ghiChu = cthdbl.GhiChu;
            hd.soLuong = cthdbl.SoLuong;
            hd.donGia = cthdbl.DonGia;

            DB.Tbl_CTHDBanLes.InsertOnSubmit(hd);
            DB.SubmitChanges();
            return 1;
        }

        public int XoaCTHDBanLe(ChiTietHoaDonBanLe cthdbl)
        {
            Tbl_CTHDBanLe tbhdbl = new Tbl_CTHDBanLe();
            tbhdbl = DB.Tbl_CTHDBanLes.Where(x => x.soHoaDon == cthdbl.SoHoaDon).FirstOrDefault();
            if (tbhdbl != null)
                return 0;
            tbhdbl.soHoaDon = cthdbl.SoHoaDon;
            tbhdbl.maSP = cthdbl.MaSP;
            tbhdbl.ghiChu = cthdbl.GhiChu;
            tbhdbl.soLuong = cthdbl.SoLuong;
            tbhdbl.donGia = cthdbl.DonGia;

            DB.Tbl_CTHDBanLes.DeleteOnSubmit(tbhdbl);
            DB.SubmitChanges();
            return 1;
        }

        public bool Update(ChiTietHoaDonBanLe cthdbl)
        {
            try
            {
                Tbl_CTHDBanLe update = DB.Tbl_CTHDBanLes.Single(tmp => tmp.soHoaDon == cthdbl.SoHoaDon);

               update.soHoaDon = cthdbl.SoHoaDon;
               update.maSP = cthdbl.MaSP;
               update.ghiChu = cthdbl.GhiChu;
               update.soLuong = cthdbl.SoLuong;
               update.donGia = cthdbl.DonGia;

                DB.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
        public static ChiTietHoaDonBanLe CTHDBL(Tbl_CTHDBanLe tmp)
        {
            return new ChiTietHoaDonBanLe(tmp.soHoaDon, tmp.soLuong, tmp.maSP, tmp.ghiChu, tmp.donGia);

        }
    }
}
