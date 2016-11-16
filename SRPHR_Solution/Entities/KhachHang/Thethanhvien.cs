using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.KhachHang
{
    public class Thethanhvien
    {
        private string mathe, makh;
        private DateTime ngaylap, ngayhethan;
        private int diemtichluy;
        private float tongtien;
        private string ghichu;

        public DateTime Ngayhethan
        {
            get { return ngayhethan; }
            set { ngayhethan = value; }
        }

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
       

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
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
        public Thethanhvien() { }
        public Thethanhvien(string makh, string mathe, int diemtichluy, float tongtien, DateTime ngaylap,DateTime ngayhethan,string ghichu)
        {
            Makh = makh;
            Mathe = mathe;
            Diemtichluy = diemtichluy;
            Tongtien = tongtien;
            Ngaylap = ngaylap;
            Ngayhethan = ngayhethan;
            Ghichu = ghichu;
                        
        }
    }
}