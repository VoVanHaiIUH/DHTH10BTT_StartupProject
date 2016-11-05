using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.PhanQuyen;
using Entities.PhanQuyen;


namespace SRPHR_Solution.PhanQuyen
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
        }

        TaiKhoanBLL taikhoanbll = new TaiKhoanBLL();
        string pq="";
        string[] mpq = new string[30];
        NhomTKBLL nhombll = new NhomTKBLL();
        private void button5_Click(object sender, EventArgs e)
        {
            // thoát form QLPQ
            Visible = false;
            ShowInTaskbar = false;

            // show form PQ
            FormPhanQuyen frmnew = new FormPhanQuyen();
            frmnew.Activate();
            frmnew.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(taikhoanbll.GetPQbyID(cbTaikhoan.SelectedValue.ToString()));
        }

        private void cb15_CheckedChanged(object sender, EventArgs e)
        {
            
            if(cb15.Checked==true)
            {
                mpq[0] = "1";
                cb11.Checked = true;
                cb12.Checked = true;
                cb13.Checked = true;
                cb14.Checked = true;
            }
            else
            {
                mpq[0] = "0";
                cb11.Checked = false;
                cb12.Checked = false;
                cb13.Checked = false;
                cb14.Checked = false;
            }
        }

        private void cb25_CheckedChanged(object sender, EventArgs e)
        {
            if (cb25.Checked == true)
            {
                 mpq[1] = "1";
                cb21.Checked = true;
                cb22.Checked = true;
                cb23.Checked = true;
                cb24.Checked = true;
            }
            else
            {
                mpq[1] = "0";
                cb21.Checked = false;
                cb22.Checked = false;
                cb23.Checked = false;
                cb24.Checked = false;
            }
        }

        private void cb35_CheckedChanged(object sender, EventArgs e)
        {
            if (cb35.Checked == true)
            {
                mpq[2] = "1";
                cb31.Checked = true;
                cb32.Checked = true;
                cb33.Checked = true;
                cb34.Checked = true;
            }
            else
            {
                mpq[2] = "0";
                cb31.Checked = false;
                cb32.Checked = false;
                cb33.Checked = false;
                cb34.Checked = false;
            }
        }

        private void cb45_CheckedChanged(object sender, EventArgs e)
        {
            if (cb45.Checked == true)
            {
                mpq[3] = "1";
                cb41.Checked = true;
                cb42.Checked = true;
                cb43.Checked = true;
                cb44.Checked = true;
            }
            else
            {
                mpq[3] = "0";
                cb41.Checked = false;
                cb42.Checked = false;
                cb43.Checked = false;
                cb44.Checked = false;
            }
        }

        private void cb55_CheckedChanged(object sender, EventArgs e)
        {
            if (cb55.Checked == true)
            {
                mpq[4] = "1";
                cb51.Checked = true;
                cb52.Checked = true;
                cb53.Checked = true;
                cb54.Checked = true;
            }
            else
            {
                mpq[4] = "0";
                cb51.Checked = false;
                cb52.Checked = false;
                cb53.Checked = false;
                cb54.Checked = false;
            }
        }

        private void cb65_CheckedChanged(object sender, EventArgs e)
        {
            if (cb65.Checked == true)
            {
                mpq[5] = "1";
                cb61.Checked = true;
                cb62.Checked = true;
                cb63.Checked = true;
                cb64.Checked = true;
            }
            else
            {
                mpq[5] = "0";
                cb61.Checked = false;
                cb62.Checked = false;
                cb63.Checked = false;
                cb64.Checked = false;
            }
        }
        private void cb_Checked(Object sender, EventArgs e)
        {
            if(cb61.Checked ==true&&cb62.Checked == true&&cb63.Checked == true&&cb64.Checked == true)
            {
                cb65.Checked = true;
            }
            if (cb51.Checked == true && cb52.Checked == true && cb53.Checked == true && cb54.Checked == true)
            {
                cb55.Checked = true;
            }
            if (cb41.Checked == true && cb42.Checked == true && cb43.Checked == true && cb44.Checked == true)
            {
                cb45.Checked = true;
            }
            if (cb31.Checked == true && cb32.Checked == true && cb33.Checked == true && cb34.Checked == true)
            {
                cb35.Checked = true;
            }
            if (cb21.Checked == true && cb22.Checked == true && cb23.Checked == true && cb24.Checked == true)
            {
                cb25.Checked = true;
            }
            if (cb11.Checked == true && cb12.Checked == true && cb13.Checked == true && cb14.Checked == true)
            {
                cb15.Checked = true;
            }
            //chuc nang them ban hang
            if (cb11.Checked == true)
                mpq[6] = "1";
            else
                mpq[6] = "0";
            //chuc nang sua ban hang
            if (cb12.Checked == true)
                mpq[7] = "1";
            else
                mpq[7] = "0";
            //chuc nang xoa ban hang
            if (cb13.Checked == true)
                mpq[8] = "1";
            else
                mpq[8] = "0";
            //chuc nang xem ban hang
            if (cb14.Checked == true)
                mpq[9] = "1";
            else
                mpq[9] = "0";
            //chuc nang them bao cao
            if (cb21.Checked == true)
                mpq[10] = "1";
            else
                mpq[10] = "0";
            //chuc nang xoa bao cao
            if (cb22.Checked == true)
                mpq[11] = "1";
            else
                mpq[11] = "0";
            //chuc nang sua bao cao
            if (cb23.Checked == true)
                mpq[12] = "1";
            else
                mpq[12] = "0";
            //chuc nang xem bao cao
            if (cb24.Checked == true)
                mpq[13] = "1";
            else
                mpq[13] = "0";

            //chuc nang them cong no
            if (cb31.Checked == true)
                mpq[14] = "1";
            else
                mpq[14] = "0";
            //chuc nang xoa cong no
            if (cb32.Checked == true)
                mpq[15] = "1";
            else
                mpq[15] = "0";
            //chuc nang sua cong no
            if (cb33.Checked == true)
                mpq[16] = "1";
            else
                mpq[16] = "0";
            //chuc nang xem cong no
            if (cb34.Checked == true)
                mpq[17] = "1";
            else
                mpq[17] = "0";

            //chuc nang them khach hang
            if (cb41.Checked == true)
                mpq[18] = "1";
            else
                mpq[18] = "0";
            //chuc nang xoa khach hang
            if (cb42.Checked == true)
                mpq[19] = "1";
            else
                mpq[19] = "0";
            //chuc nang sua khach hang
            if (cb43.Checked == true)
                mpq[20] = "1";
            else
                mpq[20] = "0";
            //chuc nang xem khach hang
            if (cb44.Checked == true)
                mpq[21] = "1";
            else
                mpq[21] = "0";

            //chuc nang them Kho
            if (cb51.Checked == true)
                mpq[22] = "1";
            else
                mpq[22] = "0";
            //chuc nang xoa Kho
            if (cb52.Checked == true)
                mpq[23] = "1";
            else
                mpq[23] = "0";
            //chuc nang sua Kho
            if (cb53.Checked == true)
                mpq[24] = "1";
            else
                mpq[24] = "0";
            //chuc nang xem Kho
            if (cb54.Checked == true)
                mpq[25] = "1";
            else
                mpq[25] = "0";

            //chuc nang them Nhan su
            if (cb61.Checked == true)
                mpq[26] = "1";
            else
                mpq[26] = "0";
            //chuc nang xoa Nhan su
            if (cb62.Checked == true)
                mpq[27] = "1";
            else
                mpq[27] = "0";
            //chuc nang sua Nhan su
            if (cb63.Checked == true)
                mpq[28] = "1";
            else
                mpq[28] = "0";
            //chuc nang xem Nhan su
            if (cb64.Checked == true)
                mpq[29] = "1";
            else
                mpq[29] = "0";

        }

        private void FormQL_Load(object sender, EventArgs e)
        {
            
            loadcbUser();
           
            loadpq(taikhoanbll.GetPQbyID(cbTaikhoan.SelectedValue.ToString()));
            
            
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            clearallcb();   
        }
        private void clearallcb()
        {
            cb15.Checked = true;
            cb25.Checked = true;
            cb35.Checked = true;
            cb45.Checked = true;
            cb55.Checked = true;
            cb65.Checked = true;
            cb15.Checked = false;
            cb25.Checked = false;
            cb35.Checked = false;
            cb45.Checked = false;
            cb55.Checked = false;
            cb65.Checked = false;
        }
        private void loadcbUser()
        {
            cbTaikhoan.DataSource = taikhoanbll.GetAllTaiKhoan();
            cbTaikhoan.DisplayMember = "ID1";
            cbTaikhoan.ValueMember = "ID1";
            
        }

        private void cbTaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void loadpq(string pq)
        {
            clearallcb();
            string[] cstr = new string[pq.Length];
            cstr = taikhoanbll.ChuyenChuoithanhmang(pq);
            //Load du lieu phan quyen cho cac checkbox all

            for (int i = 0; i < 30;i++ )
            {
                if (cstr[i] == "1")
                {
                    //load du lieu cho cac checkbox all
                    if(i==0)
                        cb15.Checked = true;
                    if (i == 1)
                        cb25.Checked = true;
                    if (i == 2)
                        cb35.Checked = true;
                    if (i == 3)
                        cb45.Checked = true;
                    if (i == 4)
                        cb55.Checked = true;
                    if (i == 5)
                        cb65.Checked = true;

                    //load du lieu cho cac checkbox con lai
                    // ban hang
                    if (i == 6)
                        cb11.Checked = true;
                    if (i == 7)
                        cb12.Checked = true;
                    if (i == 8)
                        cb13.Checked = true;
                    if (i == 9)
                        cb14.Checked = true;
                    if (i == 10)

                    //bao cao
                        cb21.Checked = true;
                    if (i == 11)
                        cb22.Checked = true;
                    if (i ==12)
                        cb23.Checked = true;
                    if (i == 13)
                        cb24.Checked = true;
                    if (i == 14)
                    //cong no
                        cb31.Checked = true;
                    if (i == 15)
                        cb32.Checked = true;
                    if (i == 16)
                        cb33.Checked = true;
                    if (i == 17)
                        cb34.Checked = true;
                    if (i == 18)
                        //khach hang
                        cb41.Checked = true;
                    if (i == 19)
                        cb42.Checked = true;
                    if (i == 20)
                        cb43.Checked = true;
                    if (i == 21)
                        cb44.Checked = true;
                    //Kho
                    if (i == 22)
                        cb51.Checked = true;
                    if (i == 23)
                        cb52.Checked = true;
                    if (i == 24)
                        cb53.Checked = true;
                    if (i == 25)
                        cb54.Checked = true;
                    //Nhan su
                    if (i == 26)
                        cb61.Checked = true;
                    if (i == 27)
                        cb62.Checked = true;
                    if (i == 28)
                        cb63.Checked = true;
                    if (i == 29)
                        cb64.Checked = true;

                }
            

            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
           int kq= taikhoanbll.ThemPQ(cbTaikhoan.SelectedValue.ToString(), taikhoanbll.Chuyenmangthanhchuoi(mpq));
           if (kq == 1)
               MessageBox.Show("Sửa thành công");
           else
               MessageBox.Show("Thất bại");
        }
        private void loadcbnhom()
        {
            combonhom.DataSource = nhombll.GetAllNhom();          
            combonhom.DisplayMember = "TenNhom1";
            combonhom.ValueMember = "IdNhom1";
        }

        private void cbnhom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnhom.Checked == true)
            {
                combonhom.Enabled = true;
                loadcbnhom();
                btnthemnhom.Enabled = true;
            }
            else
            {
                btnthemnhom.Enabled = false;
                combonhom.Enabled = false;
            }
        }

        private void combonhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTaikhoan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maid = (string)((ComboBox)sender).SelectedValue;
            loadpq(taikhoanbll.GetPQbyID(maid));
        }

        private void combonhom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string manhom = (string)((ComboBox)sender).SelectedValue;
            loadpq(nhombll.GetPQbyMaNhom(manhom));
        }

        private void btnthemnhom_Click(object sender, EventArgs e)
        {
            combonhom.Visible = false;
            lbbien.Text = "Tên nhóm :";
            txttennhom.Visible = true;
            cbTaikhoan.Visible = false;
            cbnhom.Visible = false;
            lbmanhom.Visible = true;
            txtmanhom.Visible = true;
            btnthem.Visible = true;
            btnhuy.Visible = true;
            btnquaylai.Visible = false;
            btnphanquyen.Visible = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            lbbien.Text = "Tài Khoản :";
            txttennhom.Visible = false;
            cbTaikhoan.Visible = true;
            cbnhom.Visible = true;
            lbmanhom.Visible = false;
            txtmanhom.Visible = false;
            btnthem.Visible = false;
            btnhuy.Visible = false;
            btnquaylai.Visible = true;
            btnphanquyen.Visible = true;
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            eNhom n = new eNhom();
            n.IdNhom1 = txtmanhom.Text;
            n.TenNhom1 = txttennhom.Text;
            n.PhanQuyen1 = taikhoanbll.Chuyenmangthanhchuoi(mpq);
            int kq = nhombll.them1nhom(n);
            if (kq == 1)
            {
                loadcbnhom();
                combonhom.Visible = true;
                lbbien.Text = "Tài Khoản :";
                txttennhom.Visible = false;
                cbTaikhoan.Visible = true;
                cbnhom.Visible = true;
                lbmanhom.Visible = false;
                txtmanhom.Visible = false;
                btnthem.Visible = false;
                btnhuy.Visible = false;
                btnquaylai.Visible = true;
                btnphanquyen.Visible = true;
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thất bại");
        }
    }
}
