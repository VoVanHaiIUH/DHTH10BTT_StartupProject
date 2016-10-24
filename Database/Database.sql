create database QL
use QL


create table KhachHang (
	[MaKH] int NOT NULL primary key,
	[TenKH] [nvarchar](50) NULL,	
	[NgaySinh] datetime NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] int NULL,
	[SoCMNN] int NULL,
	
)
create table TheThanhVien (
	[MaThe] int NOT NULL primary key,
	[MaKH] int  NULL,
	[TenKH] [nvarchar](50) NULL,	
	[NgayLamThe] datetime NULL,
	[DiemTichLuy] int NULL,	
)

create table NhaCungCap (
	[MaNCC] int NOT NULL primary key,
	[TenNCC] [nvarchar](50) not NULL,
	[SoDT] int NULL,	
	[DiaChi] [nvarchar](50) not null,
	[Email] nvarchar(50) not null,
	GhiChu nvarchar(50) null,
)
create table LoaiPhieu(
	MaLoai int not null primary key,
	TenLoai nvarchar(50) not null,
)
create table Phieu(
	MaPhieu int not null primary key,
	MaLoai int not null,
	NgayLap datetime null,
	NgayXuat datetime null,
	MaNCC int not null,
	MaKH int not null,
	TongTien money not null,
)

create table ChiTietPhieu(
	MaPhieu int not null,
	SoLuong int not null,
	DonGia money not null,
	GhiChu nvarchar(50) null,
)
create table LoaiBaoCao(
	[MaLoai] int NOT NULL primary key,
	[TenLoai] [nvarchar](50) NOT NULL,
)
create table BaoCao(
	MaBaoCao int not null primary key,
	MaLoai	int not null,
	MaNhanVien	int not null,
	NgayLap	datetime,
	TenBaoCao	nvarchar(50),
	MoTa	nvarchar(50),
	MaPhongBan	int not null,
)
create table HoaDonBanLe(
	MaHDBanLe int NOT NULL primary key,
	NgayBanLe	datetime NOT NULL,
	MaNV	int NOT NULL,
	MaKH	int NOT NULL,
	TongTien money NOT NULL
)
CREATE TABLE ChiTietHoaDonBanLe(
	MaHDBanLe int NOT NULL,
	MaSP	int NOT NULL,
	TenSP	nvarchar(50) NOT NULL,
	SoLuong	int NOT NULL,
	DonGia	money NOT NULL,
	GiamGia nvarchar(50) NULL,	
	KhuyenMai nvarchar(50) NULL,	
	ThanhTien money NOT NULL
)

