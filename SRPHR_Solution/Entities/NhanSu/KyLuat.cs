using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NhanSu
{
    public class KyLuat
    {

        //#region property
        //private string _maKL;
        //private string _hinhThucKL;
        //private string _ghiChu;
        //#endregion

        //#region property get set
        //public string MaKL
        //{
        //    get { return _maKL; }
        //    set { _maKL = value; }
        //}
        //public string HinhThucKL
        //{
        //    get { return _hinhThucKL; }
        //    set { _hinhThucKL = value; }
        //}
        //public string GhiChu
        //{
        //    get { return _ghiChu; }
        //    set { _ghiChu = value; }
        //}
        //#endregion

        //#region constructor
        //public KyLuat(string maKL, string hinhThucKL, string ghichu)
        //{
        //    _maKL = maKL;
        //    _hinhThucKL = hinhThucKL;
        //    _ghiChu = ghichu;
        //}
        //#endregion

        //#region methods
        //public override bool Equals(Object newKL)
        //{
        //    KyLuat kl = (KyLuat)newKL;
        //    return this.MaKL.ToLower().Equals(kl.MaKL.ToLower());
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        //#endregion

        #region property
        private string _maKL;
        private string _hinhThucKL;
        private string _ghiChu;
        #endregion

        #region property get set
        public string MaKL
        {
            get { return _maKL; }
            set { _maKL = value; }
        }
        public string HinhThucKL
        {
            get { return _hinhThucKL; }
            set { _hinhThucKL = value; }
        }
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        #endregion

        #region constructor
        public KyLuat(string maKL, string hinhThucKL, string ghichu)
        {
            _maKL = maKL;
            _hinhThucKL = hinhThucKL;
            _ghiChu = ghichu;
        }

        public KyLuat()
        {
            _maKL = "";
            _hinhThucKL = "";
            _ghiChu = "";
        }
        #endregion

        #region methods
        public override bool Equals(Object newKL)
        {
            KyLuat kl = (KyLuat)newKL;
            return this.MaKL.ToLower().Equals(kl.MaKL.ToLower());
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
