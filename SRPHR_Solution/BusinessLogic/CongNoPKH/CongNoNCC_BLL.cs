﻿using System;
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
            return new eCongNoNCC(p.soPhieu,p.maNCC,Convert.ToString( p.ngayLap),p.maNV);
        }
  
        public int tinhcongnoKH(int e)
        {
            int tong = 0;


            foreach (Tbl_CTCongNoNCC n in db.Tbl_CTCongNoNCCs.ToList())
            {
                n.sotien = tong;
            }

            return tong - e;// e so tien Cong ti tra cho nha cung cap

        }
    }
}
