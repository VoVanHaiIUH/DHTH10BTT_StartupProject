using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    public class CTPQLKho_BLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public List<eCTPhieuQlyKho> getCTPhieuQLKhoTheoMaPhieu(string maphieu)
        {
            var dsctpqlk = DB.Tbl_CTPhieuQLKhos.Where(x => x.maPhieuql == maphieu).ToList();
            List<eCTPhieuQlyKho> ls = new List<eCTPhieuQlyKho>();
            foreach (Tbl_CTPhieuQLKho ctpqlktemp in dsctpqlk)
            {
                eCTPhieuQlyKho ctpqlk = new eCTPhieuQlyKho();
                ctpqlk._maPhieuQly = ctpqlktemp.maPhieuql;
                ctpqlk._maSP = ctpqlktemp.maSP;
                ctpqlk._tenSP = ctpqlktemp.tenSP;
                ctpqlk._sTT = ctpqlktemp.sTT;
                ctpqlk._soLuongQly = Convert.ToInt32(ctpqlktemp.sLuongql);
                ctpqlk._donVi = ctpqlktemp.donVi;
                ls.Add(ctpqlk);
            }
            return ls;

        }

        public bool AddAllCTPQLKho(eCTPhieuQlyKho newctpqlk)
        {
            try
            {
                Tbl_CTPhieuQLKho ctpqlk = DB.Tbl_CTPhieuQLKhos.Single(x => x.maPhieuql == newctpqlk._maPhieuQly && x.maSP == newctpqlk._maSP);
                ctpqlk.maPhieuql = newctpqlk._maPhieuQly;
                ctpqlk.maSP = newctpqlk._maSP;
                ctpqlk.sTT = newctpqlk._sTT;
                ctpqlk.tenSP = newctpqlk._tenSP;
                ctpqlk.sLuongql = newctpqlk._soLuongQly;
                ctpqlk.donVi = newctpqlk._donVi;
                DB.Tbl_CTPhieuQLKhos.InsertOnSubmit(ctpqlk);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCTPQLKho(eCTPhieuQlyKho updatectpqlk)
        {
            try
            {
                Tbl_CTPhieuQLKho ctpqlk = DB.Tbl_CTPhieuQLKhos.Single(x => x.maPhieuql == updatectpqlk._maPhieuQly && x.maSP == updatectpqlk._maSP);
                ctpqlk.tenSP = updatectpqlk._tenSP;
                ctpqlk.sTT = updatectpqlk._sTT;
                ctpqlk.sLuongql = updatectpqlk._soLuongQly;
                ctpqlk.donVi = updatectpqlk._donVi;
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }

}
