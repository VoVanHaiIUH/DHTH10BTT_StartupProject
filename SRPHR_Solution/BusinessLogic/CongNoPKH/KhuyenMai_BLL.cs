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
        public static eCTKhuyenMai KhuyenMai(Tbl_CTKhuyenMai tmp)
        {
            return new eCTKhuyenMai(tmp.msDotKM, tmp.maSP, Convert.ToDouble(tmp.phantramKM), tmp.ghiChu);

        }
        public static eKhuyenMai KhuyenMai(Tbl_KhuyenMai tmp)
        {
            return new eKhuyenMai(tmp.msDotKM, tmp.tenDotKM, Convert.ToDateTime(tmp.ngayBD), Convert.ToDateTime(tmp.ngayKT), tmp.ghiChu);

        }
        public List<eCTKhuyenMai> getAllCTKM()
        {
            var ctkm = db.Tbl_CTKhuyenMais.ToList();
            List<eCTKhuyenMai> kq = new List<eCTKhuyenMai>();

            foreach (Tbl_CTKhuyenMai tmp in ctkm)
            {
                eCTKhuyenMai newctkm = new eCTKhuyenMai();
                newctkm.ghiChu = tmp.ghiChu;
                newctkm.maSP = tmp.maSP;
                newctkm.msDotKM = tmp.msDotKM;
                newctkm.phantramKM = tmp.phantramKM;
                kq.Add(newctkm);


            }
            return kq;
        }
        public List<eKhuyenMai> getAllKM()
        {
            var km = db.Tbl_KhuyenMais.ToList();
            List<eKhuyenMai> kq = new List<eKhuyenMai>();
            foreach (Tbl_KhuyenMai tmp in km)
            {
                eKhuyenMai newkm = new eKhuyenMai();
                newkm.ghiChu = tmp.ghiChu;
                newkm.msDotKM = tmp.msDotKM;
                newkm.ngayBD = tmp.ngayBD;
                newkm.ngayKT = tmp.ngayKT;
                newkm.tenDotKM = tmp.tenDotKM;
                kq.Add(newkm);
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

        public int themCTKM(eCTKhuyenMai ctkm)
        {
            var tkm = db.Tbl_CTKhuyenMais.Where(x => x.msDotKM == ctkm.msDotKM).FirstOrDefault();
            if (tkm != null)
                return 0;
            Tbl_CTKhuyenMai p = new Tbl_CTKhuyenMai();
            p.ghiChu = ctkm.ghiChu;
            p.maSP = ctkm.maSP;
            p.msDotKM = ctkm.msDotKM;
            p.phantramKM = ctkm.phantramKM;
            db.Tbl_CTKhuyenMais.InsertOnSubmit(p);
            db.SubmitChanges();
            return 1;
        }


        public void UpDateKhuyenMai(string msDotKM, string tenDotKM, DateTime ngayBD, DateTime ngayKT, string ghiChu)
        {

            var km = db.Tbl_KhuyenMais.Where(x => x.msDotKM == msDotKM);
            //cập nhật dữ liệu
            km.First().msDotKM = msDotKM;
            km.First().tenDotKM = tenDotKM;
            km.First().ngayBD = Convert.ToDateTime(ngayBD);
            km.First().ngayKT = Convert.ToDateTime(ngayKT);
            km.First().ghiChu = ghiChu;
            db.SubmitChanges();
        }

        public void UpDateCTKhuyenMai(string msDotKM, string maSP, double phantramKM, string ghiChu)
        {

            var ctkm = db.Tbl_CTKhuyenMais.Where(x => x.msDotKM == msDotKM);
            //cập nhật dữ liệu
            ctkm.First().msDotKM = msDotKM;
            ctkm.First().msDotKM = msDotKM;
            ctkm.First().phantramKM = Convert.ToDouble(phantramKM);
            ctkm.First().ghiChu = ghiChu;
            db.SubmitChanges();
        }
    }
}
