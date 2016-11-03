using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BanHang
{
   public class HoaDonBanLe
    {
        private int maHDBanLe, maNV, maKH;

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

        public int MaHDBanLe
        {
            get { return maHDBanLe; }
            set { maHDBanLe = value; }
        }
        private DateTime ngayBanLe;

        public DateTime NgayBanLe
        {
            get { return ngayBanLe; }
            set { ngayBanLe = value; }
        }
        private decimal tongTien;

        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public HoaDonBanLe(int maHDBanLe, int maNV, int maKH, DateTime ngayBanLe, decimal tongTien)
        {
            MaHDBanLe = maHDBanLe;
            MaNV = maNV;
            MaKH = maKH;
            NgayBanLe = ngayBanLe;
            TongTien = tongTien;
        }

        public override bool Equals(object newHDBL)
        {
            HoaDonBanLe hdbl = (HoaDonBanLe)newHDBL;
            return hdbl.Equals(hdbl.maHDBanLe);
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
