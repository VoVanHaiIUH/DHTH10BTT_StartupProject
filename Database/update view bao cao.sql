USE [SHRPR]
GO
/****** Object:  View [dbo].[BCBanLe]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[BCBanLe] as
select bl.soHoaDon, bl.maKH, bl.maNV, bl.ngayBan, ct.donGia, ct.maSP, ct.soLuong
from Tbl_HDBanLe bl join Tbl_CTHDBanLe ct on bl.soHoaDon=ct.soHoaDon

GO
/****** Object:  View [dbo].[vw_baocaokhuyenmai]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_baocaokhuyenmai]
as
select km.msDotKM, km.tenDotKM,km.ngayBD,km.ngayKT,sp.tenSP
from Tbl_KhuyenMai km join Tbl_CTKhuyenMai ctkm  on km.msDotKM=ctkm.msDotKM
join Tbl_SanPham sp on sp.maSP=ctkm.maSP

GO
/****** Object:  View [dbo].[vw_baocaosanpham]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vw_baocaosanpham] as
select sp.maSP,sp.tenSP,ct.soLuong,hd.tongTien,hd.ngayBan
from Tbl_HDBanLe hd join Tbl_CTHDBanLe ct on hd.soHoaDon=ct.soHoaDon
join Tbl_SanPham sp on sp.maSP=ct.maSP
GO
/****** Object:  View [dbo].[vw_BCKyLuat]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_BCKyLuat] as
select nv.maNV,nv.hoTen,kl.maKyLuat,kl.hinhThucKL,ct.ngayLap,ct.ngayThiHanh,ct.ngayKetThuc,ct.mucDoKL,ct.lyDo
from Tbl_KyLuatNV kl join Tbl_CTKyLuatNV ct on kl.maKyLuat=ct.maKyLuat
join Tbl_NhanVien nv on nv.maNV=ct.maNV



GO
/****** Object:  View [dbo].[vw_BCSPBanLe]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_BCSPBanLe] as
select sp.maSP,sp.tenSP,hd.ngayBan, SUM(ct.soLuong*ct.donGia) as TongTien,SUM(ct.soLuong) as SoLuong
from Tbl_HDBanLe hd join Tbl_CTHDBanLe ct on hd.soHoaDon=ct.soHoaDon
join Tbl_SanPham sp on sp.maSP=ct.maSP
group by sp.maSP,sp.tenSP,hd.ngayBan
GO
/****** Object:  View [dbo].[vw_BCSPBansi]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_BCSPBansi] as
select sp.maSP,sp.tenSP,hd.ngayLap,SUM(ct.soLuong) as SoLuong, SUM(ct.soLuong*ct.dongiaBan) as TongTien
from Tbl_HDBanSi hd join Tbl_CTHDBanSi ct on hd.maHD=ct.maHD
join Tbl_SanPham sp on sp.maSP=ct.maSP
group by sp.maSP,sp.tenSP,hd.ngayLap
GO
/****** Object:  View [dbo].[vw_BCSPtheothang]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_BCSPtheothang]
as
select sp.maSP,tenSP, soLuong,tongTien,ngayBan
from Tbl_SanPham sp join Tbl_CTHDBanLe bl on sp.maSP = bl.maSP join Tbl_HDBanLe hdbl on hdbl.soHoaDon = bl.soHoaDon
GO
/****** Object:  View [dbo].[vw_BCHDBanLe]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_BCHDBanLe] as
select hd.soHoaDon,hd.ngayBan,nv.hoTen,kh.tenKH,sp.tenSP,ct.soluong*ct.donGia as TongTien
from Tbl_HDBanLe hd join Tbl_CTHDBanLe ct on hd.soHoaDon=ct.soHoaDon
join Tbl_NhanVien nv on nv.maNV=hd.maNV
join Tbl_KhachHang kh on kh.maKH=hd.maKH
join Tbl_SanPham sp on sp.maSP=ct.maSP

GO
/****** Object:  View [dbo].[vw_BCHDBanSi]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_BCHDBanSi] as
select hd.maHD,hd.ngayLap,nv.hoTen,kh.tenKH,sp.tenSP,ct.soluong*ct.dongiaBan as TongTien
from Tbl_HDBanSi hd join Tbl_CTHDBanSi ct on hd.maHD=ct.maHD
join Tbl_NhanVien nv on nv.maNV=hd.maNV
join Tbl_KhachHang kh on kh.maKH=hd.maKH
join Tbl_SanPham sp on sp.maSP=ct.maSP

GO
/****** Object:  View [dbo].[vw_DoanhSoBanLe]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_DoanhSoBanLe] as
select nv.maNV,nv.hoTen,SUM(ct.donGia*ct.soLuong) as TongTien,hd.ngayBan
from Tbl_NhanVien nv join Tbl_HDBanLe hd on nv.maNV=hd.maNV
join Tbl_CTHDBanLe ct on ct.soHoaDon=hd.soHoaDon
group by nv.maNV,nv.hoTen,hd.ngayBan

GO
/****** Object:  View [dbo].[vw_DoanhSoBanSi]    Script Date: 17/11/2016 3:07:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_DoanhSoBanSi] as
select nv.maNV,nv.hoTen,SUM(ct.dongiaBan*ct.soLuong) as TongTien,hd.ngayLap
from Tbl_NhanVien nv join Tbl_HDBanSi hd on nv.maNV=hd.maNV
join Tbl_CTHDBanSi ct on ct.maHD=hd.maHD
group by nv.maNV,nv.hoTen,hd.ngayLap

GO
