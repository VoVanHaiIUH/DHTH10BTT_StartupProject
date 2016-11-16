using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    public class PhieuNK_BLL
    {
        SRPHRDataContext DB = new SRPHRDataContext();
        public List<ePhieuNK> laydanhsachphieuNhapKho()
        {
            var listNK = DB.Tbl_PhieuNKs.ToList();
            List<ePhieuNK> ls = new List<ePhieuNK>();
            foreach (Tbl_PhieuNK newNK in listNK)
            {
                ePhieuNK enk = new ePhieuNK();
                enk._maNV = newNK.maNV;
                enk._maPhieuNhap = newNK.maPhieuNhap;
                enk._msKho = newNK.msKho;
                enk._ngayLapNhap = newNK.ngayLapNhap;
                enk._tinhTrang = newNK.tinhTrang;
                ls.Add(enk);
            }
            return ls;
        }

        public int ThemPhieuNhapKho(ePhieuNK newpnk)
        {
            if (Kiemtrasutontai(newpnk._maPhieuNhap))
                return 0;
            Tbl_PhieuNK pnkTmp = new Tbl_PhieuNK();
            pnkTmp.maPhieuNhap = newpnk._maPhieuNhap;
            pnkTmp.ngayLapNhap = newpnk._ngayLapNhap;
            pnkTmp.maNV = newpnk._maNV;
            pnkTmp.msKho = newpnk._msKho;
            pnkTmp.tinhTrang = newpnk._tinhTrang;
            DB.Tbl_PhieuNKs.InsertOnSubmit(pnkTmp);
            DB.SubmitChanges();
            return 1;
        }
        public bool Kiemtrasutontai(string maphieu)
        {
            Tbl_PhieuNK pnk = DB.Tbl_PhieuNKs.Where(x => x.maPhieuNhap == maphieu).FirstOrDefault();
            if (pnk == null)
                return false;
            return true;
        }
        public void UpDatePhieuNK(string maphieu, string mskho, DateTime ngaylap, string Tinhtrang, string manv)
        {
            IQueryable<Tbl_PhieuNK> phieu = DB.Tbl_PhieuNKs.Where(x => x.maPhieuNhap.Equals(maphieu));
            phieu.First().msKho = mskho;
            phieu.First().ngayLapNhap = ngaylap;
            phieu.First().tinhTrang = Tinhtrang;
            phieu.First().maNV = manv;
            DB.SubmitChanges();
        }

    }
}
