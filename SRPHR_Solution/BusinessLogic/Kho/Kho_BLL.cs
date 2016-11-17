using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.Kho;
using System.Data.Linq;
using BusinessLogic.NhanSu;
using System.Text.RegularExpressions;
using System.IO;
namespace BusinessLogic.Kho
{
    public class Kho_BLL
    {
        SRPHRDataContext db;
        public Kho_BLL()
        {
            db = new SRPHRDataContext();
        }
        public void capnhatkho()
        {

            var listpb = db.Tbl_PhongBans.ToList();
            string reg = @"^KH";
            foreach (Tbl_PhongBan pb in listpb)
            {
                Tbl_Kho ek = new Tbl_Kho();
                if (!Kiemtrasutontai(pb.maPB) && Regex.IsMatch(pb.maPB, reg))
                {
                    ek.msKho = pb.maPB;
                    ek.soDT = pb.soDT;
                    ek.tenKho = pb.soDT;
                    ek.diachiKho = pb.diaDiem;
                    db.Tbl_Khos.InsertOnSubmit(ek);
                    db.SubmitChanges();
                }
            }
        }
        public List<eKho> LayDanhSachKho()
        {
            var listKho = db.Tbl_Khos.ToList();
            List<eKho> ls = new List<eKho>();
            foreach (Tbl_Kho k in listKho)
            {
                eKho kho = new eKho();
                kho._maKho = k.msKho;
                kho._tenKho = k.tenKho;
                kho._soDT = k.soDT;
                kho._diaChiKho = k.diachiKho;
                ls.Add(kho);
            }
            return ls;
        }
        public eKho laykhoboimakho(string makho)
        {
            var phonglist = db.Tbl_Khos.Where(x => x.msKho == makho).ToList();
            eKho k = new eKho();
            foreach (Tbl_Kho khotmp in phonglist)
            {
                k._maKho = khotmp.msKho;
                k._tenKho = khotmp.tenKho;
                k._diaChiKho = khotmp.diachiKho;
                k._soDT = khotmp.soDT;
            }
            return k;
        }
        public bool Kiemtrasutontai(string makho)
        {
            Tbl_Kho pxk = db.Tbl_Khos.Where(x => x.msKho == makho).FirstOrDefault();
            if (pxk == null)
                return false;
            return true;
        }
    }
}
