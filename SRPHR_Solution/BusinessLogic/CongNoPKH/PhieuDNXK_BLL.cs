using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CongNoPKH;
using DataAccess;

namespace BussinessLogic.CongNoPKH
{
    public class PhieuDNXK_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public static ePhieuDNXK PhieuDNXK(Tbl_PhieuDNXK tmp)
        {
            return new ePhieuDNXK(Convert.ToString(tmp.soPDNNK), tmp.maNV, Convert.ToString(tmp.ngayLap), tmp.maKho);

        }
        public List<ePhieuDNXK> getAllPDNXK()
        {
            var PDNXK = db.Tbl_PhieuDNXKs.ToList();
            List<ePhieuDNXK> kq = new List<ePhieuDNXK>();
            ePhieuDNXK p;
            foreach (Tbl_PhieuDNXK tmp in PDNXK)
            {
                p = PhieuDNXK(tmp);
                kq.Add(p);
            }
            return kq;
        }
        public List<eCTPhieuDNXK> getallctpdnxk()
        {
            var r = db.Tbl_CTPhieuDNXKs.ToList();
            List<eCTPhieuDNXK> ct = new List<eCTPhieuDNXK>();
            eCTPhieuDNXK t;
            foreach (Tbl_CTPhieuDNXK c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public static eCTPhieuDNXK e(Tbl_CTPhieuDNXK k)
        {
            return new eCTPhieuDNXK(k.soPDNXK, k.maSP, Convert.ToInt32(k.soluong), k.Ghichu);
        }

        public List<ePhieuDNXK> getallPDNXK()
        {
            var r = db.Tbl_PhieuDNXKs.ToList();
            List<ePhieuDNXK> pDNXK = new List<ePhieuDNXK>();
            ePhieuDNXK p;
            foreach (Tbl_PhieuDNXK c in r)
            {

            }
            return pDNXK;

        }

        public List<eCTPhieuDNXK> getAllPDNXK1(string ma)
        {
            var PDNXK = db.Tbl_CTPhieuDNXKs.Where(x => x.soPDNXK == ma).ToList();
            List<eCTPhieuDNXK> kq = new List<eCTPhieuDNXK>();
            eCTPhieuDNXK p;
            foreach (Tbl_CTPhieuDNXK a in PDNXK)
            {
                p = e(a);
            }

            return kq;
        }

        public int themPDNXK(ePhieuDNXK PDNXK)
        {
            var tPDNXK = db.Tbl_PhieuDNXKs.Where(x => x.soPDNNK == PDNXK.soPDNXK).FirstOrDefault();
            if (tPDNXK != null)
                return 0;
            Tbl_PhieuDNXK p = new Tbl_PhieuDNXK();
            p.soPDNNK = PDNXK.soPDNXK;
            p.maNV = PDNXK.maNV;
            p.ngayLap = Convert.ToDateTime(PDNXK.ngayLap);
            p.maKho = PDNXK.maKho;
            db.Tbl_PhieuDNXKs.InsertOnSubmit(p);
            db.SubmitChanges();
            return 1;
        }
        public int Update(string so, string nglap, string nv, string mk)
        {

            IQueryable<Tbl_PhieuDNXK> update = db.Tbl_PhieuDNXKs.Where(tmp => tmp.soPDNNK.Equals(so) && tmp.maNV.Equals(nv) && tmp.maKho.Equals(mk));

            update.First().ngayLap = Convert.ToDateTime(nglap);

            db.SubmitChanges();
            return 1;


        }
        public int themctpDNXK(eCTPhieuDNXK ctpDNXK)
        {
            if (kiemtractpDNXK(ctpDNXK.soPDNXK, ctpDNXK.maSP))
            {
                var r = from c in db.Tbl_CTPhieuDNXKs
                        where c.maSP == ctpDNXK.maSP
                        select new { c.soluong };
                int kq = Convert.ToInt32(ctpDNXK.soluong);
                foreach (var k in r) { kq += Convert.ToInt32(k.soluong); }
                IQueryable<Tbl_CTPhieuDNXK> DNXK1 = db.Tbl_CTPhieuDNXKs.Where(x => x.soPDNXK.Equals(ctpDNXK.soPDNXK) && x.maSP.Equals(ctpDNXK.maSP));
                DNXK1.First().soluong = kq;
                db.SubmitChanges();
                return 0;
            }
            Tbl_CTPhieuDNXK nhap = new Tbl_CTPhieuDNXK();
            nhap.soPDNXK = ctpDNXK.soPDNXK;
            nhap.maSP = ctpDNXK.maSP;
            nhap.soluong = Convert.ToInt32(ctpDNXK.soluong);
            nhap.Ghichu = ctpDNXK.Ghichu;
            db.Tbl_CTPhieuDNXKs.InsertOnSubmit(nhap);
            db.SubmitChanges();

            return 1;
        }
        public bool kiemtractpDNXK(string spDNXK, string msp)
        {
            Tbl_CTPhieuDNXK r = db.Tbl_CTPhieuDNXKs.Where(x => x.soPDNXK == spDNXK && x.maSP == msp).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }

        public int themctpdnxk(eCTPhieuDNXK n)
        {
            throw new NotImplementedException();
        }

    }
}
