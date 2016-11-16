using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.KhachHang
{
    public class KhachHang
    {

        //record.maKH, record.tenKH, record.diachi,record.email, record.gioitinh, record.ngaycapCMND, 
        //           record.ngaysinh, record.nghenghiep, record.sodienthoai, record.soCMND, record.trangthai
        private string makh, tenkh, diachi, email, socmnd, sodienthoai, nghenghiep, gioitinh;
        private int trangthai;
        private DateTime ngaycapcmnd, ngaysinh;
       

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

        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Socmnd
        {
            get
            {
                return socmnd;
            }

            set
            {
                socmnd = value;
            }
        }


        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
            }
        }

        public string Nghenghiep
        {
            get
            {
                return nghenghiep;
            }

            set
            {
                nghenghiep = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public DateTime Ngaycapcmnd
        {
            get
            {
                return ngaycapcmnd;
            }

            set
            {
                ngaycapcmnd = value;
            }
        }

        public int Trangthai
        {
            get
            {
                return trangthai;
            }

            set
            {
                trangthai = value;
            }
        }

      
   
        public KhachHang(string maKH, string tenKH, string diachi, DateTime ngaysinh, string email, string soCMND, string sodienthoai, int trangthai, DateTime ngaycapcmnd, string gioitinh, string nghenghiep)
        {
            this.Makh = makh;
            this.Tenkh = tenkh;
            this.Diachi = diachi;
            this.Ngaysinh = ngaysinh;
            this.Ngaycapcmnd = ngaycapcmnd;
            this.Trangthai = trangthai;
            this.Nghenghiep = nghenghiep;
            this.Email = email;
            this.Sodienthoai = sodienthoai;
            this.Socmnd = socmnd;
            this.Gioitinh = gioitinh;

        }

        public KhachHang()
        {
            // TODO: Complete member initialization
        }
        public override bool Equals(Object newKH)
        {
            KhachHang nv = (KhachHang)newKH;
            return this.makh.ToLower().Equals(nv.makh.ToLower());
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
