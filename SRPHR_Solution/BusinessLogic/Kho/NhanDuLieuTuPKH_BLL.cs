using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CongNoPKH;
using Entities.Kho;
using DataAccess;
namespace BusinessLogic.Kho
{
    public class NhanDuLieuTuPKH_BLL
    {
        SRPHRDataContext db = new SRPHRDataContext();
        public List<ePhieuDNNK> laydanhsachPhieuDNNK()
        {
            var listphieuDNNK = db.Tbl_PhieuDNNKs.ToList();
            List<ePhieuDNNK> ls = new List<ePhieuDNNK>();
            var k = db.Tbl_PhieuNKs.ToList();
            int kq;
            foreach (Tbl_PhieuDNNK nk in listphieuDNNK)
            {
                kq = 0;
                ePhieuDNNK ednnk = new ePhieuDNNK();
                ednnk.maKho = nk.maKho;
                ednnk.maNV = nk.maNV;
                ednnk.ngayLapphieu = nk.ngayLapphieu;
                ednnk.soPDNNK = nk.soPDNNK;
                foreach (Tbl_PhieuNK i in k)
                {
                    ePhieuNK epnk = new ePhieuNK();
                    epnk._maPhieuNhap = i.maPhieuNhap;
                    if (ednnk.soPDNNK == epnk._maPhieuNhap) kq = 1;
                }
                if (kq == 0) ls.Add(ednnk);
            }
            return ls;
        }
        public List<ePhieuDNXK> laydanhsachPhieuDNXK()
        {
            var listphieuDNXK = db.Tbl_PhieuDNXKs.ToList();
            List<ePhieuDNXK> ls = new List<ePhieuDNXK>();
            var k = db.Tbl_PhieuXKs.ToList();
            int kq;
            foreach (Tbl_PhieuDNXK xk in listphieuDNXK)
            {
                kq = 0;
                ePhieuDNXK ednxk = new ePhieuDNXK();
                ednxk.maKho = xk.maKho;
                ednxk.maNV = xk.maNV;
                ednxk.ngayLap = xk.ngayLap;
                ednxk.soPDNXK = xk.soPDNNK;

                foreach (Tbl_PhieuXK i in k)
                {
                    ePhieuNK epnk = new ePhieuNK();
                    epnk._maPhieuNhap = i.maPhieuXuat;
                    if (ednxk.soPDNXK == epnk._maPhieuNhap) kq = 1;
                }
                if (kq == 0) ls.Add(ednxk);
            }
            return ls;
        }
        public List<eCTPhieuDNNK> laydanhsachCTPhieuDNNKtheoMaphieu(string map)
        {
            var listCTphieuDNNK = db.Tbl_CTPhieuDNNKs.Where(x => x.soPDNNK == map).ToList();
            List<eCTPhieuDNNK> ls = new List<eCTPhieuDNNK>();
            foreach (Tbl_CTPhieuDNNK nk in listCTphieuDNNK)
            {
                eCTPhieuDNNK ednnk = new eCTPhieuDNNK();
                ednnk.maSP = nk.maSP;
                ednnk.soPDNXK = nk.soPDNNK;
                ednnk.soluong = Convert.ToInt32(nk.soluong);
                ednnk.Ghichu = nk.ghiChu;
                ls.Add(ednnk);
            }
            return ls;
        }
        public List<eCTPhieuDNXK> laydanhsachCTPhieuDNXKtheoMaphieu(string map)
        {
            var listCTphieuDNXK = db.Tbl_CTPhieuDNXKs.Where(x => x.soPDNXK == map).ToList();
            List<eCTPhieuDNXK> ls = new List<eCTPhieuDNXK>();
            foreach (Tbl_CTPhieuDNXK xk in listCTphieuDNXK)
            {
                eCTPhieuDNXK ednxk = new eCTPhieuDNXK();
                ednxk.maSP = xk.maSP;
                ednxk.soPDNXK = xk.soPDNXK;
                ednxk.soluong = Convert.ToInt32(xk.soluong);
                ednxk.Ghichu = xk.Ghichu;
                ls.Add(ednxk);
            }
            return ls;
        }
    }
}
