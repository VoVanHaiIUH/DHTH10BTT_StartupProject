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
    public partial class PQLKho : Form
    {
        List<ePhieuQLiKho> listpqlk;
        PhieuQLKho_BLL bllpqlk;
        Kho_BLL bllKho;
        public PQLKho()
        {
            InitializeComponent();
            bllpqlk = new PhieuQLKho_BLL();
            listpqlk = new List<ePhieuQLiKho>();
            listpqlk = bllpqlk.getAllPQLKho();
            bllKho = new Kho_BLL();
            duadulieulendgvCTPQL(dgvPQLK, listpqlk);
            DuadulieulencomboboxMaKho(comboBoxMaKho);
            loaddulieulencomboboxTinhTrang(comboTinhTrang);
            chedotextbox(false);
            chedobutton(true);
        }
        public void loaddata()
        {

        }
        public void DuadulieulencomboboxMaKho(ComboBox cb)
        {
            this.comboBoxMaKho.DataSource = bllKho.LayDanhSachKho();
            this.comboBoxMaKho.DisplayMember = "_maKho";
            this.comboBoxMaKho.ValueMember = "_maKho";
        }
        public void loaddulieulencomboboxTinhTrang(ComboBox cb)
        {
            cb.Items.Add("0");
            cb.Items.Add("1");
        }
        public void chedotextbox(bool statis)
        {
            txtmphieu.ReadOnly = !statis;
            comboBoxMaKho.Enabled = statis;
            comboboxMaNV.Enabled = statis;
            dtpNgayLap.Enabled = statis;
            comboTinhTrang.Enabled = statis;
        }
        public void chedobutton(bool statis)
        {
            btnthem.Enabled = statis;
            btnsua.Enabled = statis;
            btnLuu.Enabled = !statis;
            btnXacNhan.Enabled = !statis;
        }
        public void duadulieulendgvCTPQL(DataGridView dgv, List<ePhieuQLiKho> ls)
        {
            dgv.DataSource = ls;
        }
        private void PQLKho_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (btnthem.Text == "Thêm")
            {
                chedobutton(false);
                btnXacNhan.Enabled = false;
                btnthem.Enabled = true;
                btnthem.Text = "Bỏ qua";
                chedotextbox(true);
            }
            else
            {
                btnthem.Text = "Thêm";
                chedobutton(true);
                chedotextbox(false);
                listpqlk = bllpqlk.getAllPQLKho();
                duadulieulendgvCTPQL(dgvPQLK, listpqlk);
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "Sửa")
            {
                chedobutton(false);
                btnsua.Enabled = true;
                btnLuu.Enabled = false;
                btnsua.Text = "Bỏ qua";
                chedotextbox(true);
                comboBoxMaKho.Enabled = false;
                btnXacNhan.Enabled = true;
                txtmphieu.ReadOnly = true;

            }
            else
            {
                chedobutton(true);
                btnXacNhan.Enabled = false;
                chedotextbox(false);
                listpqlk = bllpqlk.getAllPQLKho();
                duadulieulendgvCTPQL(dgvPQLK, listpqlk);
                btnsua.Text = "Sửa";
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ePhieuQLiKho newpNk = new ePhieuQLiKho();
                newpNk._maNV = comboboxMaNV.Text;
                newpNk._maKho = comboBoxMaKho.Text;
                newpNk._maPhieuQli = txtmphieu.Text;
                newpNk._tinhTrang = comboTinhTrang.Text;
                newpNk._ngayLapQLi = dtpNgayLap.Value;
                int kq = bllpqlk.AddAllPhieuQLK(newpNk);
                if (kq == 1)
                    MessageBox.Show("Thêm thành công!!!");
                else
                    MessageBox.Show("Trùng mã phiếu!!");
                listpqlk = bllpqlk.getAllPQLKho();
                //listtp = blltp.getthuephongbymaphong(txtmaphong.Text);
                duadulieulendgvCTPQL(dgvPQLK, listpqlk);
                chedobutton(true);
                chedotextbox(false);
                btnthem.Text = "Thêm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string map = txtmphieu.Text;
            if (bllpqlk.Kiemtrasutontai(map) == true)
            {
                bllpqlk.UpDatePhieuQLK(map, comboboxMaNV.Text, comboBoxMaKho.Text, comboTinhTrang.Text, dtpNgayLap.Value);
                MessageBox.Show("Sửa xong !!");
                chedobutton(true);
                btnXacNhan.Enabled = false;
                chedotextbox(false);

                listpqlk = bllpqlk.getAllPQLKho();
                duadulieulendgvCTPQL(dgvPQLK, listpqlk);
                btnsua.Text = "Sửa";
            }
            else { MessageBox.Show("bạn chưa chọn vào phiếu quản lý kho cần sửa thông tin!"); }
        }

        private void dgvPQLK_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPQLK.SelectedRows.Count > 0)
            {
                txtmphieu.Text = e.Row.Cells["_maPhieuQli"].Value.ToString();
                comboBoxMaKho.Text = e.Row.Cells["_maKho"].Value.ToString();
                comboboxMaNV.Text = e.Row.Cells["_maNV"].Value.ToString();
                comboTinhTrang.Text = e.Row.Cells["_tinhTrang"].Value.ToString();
                dtpNgayLap.Text = e.Row.Cells["_ngayLapQLi"].Value.ToString();
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            CTPhieuQlyKho f = new CTPhieuQlyKho();
            f.ShowDialog();
        }
    }
}
