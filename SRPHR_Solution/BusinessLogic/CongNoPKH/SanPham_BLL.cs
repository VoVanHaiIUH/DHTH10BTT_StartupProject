using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CongNoPKH;
using DataAccess;

namespace BusinessLogic.CongNoPKH
{
    public class SanPham_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<eSanPham> getallsanpham()
        {
            var listsp = db.Tbl_SanPhams.ToList();
            List<eSanPham> ls = new List<eSanPham>();
            foreach (Tbl_SanPham sp in listsp)
            {
                eSanPham newsp = new eSanPham();
                newsp.maSP = sp.maSP;
                newsp.tenSP = sp.tenSP;
                newsp.ngaySX = sp.ngaySX.Value;
                newsp.moTa = sp.moTa;
                newsp.hanSD = sp.hanSD.Value;
                newsp.tenNhaPP = sp.tenNhaPP;
                newsp.trangthai = sp.trangThai;
                newsp.tenNhaSX = sp.tenNhaSX;
                ls.Add(newsp);
            }
            return ls;

        }
        public List<eSanPham> getalltim(string masp)
        {
            var listsp = db.Tbl_SanPhams.Where(x => x.maSP == masp).ToList();


            List<eSanPham> ls = new List<eSanPham>();
            foreach (Tbl_SanPham sp in listsp)
            {
                eSanPham newsp = new eSanPham();
                newsp.maSP = sp.maSP;
                newsp.tenSP = sp.tenSP;
                newsp.ngaySX = sp.ngaySX.Value;
                newsp.moTa = sp.moTa;
                newsp.hanSD = sp.hanSD.Value;
                newsp.tenNhaPP = sp.tenNhaPP;
                newsp.trangthai = sp.trangThai;
                newsp.tenNhaSX = sp.tenNhaSX;
                ls.Add(newsp);
            }
            return ls;
        }
        public List<eSanPham> getbymasanpham(string ma)
        {
            var listsp = db.Tbl_SanPhams.Where(x => x.maSP == ma).ToList();
            List<eSanPham> ls = new List<eSanPham>();
            foreach (Tbl_SanPham sp in listsp)
            {
                eSanPham newsp = new eSanPham();
                newsp.maSP = sp.maSP;
                newsp.tenSP = sp.tenSP;
                newsp.ngaySX = sp.ngaySX.Value;
                newsp.moTa = sp.moTa;
                newsp.hanSD = sp.hanSD.Value;
                newsp.tenNhaPP = sp.tenNhaPP;
                newsp.trangthai = sp.trangThai;
                newsp.tenNhaSX = sp.tenNhaSX;
                ls.Add(newsp);
            }
            return ls;
        }

        public int ThemSanPham(eSanPham newsp)
        {
            var masanpham = db.Tbl_SanPhams.Where(x => x.maSP == newsp.maSP).FirstOrDefault();
            if (masanpham != null)
                return 0;
            Tbl_SanPham spTmp = new Tbl_SanPham();
            spTmp.maSP = newsp.maSP;
            spTmp.tenSP = newsp.tenSP;
            spTmp.tenNhaPP = newsp.tenNhaPP;
            spTmp.tenNhaSX = newsp.tenNhaSX;
            spTmp.trangThai = newsp.trangthai;
            spTmp.ngaySX = newsp.ngaySX;
            spTmp.moTa = newsp.moTa;
            spTmp.hanSD = newsp.hanSD;
            db.Tbl_SanPhams.InsertOnSubmit(spTmp);
            db.SubmitChanges();
            return 1;
        }


        public bool checkExisted(string masp)
        {
            Tbl_SanPham sp = db.Tbl_SanPhams.Where(x => x.maSP == masp).FirstOrDefault();
            if (sp == null)
                return true;
            return false;
        }
        public int songay(DateTime d1, DateTime d2)
        {
            TimeSpan Time = d2 - d1;
            return Time.Days;
        }
        public void UpDateSanPham(string masp, string tensp, string mota, DateTime ngaysx, DateTime hansd, string tennhapp, string tennhasx, int trangthai)
        {

            var spham = db.Tbl_SanPhams.Where(x => x.maSP == masp);
            //cập nhật dữ liệu

            spham.First().tenSP = tensp;
            spham.First().moTa = mota;
            spham.First().hanSD = Convert.ToDateTime(hansd);
            spham.First().ngaySX = Convert.ToDateTime(ngaysx);
            spham.First().tenNhaPP = tennhapp;
            spham.First().tenNhaSX = tennhasx;
            spham.First().trangThai = Convert.ToInt32(trangthai);
            db.SubmitChanges();

        }
    }
}
