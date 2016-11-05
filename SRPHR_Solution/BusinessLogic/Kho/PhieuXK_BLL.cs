using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    class PhieuXK_BLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public bool AddAllPhieuNK(ePhieuXK newpxk)
        {
            try
            {
                Tbl_PhieuXK pxk = DB.Tbl_PhieuXKs.Single(x => x.maPhieuXuat == newpxk._maPhieuXuat);
                pxk.maPhieuXuat = newpxk._maPhieuXuat;
                pxk.ngayLapXuat = Convert.ToDateTime(newpxk._ngayLapXuat);
                pxk.maNV = newpxk._maNV;
                pxk.tinhTrang = newpxk._tinhTrang;
                DB.Tbl_PhieuXKs.InsertOnSubmit(pxk);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeletePhieuXK(string delid)
        {
            try
            {
                Tbl_PhieuXK deletema = DB.Tbl_PhieuXKs.Single(x => x.maPhieuXuat == delid);
                DB.Tbl_PhieuXKs.DeleteOnSubmit(deletema);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpDatePhieuNK(ePhieuXK updatepxk)
        {
            try
            {
                Tbl_PhieuXK pxk = DB.Tbl_PhieuXKs.Single(x => x.maPhieuXuat == updatepxk._maPhieuXuat);
                pxk.maPhieuXuat = updatepxk._maPhieuXuat;
                pxk.ngayLapXuat = Convert.ToDateTime(updatepxk._ngayLapXuat);
                pxk.maNV = updatepxk._maNV;
                pxk.tinhTrang = updatepxk._tinhTrang;
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
