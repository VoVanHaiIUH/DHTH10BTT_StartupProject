using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Kho;
using DataAccess;

namespace BusinessLogic.Kho
{
    public class PhieuXK_BLL
    {
        
        SRPHRDataContext DB = new SRPHRDataContext();
        public List<ePhieuXK> laydanhsachphieuXuatKho()
        {
            var listXK = DB.Tbl_PhieuXKs.ToList();
            List<ePhieuXK> ls = new List<ePhieuXK>();
            foreach (Tbl_PhieuXK newXK in listXK)
            {
                ePhieuXK exk = new ePhieuXK();
                exk._maNV = newXK.maNV;
                exk._maPhieuXuat = newXK.maPhieuXuat;
                //exk._maKho = newXK.maKho;
                exk._ngayLapXuat = newXK.ngayLapXuat.Value;
                exk._tinhTrang = newXK.tinhTrang;
                ls.Add(exk);
            }
            return ls;
        }

        public int ThemPhieuXuatKho(ePhieuXK newpxk)
        {
            if (Kiemtrasutontai(newpxk._maPhieuXuat))
                return 0;
            Tbl_PhieuXK pxkTmp = new Tbl_PhieuXK();
            pxkTmp.maPhieuXuat = newpxk._maPhieuXuat;
            pxkTmp.ngayLapXuat = newpxk._ngayLapXuat;
            pxkTmp.maNV = newpxk._maNV;
            //pxkTmp.maKho = newpxk._maKho;
            pxkTmp.tinhTrang = newpxk._tinhTrang;
            DB.Tbl_PhieuXKs.InsertOnSubmit(pxkTmp);
            DB.SubmitChanges();
            return 1;
        }
        public bool Kiemtrasutontai(string maphieu)
        {
            Tbl_PhieuXK pxk = DB.Tbl_PhieuXKs.Where(x => x.maPhieuXuat == maphieu).FirstOrDefault();
            if (pxk == null)
                return false;
            return true;
        }
        public void UpDatePhieuXK(string maphieu, /*string mskho,*/ DateTime ngaylap, string Tinhtrang, string manv)
        {
            IQueryable<Tbl_PhieuXK> phieu = DB.Tbl_PhieuXKs.Where(x => x.maPhieuXuat.Equals(maphieu));
            //      thuep.First().maPhong = maphong;
            //phieu.First().maKho = mskho;
            phieu.First().ngayLapXuat = ngaylap;
            phieu.First().tinhTrang = Tinhtrang;
            phieu.First().maNV = manv;
            DB.SubmitChanges();
        }
    }
}
