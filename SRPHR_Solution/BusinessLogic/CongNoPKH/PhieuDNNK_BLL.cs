using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CongNoPKH;
using DataAccess;

namespace BusinessLogic.CongNoPKH
{
    public class PhieuDNNK_BLL
    {

        SRPHRDataContext db = new SRPHRDataContext();
        public static ePhieuDNNK PhieuDNNK(Tbl_PhieuDNNK tmp)
        {
            return new ePhieuDNNK(Convert.ToString(tmp.soPDNNK), tmp.maNV, Convert.ToString(tmp.ngayLapphieu), tmp.maKho);

        }
        public List<ePhieuDNNK> getAllPDNNK()
        {
            var PDNNK = db.Tbl_PhieuDNNKs.ToList();
            List<ePhieuDNNK> kq = new List<ePhieuDNNK>();
            ePhieuDNNK p;
            foreach (Tbl_PhieuDNNK tmp in PDNNK)
            {
                p = PhieuDNNK(tmp);
                kq.Add(p);
            }
            return kq;
        }
        public List<eCTPhieuDNNK> getallctpnnk()
        {
            var r = db.Tbl_CTPhieuDNNKs.ToList();
            List<eCTPhieuDNNK> ct = new List<eCTPhieuDNNK>();
            eCTPhieuDNNK t;
            foreach (Tbl_CTPhieuDNNK c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public static eCTPhieuDNNK e(Tbl_CTPhieuDNNK k)
        {
            return new eCTPhieuDNNK(k.soPDNNK, k.maSP, Convert.ToInt32(k.soluong), k.ghiChu);
        }

        public List<ePhieuDNNK> getallpdnnk()
        {
            var r = db.Tbl_PhieuDNNKs.ToList();
            List<ePhieuDNNK> pdnnk = new List<ePhieuDNNK>();
            ePhieuDNNK p;
            foreach (Tbl_PhieuDNNK c in r)
            {

            }
            return pdnnk;

        }

        public List<eCTPhieuDNNK> getAllPDNNK1(string ma)
        {
            var PDNNK = db.Tbl_CTPhieuDNNKs.Where(x => x.soPDNNK == ma).ToList();
            List<eCTPhieuDNNK> kq = new List<eCTPhieuDNNK>();
            eCTPhieuDNNK p;
            foreach (Tbl_CTPhieuDNNK a in PDNNK)
            {
                p = e(a);
            }

            return kq;
        }

        public int themPDNNK(ePhieuDNNK PDNNK)
        {
            var tPDNNK = db.Tbl_PhieuDNNKs.Where(x => x.soPDNNK == PDNNK.soPDNNK).FirstOrDefault();
            if (tPDNNK != null)
                return 0;
            Tbl_PhieuDNNK p = new Tbl_PhieuDNNK();
            p.soPDNNK = PDNNK.soPDNNK;
            p.maNV = PDNNK.maNV;
            p.ngayLapphieu = Convert.ToDateTime(PDNNK.ngayLapphieu);
            p.maKho = PDNNK.maKho;
            db.Tbl_PhieuDNNKs.InsertOnSubmit(p);
            db.SubmitChanges();
            return 1;
        }
        public int Update(string so, string nglap, string nv, string mk)
        {

            IQueryable<Tbl_PhieuDNNK> update = db.Tbl_PhieuDNNKs.Where(tmp => tmp.soPDNNK.Equals(so) && tmp.maNV.Equals(nv) && tmp.maKho.Equals(mk));

            update.First().ngayLapphieu = Convert.ToDateTime(nglap);

            db.SubmitChanges();
            return 1;


        }
        public int themctpdnnk(eCTPhieuDNNK ctpdnnk)
        {
            if (kiemtractpdnnk(ctpdnnk.soPDNXK, ctpdnnk.maSP))
            {
                var r = from c in db.Tbl_CTPhieuDNNKs
                        where c.maSP == ctpdnnk.maSP
                        select new { c.soluong };
                int kq = Convert.ToInt32(ctpdnnk.soluong);
                foreach (var k in r) { kq += Convert.ToInt32(k.soluong); }
                IQueryable<Tbl_CTPhieuDNNK> dnnk1 = db.Tbl_CTPhieuDNNKs.Where(x => x.soPDNNK.Equals(ctpdnnk.soPDNXK) && x.maSP.Equals(ctpdnnk.maSP));
                dnnk1.First().soluong = kq;
                db.SubmitChanges();
                return 0;
            }
            Tbl_CTPhieuDNNK nhap = new Tbl_CTPhieuDNNK();
            nhap.soPDNNK = ctpdnnk.soPDNXK;
            nhap.maSP = ctpdnnk.maSP;
            nhap.soluong = Convert.ToInt32(ctpdnnk.soluong);
            nhap.ghiChu = ctpdnnk.Ghichu;
            db.Tbl_CTPhieuDNNKs.InsertOnSubmit(nhap);
            db.SubmitChanges();

            return 1;
        }
        public bool kiemtractpdnnk(string spdnnk, string msp)
        {
            Tbl_CTPhieuDNNK r = db.Tbl_CTPhieuDNNKs.Where(x => x.soPDNNK == spdnnk && x.maSP == msp).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }
    }
}