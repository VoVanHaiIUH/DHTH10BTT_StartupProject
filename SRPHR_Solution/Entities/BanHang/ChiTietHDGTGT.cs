using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BanHang
{
    public class ChiTietHDGTGT
    {
        public class ChiTietHDGTGT
    {
        private int maHDGTGT, maSP, soLuong, maThue, thueGTGT;

        public int ThueGTGT
        {
            get { return thueGTGT; }
            set { thueGTGT = value; }
        }

        public int MaThue
        {
            get { return maThue; }
            set { maThue = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public int MaHDGTGT
        {
            get { return maHDGTGT; }
            set { maHDGTGT = value; }
        }
        private string tenSP, giamGia, khuyenMai, tenDVMua, diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string TenDVMua
        {
            get { return tenDVMua; }
            set { tenDVMua = value; }
        }

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
        private decimal donGia, thanhTien, tongTien;

        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

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

        public ChiTietHDGTGT (int maHDGTGT, int maSP, int soLuong, int maThue, int thueGTGT, string tenSP, string giamGia, string khuyenMai, string tenDVMua, string diaChi, decimal donGia, decimal tongTien)
        {
            maHDGTGT = MaHDGTGT;
            maSP = MaSP;
            tenSP = TenSP;
            soLuong = SoLuong;
            donGia = DonGia;
            giamGia = GiamGia;
            khuyenMai = KhuyenMai;
            thanhTien = ThanhTien;
            tenDVMua = TenDVMua;
            maThue = MaThue;
            diaChi = DiaChi;
            thueGTGT = ThueGTGT;
            tongTien = TongTien;
        }

        public override bool Equals(object newCTHDGTGT)
        {
            ChiTietHDGTGT cthdgtgt = (ChiTietHDGTGT)newCTHDGTGT;
            return cthdgtgt.Equals(cthdgtgt.maHDGTGT);
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
