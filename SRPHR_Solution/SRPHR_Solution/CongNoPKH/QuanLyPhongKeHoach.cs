using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.CongNoPKH;
using BusinessLogic.CongNoPKH;
using BussinessLogic.CongNoPKH;

namespace SRPHR_Solution.CongNoPKH
{
    public partial class QuanLyPhongKeHoach : Form
    {
        public string PQPKH;
        HDBanSi_BLL blbs;
        HDMuaHangNCC_BLL mhbll;
        List<eCTHDBanSi> cthdbs;
        List<eCTMuaHangNCC> ctmh;
        List<eHDMuaHangNCC> hdmd;
        List<eHDBanSi> hdbs;
        List<eCTCongNoKH> ct;
        CongNoKH_BLL cnkh;
        CongNoNCC_BLL cc;
        public QuanLyPhongKeHoach()
        {
            InitializeComponent();
            pdnnkbll = new PhieuDNNK_BLL();
            pdnnk = new List<ePhieuDNNK>();
            ctpdnnk = new List<eCTPhieuDNNK>();
            pdnnk = pdnnkbll.getAllPDNNK();
            loaddatagridview(pdnnk, dgvPDNNK);
            pdnxkbll = new PhieuDNXK_BLL();
            pdnxk = new List<ePhieuDNXK>();
            ctpdnxk = new List<eCTPhieuDNXK>();

            pdnxk = pdnxkbll.getAllPDNXK();
            loaddatagridviewPDNXK(pdnxk, dgvPDNXK);

            kmbll = new KhuyenMai_BLL();
            ctkm = new List<eCTKhuyenMai>();
            ctkm = kmbll.getAllCTKM();
            loaddatagridviewctkm(ctkm, dgvctkhuyenmai);
            km = new List<eKhuyenMai>();
            km = kmbll.getAllKM();
            loaddatagridviewkm(km, dgvkhuyenmai);

            nccbll = new NhaCungCap_BLL();
            ncc = new List<eNhaCungCap>();
            loaddataintreeview(ncc, treeView1);
            spbll = new SanPham_BLL();
            sp = new List<eSanPham>();
            sp = spbll.getallsanpham();
            loaddatagridviewsp(sp, dgvSanPham);
            EnableButton(true);
            hdbs = new List<eHDBanSi>();
            cthdbs = new List<eCTHDBanSi>();
            blbs = new HDBanSi_BLL();

            mhbll = new HDMuaHangNCC_BLL();
            ctmh = new List<eCTMuaHangNCC>();
            hdbs = new List<eHDBanSi>();
            hdmd = new List<eHDMuaHangNCC>();
            ct = new List<eCTCongNoKH>();
            cnkh = new CongNoKH_BLL();
            //ct = cnkh.Getallcn();



            hdbs = blbs.getallhd();
            laydulieuvaogridview(dgvhdbansikh, hdbs);
            laydulieuvaogridview1234(dgvKhachHang, hdbs);
            hdmd = mhbll.getallHDMH();
            laydulieuvaogridview12(dgvhdmuahangncc, hdmd);
            laydulieuvaogridview33(dgvNCC, hdmd);
        }

        PhieuDNNK_BLL pdnnkbll;
        List<eCTPhieuDNNK> ctpdnnk;
        PhieuDNXK_BLL pdnxkbll;
        List<eCTPhieuDNXK> ctpdnxk;
        List<ePhieuDNNK> pdnnk;
        List<ePhieuDNXK> pdnxk;

        KhuyenMai_BLL kmbll;
        List<eCTKhuyenMai> ctkm;
        List<eKhuyenMai> km;

        NhaCungCap_BLL nccbll;
        List<eNhaCungCap> ncc;
        SanPham_BLL spbll;
        List<eSanPham> sp;
        BindingSource bds = new BindingSource();
        BindingSource bds2 = new BindingSource();
        public void loadvaogrid(string masp)
        {
            sp = spbll.getbymasanpham(masp);
            bds.DataSource = sp;
            dgvSanPham.DataSource = bds;
        }
        private void dgvkhuyenmai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loaddatagridview(List<ePhieuDNNK> dnnk, DataGridView dtgv)
        {
            dtgv.DataSource = dnnk;
        }
        public void loaddatagridviewPDNXK(List<ePhieuDNXK> pdnxk, DataGridView dtgvpdnxk)
        {

            dtgvpdnxk.DataSource = pdnxk;

        }
        public void loaddatagridviewPDNXK1(List<eCTPhieuDNXK> pdnxk, DataGridView dtgvpdnxk)
        {

            dtgvpdnxk.DataSource = pdnxk;

        }
        public void loaddatagridviewq(List<eCTPhieuDNNK> ctpdnnk, DataGridView dtgv)
        {
            dtgv.DataSource = ctpdnnk;
        }



