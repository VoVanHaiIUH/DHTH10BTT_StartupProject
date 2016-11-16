using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Kho;
using Entities.CongNoPKH;
using BusinessLogic.Kho;
namespace SRPHR_Solution.Kho
{
    public partial class XuatKhoFrm : Form
    {
        PhieuXK_BLL bllpXK;
        List<ePhieuXK> listpXK;
        List<ePhieuDNXK> listpDNXK;
        NhanDuLieuTuPKH_BLL bllNDLTPKH;
        Kho_BLL bllKho;
        public XuatKhoFrm()
        {
            InitializeComponent();
            bllpXK = new PhieuXK_BLL();
            bllKho = new Kho_BLL();
            bllNDLTPKH = new NhanDuLieuTuPKH_BLL();

            listpXK = new List<ePhieuXK>();
            listpXK = bllpXK.laydanhsachphieuXuatKho();
            listpDNXK = new List<ePhieuDNXK>();
            listpDNXK = bllNDLTPKH.laydanhsachPhieuDNXK();
            LoaddulieulendatagridviewPhieuXuatKho(dgvXuatKho, listpXK);
            LoaddulieulendatagridviewPhieuDeNghiXuatKho(dgvPhieuDNChuaLap, listpDNXK);
            DuadulieulencomboboxMaKho(cbbMaKho);
            loaddulieulencomboboxTinhTrang(cbbTinhTrang);
            CheDoButton(true);
            CheDoComboBox(false);
        }
        public void LoaddulieulendatagridviewPhieuXuatKho(DataGridView dgv, List<ePhieuXK> lsnk)
        {
            dgv.DataSource = lsnk;
        }
        public void LoaddulieulendatagridviewPhieuDeNghiXuatKho(DataGridView dgv, List<ePhieuDNXK> ls)
        {
            dgv.DataSource = ls;
        }
        public void CheDoButton(bool status)
        {
            btnThem.Enabled = status;
            btnSua.Enabled = status;
            btnLuu.Enabled = !status;
            btnXacNhan.Enabled = !status;
        }
        public void CheDoComboBox(bool status)
        {
            cbbMaKho.Enabled = status;
            cbbMaNV.Enabled = status;
            txtMaPhieuXuat.ReadOnly = !status;
            cbbTinhTrang.Enabled = status;
            dtpNgayLapPhieu.Enabled = status;
        }
        public void DuadulieulencomboboxMaKho(ComboBox cb)
        {
            this.cbbMaKho.DataSource = bllKho.LayDanhSachKho();
            this.cbbMaKho.DisplayMember = "_maKho";
            this.cbbMaKho.ValueMember = "_maKho";
        }
        public void loaddulieulencomboboxTinhTrang(ComboBox cb)
        {
            cb.Items.Add("0");
            cb.Items.Add("1");
        }

        private void XuatKhoFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                CheDoButton(false);
                btnXacNhan.Enabled = false;
                btnThem.Enabled = true;
                btnThem.Text = "Bỏ qua";
                CheDoComboBox(true);
            }
            else
            {
                btnThem.Text = "Thêm";
                CheDoButton(true);
                CheDoComboBox(false);
                listpXK = bllpXK.laydanhsachphieuXuatKho();
                LoaddulieulendatagridviewPhieuXuatKho(dgvXuatKho, listpXK);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ePhieuXK newpXk = new ePhieuXK();
                newpXk._maNV = cbbMaNV.Text;
                newpXk._maPhieuXuat = txtMaPhieuXuat.Text;
                newpXk._maKho = cbbMaKho.Text;
                newpXk._tinhTrang = cbbTinhTrang.Text;
                newpXk._ngayLapXuat = dtpNgayLapPhieu.Value;
                int kq = bllpXK.ThemPhieuXuatKho(newpXk);
                if (kq == 1)
                    MessageBox.Show("Thêm thành công!!!");
                else
                    MessageBox.Show("Trùng mã phiếu!!");
                listpXK = bllpXK.laydanhsachphieuXuatKho();
                //listtp = blltp.getthuephongbymaphong(txtmaphong.Text);
                LoaddulieulendatagridviewPhieuXuatKho(dgvXuatKho, listpXK);
                CheDoButton(true);
                CheDoComboBox(false);
                btnThem.Text = "Thêm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listpDNXK = bllNDLTPKH.laydanhsachPhieuDNXK();
            LoaddulieulendatagridviewPhieuDeNghiXuatKho(dgvPhieuDNChuaLap, listpDNXK);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                CheDoButton(false);
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Text = "Bỏ qua";
                CheDoComboBox(true);
                btnXacNhan.Enabled = true;
                txtMaPhieuXuat.ReadOnly = true;

            }
            else
            {
                CheDoButton(true);
                btnXacNhan.Enabled = false;
                CheDoComboBox(false);
                listpXK = bllpXK.laydanhsachphieuXuatKho();
                LoaddulieulendatagridviewPhieuXuatKho(dgvXuatKho, listpXK);
                btnSua.Text = "Sửa";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string map = txtMaPhieuXuat.Text;
            if (bllpXK.Kiemtrasutontai(map) == true)
            {
                bllpXK.UpDatePhieuXK(map, cbbMaKho.Text, dtpNgayLapPhieu.Value, cbbTinhTrang.Text, cbbMaNV.Text);
                MessageBox.Show("Sửa xong !!");
                CheDoButton(true);
                btnXacNhan.Enabled = false;
                CheDoComboBox(false);

                listpXK = bllpXK.laydanhsachphieuXuatKho();
                LoaddulieulendatagridviewPhieuXuatKho(dgvXuatKho, listpXK);
                btnSua.Text = "Sửa";
            }
            else { MessageBox.Show("bạn chưa chọn vào phiếu xuất kho cần sửa thông tin!"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCTphieuDN_Click(object sender, EventArgs e)
        {
            ChiTietXuatKho f = new ChiTietXuatKho();
            f.ShowDialog();
        }

        private void dgvXuatKho_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvXuatKho.SelectedRows.Count > 0)
            {
                txtMaPhieuXuat.Text = e.Row.Cells["_maPhieuNhap"].Value.ToString();
                cbbMaKho.Text = e.Row.Cells["_msKho"].Value.ToString();
                cbbMaNV.Text = e.Row.Cells["_maNV"].Value.ToString();
                cbbTinhTrang.Text = e.Row.Cells["_tinhTrang"].Value.ToString();
                dtpNgayLapPhieu.Text = e.Row.Cells["_ngayLapNhap"].Value.ToString();
            }
        }

        private void dgvPhieuDNChuaLap_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPhieuDNChuaLap.SelectedRows.Count > 0)
            {
                txtMaPhieuXuat.Text = e.Row.Cells["soPDNNK"].Value.ToString();
                cbbMaKho.Text = e.Row.Cells["maKho"].Value.ToString();
            }
        }
    }
}
