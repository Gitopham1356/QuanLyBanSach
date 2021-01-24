create database QLBanSach
go


use QLBanSach
go

--Tạo bảng--
create table TheLoai
(
	MaTL varchar(8),
	TenTL nvarchar(50) not null,
	primary key(MaTL)
)
create table TacGia
(
	MaTG varchar(8),
	TenTG nvarchar(50) not null,
	NgaySinhTG date check (NgaySinhTG<GETDATE()),
	SdtTG varchar(11) check (SdtTG is null or SdtTG like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	EmailTG varchar(50),
	primary key(MaTG)
)
create table NhaXuatBan
(
	MaNXB varchar(8),
	TenNXB nvarchar(50) not null,
	DiaChiNXB nvarchar(50),
	SdtNXB varchar(11),
	EmailNXB varchar(50),
	primary key(MaNXB)
)
create table Sach
(
	MaS varchar(8),
	TenS nvarchar(100) not null,
	NamXuatBan int,
	SoLuongTon int check (SoLuongTon>0),
	GiaNhap int check (GiaNhap>0),
	GiaBan int check (GiaBan>0),
	MaTL varchar(8),
	MaTG varchar(8),
	MaNXB varchar(8),
	primary key(MaS)
)
create table KhachHang
(
	MaKH varchar(8),
	TenKH nvarchar(50) not null,
	NgaySinhKH date check (NgaySinhKH<GETDATE()),
	DiaChiKH nvarchar(50),
	SdtKH varchar(11) check (SdtKH is null or SdtKH like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	EmailTG varchar(50),
	primary key(MaKH)
)
create table HoaDon
(
	MaHD varchar(8),
	NgayLapHD datetime,
	MaKH varchar(8),
	TongHD int default 0,
	primary key(MaHD)
)
create table CTHD
(
	MaHD varchar(8),
	MaS varchar(8),
	SoLuongBan int check (SoLuongBan>0),
	GiaBan int check (GiaBan>0),
	primary key(MaHD, MaS)
)
create table PhieuGiao
(
	MaPG varchar(8),
	NgayLapPG datetime,
	MaKH varchar(8) not null,
	NgayGiaoDuKien datetime,
	primary key(MaPG)
)
create table CTPG
(
	MaPG varchar(8),
	MaS varchar(8),
	SoLuongGiao int check (SoLuongGiao>0),
	primary key(MaPG, MaS)
)
create table NhanVien
(
	MaNV varchar(8),
	TenNV nvarchar(50) not null,
	NgaySinhNV date check (NgaySinhNV<GETDATE()),
	DiaChiNV nvarchar(50),
	SdtNV varchar(11) check (SdtNV is null or SdtNV like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	EmailNV varchar(50),
	ChucVu bit default 0,
	MatKhau varchar(20),
	primary key(MaNV)
)
-----TẠO KHÓA NGOẠI-----
alter table Sach
add constraint FK_Sach_TheLoai foreign key(MaTL) references TheLoai(MaTL) on update cascade,
	constraint FK_Sach_TacGia foreign key(MaTG) references TacGia(MaTG) on update cascade,
	constraint FK_Sach_NhaXuatBan foreign key(MaNXB) references NhaXuatBan(MaNXB) on update cascade

alter table HoaDon
add constraint FK_HoaDon_KhachHang foreign key(MaKH) references KhachHang(MaKH) on update cascade

alter table CTHD
add constraint FK_CTHD_HoaDon foreign key(MaHD) references HoaDon(MaHD) on update cascade,
	constraint FK_CTHD_Sach foreign key(MaS) references Sach(MaS) on update cascade

alter table PhieuGiao
add constraint FK_PhieuGiao_KhachHang foreign key(MaKH) references KhachHang(MaKH) on update cascade

alter table CTPG
add constraint FK_CTPG_PG foreign key(MaPG) references PhieuGiao(MaPG) on update cascade,
	constraint FK_CTPG_Sach foreign key(MaS) references Sach(MaS) on update cascade

-----TẠO TRIGGER-----
--Cập nhật lại tổng HD khi CTHD thay đổi
create trigger TG_CapNhatTongHD
on CTHD
for insert, update
as
	begin
		declare @maHD varchar(8)
		select @maHD=MaHD from inserted

		declare @thanhTien int
		select @thanhTien=GiaBan*SoLuongBan from inserted

		update HoaDon 
		set TongHD=TongHD+@thanhTien
		where MaHD=@maHD
	end
--Ngày giao dự kiến phải lớn hơn hoặc bằng ngày lập phiếu giao
create trigger TG_NgayGiaoDuKien
on PhieuGIao
for insert, update
as
	begin
		if exists (	select *
					from PhieuGiao
					where NgayGiaoDuKien<NgayLapPG)
			begin
				raiserror(N'Ngày giao dự kiến phải lớn hơn hoặc bằng ngày lập phiếu giao', 16, 1)
				rollback tran
			end
	end

-----THÊM DỮ LIỆU-----
set dateformat dmy

insert into TheLoai values ('TL001', N'Văn học')
insert into TheLoai values ('TL002', N'Sách giáo khoa')
insert into TheLoai values ('TL003', N'Thiếu nhi')
insert into TheLoai values ('TL004', N'Kinh tế')
insert into TheLoai values ('TL005', N'Kỹ năng sống')
select * from TheLoai

insert into TacGia values ('TG001', N'Nguyễn Nhật Ánh', '07/05/1955', null, null)
insert into TacGia values ('TG002', N'Bộ Giáo Dục Và Đào Tạo', null, '0243869514', 'bogddt@moet.gov.vn')
insert into TacGia values ('TG003', N'Kristina Ohlsson', '02/03/1979', null, null)
insert into TacGia values ('TG004', N'Claire Belton', null , null, null)
insert into TacGia values ('TG005', N'Dorie Clark', '06/09/1978' , null, null)
insert into TacGia values ('TG006', N'Jim Collins', '25/01/1958' , null, null)
insert into TacGia values ('TG007', N'Dale Carnegie', '24/11/1888', null, null)
insert into TacGia values ('TG008', N'Lê Đỗ Quỳnh Hương', '01/05/1974', null, null)
select * from TacGia

insert into NhaXuatBan values ('NXB001', N'NXB Trẻ', N'161B Lý Chính Thắng, Phường 7, Quận 3 , TPHCM', '02838437450', 'hopthubandoc@nxbtre.com.vn')
insert into NhaXuatBan values ('NXB002', N'NXB Giáo Dục Việt Nam', N'Số 81 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '02438220801', 'nxbgd@moet.edu.vn')
insert into NhaXuatBan values ('NXB003', N'NXB Kim Đồng', N'248 Cống Quỳnh, Phường Phạm Ngũ Lão, Quận 1, TPHCM', '02839250170', 'info@nxbkimdong.com.vn')
insert into NhaXuatBan values ('NXB004', N'NXB Lao Động', N'175 Giảng Võ, Q. Đống Đa, Hà Nội', '02438515380', 'nxblaodong@yahoo.com')
insert into NhaXuatBan values ('NXB005', N'NXB Tổng Hợp TPHCM', N'62 Nguyễn Thị Minh Khai, P. Đa Kao, Quận 1, TPHCM', '02838256713', 'tonghop@nxbhcm.com.vn')
select * from NhaXuatBan

insert into Sach values ('S001', N'Tôi thấy hoa vàng trên cỏ xanh', 2018, 100, 100000, 125000, 'TL001', 'TG001', 'NXB001')
insert into Sach values ('S002', N'Bàn có 5 chỗ ngồi', 2018, 100, 44550, 55000, 'TL001', 'TG001', 'NXB001')
insert into Sach values ('S003', N'Toán 3 (2020)', 2020, 100, 11000, 13000, 'TL002', 'TG002', 'NXB002')
insert into Sach values ('S004', N'Hóa học 12 - Nâng cao (2020)', 2020, 100, 22000, 24000, 'TL002', 'TG002', 'NXB002')
insert into Sach values ('S005', N'Lũ Trẻ Thủy Tinh', 2020, 100, 38000, 40000, 'TL003', 'TG003', 'NXB003')
insert into Sach values ('S006', N'Tớ là mèo Pusheen', 2019, 100, 66400, 80000, 'TL003', 'TG004', 'NXB003')
insert into Sach values ('S007', N'Khởi nghiệp 4.0', 2018, 100, 108000, 139000, 'TL004', 'TG005', 'NXB004')
insert into Sach values ('S008', N'Từ tốt đến vĩ đại', 2019, 100, 97000, 115000, 'TL004', 'TG006', 'NXB001')
insert into Sach values ('S009', N'Đắc nhân tâm', 2018, 100, 59000, 76000, 'TL005', 'TG007', 'NXB005')
insert into Sach values ('S010', N'Thay đổi cuộc sống với nhân số học', 2020, 100, 223000, 248000, 'TL005', 'TG008', 'NXB005')
select * from Sach








insert into NhanVien values ('NV001', N'Lê Nguyễn Thiện Quang', '20/12/1996', 'KDC Gia Hòa', '0961865161', 'thienquang8825@gmail.com', 1)

select * from NhanVien



create proc [dbo].[ReportInHoaDon]
as
	begin
	select HoaDon.MaHD, Sach.MaS, Sach.TenS, HoaDon.NgayLapHD, KhachHang.MaKH, KhachHang.TenKH, CTHD.GiaBan, CTHD.SoLuongBan
	from HoaDon, Sach, KhachHang, CTHD
	where (HoaDon.MaHD=CTHD.MaHD) and (Sach.MaS=CTHD.MaS) and (KhachHang.MaKH=HoaDon.MaKH) 
	end


create proc [dbo].[ReportInPhieuGiao]
as
	begin
	select PhieuGiao.MaPG, PhieuGiao.NgayLapPG, PhieuGiao.NgayGiaoDuKien, PhieuGiao.MaKH ,CTPG.MaS, CTPG.SoLuongGiao, KhachHang.TenKH,  Sach.TenS
	from PhieuGiao, Sach, KhachHang,  CTPG
	where (PhieuGiao.MaPG=CTPG.MaPG) and (KhachHang.MaKH=PhieuGiao.MaKH) and (Sach.MaS=CTPG.MaS)
	end

	