        public void loaddatagridviewkm(List<eKhuyenMai> km, DataGridView dtgv) //km
        {
            dtgv.DataSource = km;
        }
        public void laydulieuvaogridview(DataGridView tv, List<eHDBanSi> ls)
        {



            tv.DataSource = ls;
        }

        public void laydulieuvaogridview1234(DataGridView tv, List<eHDBanSi> ls)
        {



            tv.DataSource = ls;
        }
        public void laydulieuvaogridview33(DataGridView tv, List<eHDMuaHangNCC> ls)
        {



            tv.DataSource = ls;
        }
       

        public void laydulieuvaogridview1(DataGridView tv, List<eCTHDBanSi> ls)
        {



            tv.DataSource = ls;
        }

        public void loaddatagridviewctkm(List<eCTKhuyenMai> ctkm, DataGridView dtgvctkm) // ctkm
        {
            dtgvctkm.DataSource = ctkm;
            dtgvctkm.Columns["msDotKM"].Visible = false;
        }
        public void loaddataintreeview(List<eNhaCungCap> ncc, TreeView tv)
        {
            tv.Nodes.Clear();
            TreeNode n;
            foreach (eNhaCungCap tmp in nccbll.getAllNCC())
            {
                n = new TreeNode(tmp.tenNCC);
                n.Tag = tmp.maNCC;
                tv.Nodes.Add(n);

            }
        }
        public void loaddatagridviewsp(List<eSanPham> sp, DataGridView dtgvsp)
        {
            sp = spbll.getallsanpham();
            bds.DataSource = sp;
            dgvSanPham.DataSource = bds;
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

       

        private void btntimsp_Click(object sender, EventArgs e)
        {

        }

        private void btnThoatsp_Click(object sender, EventArgs e)
        {

        }

        private void btnSuasp_Click(object sender, EventArgs e)
        {

        }

        private void btnLuusp_Click(object sender, EventArgs e)
        {

        }

        private void btnThemsp_Click(object sender, EventArgs e)
        {

        }

        private void btnthemncc_Click(object sender, EventArgs e)
        {

        }

        private void cbtt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPham_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemsp_Click_1(object sender, EventArgs e)
        {
            eSanPham b = new eSanPham();
            b.maSP = txtmaspsp.Text;
            b.tenSP = txtTenSP.Text;
            b.moTa = txtMoTa.Text;
            b.ngaySX = Convert.ToDateTime(dtpnsxsp.Text);
            b.hanSD = Convert.ToDateTime(dtphsdsp.Text);
            b.tenNhaPP = txtNhaPhanPhoi.Text;
            b.tenNhaSX = txtNhaSXuat.Text;
            b.trangthai = Convert.ToInt32(cbtt.SelectedItem.ToString());
            int m = spbll.ThemSanPham(b);
            if (m == 0) MessageBox.Show("Trùng mã !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                if (m == 1) MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                loaddatagridviewsp(sp, dgvSanPham);
            }
            btnLuusp.Enabled = false;
            btnSuasp.Enabled = true;
            btnthemncc.Enabled = true;
        }

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            string masp = (string)((TreeView)sender).SelectedNode.Tag;
            if (spbll.getbymasanpham(masp).Count() == 0)
            {
                MessageBox.Show("Trong nha cung cap  không có san pham", "Thong bao!");
                loaddatagridviewsp(sp, dgvSanPham);
            }
            else
            {
                loadvaogrid(masp);
            }
        }

