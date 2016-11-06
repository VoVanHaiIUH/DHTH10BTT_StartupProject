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
        public List<eCTQLKho> getAllCTPhieuQLKho()
        {
            var dsctpqlk = DB.Tbl_CTPhieuQLKhos.ToList();
            List<eCTQLKho> ls = new List<eCTQLKho>();
            foreach (Tbl_CTPhieuQLKho ctpqlktemp in dsctpqlk)
            {
                eCTQLKho ctpqlk = new eCTQLKho();
                ctpqlk._maPhieuQL = ctpqlktemp.maPhieuql;
                ctpqlk._masp = ctpqlktemp.maSP;
                ctpqlk._tensp = ctpqlktemp.tenSP;
                ctpqlk._sott = ctpqlktemp.sTT;
                ctpqlk._soluongql = ctpqlktemp.sLuongql;
                ctpqlk._donvi = ctpqlktemp.donVi;
                ls.Add(ctpqlk);

            }
            return ls;

        }

        public bool AddAllCTPQLKho(eCTQLKho newctpqlk)
        {
            try
            {
                Tbl_CTPhieuQLKho ctpqlk = DB.Tbl_CTPhieuQLKhos.Single(x => x.maPhieuql == newctpqlk._maPhieuQL && x.maSP == newctpqlk._masp);
                ctpqlk.maPhieuql = newctpqlk._maPhieuQL;
                ctpqlk.maSP = newctpqlk._masp;
                ctpqlk.sTT = newctpqlk._sott;
                ctpqlk.tenSP = newctpqlk._tensp;
                ctpqlk.sLuongql = newctpqlk._soluongql;
                ctpqlk.donVi = newctpqlk._donvi;
                DB.Tbl_CTPhieuQLKhos.InsertOnSubmit(ctpqlk);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCTPhieuQLK(eCTQLKho delid)
        {
            try
            {
                Tbl_CTPhieuQLKho deletema = DB.Tbl_CTPhieuQLKhos.Single(x => x.maPhieuql == delid._maPhieuQL && x.maSP == delid._masp);
                DB.Tbl_CTPhieuQLKhos.DeleteOnSubmit(deletema);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
        public bool UpdateCTPQLKho(eCTQLKho updatectpqlk)
        {
            try
            {
                Tbl_CTPhieuQLKho ctpqlk = DB.Tbl_CTPhieuQLKhos.Single(x => x.maPhieuql == updatectpqlk._maPhieuQL && x.maSP == updatectpqlk._masp);
                ctpqlk.maSP = updatectpqlk._masp;
                ctpqlk.maPhieuql = updatectpqlk._maPhieuQL;
                ctpqlk.tenSP = updatectpqlk._tensp;
                ctpqlk.sTT = updatectpqlk._sott;
                ctpqlk.sLuongql = updatectpqlk._soluongql;
                ctpqlk.donVi = updatectpqlk._donvi;
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
