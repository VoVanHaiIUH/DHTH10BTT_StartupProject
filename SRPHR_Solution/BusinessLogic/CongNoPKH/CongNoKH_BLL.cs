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
            return new eCongNoKH(p.soPhieu,p.maKH,Convert.ToString( p.ngayLap), p.maNV);
        }
        public List<eCTCongNoKH> getAllallCNKHbyMKH(string ma)
        {
            var ncc = db.Tbl_CTCongNoKHs.Where(x => x.maKH == ma).ToList();
            List<eCTCongNoKH> kq = new List<eCTCongNoKH>();
            eCTCongNoKH p;
          
            foreach (Tbl_CTCongNoKH tmp in ncc)
            {
                 p=congnoCTkh(tmp);
                kq.Add(p);

            }

            return kq;
        } 
        public static eCTCongNoKH congnoCTkh(Tbl_CTCongNoKH p)
        {
            return new eCTCongNoKH(p.maKH,Convert.ToString(p.sotien),p.soPhieu,p.ghiChu);
        }
        public int tinhcongnoKH(int e)
        {
            int tong=0;
            
            
            foreach(Tbl_CTCongNoKH n in db.Tbl_CTCongNoKHs.ToList())
            {
                n.sotien = tong;
            }

            return tong - e;// e so tien khac hang da tra

        }
    }
}
