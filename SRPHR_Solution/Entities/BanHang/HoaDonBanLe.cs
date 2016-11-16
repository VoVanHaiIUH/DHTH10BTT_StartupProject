using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BanHang
{
   public class HoaDonBanLe
    {
        private string soHoaDon, maNV, maKH, ghiChu;
        private DateTime ngayBan;
        private decimal tongTien;

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

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public decimal TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public DateTime NgayBan
        {
            get
            {
                return ngayBan;
            }

            set
            {
                ngayBan = value;
            }
        }

        public HoaDonBanLe(string soHoaDon, string maNV, string maKH, string ghiChu, DateTime ngayBan, decimal tongTien)
        {
            soHoaDon = SoHoaDon;
            maKH = MaKH;
            maNV = MaNV;
            ngayBan = NgayBan;
            ghiChu = GhiChu;
            tongTien = TongTien;
        }

        public HoaDonBanLe(string soHoaDon, string maKH, string maNV, string ghiChu, DateTime ngayBan)
        {
            this.soHoaDon = soHoaDon;
            this.maKH = maKH;
            this.maNV = maNV;
            this.ghiChu = ghiChu;
            this.ngayBan = ngayBan;
        }

        public HoaDonBanLe()
        {
        }

        public override bool Equals(object obj)
        {
            HoaDonBanLe hdbl = (HoaDonBanLe)obj;
            return hdbl.Equals(hdbl.soHoaDon);
        }
        public override int GetHashCode()
        {
            return soHoaDon.GetHashCode();
        }
    }
}
