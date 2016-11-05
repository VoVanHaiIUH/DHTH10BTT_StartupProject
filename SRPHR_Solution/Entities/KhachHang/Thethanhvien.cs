using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.KhachHang
{
    public class Thethanhvien
    {
        private string mathe, makh, ngaylap;
        private int diemtichluy;
        private float tongtien;

        public string Mathe
        {
            get
            {
                return mathe;
            }

            set
            {
                mathe = value;
            }
        }

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }

        public string Ngaylap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

        public int Diemtichluy
        {
            get
            {
                return diemtichluy;
            }

            set
            {
                diemtichluy = value;
            }
        }

        public float Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }
        public Thethanhvien(string makh, string mathe, int diemtichluy, float tongtien, string ngaylap)
        {
            Makh = makh;
            Mathe = mathe;
            Diemtichluy = diemtichluy;
            Tongtien = tongtien;
            Ngaylap = ngaylap;
        }
    }
}