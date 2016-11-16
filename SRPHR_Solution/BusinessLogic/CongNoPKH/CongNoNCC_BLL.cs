using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.CongNoPKH;

namespace BusinessLogic.CongNoPKH
{
    public class CongNoNCC_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();

        public List<eCongNoNCC> getAllallCNKH()
        {
            var ncc = db.Tbl_CongNoNCCs.ToList();
            List<eCongNoNCC> kq = new List<eCongNoNCC>();
            eCongNoNCC p;
            foreach (Tbl_CongNoNCC tmp in ncc)
            {

                p = congnoNCC(tmp);

                kq.Add(p);
            }

            return kq;
        }
        public static eCongNoNCC congnoNCC(Tbl_CongNoNCC p)
        {
            return new eCongNoNCC(p.soPhieu, p.maNCC, Convert.ToString(p.ngayLap), p.maNV);
        }
        public List<eCTCongNoNCC> getAllCNNCCMbyma(string ma)
        {
            var ncc = db.Tbl_CTCongNoNCCs.Where(x => x.maHD == ma).ToList();
            List<eCTCongNoNCC> kq = new List<eCTCongNoNCC>();
            eCTCongNoNCC p;

            foreach (Tbl_CTCongNoNCC tmp in ncc)
            {
                p = congnoCTkh(tmp);
                kq.Add(p);

            }

            return kq;
        }
        public static eCTCongNoNCC congnoCTkh(Tbl_CTCongNoNCC p)
        {
            return new eCTCongNoNCC(p.soPhieu, p.maHD, Convert.ToString(p.sotien), p.ghiChu);
        }

        public int tinhcongnoncc(string ma)
        {
            int kq = 0;

            var r = from c in db.Tbl_CTMuaHangNCCs
                    join d in db.Tbl_HDMuaHangNCCs
                    on c.maHD equals d.maHD
                    where d.maNCC == ma
                    select new
                    {
                        c.soluong,
                        c.dongiaMua,

                    };
            foreach (var k in r)
            {
                kq += Convert.ToInt32(k.soluong) * Convert.ToInt32(k.dongiaMua);


            }

            return kq;


        }
    }
}
