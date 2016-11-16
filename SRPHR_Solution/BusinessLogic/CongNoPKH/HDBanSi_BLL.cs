using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.CongNoPKH;

namespace BussinessLogic
{

    public class HDBanSi_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<eCTHDBanSi> GetallctHDbansi(string ma)
        {
            var r = db.Tbl_CTHDBanSis.Where(x => x.maHD == ma).ToList();
            List<eCTHDBanSi> ct = new List<eCTHDBanSi>();
            eCTHDBanSi t;
            foreach (Tbl_CTHDBanSi c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public List<eCTHDBanSi> GetallctHDbansi1()
        {
            var r = db.Tbl_CTHDBanSis.ToList();
            List<eCTHDBanSi> ct = new List<eCTHDBanSi>();
            eCTHDBanSi t;
            foreach (Tbl_CTHDBanSi c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public static eCTHDBanSi e(Tbl_CTHDBanSi p)
        {
            return new eCTHDBanSi(p.maHD, p.maSP, Convert.ToInt32(p.soluong), Convert.ToString(p.dongiaBan), p.ghiChu);
        }
        public List<eHDBanSi> getallhd()
        {
            var r = db.Tbl_HDBanSis.ToList();
            List<eHDBanSi> ct = new List<eHDBanSi>();
            eHDBanSi t;
            foreach (Tbl_HDBanSi c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }

        public static eHDBanSi e(Tbl_HDBanSi p)
        {
            return new eHDBanSi(p.maHD, Convert.ToString(p.ngayLap), p.maKH, Convert.ToString(p.maNV), p.ghiChu);
        }
        public int themhoadon(eHDBanSi hdbs)
        {

            if (kiemtra(hdbs.maHD))
                return 0;
            Tbl_HDBanSi n = new Tbl_HDBanSi();
            n.maHD = hdbs.maHD;
            n.maKH = hdbs.maKH;
            n.maNV = hdbs.maNV;
            n.ngayLap = Convert.ToDateTime(hdbs.ngayLap);
            n.ghiChu = hdbs.ghiChu;
            db.Tbl_HDBanSis.InsertOnSubmit(n);
            db.SubmitChanges();
            //Tbl_CTHDBanSi si = new Tbl_CTHDBanSi();
            //si.maHD = ctbs.maHD;
            //si.maSP = si.maSP;
            //si.soluong = ctbs.soluong;
            //si.ghiChu = ctbs.ghiChu;
            //si.dongiaBan =Convert.ToInt16(ctbs.dongiaBan);
            //db.Tbl_CTHDBanSis.InsertOnSubmit(si);
            //db.SubmitChanges();
            return 1;


        }
        public int themcthoadon(eCTHDBanSi ctbs)
        {

            if (kiemtract(ctbs.maHD, ctbs.maSP))
            {
                var r = from c in db.Tbl_CTHDBanSis
                        where c.maHD == ctbs.maHD
                        select new { c.soluong };
                int kq = Convert.ToInt32(ctbs.soluong);
                foreach (var k in r) { kq += Convert.ToInt32(k.soluong); }

                IQueryable<Tbl_CTHDBanSi> hd1 = db.Tbl_CTHDBanSis.Where(x => x.maHD.Equals(ctbs.maHD) && x.maSP.Equals(ctbs.maSP));
                //hd1.First().maNV = hd;
                hd1.First().soluong = kq;
                // hd1.First().dongiaBan = Convert.ToInt32(dg);
                //hd1.First().maNV=m
                //hd1.First().ghiChu = ghichu;
                return 0;


            }

            Tbl_CTHDBanSi si = new Tbl_CTHDBanSi();
            si.maHD = ctbs.maHD;
            si.maSP = ctbs.maSP;
            si.soluong = ctbs.soluong;
            si.ghiChu = ctbs.ghiChu;
            si.dongiaBan = Convert.ToInt16(ctbs.dongiaBan);
            db.Tbl_CTHDBanSis.InsertOnSubmit(si);
            db.SubmitChanges();
            return 1;

        }
        public bool kiemtract(string hd, string sp)
        {
            Tbl_CTHDBanSi r = db.Tbl_CTHDBanSis.Where(x => x.maHD == hd && x.maSP == sp).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }

        public bool kiemtra(string ma)
        {
            Tbl_HDBanSi r = db.Tbl_HDBanSis.Where(x => x.maHD == ma).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }
        public bool kiemtra1(string nv, string kh)
        {
            Tbl_HDBanSi r = db.Tbl_HDBanSis.Where(x => x.maNV == nv && x.maKH == kh).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }
        public int capnhat(string hd, string nglap, string mkh, string nv, string ghichu)
        {
            IQueryable<Tbl_HDBanSi> hd1 = db.Tbl_HDBanSis.Where(x => x.maHD.Equals(hd) && x.maKH.Equals(mkh) && x.maNV.Equals(nv));
            //hd1.First().maNV = hd;
            hd1.First().ngayLap = Convert.ToDateTime(nglap);
            //hd1.First().maKH = mkh;
            //hd1.First().maNV=m
            hd1.First().ghiChu = ghichu;
            return 1;



        }
        public int capnhat1(string hd, string sp, string sl, string dg, string ghichu)
        {
            IQueryable<Tbl_CTHDBanSi> hd1 = db.Tbl_CTHDBanSis.Where(x => x.maHD.Equals(hd) && x.maSP.Equals(sp));
            //hd1.First().maNV = hd;
            hd1.First().soluong = Convert.ToInt16(sl);
            hd1.First().dongiaBan = Convert.ToInt32(dg);
            //hd1.First().maNV=m
            hd1.First().ghiChu = ghichu;
            return 1;

        }
        public List<eHDBanSi> Getall(string hd, string nv, string kh)
        {
            var r = db.Tbl_HDBanSis.Where(x => x.maHD == hd || x.maKH == kh || x.maNV == nv).ToList();
            List<eHDBanSi> ck = new List<eHDBanSi>();
            eHDBanSi d = new eHDBanSi();
            foreach (Tbl_HDBanSi c in r)
            {
                d = e(c);

                ck.Add(d);
            }
            return ck;
        }




    }
}
