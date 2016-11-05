using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PhanQuyen
{
    public class eNhom
    {
        private string IdNhom, TenNhom, PhanQuyen;

        public string IdNhom1
        {
            get { return IdNhom; }
            set { IdNhom = value; }
        }

        public string TenNhom1
        {
            get { return TenNhom; }
            set { TenNhom = value; }
        }

        public string PhanQuyen1
        {
            get { return PhanQuyen; }
            set { PhanQuyen = value; }
        }
        public eNhom()
        {
            this.IdNhom = "";
            this.TenNhom = "";
            this.PhanQuyen = "";
        }
        public eNhom(string idnhom, string tennhom, string phanquyen)
        {
            this.IdNhom = idnhom;
            this.TenNhom = tennhom;
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
