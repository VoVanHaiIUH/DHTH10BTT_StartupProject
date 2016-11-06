using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.CongNoPKH;
namespace BusinessLogic.CongNoPKH
{
    public class KhuyenMai_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public eKhuyenMai KhuyenMai(Tbl_KhuyenMai tmp)
        {
            return new eKhuyenMai(tmp.msDotKM, tmp.tenDotKM, tmp.ngayBD, tmp.ngayKT, tmp.ghiChu);

        }
        public List<eKhuyenMai> getAllKM()
        {
            var km = db.Tbl_KhuyenMais.ToList();
            List<eKhuyenMai> kq = new List<eKhuyenMai>();
            eKhuyenMai p;
            foreach (Tbl_KhuyenMai tmp in km)
            {
                p = KhuyenMai(tmp);
                kq.Add(p);
            }
            return kq;
        }
        public int themKM(eKhuyenMai km)
        {
            var tkm = db.Tbl_KhuyenMais.Where(x => x.msDotKM == km.msDotKM).FirstOrDefault();
            if (tkm != null)
                return 0;
            Tbl_KhuyenMai p = new Tbl_KhuyenMai();
            p.msDotKM = km.msDotKM;
            p.tenDotKM = km.tenDotKM;
            p.ngayBD = km.ngayBD;
            p.ngayKT = km.ngayKT;
            p.ghiChu = km.ghiChu;
            db.Tbl_KhuyenMais.InsertOnSubmit(p);
            db.SubmitChanges();
            return 1;
        }

        public int xoa1km(eKhuyenMai km)
        {
            Tbl_KhuyenMai p = new Tbl_KhuyenMai();
            p = db.Tbl_KhuyenMais.Where(x => x.msDotKM == km.msDotKM).FirstOrDefault();
            if (p != null)
                return 0;
            p.msDotKM = km.msDotKM;
            p.tenDotKM = km.tenDotKM;
            p.ngayBD = km.ngayBD;
            p.ngayKT = km.ngayKT;
            p.ghiChu = km.ghiChu;
            db.Tbl_KhuyenMais.DeleteOnSubmit(p);
            db.SubmitChanges();
            return 1;
        }

        public bool Update(eKhuyenMai km)
        {
            try
            {
                Tbl_KhuyenMai update = db.Tbl_KhuyenMais.Single(tmp => tmp.msDotKM == km.msDotKM);

                update.msDotKM = km.msDotKM;
                update.tenDotKM = km.tenDotKM;
                update.ngayBD = km.ngayBD;
                update.ngayKT = km.ngayKT;
                update.ghiChu = km.ghiChu;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