        private void dgvSanPham_RowStateChanged_1(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                eSanPham tth = (eSanPham)bds.Current;
                txtmaspsp.Text = e.Row.Cells["maSP"].Value.ToString();
                txtTenSP.Text = e.Row.Cells["tenSP"].Value.ToString();
                txtMoTa.Text = e.Row.Cells["moTa"].Value.ToString();
                dtpnsxsp.Text = e.Row.Cells["ngaySX"].Value.ToString();
                dtphsdsp.Text = e.Row.Cells["hanSD"].Value.ToString();
                txtNhaPhanPhoi.Text = e.Row.Cells["tenNhaPP"].Value.ToString();
                txtNhaSXuat.Text = e.Row.Cells["tenNhaSX"].Value.ToString();
                cbtt.SelectedItem = e.Row.Cells["trangthai"].Value.ToString();

            }
        }
        public void EnableButton(bool status)
        {
            btnThemsp.Enabled = status;
            btnSuasp.Enabled = status;
            btnLuusp.Enabled = !status;

        }
        public void DisableTextbox(bool status)
        {
            txtmaspsp.ReadOnly = status;
            txtMoTa.ReadOnly = status;
            txtNhaPhanPhoi.ReadOnly = status;
            txtTenSP.ReadOnly = status;
            dtphsdsp.Enabled = !status;
            dtpnsxsp.Enabled = !status;
            cbtt.Enabled = !status;
            txtNhaSXuat.ReadOnly = status;
        }
        private void btnSuasp_Click_1(object sender, EventArgs e)
        {
            if (btnSuasp.Text == "Sửa")
            {
                EnableButton(false);
                btnSuasp.Enabled = true;
                btnSuasp.Text = "Bỏ qua";
                DisableTextbox(false);
                btnLuusp.Enabled = true;
                txtmaspsp.ReadOnly = true;
                txtmaspsp.Focus();
            }
            else
            {
                EnableButton(true);
                btnLuusp.Enabled = false;
                DisableTextbox(true);
                sp = spbll.getallsanpham();
                loaddatagridviewsp(sp, dgvSanPham);
                btnSuasp.Text = "Sửa";

            }
        }

        private void btnLuusp_Click_1(object sender, EventArgs e)
        {
            string masp = txtmaspsp.Text;
            if (masp != null)
            {
                spbll.UpDateSanPham(masp, txtTenSP.Text, txtMoTa.Text, Convert.ToDateTime(dtpnsxsp.Text), Convert.ToDateTime(dtphsdsp.Text), txtNhaPhanPhoi.Text, txtNhaSXuat.Text, Convert.ToInt32(cbtt.SelectedItem.ToString()));
                MessageBox.Show("Sửa xong !!");
                EnableButton(true);
                btnLuusp.Enabled = false;
                DisableTextbox(true);

                sp = spbll.getallsanpham();
                loaddatagridviewsp(sp, dgvSanPham);
                btnSuasp.Text = "Sửa";
            }
            else { MessageBox.Show("bạn chưa chọn vào sản phẩm cần sửa thông tin!"); }
        }

        private void btntimsp_Click_1(object sender, EventArgs e)
        {
            string masp = txttimsp.Text;
            sp = spbll.getalltim(masp);
            dgvSanPham.DataSource = sp;
        }

        private void btnthemncc_Click_1(object sender, EventArgs e)
        {
            frmnhacungcap frm = new frmnhacungcap();
            frm.ShowDialog();
            loaddataintreeview(ncc, treeView1);
        }

        private void QuanLyPhongKeHoach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoatsp_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvhdbansikh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyPhongKeHoach_Load(object sender, EventArgs e)
        {
            trangthaiPQ(PQPKH);
        }
        private void trangthaiPQ(string pq)
        {
            if (pq.Substring(0, 1) == "1")
            {
                btnthembansikh.Enabled = true;
                btnthemdnnk.Enabled = true;
                btnthemdnxk.Enabled = true;
                btnthemkm.Enabled = true;
                btnthemmuahangncc.Enabled = true;
                btnThemsp.Enabled = true;
            }
            else
            {
                btnthembansikh.Enabled = false;
                btnthemdnnk.Enabled = false;
                btnthemdnxk.Enabled = false;
                btnthemkm.Enabled = false;
                btnthemmuahangncc.Enabled = false;
                btnThemsp.Enabled = false;
            }
            if (pq.Substring(2, 1) == "1")
            {
                btnsuabansikh.Enabled = true;
                btnsuadnnk.Enabled = true;
                btnsuakm.Enabled = true;
                btnsuamuahangncc.Enabled = true;
                btnSuasp.Enabled = true;

            }
            else
            {
                btnsuabansikh.Enabled = false;
                btnsuadnnk.Enabled = false;
                btnsuakm.Enabled = false;
                btnsuamuahangncc.Enabled = false;
                btnSuasp.Enabled = false;
            }

             if (pq.Substring(3, 1) == "1")
             {
                 //btninbansikh.Enabled = true;
                 //btnindnnk.Enabled = true;
                 //btnindnxk.Enabled = true;
                 //btninmuahangncc.Enabled = true;
             }
             else
             {
                // btninbansikh.Enabled = false;
                // //btnindnnk.Enabled = false;
                //// btnindnxk.Enabled = false;
                // btninmuahangncc.Enabled = false;
             }



        }

