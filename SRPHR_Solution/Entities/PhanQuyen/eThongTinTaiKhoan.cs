using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PhanQuyen
{
    public class eThongTinTaiKhoan
    {
        private string ID, Manv, Nhom ;

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

        public eThongTinTaiKhoan()
        {
            this.ID = "";
            this.Manv = "";
            this.Nhom = "";
           
        }
        public eThongTinTaiKhoan(string Id, string manv, string nhom)
        {
            this.ID = Id;
            this.Manv = manv;
            this.Nhom = nhom;
           
        }
    }
}
