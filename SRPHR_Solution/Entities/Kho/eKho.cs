using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Kho
{
    public class eKho
    {
        public string _maKho { get; set; }
        public string _tenKho { get; set; }
        public string _diaChiKho { get; set; }
        public string _soDT { get; set; }
        public eKho(string makho, string tenkho, string diachikho, string sodt)
        {
            this._maKho = makho;
            this._tenKho = tenkho;
            this._diaChiKho = diachikho;
            this._soDT = sodt;
        }
        public override bool Equals(object newK)
        {
            eKho k = (eKho)newK;
            return this._maKho.ToLower().Equals(k._maKho.ToLower());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
