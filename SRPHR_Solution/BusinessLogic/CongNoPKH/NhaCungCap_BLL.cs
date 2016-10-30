using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.CongNoPKH;

namespace BusinessLogic.CongNoPKH
{
    public class NhaCungCap_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<eNhaCungCap> getAllNCC()
        {
            var ncc = db.Tbl_NhaCungCaps.ToList();
            List<eNhaCungCap> kq = new List<eNhaCungCap>();
            eNhaCungCap p;
            foreach(Tbl_NhaCungCap tmp in ncc)
            {
                p = NhaCungCap(tmp);
                kq.Add(p);
            }
            return kq;
        }   
       
        public int themNCC(eNhaCungCap ncc)
        {
            var nccap = db.Tbl_NhaCungCaps.Where(x => x.maNCC == ncc.maNCC).FirstOrDefault();
            if (nccap != null)
                return 0;
            Tbl_NhaCungCap p = new Tbl_NhaCungCap();
            p.maNCC = ncc.maNCC;
            p.tenNCC = ncc.tenNCC;
            p.diaChi = ncc.diaChi;
            p.sDT = ncc.sDT;
            p.email = ncc.email;
            db.Tbl_NhaCungCaps.InsertOnSubmit(p);
            db.SubmitChanges();
            return 1;
        }
        public int xoa1nhacungcap(eNhaCungCap ncc)
        {
            Tbl_NhaCungCap p = new Tbl_NhaCungCap();
            p = db.Tbl_NhaCungCaps.Where(x => x.maNCC == ncc.maNCC).FirstOrDefault();
            if (p != null)
                return 0;
            p.maNCC = ncc.maNCC;
            p.tenNCC = ncc.tenNCC;
            p.diaChi = ncc.diaChi;
            p.sDT = ncc.sDT;
            p.email = ncc.email;
            db.Tbl_NhaCungCaps.DeleteOnSubmit(p);
            db.SubmitChanges();
            return 1;
        }
        public bool Update(eNhaCungCap ncc)
        {
            try
            {
                Tbl_NhaCungCap update = db.Tbl_NhaCungCaps.Single(tmp => tmp.maNCC == ncc.maNCC);

                update.maNCC = ncc.maNCC;
                update.tenNCC = ncc.tenNCC;
                update.diaChi = ncc.diaChi;
                update.sDT = ncc.sDT;
                update.email = ncc.email;
                
                db.SubmitChanges();

                return true;
            }
            catch { return false; }
        }
         public static eNhaCungCap NhaCungCap(Tbl_NhaCungCap tmp)
        {
            return new eNhaCungCap(tmp.maNCC,tmp.tenNCC,tmp.diaChi,tmp.sDT, tmp.email);
                
        }
        
    }
}
