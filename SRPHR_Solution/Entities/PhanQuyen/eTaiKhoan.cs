using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PhanQuyen
{
     public class eTaiKhoan
    {
        private string ID, Manv, Nhom, Password, PhanQuyen;

        public string ID1
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Manv1
        {
            get { return Manv; }
            set { Manv = value; }
        }

        public string Nhom1
        {
            get { return Nhom; }
            set { Nhom = value; }
        }

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
        }

        public string PhanQuyen1
        {
            get { return PhanQuyen; }
            set { PhanQuyen = value; }
        }
        public eTaiKhoan()
        {
            this.ID = "";
            this.Manv = "";
            this.Nhom = "";
            this.Password = "";
            //6bit 0 dau tien luu gia tri all chuc nang
            //moi 6bit tiep theo luu chuc nang cua tung form  
            this.PhanQuyen = "000000000000000000000000000000";
        }
         public eTaiKhoan(string Id,string manv,string nhom,string pass,string phanquyen)
        {
            this.ID = Id;
            this.Manv = manv;
            this.Nhom = nhom;
            this.Password = pass;
            this.PhanQuyen = phanquyen;
        }
         public override bool Equals(object obj)
         {
             return base.Equals(obj);
         }
         public override string ToString()
         {
             return base.ToString();
         }
        
    }
}
