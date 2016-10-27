using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NhanSu
{
    public class DaoTao
    {
        #region property
        private string _maKhoaDT;
        private string _tenKhoaDT;
        private DateTime _ngayBD;
        private DateTime _ngayKT;
        private string _diadiem;
        private string _hinhThucDT;
        private decimal _chiphi;
        #endregion

        #region property get set

        public string MaKhoaDT
        {
            get { return _maKhoaDT; }
            set { _maKhoaDT = value; }
        }


        public string TenKhoaDT
        {
            get { return _tenKhoaDT; }
            set { _tenKhoaDT = value; }
        }


        public DateTime NgayBD
        {
            get { return _ngayBD; }
            set { _ngayBD = value; }
        }


        public DateTime NgayKT
        {
            get { return _ngayKT; }
            set { _ngayKT = value; }
        }


        public string Diadiem
        {
            get { return _diadiem; }
            set { _diadiem = value; }
        }


        public string HinhThucDT
        {
            get { return _hinhThucDT; }
            set { _hinhThucDT = value; }
        }


        public decimal Chiphi
        {
            get { return _chiphi; }
            set { _chiphi = value; }
        }
        #endregion

        #region constructor
        public DaoTao(string maKhoaDT, string tenKhoaDT, DateTime ngayBD, DateTime ngayKT, string diadiem, string hinhThucDT, decimal chiphi)
        {
            _maKhoaDT = maKhoaDT;
            _tenKhoaDT = tenKhoaDT;
            _ngayBD = ngayBD;
            _ngayKT = ngayKT;
            _diadiem = diadiem;
            _hinhThucDT = hinhThucDT;
            _chiphi = chiphi;
        }
        #endregion

        #region methods
        public override bool Equals(Object newDT)
        {
            DaoTao dt = (DaoTao)newDT;
            return this.MaKhoaDT.ToLower().Equals(dt.MaKhoaDT.ToLower());
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
