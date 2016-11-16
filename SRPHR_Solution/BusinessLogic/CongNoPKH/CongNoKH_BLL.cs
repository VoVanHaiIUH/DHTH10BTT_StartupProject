using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.CongNoPKH;


namespace BusinessLogic.CongNoPKH
{

    public class CongNoKH_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();

        public List<eCongNoKH> getAllallCNKH()
        {
            var ncc = db.Tbl_CongNoKHs.ToList();
            List<eCongNoKH> kq = new List<eCongNoKH>();
            eCongNoKH p;
            foreach (Tbl_CongNoKH tmp in ncc)
            {

                p = congnokh(tmp);

                kq.Add(p);
            }

            return kq;
        }
        public static eCongNoKH congnokh(Tbl_CongNoKH p)
        {
            return new eCongNoKH(p.soPhieu, p.maKH, Convert.ToString(p.ngayLap), p.maNV);
        }
        public List<eCTCongNoKH> getAllallCNKHbyMKH(string ma)
        {
            var ncc = db.Tbl_CTCongNoKHs.Where(x => x.maKH == ma).ToList();
            List<eCTCongNoKH> kq = new List<eCTCongNoKH>();
            eCTCongNoKH p;

            foreach (Tbl_CTCongNoKH tmp in ncc)
            {
                p = congnoCTkh(tmp);
                kq.Add(p);

            }

            return kq;
        }
        public static eCTCongNoKH congnoCTkh(Tbl_CTCongNoKH p)
        {
            return new eCTCongNoKH(p.maKH, Convert.ToString(p.sotien), p.soPhieu, p.ghiChu);
        }
        public int tinhcongnoKH(string ma)
        {
            int kq = 0;

            var r = from c in db.Tbl_CTHDBanSis
                    join d in db.Tbl_HDBanSis
                    on c.maHD equals d.maHD
                    where d.maKH == ma
                    select new
                    {
                        c.soluong,
                        c.dongiaBan,

                    };
            foreach (var k in r)
            {
                kq += Convert.ToInt32(k.soluong) * Convert.ToInt32(k.dongiaBan);


            }

            return kq;


        }

        //public List<eCTCongNoKH> Getallcn()
        //{
        //    List<eCTCongNoKH> kq = new List<eCTCongNoKH>();
        //    var r = from c in db.Tbl_CTCongNoKHs
        //            join a in db.Tbl_HDBanSis
        //            on c.maKH equals a.maKH
        //            select new
        //            {

        //                c.maKH,
        //                c.soPhieu,
        //                c.sotien,
        //                c.ghiChu,


        //            };




        //    foreach (Tbl_CTCongNoKH i in db.Tbl_CTCongNoKHs)
        //    {
        //        i.sotien = tinhcongnoKH(i.maKH);
        //    }



    }

}
