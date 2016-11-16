using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NhanSu
{
    public class NhanVien
    {
#region Property
        private string   _maNV;
        private string   _hoTen;
        private DateTime _ngaySinh;
        private DateTime _ngayVaoLam;
        private string   _soCMND;
        private DateTime _ngayCapCMND;
        private string   _gioiTinh;
        private string   _email;
        private string   _SDT;
        private string   _diaChi;
        private int      _trangThai; 
#endregion

#region Get Set Property
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        public DateTime NgayVaoLam
        {
            get { return _ngayVaoLam; }
            set { _ngayVaoLam = value; }
        }
        public string SoCMND
        {
            get { return _soCMND; }
            set { _soCMND = value; }
        }

        public DateTime NgayCapCMND
        {
            get { return _ngayCapCMND; }
            set { _ngayCapCMND = value; }
        }

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        } 
#endregion

#region Constructor
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, DateTime ngayVaoLam, string soCMND, DateTime ngayCapCMND,
                        string gioiTinh, string email, string sdt, string diaChi, int trangThai)
        {
            MaNV        = maNV;
            HoTen       = hoTen;
            NgaySinh    = ngaySinh;
            NgayVaoLam  = ngayVaoLam;
            SoCMND      = soCMND;
            NgayCapCMND = ngayCapCMND;
            GioiTinh    = gioiTinh;
            Email       = email;
            this.SDT    = sdt;
            DiaChi      = diaChi;
            TrangThai   = trangThai; 
        }

        public NhanVien()
        {
            // TODO: Complete member initialization
        }
#endregion

#region Methods
        public override bool Equals(Object newNV)
        {
            NhanVien nv = (NhanVien)newNV;
            return this.MaNV.ToLower().Equals(nv.MaNV.ToLower());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
#endregion
    }
}
