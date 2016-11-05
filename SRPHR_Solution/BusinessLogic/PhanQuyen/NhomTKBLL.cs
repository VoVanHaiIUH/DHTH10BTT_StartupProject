using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.PhanQuyen;
using DataAccess;

namespace BusinessLogic.PhanQuyen
{
    public class NhomTKBLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<eNhom> GetAllNhom()
        {
            var tmp = db.Tbl_Nhoms.ToList();
            List<eNhom> ls = new List<eNhom>();
            foreach(Tbl_Nhom  nhom in tmp)
            {
                eNhom e = new eNhom();
                e.IdNhom1 = nhom.IDNhom;
                e.PhanQuyen1 = nhom.Phanquyen;
                e.TenNhom1 = nhom.TenNhom;
                ls.Add(e);

            }
            return ls;
        }
        public string GetPQbyMaNhom(string manhom)
        {
            string s = "";
            var tmp = db.Tbl_Nhoms.Where(x => x.IDNhom == manhom).FirstOrDefault();
            s = tmp.Phanquyen;
            return s;
        }
        public int them1nhom(eNhom nhom)
        {
            var tmp = db.Tbl_Nhoms.Where(x => x.IDNhom == nhom.IdNhom1).FirstOrDefault();
            if (tmp != null)
                return 0;
       
            Tbl_Nhom n = new Tbl_Nhom();
            n.IDNhom = nhom.IdNhom1;
            n.TenNhom = nhom.TenNhom1;
            n.Phanquyen = nhom.PhanQuyen1;
            db.Tbl_Nhoms.InsertOnSubmit(n);
            db.SubmitChanges();

            return 1;
        }
    }
}
