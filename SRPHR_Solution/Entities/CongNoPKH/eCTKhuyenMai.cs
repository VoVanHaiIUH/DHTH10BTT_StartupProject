using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CongNoPKH
{
    public class eCTKhuyenMai
    {
        public string msDotKM { get; set; }
        public string maSP { get; set; }
        public double phantramKM { get; set; }
        public string ghiChu { get; set; }

        public eCTKhuyenMai(string msDotKM, string maSP, double phantramKM, string ghiChu)
        {
            this.msDotKM = msDotKM;
            this.maSP = maSP;
            this.phantramKM = phantramKM;
            this.ghiChu = ghiChu;
        }
        public override int GetHashCode()
        {
            return msDotKM.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            eCTKhuyenMai ctkm = (eCTKhuyenMai)obj;
            return ctkm.Equals(ctkm.msDotKM);
        }
    }
}
