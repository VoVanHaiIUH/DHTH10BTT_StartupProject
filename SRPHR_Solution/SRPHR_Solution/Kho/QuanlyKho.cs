using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Kho;
using Entities.Kho;

namespace SRPHR_Solution.Kho
{
    public partial class QuanlyKho : Form
    {
        List<eKho> listKho;
        Kho_BLL bllKho;
        public QuanlyKho()
        {
            listKho = new List<eKho>();
            bllKho = new Kho_BLL();
            listKho = bllKho.LayDanhSachKho();
            InitializeComponent();
            DuaDuLieuLenTreeViewKho(treeViewKho, listKho);
        }

        public void DuaDuLieuLenTreeViewKho(TreeView tv, List<eKho> list)
        {
            tv.Nodes.Clear();
            foreach (eKho kh in list)
            {
                TreeNode n = new TreeNode(kh._maKho);
                n.Tag = kh._maKho;
                tv.Nodes.Add(n);
            }
        }
        private void QuanlyKho_Load(object sender, EventArgs e)
        {

        }
        public void duadulieulenlable(eKho kho)
        {
            lblTenKho.Text = "Tên Kho: " + kho._tenKho.ToString();
            lblDiaChi.Text = "Địa chỉ: " + kho._diaChiKho.ToString();
            lblSDT.Text = "Số điện thoại liên hệ: " + kho._soDT.ToString();
        }
        private void treeViewKho_AfterSelect(object sender, TreeViewEventArgs e)
        {
            eKho kho = new eKho();
            string makho = e.Node.Tag.ToString();
            kho = bllKho.laykhoboimakho(makho);
            duadulieulenlable(kho);
        }

        private void btnPhieuQlyKho_Click(object sender, EventArgs e)
        {
            PQLKho p = new PQLKho();
            p.ShowDialog();
        }

        private void btnQLySP_Click(object sender, EventArgs e)
        {
        }


        private void btnQlyPhieuNK_Click(object sender, EventArgs e)
        {
            NhapKho nk = new NhapKho();
            nk.ShowDialog();
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            XuatKhoFrm xk = new XuatKhoFrm();
            xk.ShowDialog();
        }
    }
}
