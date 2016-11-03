using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BanHang
{
    public class ChiTietHoaDonBanLe
    {
        private int maHDBanLe, maSP, soLuong;

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int MaHDBanLe
        {
            get { return maHDBanLe; }
            set { maHDBanLe = value; }
        }
        private string tenSP, giamGia, khuyenMai;

        public string KhuyenMai
        {
            get { return khuyenMai; }
            set { khuyenMai = value; }
        }

        public string GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        private decimal donGia, thanhTien;

        public decimal ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public ChiTietHoaDonBanLe(int maHDBanle, int maSP, int soLuong, string tenSP, string giamGia, string khuyenMai, decimal donGia, decimal thanhTien)
        {
            maHDBanLe = MaHDBanLe;
            maSP = MaSP;
            tenSP = TenSP;
            soLuong = SoLuong;
            donGia = DonGia;
            giamGia = GiamGia;
            khuyenMai = KhuyenMai;
            thanhTien = ThanhTien;
        }

        public override bool Equals(object newCTHDBL)
        {
            ChiTietHoaDonBanLe cthdbl = (ChiTietHoaDonBanLe)newCTHDBL;
            return cthdbl.Equals(cthdbl.maHDBanLe);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
