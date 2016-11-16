using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.CongNoPKH;

namespace BussinessLogic
{
    public class HDMuaHangNCC_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<eCTMuahangNCC> getallctMuahangNCC(string ma)
        {
            var r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == ma).ToList();
            List<eCTMuaHangNCC> ct = new List<eCTMuahangNCC>();
            eCTMuahangNCC t;
            foreach (Tbl_CTMuaHangNCC c in r)
            {
                t = e(c);
                ct.Add(t);

            }
            return ct;
        }
        public List<eCTMuahangNCC> getallctMuahangNCC()
        {
            var r = db.Tbl_CTMuaHangNCCs.ToList();
            List<eCTMuahangNCC> ct = new List<eCTMuahangNCC>();
            eCTMuahangNCC t;
            foreach (Tbl_CTMuaHangNCC c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public static eCTMuahangNCC e(Tbl_CTMuaHangNCC p)
        {
            return new eCTMuahangNCC(p.maHD, Convert.ToInt32(p.maSP), Convert.ToInt32(p.soluong), Convert.ToInt32(p.dongiaMua), p.ghichu);
        }
        public List<eHDMuaHangNCC> getallHDMH()
        {
            var r = db.Tbl_HDMuaHangNCCs.ToList();
            List<eHDMuaHangNCC> ct = new List<eHDMuaHangNCC>();
            eHDMuaHangNCC t;
            foreach (Tbl_HDMuaHangNCC c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public static eHDMuaHangNCC e(Tbl_HDMuaHangNCC p)
        {
            return new eHDMuaHangNCC(p.maHD, Convert.ToString(p.ngayLap), p.maNCC, p.maNV, p.noiDung, p.tenHD);
        }
        public int themhd(eHDMuaHangNCC hdmh)
        {
            if (kiemtra(hdmh.maHD))
                return 0;
            Tbl_HDMuaHangNCC n = new Tbl_HDMuaHangNCC();
            n.maHD = hdmh.maHD;
            n.tenHD = hdmh.tenHD;
            n.maNCC = hdmh.maNCC;
            n.maNV = hdmh.maNV;
            n.ngayLap = Convert.ToDateTime(hdmh.ngayLap);
            n.noiDung = hdmh.noidung;
            db.Tbl_HDMuaHangNCCs.InsertOnSubmit(n);
            db.SubmitChanges();
            return 1;
        }
        public int themcthoadon(eCTHDMuahangNCC ctmh)
        {
            if (kiemtract(ctmh.maHD, ctmh.maSP))
            {
                var r = from c in db.Tbl_CTMuaHangNCCs
                        where c.maHD == ctmh.maHD
                        select new { c.soluong };
                int kq = Convert.ToInt32(ctmh.soluong);
                foreach (var k in r) { kq += Convert.ToInt32(k.soluong); }

                IQueryable<Tbl_CTMuaHangNCC> hd1 = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD.Equals(ctmh.maHD) && x.maSP.Equals(ctmh.maSP));
                hd1.First().soluong = kq;
                return 0;
            }
            Tbl_CTMuaHangNCC si = new Tbl_CTMuaHangNCC();
            si.maHD = ctmh.maHD;
            si.maSP = Convert.ToInt32(ctmh.maSP);
            si.soluong = ctmh.soluong;
            si.ghichu = ctmh.ghiChu;
            si.dongiaMua = Convert.ToInt32(ctmh.dongiaMua);
            db.Tbl_CTMuaHangNCCs.InsertOnSubmit(si);
            db.SubmitChanges();
            return 1;

        }
        public bool kiemtract(string hd, int sp)
        {
            Tbl_CTMuaHangNCC r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == hd && x.maSP == Convert.ToInt16(sp)).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }

        public bool kiemtra(string ma)
        {
            Tbl_CTMuaHangNCC r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == ma).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }
        //public bool kiemtra1(string nv, string kh)
        //{
        //    Tbl_CTMuaHangNCC r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == nv && x.maNCC == ncc).FirstOrDefault();
        //    if (r != null)
        //        return true;
        //    return false;
        //}
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
            IQueryable<Tbl_CTMuaHangNCC> hd1 = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD.Equals(hd) && x.maSP.Equals(sp));
            //hd1.First().maNV = hd;
            hd1.First().soluong = Convert.ToInt16(sl);
            hd1.First().dongiaMua = Convert.ToInt32(dg);
            //hd1.First().maNV=m
            hd1.First().ghichu = ghichu;
            return 1;

        }
        public List<eHDMuaHangNCC> Getall1(string hd, string nv, string ncc)
        {
            var r = db.Tbl_HDMuaHangNCCs.Where(x => x.maHD == hd || x.maNCC == ncc || x.maNV == nv).ToList();
            List<eHDMuaHangNCC> ck = new List<eHDMuaHangNCC>();
            eHDMuaHangNCC d;
            foreach (Tbl_HDMuaHangNCC c in r)
            {
                d = e(c);

                ck.Add(d);
            }
            return ck;
        }



    }

    public class eCTMuahangNCC
    {
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace BussinessLogic
{
    public class HDMuaHangNCC_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<eCTHDMuahangNCC> getallctMuahangNCC(string ma)
        {
            var r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == ma).ToList();
            List<eCTHDMuahangNCC> ct = new List<eCTHDMuahangNCC>();
            eCTHDMuahangNCC t;
            foreach (Tbl_CTMuaHangNCC c in r)
            {
                t = e(c);
                ct.Add(t);

            }
            return ct;
        }
        public List<eCTHDMuahangNCC> getallctMuahangNCC()
        {
            var r = db.Tbl_CTMuaHangNCCs.ToList();
            List<eCTHDMuahangNCC> ct = new List<eCTHDMuahangNCC>();
            eCTHDMuahangNCC t;
            foreach (Tbl_CTMuaHangNCC c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public static eCTHDMuahangNCC e(Tbl_CTMuaHangNCC p)
        {
            return new eCTHDMuahangNCC(p.maHD, Convert.ToInt32(p.maSP), Convert.ToInt32(p.soluong), Convert.ToInt32(p.dongiaMua), p.ghichu);
        }
        public List<eHDMuaHangNCC> getallHDMH()
        {
            var r = db.Tbl_HDMuaHangNCCs.ToList();
            List<eHDMuaHangNCC> ct = new List<eHDMuaHangNCC>();
            eHDMuaHangNCC t;
            foreach (Tbl_HDMuaHangNCC c in r)
            {
                t = e(c);
                ct.Add(t);
            }
            return ct;
        }
        public static eHDMuaHangNCC e(Tbl_HDMuaHangNCC p)
        {
            return new eHDMuaHangNCC(p.maHD, Convert.ToString(p.ngayLap), p.maNCC, p.maNV, p.noiDung, p.tenHD);
        }
        public int themhd(eHDMuaHangNCC hdmh)
        {
            if (kiemtra(hdmh.maHD))
                return 0;
            Tbl_HDMuaHangNCC n = new Tbl_HDMuaHangNCC();
            n.maHD = hdmh.maHD;
            n.tenHD = hdmh.tenHD;
            n.maNCC = hdmh.maNCC;
            n.maNV = hdmh.maNV;
            n.ngayLap = Convert.ToDateTime(hdmh.ngayLap);
            n.noiDung = hdmh.noidung;
            db.Tbl_HDMuaHangNCCs.InsertOnSubmit(n);
            db.SubmitChanges();
            return 1;
        }
        public int themcthoadon(eCTHDMuahangNCC ctmh)
        {
            if (kiemtract(ctmh.maHD, ctmh.maSP))
            {
                var r = from c in db.Tbl_CTMuaHangNCCs
                        where c.maHD == ctmh.maHD
                        select new { c.soluong };
                int kq = Convert.ToInt32(ctmh.soluong);
                foreach (var k in r) { kq += Convert.ToInt32(k.soluong); }

                IQueryable<Tbl_CTMuaHangNCC> hd1 = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD.Equals(ctmh.maHD) && x.maSP.Equals(ctmh.maSP));
                hd1.First().soluong = kq;
                return 0;
            }
            Tbl_CTMuaHangNCC si = new Tbl_CTMuaHangNCC();
            si.maHD = ctmh.maHD;
            si.maSP = Convert.ToInt32(ctmh.maSP);
            si.soluong = ctmh.soluong;
            si.ghichu = ctmh.ghiChu;
            si.dongiaMua = Convert.ToInt32(ctmh.dongiaMua);
            db.Tbl_CTMuaHangNCCs.InsertOnSubmit(si);
            db.SubmitChanges();
            return 1;

        }
        public bool kiemtract(string hd, int sp)
        {
            Tbl_CTMuaHangNCC r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == hd && x.maSP == Convert.ToInt16(sp)).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }

        public bool kiemtra(string ma)
        {
            Tbl_CTMuaHangNCC r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == ma).FirstOrDefault();
            if (r != null)
                return true;
            return false;
        }
        //public bool kiemtra1(string nv, string kh)
        //{
        //    Tbl_CTMuaHangNCC r = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD == nv && x.maNCC == ncc).FirstOrDefault();
        //    if (r != null)
        //        return true;
        //    return false;
        //}
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
            IQueryable<Tbl_CTMuaHangNCC> hd1 = db.Tbl_CTMuaHangNCCs.Where(x => x.maHD.Equals(hd) && x.maSP.Equals(sp));
            //hd1.First().maNV = hd;
            hd1.First().soluong = Convert.ToInt16(sl);
            hd1.First().dongiaMua = Convert.ToInt32(dg);
            //hd1.First().maNV=m
            hd1.First().ghichu = ghichu;
            return 1;

        }
        public List<eHDMuaHangNCC> Getall1(string hd, string nv, string ncc)
        {
            var r = db.Tbl_HDMuaHangNCCs.Where(x => x.maHD == hd || x.maNCC == ncc || x.maNV == nv).ToList();
            List<eHDMuaHangNCC> ck = new List<eHDMuaHangNCC>();
            eHDMuaHangNCC d;
            foreach (Tbl_HDMuaHangNCC c in r)
            {
                d = e(c);

                ck.Add(d);
            }
            return ck;
        }



    }
}
