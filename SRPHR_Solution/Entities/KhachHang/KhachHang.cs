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
        private string makh, tenkh, diachi, email, socmnn, sodienthoai, nghenghiep, gioitinh;
        private int trangthai;
        private DateTime ngaycap, ngaysinh;
        private DateTime? ngaysinh1;
        private string soCMND;
        private DateTime? ngaycapCMND;

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

        public string Socmnn
        {
            get
            {
                return socmnn;
            }

            set
            {
                socmnn = value;
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

        public DateTime Ngaycap
        {
            get
            {
                return ngaycap;
            }

            set
            {
                ngaycap = value;
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

        public KhachHang()
        {
            Makh = "";
            Tenkh = "";
            Diachi = "";
            Email = "";
            Socmnn = "";
            Sodienthoai = "";
            trangthai = 0;
            nghenghiep = "";
            gioitinh = "";
        }
        public KhachHang(string makh, string tenkh, string diachi, DateTime ngaysinh, string email, string socmnn, string dienthoai, int trangthai, DateTime ngaycap, string gioitinh, string nghenghiep)
        {

            Makh = makh;
            Tenkh = tenkh;
            Diachi = diachi;
            Ngaysinh = ngaysinh;
            Email = email;
            Socmnn = socmnn;
            Sodienthoai = sodienthoai;
            trangthai = Trangthai;
            ngaycap = Ngaycap;
            gioitinh = Gioitinh;
            nghenghiep = Nghenghiep;
        }

        public KhachHang(string maKH, string tenKH, string diachi, DateTime? ngaysinh1, string email, string soCMND, string sodienthoai, int trangthai, DateTime? ngaycapCMND, string gioitinh, string nghenghiep)
        {
            makh = maKH;
            tenkh = tenKH;
            this.diachi = diachi;
            this.ngaysinh1 = ngaysinh1;
            this.email = email;
            this.soCMND = soCMND;
            this.sodienthoai = sodienthoai;
            this.trangthai = trangthai;
            this.ngaycapCMND = ngaycapCMND;
            this.gioitinh = gioitinh;
            this.nghenghiep = nghenghiep;
        }
    }
}
