using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eSanPham
    {
         public string maSP { get; set; }
        public string tenSP { get; set; }
        public string moTa { get; set; }
        public DateTime ngaySX { get; set; }
        public DateTime hanSD { get; set; }
        public string tenNhaPP { get; set; }
        public string tenNhaSX { get; set; }
        public int trangthai { get; set; }

        public eSanPham()
        {
            this.hanSD = DateTime.Now;
            this.maSP = "";
            this.moTa = "";
            this.ngaySX = DateTime.Now; ;
            this.tenNhaPP = "";
            this.tenNhaSX = "";
            this.tenSP = "";
            this.trangthai = 1;
        }

        public eSanPham(string masp, string tensp, string mota, DateTime ngaysx, DateTime hansd, string tennhapp, string tennhasx, int trangthai)
        {
            this.hanSD = hansd;
            this.maSP = masp;
            this.moTa = mota;
            this.ngaySX = ngaysx;
            this.tenNhaPP = tennhapp;
            this.tenNhaSX = tennhasx;
            this.tenSP = tensp;
            this.trangthai = trangthai;
        }
        #region Methods
        public override bool Equals(Object newSP)
        {
            eSanPham sp = (eSanPham)newSP;
            return this.maSP.ToLower().Equals(sp.maSP.ToLower());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
    }
}
