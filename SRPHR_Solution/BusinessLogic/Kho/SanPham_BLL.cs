using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    class SanPham_BLL
    {
         SRPHRDataContext DB = new SRPHRDataContext();
        public bool AddAllSanPham(eSanPham newsp)
        {
            try
            {
                Tbl_SanPham sp = DB.Tbl_SanPhams.Single(x => x.maSP == newsp._maSP);
                sp.maSP=newsp._maSP;
                sp.hanSD = Convert.ToDateTime(newsp._hanSD);
                sp.ngaySX = Convert.ToDateTime(newsp._ngaySX);
                sp.tenNhaPP= newsp._tenNhaPP;
                sp.tenSP = newsp._teSP;
                sp.tenNhaSX = newsp._tenNhaSX;
                sp.trangThai = newsp._trangthai;
                DB.Tbl_SanPhams.InsertOnSubmit(sp);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
       

        public bool DeleteSanPham(string delid)
        {
            try
            {
                Tbl_SanPham deletema = DB.Tbl_SanPhams.Single(x => x.maSP == delid);
                DB.Tbl_SanPhams.DeleteOnSubmit(deletema);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpDateSanPham(eSanPham updatesp)
        {
            try
            {
                Tbl_SanPham sp = DB.Tbl_SanPhams.Single(x => x.maSP == updatesp._maSP);
                sp.maSP = updatesp._maSP;
                sp.hanSD = Convert.ToDateTime(updatesp._hanSD);
                sp.ngaySX = Convert.ToDateTime(updatesp._ngaySX);
                sp.tenNhaPP= updatesp._tenNhaPP;
                sp.tenSP = updatesp._teSP;
                sp.tenNhaSX = updatesp._tenNhaSX;
                sp.trangThai = updatesp._trangthai;
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
}