        private void btnthemkm_Click(object sender, EventArgs e)
        {
            eKhuyenMai k = new eKhuyenMai();
            k.ghiChu = txtghiChukm.Text;
            k.msDotKM = txtMaSoDotKhuyenMai.Text;
            k.ngayBD = Convert.ToDateTime(dtpngaybatdaukm.Text);
            k.ngayKT = Convert.ToDateTime(dtpngayketthuckm.Text);
            k.tenDotKM = txtghiChukm.Text;
            int m = kmbll.themKM(k);
            if (m == 0) MessageBox.Show("Trùng mã !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                if (m == 1) MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dgvkhuyenmai.DataSource = kmbll.getAllKM();
                dgvctkhuyenmai.DataSource = kmbll.getAllCTKM();
            }
            btnthemkm.Enabled = true;
        }

        private void btnsuakm_Click(object sender, EventArgs e)
        {
            string msdkm = txtMaSoDotKhuyenMai.Text;
            if (msdkm != null)
            {
                kmbll.UpDateKhuyenMai(txtMaSoDotKhuyenMai.Text, txtTenDotKhuyenMai.Text, Convert.ToDateTime(dtpngaybatdaukm.Text), Convert.ToDateTime(dtpngayketthuckm.Text), txtghiChukm.Text);
                MessageBox.Show("Sửa xong !!");
                dgvkhuyenmai.DataSource = kmbll.getAllKM();

            }
            else { MessageBox.Show("bạn chưa chọn vào sản phẩm cần sửa thông tin!"); }
        }

