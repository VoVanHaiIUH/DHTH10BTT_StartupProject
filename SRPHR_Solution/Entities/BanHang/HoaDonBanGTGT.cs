using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BanHang
{
      public class HoaDonBanGTGT
    {
        private string soHoaDon, dvBanHang, dvMuaHang, diaChi, hinhThucThanhToan, soTaiKhoan;
        private int msThue;
        private DateTime ngaylapHoaDon;
        private decimal thanhTien;

        public string SoHoaDon
        {
            get
            {
                return soHoaDon;
            }

            set
            {
                soHoaDon = value;
            }
        }

        public string DvBanHang
        {
            get
            {
                return dvBanHang;
            }

            set
            {
                dvBanHang = value;
            }
        }

        public string DvMuaHang
        {
            get
            {
                return dvMuaHang;
            }

            set
            {
                dvMuaHang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string HinhThucThanhToan
        {
            get
            {
                return hinhThucThanhToan;
            }

            set
            {
                hinhThucThanhToan = value;
            }
        }

        public string SoTaiKhoan
        {
            get
            {
                return soTaiKhoan;
            }

            set
            {
                soTaiKhoan = value;
            }
        }

        public int MsThue
        {
            get
            {
                return msThue;
            }

            set
            {
                msThue = value;
            }
        }

        public DateTime NgaylapHoaDon
        {
            get
            {
                return ngaylapHoaDon;
            }

            set
            {
                ngaylapHoaDon = value;
            }
        }

        public decimal ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        public HoaDonBanGTGT(string soHoaDon,string dvBanHang,string dvMuaHang, string diaChi, string hinhThucThanhToan, string soTaiKhoan, int msThue, DateTime ngaylapHoaDon,decimal thanhTien)
        {
            soHoaDon = SoHoaDon;
            dvBanHang = DvBanHang;
            dvMuaHang = DvMuaHang;
            diaChi = DiaChi;
            hinhThucThanhToan = HinhThucThanhToan;
            soTaiKhoan = SoTaiKhoan;
            msThue = MsThue;
            ngaylapHoaDon = NgaylapHoaDon;
            thanhTien = ThanhTien;
        }
        public HoaDonBanGTGT()
        {

        }
        public override bool Equals(object obj)
        {
            HoaDonBanGTGT hdgtgt = (HoaDonBanGTGT)obj;
            return hdgtgt.Equals(hdgtgt.soHoaDon);
        }
        public override int GetHashCode()
        {
            return soHoaDon.GetHashCode();
        }
    }
}
