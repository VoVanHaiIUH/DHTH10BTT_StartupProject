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
using Entities.CongNoPKH;

namespace SRPHR_Solution.Kho
{
    public partial class NhapKho : Form
    {
        PhieuNK_BLL bllpNK;
        List<ePhieuNK> listpNK;
        List<ePhieuDNNK> listpDNNK;
        NhanDuLieuTuPKH_BLL bllNDLTPKH;
        Kho_BLL bllKho;
        public NhapKho()
        {
            InitializeComponent();
            bllpNK = new PhieuNK_BLL();
            bllKho = new Kho_BLL();
            bllNDLTPKH = new NhanDuLieuTuPKH_BLL();

            listpNK = new List<ePhieuNK>();
            listpNK = bllpNK.laydanhsachphieuNhapKho();
            listpDNNK = new List<ePhieuDNNK>();
            listpDNNK = bllNDLTPKH.laydanhsachPhieuDNNK();
            LoaddulieulendatagridviewPhieuNhapKho(dgvNhapKho, listpNK);
            LoaddulieulendatagridviewPhieuDeNghiNhapKho(dgvPhieuDNChuaLap, listpDNNK);
            DuadulieulencomboboxMaKho(cbbMaKho);
            loaddulieulencomboboxTinhTrang(cbbTinhTrang);
            CheDoButton(true);
            CheDoComboBox(false);
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
            txtMaPhieuNhap.ReadOnly = !status;
            cbbTinhTrang.Enabled = status;
            dtpNgayLapPhieu.Enabled = status;
        }
        private void NhapKho_Load(object sender, EventArgs e)
        {

        }
        public void LoaddulieulendatagridviewPhieuNhapKho(DataGridView dgv, List<ePhieuNK> lsnk)
        {
            dgv.DataSource = lsnk;
        }
        public void LoaddulieulendatagridviewPhieuDeNghiNhapKho(DataGridView dgv, List<ePhieuDNNK> ls)
        {
            dgv.DataSource = ls;
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
                listpNK = bllpNK.laydanhsachphieuNhapKho();
                LoaddulieulendatagridviewPhieuNhapKho(dgvNhapKho, listpNK);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ePhieuNK newpNk = new ePhieuNK();
                newpNk._maNV = cbbMaNV.Text;
                newpNk._maPhieuNhap = txtMaPhieuNhap.Text;
                newpNk._msKho = cbbMaKho.Text;
                newpNk._tinhTrang = cbbTinhTrang.Text;
                newpNk._ngayLapNhap = dtpNgayLapPhieu.Value;
                int kq = bllpNK.ThemPhieuNhapKho(newpNk);
                if (kq == 1)
                    MessageBox.Show("Thêm thành công!!!");
                else
                    MessageBox.Show("Trùng mã phiếu!!");
                listpNK = bllpNK.laydanhsachphieuNhapKho();
                //listtp = blltp.getthuephongbymaphong(txtmaphong.Text);
                LoaddulieulendatagridviewPhieuNhapKho(dgvNhapKho, listpNK);
                CheDoButton(true);
                CheDoComboBox(false);
                btnThem.Text = "Thêm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listpDNNK = bllNDLTPKH.laydanhsachPhieuDNNK();
            LoaddulieulendatagridviewPhieuDeNghiNhapKho(dgvPhieuDNChuaLap, listpDNNK);
        }

        private void dgvPhieuDNChuaLap_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPhieuDNChuaLap.SelectedRows.Count > 0)
            {
                txtMaPhieuNhap.Text = e.Row.Cells["soPDNNK"].Value.ToString();
                cbbMaKho.Text = e.Row.Cells["maKho"].Value.ToString();
            }
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
                cbbMaKho.Enabled = false;
                btnXacNhan.Enabled = true;
                txtMaPhieuNhap.ReadOnly = true;

            }
            else
            {
                CheDoButton(true);
                btnXacNhan.Enabled = false;
                CheDoComboBox(false);
                listpNK = bllpNK.laydanhsachphieuNhapKho();
                LoaddulieulendatagridviewPhieuNhapKho(dgvNhapKho, listpNK);
                btnSua.Text = "Sửa";
            }
        }

        private void dgvNhapKho_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvNhapKho.SelectedRows.Count > 0)
            {
                txtMaPhieuNhap.Text = e.Row.Cells["_maPhieuNhap"].Value.ToString();
                cbbMaKho.Text = e.Row.Cells["_msKho"].Value.ToString();
                cbbMaNV.Text = e.Row.Cells["_maNV"].Value.ToString();
                cbbTinhTrang.Text = e.Row.Cells["_tinhTrang"].Value.ToString();
                dtpNgayLapPhieu.Text = e.Row.Cells["_ngayLapNhap"].Value.ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string map = txtMaPhieuNhap.Text;
            if (bllpNK.Kiemtrasutontai(map) == true)
            {
                bllpNK.UpDatePhieuNK(map, cbbMaKho.Text, dtpNgayLapPhieu.Value, cbbTinhTrang.Text, cbbMaNV.Text);
                MessageBox.Show("Sửa xong !!");
                CheDoButton(true);
                btnXacNhan.Enabled = false;
                CheDoComboBox(false);

                listpNK = bllpNK.laydanhsachphieuNhapKho();
                LoaddulieulendatagridviewPhieuNhapKho(dgvNhapKho, listpNK);
                btnSua.Text = "Sửa";
            }
            else { MessageBox.Show("bạn chưa chọn vào phiếu nhập kho cần sửa thông tin!"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCTphieuDN_Click(object sender, EventArgs e)
        {
            ChiTietNhapKho f = new ChiTietNhapKho();
            f.ShowDialog();
        }
    }
}
