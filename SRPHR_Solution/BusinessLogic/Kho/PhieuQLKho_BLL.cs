using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    class PhieuQLKho_BLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public List<ePhieuQLiKho> getAllPQLKho()
        {
            var dspqlk = DB.Tbl_PhieuQLKhos.ToList();
            List<ePhieuQLiKho> ls = new List<ePhieuQLiKho>();
            foreach (Tbl_PhieuQLKho temppqlk in dspqlk)
            {
                ePhieuQLiKho pqlk = new ePhieuQLiKho();
                pqlk._maPhieuQli = temppqlk.maPhieuQL;
                pqlk._ngayLapQLi = Convert.ToString(temppqlk.ngayLapQL);
                pqlk._maNV = temppqlk.maNV;
                pqlk._maKho = temppqlk.msKho;
                pqlk._tinhTrang = temppqlk.tinhTrang;
                ls.Add(pqlk);

            }
            return ls;
        }
        public bool AddAllPhieuQLK(ePhieuQLiKho newpqlk)
        {
            try
            {
                Tbl_PhieuQLKho pqlk = DB.Tbl_PhieuQLKhos.Single(x => x.maPhieuQL == newpqlk._maPhieuQli);
                pqlk.maPhieuQL = newpqlk._maPhieuQli;
                pqlk.ngayLapQL = Convert.ToDateTime(newpqlk._ngayLapQLi);
                pqlk.maNV = newpqlk._maNV;
                pqlk.tinhTrang = newpqlk._tinhTrang;
                DB.Tbl_PhieuQLKhos.InsertOnSubmit(pqlk);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeletePhieuQLK(string delid)
        {
            try
            {
                Tbl_PhieuQLKho deletema = DB.Tbl_PhieuQLKhos.Single(x => x.maPhieuQL == delid);
                DB.Tbl_PhieuQLKhos.DeleteOnSubmit(deletema);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpDatePhieuQLK(ePhieuQLiKho updatepqlk)
        {
            try
            {
                Tbl_PhieuQLKho pqlk = DB.Tbl_PhieuQLKhos.Single(x => x.maPhieuQL == updatepqlk._maPhieuQli);
                pqlk.maPhieuQL = updatepqlk._maPhieuQli;
                pqlk.maNV = updatepqlk._maNV;
                pqlk.ngayLapQL = Convert.ToDateTime(updatepqlk._ngayLapQLi);
                pqlk.tinhTrang = updatepqlk._tinhTrang;
                pqlk.msKho = updatepqlk._maKho;
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
