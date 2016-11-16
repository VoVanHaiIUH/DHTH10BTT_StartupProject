using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    public class PhieuQLKho_BLL
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
                pqlk._ngayLapQLi = temppqlk.ngayLapQL.Value;
                pqlk._maNV = temppqlk.maNV;
                pqlk._maKho = temppqlk.msKho;
                pqlk._tinhTrang = temppqlk.tinhTrang;
                ls.Add(pqlk);
            }
            return ls;
        }
        public int AddAllPhieuQLK(ePhieuQLiKho newpqlk)
        {
            if (Kiemtrasutontai(newpqlk._maPhieuQli))
                return 0;
            Tbl_PhieuQLKho pqlk = new Tbl_PhieuQLKho();
            pqlk.maPhieuQL = newpqlk._maPhieuQli;
            pqlk.ngayLapQL = newpqlk._ngayLapQLi;
            pqlk.maNV = newpqlk._maNV;
            pqlk.tinhTrang = newpqlk._tinhTrang;
            pqlk.msKho = newpqlk._maKho;
            DB.Tbl_PhieuQLKhos.InsertOnSubmit(pqlk);
            DB.SubmitChanges();
            return 1;
        }

        public bool Kiemtrasutontai(string map)
        {
            Tbl_PhieuQLKho qlk = DB.Tbl_PhieuQLKhos.Where(x => x.maPhieuQL == map).FirstOrDefault();
            if (qlk == null)
                return false;
            return true;
        }
        public void UpDatePhieuQLK(string maphieu, string manv, string makho, string tinhtrang, DateTime ngaylap)
        {
            IQueryable<Tbl_PhieuQLKho> phieu = DB.Tbl_PhieuQLKhos.Where(x => x.maPhieuQL.Equals(maphieu));
            phieu.First().ngayLapQL = ngaylap;
            phieu.First().tinhTrang = tinhtrang;
            phieu.First().maNV = manv;
            DB.SubmitChanges();
        }

    }
}
