using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NhanSu
{
    public class ChucVu
    {
        #region property
        private string _maCV;
        private string _tenCV;
        private decimal _heSo;
        private string _ghiChu;
        #endregion

        #region property get set
        public string MaCV
        {
            get
            {
                return _maCV;
            }

            set
            {
                _maCV = value;
            }
        }
        public string TenCV
        {
            get
            {
                return _tenCV;
            }

            set
            {
                _tenCV = value;
            }
        }

        public decimal HeSo
        {
            get
            {
                return _heSo;
            }

            set
            {
                _heSo = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }

            set
            {
                _ghiChu = value;
            }
        }
        #endregion

        #region constructor
        public ChucVu(string maCV, string tenCV, decimal heSo, string ghiChu)
        {
            maCV = MaCV;
            tenCV = TenCV;
            heSo = HeSo;
            ghiChu = GhiChu;
        }
        #endregion

        #region methods
        public override bool Equals(Object newCV)
        {
            ChucVu cv = (ChucVu)newCV;
            return this.MaCV.ToLower().Equals(cv.MaCV.ToLower());
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
