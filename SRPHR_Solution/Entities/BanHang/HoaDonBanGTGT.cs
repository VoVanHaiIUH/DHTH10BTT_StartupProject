using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BanHang
{
      public class HoaDonBanGTGT
    {
        private int maHDGTGT, maNV, maKH;

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public int MaHDGTGT
        {
            get { return maHDGTGT; }
            set { maHDGTGT = value; }
        }
        private DateTime ngayBan;

        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        private string tenDVBan, tenDVMua;

        public string TenDVMua
        {
            get { return tenDVMua; }
            set { tenDVMua = value; }
        }

        public string TenDVBan
        {
            get { return tenDVBan; }
            set { tenDVBan = value; }
        }
        private decimal thanhTien;

        public decimal ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public HoaDonBanGTGT(int maHDGTGT, int maNV, int maKH, DateTime ngayBan, string tenDVBan, string tenDVMua, decimal thanhTien)
        {
            maHDGTGT = MaHDGTGT;
            maNV = MaNV;
            maKH = MaKH;
            ngayBan = NgayBan;
            tenDVBan = TenDVBan;
            tenDVMua = TenDVMua;
            thanhTien = ThanhTien;
        }

        public override bool Equals(object newHDGTGT)
        {
            HoaDonBanGTGT hdgtgt = (HoaDonBanGTGT)newHDGTGT;
            return hdgtgt.Equals(hdgtgt.maHDGTGT);
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
