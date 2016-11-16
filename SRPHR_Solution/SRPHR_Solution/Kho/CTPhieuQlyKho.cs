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
using BusinessLogic.Kho;
namespace SRPHR_Solution.Kho
{
    public partial class CTPhieuQlyKho : Form
    {
        CTPQLKho_BLL bllCTqlkho;
        PhieuQLKho_BLL bllpqlk;
        List<eCTPhieuQlyKho> listCTqlykho;
        List<ePhieuQLiKho> listpqlk;

        public CTPhieuQlyKho()
        {

            InitializeComponent();
            bllCTqlkho = new CTPQLKho_BLL();
            listCTqlykho = new List<eCTPhieuQlyKho>();
            laydulieulencomboboxMaphieu(cbbMaPhieuQL);
            listCTqlykho = bllCTqlkho.getCTPhieuQLKhoTheoMaPhieu(cbbMaPhieuQL.Text);
            duadulieulendgview(dgvCTPQLK, listCTqlykho);
            CheDoButton(true);
            CheDoTextBox(false);
        }
        public void CheDoButton(bool status)
        {
            btnThem.Enabled = status;
            btnSua.Enabled = status;
            btnLuu.Enabled = !status;
            btnXacNhan.Enabled = !status;
        }
        public void CheDoTextBox(bool status)
        {
            txtSTT.Enabled = status;
            cbbMaSP.Enabled = status;
            cbbTenSP.Enabled = status;
            txtSoluong.Enabled = status;
            txtDonVi.Enabled = status;
        }
        public void duadulieulendgview(DataGridView dgv, List<eCTPhieuQlyKho> ls)
        {
            dgv.DataSource = ls;
        }
        public void laydulieulencomboboxMaphieu(ComboBox cb)
        {
            bllpqlk = new PhieuQLKho_BLL();
            this.cbbMaPhieuQL.DataSource = bllpqlk.getAllPQLKho();
            this.cbbMaPhieuQL.DisplayMember = "_maPhieuQli";
            this.cbbMaPhieuQL.ValueMember = "_maPhieuQli";
        }
        private void CTPhieuQlyKho_Load(object sender, EventArgs e)
        {

        }

        private void cbbMaPhieuQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCTqlykho = bllCTqlkho.getCTPhieuQLKhoTheoMaPhieu(cbbMaPhieuQL.Text);
            duadulieulendgview(dgvCTPQLK, listCTqlykho);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCTPQLK_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvCTPQLK.SelectedRows.Count > 0)
            {
                cbbMaPhieuQL.Text = e.Row.Cells["_maPhieuQli"].Value.ToString();
                txtSTT.Text = e.Row.Cells["_sTT"].Value.ToString();
                txtSoluong.Text = e.Row.Cells["_soLuong"].Value.ToString();
                txtDonVi.Text = e.Row.Cells["_donVi"].Value.ToString();
                cbbMaSP.Text = e.Row.Cells["_maSP"].Value.ToString();
                cbbTenSP.Text = e.Row.Cells["_tenSP"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                CheDoButton(false);
                btnXacNhan.Enabled = false;
                btnThem.Enabled = true;
                btnThem.Text = "Bỏ qua";
                CheDoTextBox(true);
            }
            else
            {
                btnThem.Text = "Thêm";
                CheDoButton(true);
                CheDoTextBox(false);
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
                CheDoTextBox(true);
                cbbMaPhieuQL.Enabled = false;
                btnXacNhan.Enabled = true;
            }
            else
            {
                CheDoButton(true);
                btnXacNhan.Enabled = false;
                CheDoTextBox(false);
                btnSua.Text = "Sửa";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                eCTPhieuQlyKho newect = new eCTPhieuQlyKho();
                newect._maPhieuQly = cbbMaPhieuQL.Text;
                newect._sTT = txtSTT.Text;
                newect._maSP = cbbMaSP.Text;
                newect._tenSP = cbbMaSP.Text;
                newect._soLuongQly = Convert.ToInt32(txtSoluong.Text);
                newect._donVi = txtDonVi.Text;
                bool kq = bllCTqlkho.AddAllCTPQLKho(newect);
                if (kq)
                    MessageBox.Show("Thêm thành công!!!");
                else
                    MessageBox.Show("Trùng mã phiếu!!");
                listCTqlykho = bllCTqlkho.getCTPhieuQLKhoTheoMaPhieu(cbbMaPhieuQL.Text);
                //listtp = blltp.getthuephongbymaphong(txtmaphong.Text);
                duadulieulendgview(dgvCTPQLK, listCTqlykho);
                CheDoButton(true);
                CheDoTextBox(false);
                btnThem.Text = "Thêm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            eCTPhieuQlyKho ect = new eCTPhieuQlyKho();
            ect._donVi = txtDonVi.Text;
            ect._maPhieuQly = cbbMaPhieuQL.Text;
            ect._maSP = cbbMaSP.Text;
            ect._tenSP = cbbTenSP.Text;
            ect._soLuongQly = Convert.ToInt32(txtSoluong.Text);
            ect._sTT = txtSTT.Text;
            if (bllCTqlkho.UpdateCTPQLKho(ect))
            {

                MessageBox.Show("Sửa xong !!");
                CheDoButton(true);
                btnXacNhan.Enabled = false;
                CheDoTextBox(false);

                listCTqlykho = bllCTqlkho.getCTPhieuQLKhoTheoMaPhieu(cbbMaPhieuQL.Text);
                duadulieulendgview(dgvCTPQLK, listCTqlykho);
                btnSua.Text = "Sửa";
            }
            else { MessageBox.Show("bạn chưa chọn vào phiếu nhập kho cần sửa thông tin!"); }
        }
    }
}