        private void btnthemctkm_Click(object sender, EventArgs e)
        {
           eCTKhuyenMai m = new eCTKhuyenMai();
            m.msDotKM = cmbmsDotKm.Text;
            m.ghiChu = txtghiChukmct.Text;
            m.maSP = txtmaSpkm.Text;
            m.phantramKM = Convert.ToDouble(txtphanTramKM.Text);
            int k = kmbll.themCTKM(m);
            MessageBox.Show("Thêm thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            dgvkhuyenmai.DataSource = kmbll.getAllKM();
            dgvctkhuyenmai.DataSource = kmbll.getAllCTKM();
        }

        private void btnsuaCTKM_Click(object sender, EventArgs e)
        {
           string msdkm = txtMaSoDotKhuyenMai.Text;
            if (msdkm != null)
            {
                kmbll.UpDateCTKhuyenMai(txtMaSoDotKhuyenMai.Text, txtmaSpkm.Text, Convert.ToDouble(txtphanTramKM.Text), txtghiChukmct.Text);
                MessageBox.Show("Sửa xong !!");
                dgvctkhuyenmai.DataSource = kmbll.getAllCTKM();

            }
            else { MessageBox.Show("bạn chưa chọn vào sản phẩm cần sửa thông tin!"); }
        }

        private void dgvctkhuyenmai_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           if (dgvctkhuyenmai.SelectedRows.Count > 0)
            {

                eCTKhuyenMai ectkm = (eCTKhuyenMai)bds.Current;
                txtMaSoDotKhuyenMai.Text = e.Row.Cells["msDotKM"].Value.ToString();
                txtmaSpkm.Text = e.Row.Cells["maSP"].Value.ToString();
                txtphanTramKM.Text = e.Row.Cells["phantramKM"].Value.ToString();
                txtghiChukmct.Text = e.Row.Cells["ghiChu"].Value.ToString();
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btnthemmuahangncc_Click(object sender, EventArgs e)
        {

        }

        private void btnthembansikh_Click(object sender, EventArgs e)
        {
            string nv = txtmanhanvienbansikh.Text;
            string kh = txtmakhachhang.Text;

            eHDBanSi y = new eHDBanSi()
            {
                maHD = txtmahopdongbansikh.Text,
                ngayLap = dtpngaylaphdbansikh.Text,
                maKH = kh,
                maNV = nv,
                ghiChu = txtghichubansikh.Text

            };

            int kq = blbs.themhoadon(y);

            if (kq == 1)

                MessageBox.Show("them thanh cong");


            else

                MessageBox.Show("Thêm Thất Bại!Kiểm Tra Chùng Mã.");
            dgvhdbansikh.DataSource = blbs.getallhd();
        }

        private void dgvhdbansikh_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvhdbansikh.SelectedRows != null && dgvhdbansikh.SelectedRows.Count > 0)
            {
                if (e.Row.Cells["maHD"].Value != null)
                {
                    txtmahopdongbansikh.Text = e.Row.Cells["maHD"].Value.ToString();
                    string ma = e.Row.Cells["maHD"].Value.ToString();
                    cthdbs = blbs.GetallctHDbansi(ma);
                    laydulieuvaogridview1(dataGridView1, cthdbs);

                }

                if (e.Row.Cells["maNV"].Value != null)
                {
                    txtmanhanvienbansikh.Text = e.Row.Cells["maNV"].Value.ToString();
                }
                if (e.Row.Cells["ghiChu"].Value != null)
                {
                    txtghichubansikh.Text = e.Row.Cells["ghiChu"].Value.ToString();
                }



                if (e.Row.Cells["maKH"].Value != null)
                {
                    txtmakhachhang.Text = e.Row.Cells["maKH"].Value.ToString();
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            eCTHDBanSi n = new eCTHDBanSi()
            {
                maHD = txtmahopdongbansikh.Text,
                maSP = txtmasanphambansikh.Text,
                soluong = Convert.ToInt16(txtsoluongbansikh.Text),
                dongiaBan = txtdongiaban.Text,
                ghiChu = txtghichubansikh.Text
            };
            int kq1 = blbs.themcthoadon(n);
            if (kq1 == 1 || kq1 != 1)

                MessageBox.Show("them thanh cong");
            dataGridView1.DataSource = blbs.GetallctHDbansi1();

        }

        private void btnsuabansikh_Click(object sender, EventArgs e)
        {

            int kq = blbs.capnhat(txtmahopdongbansikh.Text, dtpngaylaphdbansikh.Text, txtmakhachhang.Text, txtmanhanvienbansikh.Text, txtghichubansikh.Text);

            if (kq == 1)
            {

                dgvhdbansikh.DataSource = blbs.getallhd();
                MessageBox.Show("Sua xong!!!");
            }
            else
            {
                MessageBox.Show("sửa thât bại.Không được sửa mã dv!");
            }
        }

        private void btntimbansikh_Click(object sender, EventArgs e)
        {

            string hd = txttimmahdbansikh.Text;
            string nv = txttimmahdbansikh.Text;
            string kh = txttimmahdbansikh.Text;
            hdbs = blbs.Getall(hd, nv, kh);
            dgvhdbansikh.DataSource = hdbs;

        }

        private void btnthemmuahangncc_Click_1(object sender, EventArgs e)
        {

            eHDMuaHangNCC y = new eHDMuaHangNCC()
            {
                maHD = txtmahdmuahangncc.Text,
                ngayLap = dtpngaylaphdmuahangncc.Text,
                maNCC = txtmanhacungcap.Text,
                maNV = txtmanhanvienmuahangncc.Text,

                noidung = txtghichumuahangncc.Text,
                tenHD = textBox1.Text
            };

            int kq = mhbll.themhd(y);

            if (kq == 1)

                MessageBox.Show("them thanh cong");


            else
                MessageBox.Show("Thêm Thất Bại!Kiểm Tra Chùng Mã.");
            dgvhdmuahangncc.DataSource = mhbll.getallHDMH();
        }
        public void laydulieuvaogridview12(DataGridView tv, List<eHDMuaHangNCC> ls)
        {



            tv.DataSource = ls;
        }
        public void laydulieuvaogridview121(DataGridView tv, List<eCTMuaHangNCC> ls)
        {



            tv.DataSource = ls;
        }

        private void dgvhdmuahangncc_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvhdmuahangncc.SelectedRows != null && dgvhdmuahangncc.SelectedRows.Count > 0)
            {
                if (e.Row.Cells["maHD"].Value != null)
                {
                    txtmahdmuahangncc.Text = e.Row.Cells["maHD"].Value.ToString();
                    string ma = e.Row.Cells["maHD"].Value.ToString();
                    ctmh = mhbll.getallctMuahangNCC(ma);
                    laydulieuvaogridview121(dataGridView2, ctmh);

                }

                if (e.Row.Cells["maNV"].Value != null)
                {
                    txtmanhanvienmuahangncc.Text = e.Row.Cells["maNV"].Value.ToString();
                }
                if (e.Row.Cells["noidung"].Value != null)
                {
                    txtghichumuahangncc.Text = e.Row.Cells["noidung"].Value.ToString();
                }

                if (e.Row.Cells["tenHD"].Value != null)
                {
                    textBox1.Text = e.Row.Cells["tenHD"].Value.ToString();
                }

                if (e.Row.Cells["maNCC"].Value != null)
                {
                    txtmanhacungcap.Text = e.Row.Cells["maNCC"].Value.ToString();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eCTMuaHangNCC d1 = new eCTMuaHangNCC()
            {
                maSP = Convert.ToInt32(txtmasanphammuahangncc.Text),
                maHD = txtmahdmuahangncc.Text,
                soluong = Convert.ToInt32(txtsoluongmuahangncc.Text),
                dongiaMua = Convert.ToString(txtdongiamua.Text),
                ghiChu = textBox1.Text,


            };
            int kq1 = mhbll.themcthoadon(d1);
            if (kq1 == 1 || kq1 != 1)

                MessageBox.Show("them thanh cong");
            dataGridView2.DataSource = mhbll.getallctMuahangNCC();
            // dgvhdbansikh.DataSource = blbs.getallhd();
            //dgvhdbansikh.DataSource = laydulieuvaogridview(dgvhdbansikh, cthdbs, hdbs);
            //   }
        }

        private void btntimmahdmuahangncc_Click(object sender, EventArgs e)
        {
            string hd = txttimmahdmuahangncc.Text;
            string nv = txttimmahdmuahangncc.Text;
            string ncc = txttimmahdmuahangncc.Text;
            hdmd = mhbll.Getall1(hd, nv, ncc);
            dgvhdmuahangncc.DataSource = hdmd;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = txtMaKH.Text;
            double kq = cnkh.tinhcongnoKH(a);
            MessageBox.Show("So tien khach hang con thieu" + kq.ToString());
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void btnxuatcnncc_Click(object sender, EventArgs e)
        {
            string ab = txtMaNCC.Text;
            double kq = cc.tinhcongnoncc(ab);
            MessageBox.Show("So tien chua thanh toan voi nha cung cap" + kq.ToString());
        }

        private void btnthemdnxk_Click(object sender, EventArgs e)
        {
            ePhieuDNXK p = new ePhieuDNXK();
            p.soPDNXK = txtsophieudnxk.Text;
            p.ngayLap = Convert.ToString(dtpngaylapphieudnxk.Text);
            p.maNV = txtMaNV.Text;
            p.maKho = Convert.ToString(cmbMKho.Text);

            int m = pdnxkbll.themPDNXK(p);
            if (m == 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");

            dgvPDNXK.DataSource = pdnxkbll.getAllPDNXK();
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtsophieudnxk.Text;
            int kq = pdnxkbll.Update(ma, dtpngaylapphieudnxk.Text, txtMaNV.Text, cmbMKho.Text);

            if (kq == 1)
            {
                dgvPDNXK.DataSource = pdnxkbll.getAllPDNXK();
                MessageBox.Show("Sửa xong!!!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnThemChitietXK_Click(object sender, EventArgs e)
        {
            eCTPhieuDNXK n = new eCTPhieuDNXK()
            {
                soPDNXK = txtsophieu.Text,
                maSP = txtMSP.Text,
                soluong = Convert.ToInt32(txtsoluong.Text),
                Ghichu = txtghichudnxk.Text

            };
            int kq1 = pdnxkbll.themctpdnxk(n);
            if (kq1 == 1 || kq1 != 1)

                MessageBox.Show("Thêm thành công");
            dgvCTPDNXK.DataSource = pdnxkbll.getallctpdnxk();
        }

       

        private void dgvPDNXK_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPDNXK.SelectedRows != null && dgvPDNXK.SelectedRows.Count > 0)
            {
                if (e.Row.Cells["soPDNXK"].Value != null)
                {

                    txtsophieudnxk.Text = e.Row.Cells["soPDNXK"].Value.ToString();
                    string ma = e.Row.Cells["soPDNXK"].Value.ToString();
                    ctpdnxk = pdnxkbll.getallctpdnxk();
                    loaddatagridviewPDNXK1(ctpdnxk, dgvCTPDNXK);

                }

                if (e.Row.Cells["maNV"].Value != null)
                {
                    txtmanhanviendnxk.Text = e.Row.Cells["maNV"].Value.ToString();
                }



                if (e.Row.Cells["maKho"].Value != null)
                {
                    cmbMKho.Text = e.Row.Cells["maKho"].Value.ToString();
                }


            }
        }

        private void dgvCTPDNNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPDNNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPDNXK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPDNNK_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPDNNK.SelectedRows != null && dgvPDNNK.SelectedRows.Count > 0)
            {
                if (e.Row.Cells["soPDNNK"].Value != null)
                {
                    txtsophieu.Text = e.Row.Cells["soPDNNK"].Value.ToString();
                    string ma = e.Row.Cells["soPDNNK"].Value.ToString();
                    ctpdnnk = pdnnkbll.getallctpnnk();
                    loaddatagridviewq(ctpdnnk, dgvCTPDNNK);

                }

                if (e.Row.Cells["maNV"].Value != null)
                {
                    txtMaNV.Text = e.Row.Cells["maNV"].Value.ToString();
                }



                if (e.Row.Cells["maKho"].Value != null)
                {
                    cmbMakho.Text = e.Row.Cells["maKho"].Value.ToString();
                }


            }
        }

        private void btnthemdnnk_Click(object sender, EventArgs e)
        {
            ePhieuDNNK p = new ePhieuDNNK();
            p.soPDNNK = txtsophieu.Text;
            p.ngayLapphieu = Convert.ToString(dtpngaylapphieudnnk.Text);
            p.maNV = txtMaNV.Text;

            p.maKho = cmbMakho.Text;

            int m = pdnnkbll.themPDNNK(p);
            if (m == 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");

            dgvPDNNK.DataSource = pdnnkbll.getAllPDNNK();
            btnsuadnnk.Enabled = true;
        }

        private void btnsuadnnk_Click(object sender, EventArgs e)
        {
            string ma = txtsophieu.Text;
            int kq = pdnnkbll.Update(ma, dtpngaylapphieudnnk.Text, txtMaNV.Text, cmbMakho.Text);

            if (kq == 1)
            {
                dgvPDNNK.DataSource = pdnnkbll.getAllPDNNK();
                MessageBox.Show("Sửa xong!!!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            eCTPhieuDNNK n = new eCTPhieuDNNK()
            {
                soPDNXK = txtsophieu.Text,
                maSP = txtMSP.Text,
                soluong = Convert.ToInt32(txtsoluong.Text),
                Ghichu = txtghichuphieudnnk.Text

            };
            int kq1 = pdnnkbll.themctpdnnk(n);
            if (kq1 == 1 || kq1 != 1)

                MessageBox.Show("Thêm thành công");
            dgvCTPDNNK.DataSource = pdnnkbll.getallctpnnk();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void dgvkhuyenmai_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

            if (dgvkhuyenmai.SelectedRows.Count > 0)
            {

                eKhuyenMai ekm = (eKhuyenMai)bds2.Current;
                txtMaSoDotKhuyenMai.Text = e.Row.Cells["msDotKM"].Value.ToString();
                cmbmsDotKm.Text = e.Row.Cells["msDotKM"].Value.ToString();
                dtpngaybatdaukm.Text = e.Row.Cells["ngayBD"].Value.ToString();
                dtpngayketthuckm.Text = e.Row.Cells["ngayKT"].Value.ToString();
                txtTenDotKhuyenMai.Text = e.Row.Cells["tenDotKM"].Value.ToString();
                txtghiChukm.Text = e.Row.Cells["ghiChu"].Value.ToString();


            }
        }
        }
    }

