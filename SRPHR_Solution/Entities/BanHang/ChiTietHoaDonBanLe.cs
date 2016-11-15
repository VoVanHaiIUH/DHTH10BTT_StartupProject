﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BanHang
{
    public class ChiTietHoaDonBanLe
    {
        private string soHoaDon, maSP, ghiChu;
        private double soLuong;
        private decimal donGia;

        public string SoHoaDon
        {
            get
            {
                return soHoaDon;
            }

            set
            {
                soHoaDon = value;
            }
        }

        public string MaSP
        {
            get
            {
                return maSP;
            }

            set
            {
                maSP = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public double SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public decimal DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public ChiTietHoaDonBanLe(string soHoaDon, string maSP, string ghiChu, double soLuong, decimal donGia)
        {
            soHoaDon = SoHoaDon;
            maSP = MaSP;
            ghiChu = GhiChu;
            soLuong = SoLuong;
            donGia = DonGia;
        }

        public override bool Equals(object obj)
        {
            ChiTietHoaDonBanLe cthdbl = (ChiTietHoaDonBanLe)obj;
            return cthdbl.Equals(cthdbl.soHoaDon);
        }
        public override int GetHashCode()
        {
            return soHoaDon.GetHashCode();
        }
    }
}