CREATE TABLE HoaDonBanGTGT(
	MaHDGTGT int NOT NULL primary key,
	NgayBan	datetime null,
	MaNV	int NOT NULL,
	MaKH	int NOT NULL,
	TenDVBan nvarchar(50)  NULL,
	TenDVMua nvarchar(50)  NULL,
	ThanhTien money NOT NULL
)
create table ChiTietHoaDonGTGT(
	MaHDGTGT int NOT NULL,
	MaSP	int NOT NULL,
	TenSP	nvarchar(50) NOT NULL,
	SoLuong	int NOT NULL,
	DonGia	money NOT NULL,
	GiamGia	nvarchar(50) NULL,
	KhuyenMai	nvarchar(50) NULL,
	ThanhTien	money NOT NULL,
	TenDVMua	nvarchar(50) NOT NULL,
	MaThue	int NOT NULL,
	DiaChi	nvarchar(50) NOT NULL,
	ThueGTGT	int NOT NULL,
	TongTien	money NOT NULL,
)
CREATE TABLE PhieuNhapKho(
	MaPNK int NOT NULL primary key,
	NgayLapPNK	datetime NOT NULL,
	MaNVLapPNK	int NOT NULL,
	HoTenNVLapPNK nvarchar(50) NOT NULL,
	NguoiGiao	nvarchar(50) NOT NULL
)
CREATE TABLE ChiTietPNK(
	MaChitietPNK int NOT NULL primary key,
	MaPNK int NOT NULL,
	STT int NULL,
	TenSPNhapKho nvarchar(50) NOT NULL,
	MaSPNhapKho int NOT NULL,
	DonVi nvarchar(50) NOT NULL,
	SoLuong int NOT NULL,
	GiaTienNhapKho money NOT NULL
)
CREATE TABLE PhieuXuatKho(
	MaPXK int NOT NULL primary key,
	NgayLapPXK	datetime NOT NULL,
	MaNVXuatKho	int NOT NULL,
	TenNVXuatKho nvarchar(50) NOT NULL,
	NguoiNhan nvarchar(50) NOT NULL
)
CREATE TABLE ChiTietPXK(
	MaChitietPXK int NOT NULL primary key,
	MaPXK int NOT NULL,
	STT int NULL,
	TenSPXuatKho nvarchar(50) NOT NULL,
	MaSPXuatKho int NOT NULL,
	DonVi nvarchar(50) NOT NULL,
	SoLuong int NOT NULL,
	GiaTienXuatKho money NOT NULL
)
CREATE TABLE PhieuQuanLyKho(
	MaPhieuQL	int NOT NULL primary key,
	NgayLapPhieuQL	datetime NOT NULL,
	HoTenQL	nvarchar(50) NOT NULL,
	MaNV	int NOT NULL,
	TenNguoiNhanHang nvarchar(50) NOT NULL
)
create table ChiTietPhieuQuanLyKho(
	MaChiTietPhieuQL	int NOT NULL,
	MaPhieuQL	int NOT NULL, 
	TenSP nvarchar(50) NOT NULL,
	MaSP int NOT NULL,
	DonViQL	nvarchar(50) NOT NULL,
	SoLuongQL int NOT NULL,
	GiaTienSP	money NOT NULL,
	TinhTrang	nvarchar(50) NOT NULL
)
create table SanPham(
	MaSP	 int NOT NULL primary key,
	TenSP	nvarchar(50) NOT NULL,
	Loai	nvarchar(50) NOT NULL,
	NgaySX	Datetime NOT NULL,
	HSD	Datetime NOT NULL, 
	DonVi	nvarchar(50) NOT NULL,
	XuatXu	nvarchar(50) NOT NULL,
	GiaTien	money NOT NULL,
	QuyCach	nvarchar(50) NOT NULL,
	NhaPP nvarchar(50) NOT NULL,
	NhaSX nvarchar(50) NOT NULL,
	KichThuoc	nvarchar(50) NULL,
	TinhTrang	nvarchar(50) NULL,
	KhoiLuong	nvarchar(50) NULL,
	SoLuong	int NOT NULL
)
create table NhanVien (
	MaNV int not null primary key,								
	TenNV nvarchar(50) not null,									
	MaPhongBan int	not null,									
	NgaySinh datetime not null,									
	NgayVaoLam	datetime not null,									
	MaHD int not null,											
	VitriCongViec nvarchar(50)	not null,									
	NgayCapCMND		datetime	not null,									
	MaCapCMND	datetime	not null,									
	SoHoKhau	nvarchar(50)	not null,									
	SoCMND	int	not null,									
	NoiCapHoKhau nvarchar(50) not null,								
	MaPhongBanCu int,							
	NgayCapHoKhau datetime not null,									
)
create table PhongBan(
	MaPB int not null primary key, 									
	TenPB nvarchar(50) not null, 									
	DiaDiem	nvarchar(50),									
	NgayThanhLap datetime,									
)
create table ThongTinTuyenDung(
	MaTT	int			not null primary key, 									
	tenTT	nvarchar(50)	not null, 									
	MaNguoiLap	int null,									
	YeuCauTT nvarchar(50) null,									
)
create table PhieuTuyenDung(
	MaPhieu	int	not null primary key, 									
	NgayGiaoPhieu datetime	not null, 									
	MaNguoiLap	int,									
	NgayLapPhieu datetime not null, 									
	ViTri	nvarchar(50)	not null, 									
	SoLuong	int	not null, 									
	DoTuoi	datetime not null, 									
	MoTa nvarchar(50) null,									
	MaTTTD int null,									
	GioiTinh nvarchar(50) not null, 									
	SoLuongTD	int null,									
	TenPhieu nvarchar(50) not null, 								
)
create table PhieuChamCong(
	MaPhieu	int	not null, 									
	NgayLapPhieu datetime not null, 									
	MaNguoiLap	int null,									
	NgayKetThuc	datetime null,									
	NgayBatDau	datetime null,									
	MoTa		nvarchar(50) null,									
	DanhGia		nvarchar(50) null,									
	TongSoNgayCong	int	 null,									
	TenPhieu nvarchar(50)	not null, 									
)
create table UngVien(
	MaUV int not null primary key, 									
	TenUV nvarchar(50) not null, 									
	NgaySinh datetime not null, 									
	GioiTinh	nvarchar(50) not null, 									
	TrinhDo		nvarchar(50) not null, 									
	TinhTrang	nvarchar(50),									
	ChuyenNganh	nvarchar(50) not null, 									
	Quequan	nvarchar(50) not null, 									
	NamTotNghiep nvarchar(50) not null, 									
	DiaChi nvarchar(50) not null, 									
	Khoa nvarchar(50) not null, 									
	MaKQ int not null, 									
	ViTriUngTuyen nvarchar(50) not null, 									
	NoiDaoTao nvarchar(50) not null, 									
)
create table VanBanXacNhan(
	MaVB int	not null primary key, 									
	TenVB nvarchar(50) not null, 									
	MaNguoiXacNhan	int null,									
	NgayXacNhan	datetime null,									
	TenBangKeHoach nvarchar(50) null,									
	MaBangKH int null,									
	NoiDungVanBan nvarchar(50) not null, 									
)
create table BangKeHoach(
	MaBang	int	not null primary key,									
	TenBang	nvarchar(50) not null,									
	MaNguoiLap int null,									
	MaPhieuTD int null,									
	MoTa nvarchar(50) null,									
	TTBang nvarchar(50) not null,
)
create table HopDong(
	MaHD int not null primary key,									
	ThoiGianHopDong	datetime not null,									
	NgayCoHieuLuc datetime	not null,									
	NgayHetHieuLuc datetime	not null,									
	MaNV int,												
	VitriCongViec nvarchar(50) not null,									
	DonViCongTac nvarchar(50) not null,									
	MucLuongThoaThuan money not null,									
	NgayLap	datetime,									
	TenNguoiLap nvarchar(50)  null,									
	MaNguoiLap	int	null,									
	LoaiHD nvarchar(50)  not null,									
)
create table ToChucTuyenDung(
	MaToChuc int not null primary key,									
	NgayToChuc datetime	not null,									
	MaUV int null,									
	MaNVTG int	null,									
	MaNguoiToChuc int null,									
	MaVB int null,									
	TenToChuc nvarchar(50) null,									
	NgayKetThuc	datetime not null,									
	SoLuongGK int	not null,									
	MaHinhThuc	int	,									
	MoTa nvarchar(50) null,									
	SoLuongUV int not null									
)
create table HinhThuc(
	MaHT int not null primary key,									
	TenHT nvarchar(50) not null,									
	MoTaHT nvarchar(50) not null,									
)
create table KetQuaTuyenDung(
	MaKQ int not null primary key,									
	KetQuaTuyenDung	nvarchar(50),									
	MaToChuc int,									
	XepLoai	nvarchar(50) null,									
	MaUV int	not null,									
)
alter table Phieu add constraint FK_Phieu_LoaiPhieu foreign key (MaLoai) references LoaiPhieu(MaLoai)
alter table Phieu add constraint FK_Phieu_NhaCungCap foreign key (MaNCC) references NhaCungCap(MaNCC)
alter table Phieu add constraint FK_Phieu_TheThanhVien foreign key (MaKH) references KhachHang(MaKH) 
alter table ChiTietPhieu add constraint FK_Phieu_ChiTietPhieu foreign key (MaPhieu) references Phieu(MaPhieu)
alter table BaoCao add constraint FK_BaoCao_LoaiBaoCao foreign key (MaLoai) references LoaiBaoCao(MaLoai)
alter table TheThanhVien add constraint FK_KhachHang_TheThanhVien foreign key (MaKH) references KhachHang(MaKH)
alter table ChiTietHoaDonBanLe add constraint FK_ChiTietHoaDonBanLe_HoaDonBanLe foreign key (MaHDBanLe) references HoaDonBanLe(MaHDBanLe)  
alter table [dbo].[ChiTietHoaDonGTGT] add constraint FK_ChiTietHoaDonGTGT_HoaDonBanGTGT foreign key ([MaHDGTGT]) references HoaDonBanGTGT(MaHDGTGT)
alter table ChiTietPNK add constraint FK_PhieuNhapKho_ChiTietPNK foreign key (MaPNK) references PhieuNhapKho(MaPNK)
alter table ChiTietPXK add constraint FK_PhieuXuatKho_ChiTietPXK foreign key (MaPXK) references PhieuXuatKho(MaPXK) 
alter table ChiTietPhieuQuanLyKho add constraint FK_PhieuQuanLyKho_ChiTietPhieuQuanLyKho foreign key (MaPhieuQL) references PhieuQuanLyKho(MaPhieuQL)
alter table PhieuTuyenDung add constraint FK_PhieuTuyenDung_ThongTinTuyenDung foreign key (MaTTTD) references ThongTinTuyenDung(MaTT)
alter table NhanVien add constraint FK_NhanVien_PhongBan foreign key (MaPhongBan) references PhongBan(MaPB)
alter table NhanVien add constraint FK_NhanVien_HopDong foreign key (MaHD) references HopDong(MaHD)
alter table KetQuaTuyenDung add constraint FK_UngVien_KetQuaTuyenDung foreign key (MaUV) references UngVien(MaUV)
alter table ToChucTuyenDung add constraint FK_UngVien_ToChucTuyenDung foreign key (MaUV) references UngVien(MaUV)
alter table UngVien add constraint FK_UngVien_KetQuaTuyenDung_1 foreign key (MaKQ) references KetQuaTuyenDung(MaKQ)
alter table BaoCao add constraint FK_BaoCao_PhongBan foreign key (MaPhongBan) references PhongBan(MaPB)
alter table BaoCao add constraint FK_BaoCao_NhanVien foreign key (MaNhanVien) references NhanVien(MaNV)
alter table HoaDonBanLe add constraint FK_HoaDonBanLe_NhanVien foreign key (MaNV) references NhanVien(MaNV)
alter table HoaDonBanLe add constraint FK_HoaDonBanLe_KhachHang foreign key (MaKH) references KhachHang(MaKH)
alter table ChiTietHoaDonGTGT add constraint FK_ChiTietHoaDonGTGT_SanPham foreign key (MaSP) references SanPham(MaSP)
alter table HoaDonBanGTGT add constraint FK_HoaDonBanGTGT_NhanVien foreign key (MaNV) references NhanVien(MaNV)
alter table HoaDonBanGTGT add constraint FK_HoaDonBanGTGT_KhachHang foreign key (MaKH) references KhachHang(MaKH)
alter table ToChucTuyenDung add constraint FK_ToChucTuyenDung_HinhThuc foreign key (MaHinhThuc) references HinhThuc(MaHT)
alter table KetQuaTuyenDung add constraint FK_KetQuaTuyenDung_ToChucTuyenDung foreign key (MaToChuc) references ToChucTuyenDung(MaToChuc)
alter table BangKeHoach add constraint FK_BangKeHoach_PhieuTuyenDung foreign key (MaPhieuTD) references PhieuTuyenDung(MaPhieu)
