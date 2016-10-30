using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.CongNoPKH;
using DataAccess;

namespace BusinessLogic.CongNoPKH
{
    public class PhieuDNNK_BLL
    {
        private ePhieuDNNK pdn;
        private List<eCTPhieuDNNK> ctp;
        public PhieuDNNK_BLL(ePhieuDNNK pdn)
        {
            this.pdn = pdn;
            ctp = new List<eCTPhieuDNNK>();
        }
        public void themChitietPhieu(eCTPhieuDNNK ct)
        {
            if (ctp.Contains(ct))//nếu có thì cập nhật số lượng
            {
                ctp[ctp.IndexOf(ct)].soluong += ct.soluong;
            }
            else//không thì thêm
            {
                ctp.Add(ct);
            }
        }
        public bool xoaChitietPhieu(eCTPhieuDNNK ct)
        {
            if (ctp.Contains(ct))//nếu có thì xóa
                return ctp.Remove(ct);
            return false;
        }
    }
}
