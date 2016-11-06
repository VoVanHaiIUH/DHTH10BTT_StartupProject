using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    puclic class PhieuNK_BLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public bool AddAllPhieuNK(ePhieuNK newpnk)
        {
            try
            {
                Tbl_PhieuNK pnk = DB.Tbl_PhieuNKs.Single(x => x.maPhieuNhap == newpnk._maPhieuNhap);
                pnk.maPhieuNhap = newpnk._maPhieuNhap;
                pnk.ngayLapNhap = Convert.ToDateTime(newpnk._ngayLapNhap);
                pnk.maNV = newpnk._maNV;
                pnk.msKho = newpnk._msKho;
                pnk.tinhTrang = newpnk._tinhTrang;
                DB.Tbl_PhieuNKs.InsertOnSubmit(pnk);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeletePhieuNK(string delid)
        {
            try
            {
                Tbl_PhieuNK deletema = DB.Tbl_PhieuNKs.Single(x => x.maPhieuNhap == delid);
                DB.Tbl_PhieuNKs.DeleteOnSubmit(deletema);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpDatePhieuNK(ePhieuNK updatepnk)
        {
            try
            {
                Tbl_PhieuNK pnk = DB.Tbl_PhieuNKs.Single(x => x.maPhieuNhap == updatepnk._maPhieuNhap);
                pnk.maPhieuNhap = updatepnk._maPhieuNhap;
                pnk.ngayLapNhap = Convert.ToDateTime(updatepnk._ngayLapNhap);
                pnk.maNV = updatepnk._maNV;
                pnk.msKho = updatepnk._msKho;
                pnk.tinhTrang = updatepnk._tinhTrang;
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
