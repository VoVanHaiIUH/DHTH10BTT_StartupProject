using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.PhanQuyen;
using DataAccess;


namespace BusinessLogic.PhanQuyen
{
    public class TaiKhoanBLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<eTaiKhoan> GetAllTaiKhoan()
        {
            var tmp = db.Tbl_Users.Where(x=>x.ID!="admin").ToList();
            List<eTaiKhoan> lstk = new List<eTaiKhoan>();
            foreach(Tbl_User user in tmp)
            {
                eTaiKhoan tk = new eTaiKhoan();
                tk.ID1 = user.ID;
                tk.Manv1 = user.MaNV;
                tk.Nhom1 = user.Nhom;
                tk.Password1 = user.Password;
                tk.PhanQuyen1 = user.Phanquyen;
                lstk.Add(tk);
            }
            return lstk;
        }
        public int  KiemTraDangNhap(string id,string pass)
        {
            var tmp = db.Tbl_Users.Where(x => x.ID == id && x.Password == pass).FirstOrDefault();
            if (tmp == null)
                return 0;
            else
            {
                if (id == "admin")
                    return 2;
                else
                    return 1;
            }
        }
        public string[] ChuyenChuoithanhmang(string pq)
        {
            string[] str = new string[pq.Length];
            for (int i = 0; i <pq.Length; i++)
            {
                str[i] = pq.Substring(i, 1);
            }
            return str;
        }
        public string Chuyenmangthanhchuoi(string[] str)
        {
            string s = "";
            for (int i = 0; i <str.Length; i++)
            {
                s+=str[i];
            }
            return s;
        }
        public string[] CatNhom6PQ(string s)
        {
            string[] str = new string[s.Length];
            for (int i = 0; i < s.Length; i+=6)
            {
                str[i] = s.Substring(i, 6);
            }
            return str;
        }
        public int ThemPQ(string id,string pq)
        {
            try
            {
                var tmp = db.Tbl_Users.Where(x => x.ID == id).Single();
                tmp.Phanquyen = pq;
                db.SubmitChanges();

                
                return 1;

            }
            catch
            {
                return 0;
            }
        }
        public string GetPQbyID(string id)
        { 
            string pq="";
            var tmp = db.Tbl_Users.Where(x => x.ID == id).Single();
            pq=tmp.Phanquyen ;
            return pq;

        }
    }
}
