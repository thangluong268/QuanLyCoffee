CREATE DATABASE QuanLyCaPhe
go

use QuanLyCaPhe
go

create table NhanVien (
	MaNV varchar(10) primary key,
	HoTen nvarchar(50),
	DiaChi nvarchar(100),
	SDT varchar(11),
	NgayVaoLam date,
	SoNgayLam int,
	GioiTinh bit,
	NgaySinh date,
	ChucVu nvarchar(20),
)
go



create table TaiKhoan (
	TenTaiKhoan varchar(10) primary key 
	references NhanVien(MaNV),
	MatKhau varchar(50) not null,
	Quyen nvarchar(20)
)
go



create table CaLamViec(
	MaCa varchar(10),
	MaNV varchar(10) references NhanVien(MaNV),
	Ca int
	primary key(MaCa, MaNV, Ca)
)
go



create table Ban (
	MaBan varchar(10) primary key,
	TenBan varchar(10),
	TrangThai bit
)
go

insert into Ban values('MB01', '01', 0)
insert into Ban values('MB02', '02', 0)
insert into Ban values('MB03', '03', 0)
insert into Ban values('MB04', '04', 0)
insert into Ban values('MB05', '05', 0)
insert into Ban values('MB06', '06', 0)
insert into Ban values('MB07', '07', 0)
insert into Ban values('MB08', '08', 0)
insert into Ban values('MB09', '09', 0)
insert into Ban values('MB10', '10', 0)
insert into Ban values('MB11', '11', 0)
insert into Ban values('MB12', '12', 0)
insert into Ban values('MB13', '13', 0)
insert into Ban values('MB14', '14', 0)
insert into Ban values('MB15', '15', 0)
go


create table LoaiMon (
	MaLoai varchar(10) primary key,
	TenLoai nvarchar(50) unique,
	TrangThai bit
)
go

insert into LoaiMon values ('ML01', N'Đồ uống', 1)
insert into LoaiMon values ('ML02', N'Đồ ăn', 1)
go

create table ThucDon (
	MaMon varchar(10) primary key,
	MaLoai varchar(10) references LoaiMon(MaLoai),
	TenMon nvarchar(50),
	DonGia int,
	DVT nvarchar(10),
	TrangThai bit not null default 1
)
go

insert into ThucDon values ('MM01', 'ML01', N'Caffe đen đá', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM02', 'ML01', N'Caffe đen nóng', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM03', 'ML01', N'Caffe sữa nóng', 16000, N'VNĐ', 1)
insert into ThucDon values ('MM04', 'ML01', N'Bạc xỉu nóng', 16000, N'VNĐ', 1)
insert into ThucDon values ('MM05', 'ML01', N'Caffe cội nguồn', 18000, N'VNĐ',1)
insert into ThucDon values ('MM06', 'ML01', N'Caffe sữa đá', 18000, N'VNĐ', 1)
insert into ThucDon values ('MM07', 'ML01', N'Bạc xỉu đá', 18000, N'VNĐ', 1)
insert into ThucDon values ('MM08', 'ML01', N'Cacao sữa đá', 18000, N'VNĐ', 1)
insert into ThucDon values ('MM09', 'ML01', N'Caffe sữa tươi', 20000, N'VNĐ', 1)
insert into ThucDon values ('MM10', 'ML01', N'Caffe rum', 20000, N'VNĐ', 1)
insert into ThucDon values ('MM11', 'ML01', N'Trà chanh', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM12', 'ML01', N'Trà đào', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM13', 'ML01', N'Trà ô long', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM14', 'ML01', N'Trà sen vải', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM15', 'ML01', N'Nước ép cam', 20000, N'VNĐ', 1)
insert into ThucDon values ('MM16', 'ML01', N'Nước ép dừa tươi', 20000, N'VNĐ', 1)
insert into ThucDon values ('MM17', 'ML01', N'Nước ép táo', 20000, N'VNĐ', 1)
insert into ThucDon values ('MM18', 'ML01', N'Nước ép dưa hấu', 20000, N'VNĐ', 1)
insert into ThucDon values ('MM19', 'ML02', N'Xúc xích', 10000, N'VNĐ', 1)
insert into ThucDon values ('MM20', 'ML02', N'Cá viên chiên', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM21', 'ML02', N'Bò viên chiên', 15000, N'VNĐ', 1)
insert into ThucDon values ('MM22', 'ML02', N'Mỳ xào', 30000, N'VNĐ', 1)
insert into ThucDon values ('MM23', 'ML02', N'Bắp xào', 10000, N'VNĐ', 1)
insert into ThucDon values ('MM24', 'ML02', N'Cút lộn xào me', 25000, N'VNĐ', 1)
insert into ThucDon values ('MM25', 'ML02', N'Cơm rang', 25000, N'VNĐ', 1)
insert into ThucDon values ('MM26', 'ML02', N'Kem ly', 10000, N'VNĐ', 1)
go


create table HoaDon (
	MaHD varchar(10) primary key,
	MaNV varchar(10) references NhanVien(MaNV),
	MaBan varchar(10) references Ban(MaBan),
	NgayTao date,
	GiamGia float,
	TongTien int,
	TrangThai bit
)
go


create table ChiTietHoaDon (
	MaCTHD varchar(10) primary key,
	MaHD varchar(10) references HoaDon(MaHD),
	MaMon varchar(10) references ThucDon(MaMon),
	SoLuong int not null default 0
)
go



-- Tạo thông tin và tài khoản quản lý
insert into NhanVien values('NV00', N'Người quản lý', N'Thủ đức', '0987654321', null, null, 1, '1997-10-24', N'Quản lý')
go
insert into TaiKhoan values('NV00', '123456', N'Quản lý')
go

-- Tạo tài khoản cho login và user
create login NV00 with password = '123456'
create user NV00 for login NV00
-- Phân quyền toàn quyền hệ thống cho quản lý
grant exec, select, insert, update, delete to NV00
EXEC master..sp_addsrvrolemember @loginame = NV00, @rolename = N'sysadmin'
go



----------------View--------------------
-- Tạo View Tính lương
create view TinhLuong_View as
select NV.MaNV, NV.HoTen, NV.ChucVu, Count(CLV.Ca) as N'Số Ca', 
		case when NV.ChucVu=N'Thu Ngân' then NV.SoNgayLam*25000*5*Count(CLV.Ca)						       
		when NV.ChucVu=N'Pha Chế'  then NV.SoNgayLam*24000*5*Count(CLV.Ca)
		when NV.ChucVu=N'Phục Vụ'  then NV.SoNgayLam*23000*5*Count(CLV.Ca) end as N'Tổng Lương'
from NhanVien as NV inner join CaLamViec as CLV
on NV.MaNV=CLV.MaNV
group by NV.MaNV, NV.HoTen, NV.ChucVu, NV.SoNgayLam
go





----------------Trigger--------------------

-- Trigeer kiểm tra tuổi của nhân viên phải đảm bảo không được dưới 18 tuổi
create trigger KiemTraTuoi on NhanVien
for insert as
begin
	declare @ngaysinh_nv_moi date, @tuoi_nv_moi int
	select @ngaysinh_nv_moi = ins.NgaySinh from inserted ins
	set @tuoi_nv_moi = (select year(getdate()) - year(@ngaysinh_nv_moi))
	if (@tuoi_nv_moi < 18)
	begin
		raiserror(N'Nhân viên không được dưới 18 tuổi', 16, 1)
		rollback tran
		return
	end
end
go

-- Trigger tạo tài khoản khi thêm nhân viên mới
create trigger TaoTaiKhoan on NhanVien
after insert as
begin
	declare @manv varchar(10), @chucvu nvarchar(50)
	select @manv = MaNV, @chucvu = ChucVu from inserted
	if(@chucvu = N'Thu ngân')
		begin
			insert into TaiKhoan values(@manv, '123456', N'Nhân viên')
		end
end
go


-- Trigger cập nhật trạng thái của bàn khi chưa in và in hóa đơn
create trigger CapNhatBan on HoaDon
for insert, update as
begin
	declare @ma_ban varchar(10), @trang_thai bit
	select @ma_ban =  ins.MaBan, @trang_thai = ins.TrangThai from inserted ins
	if(@trang_thai = 0)
		begin
			update Ban
			set TrangThai = 1
			where MaBan = @ma_ban
		end
	else
		begin
			update Ban
			set TrangThai = 0
			where MaBan = @ma_ban
		end
 end
 go

 -- Trigger cập nhật trạng thái của thực đơn = false khi xóa loại món
 create trigger CapNhatThucDonKhiXoa on LoaiMon
 for update 
 as
 begin
	declare @maloai varchar(10)
	select @maloai = MaLoai from inserted
	update ThucDon set TrangThai = 0 where MaLoai = @maloai
 end
 go


  -- Trigger cập nhật trạng thái của thực đơn = true khi sửa trạng thái của món = true
 create trigger CapNhatThucDonKhiSua on LoaiMon
 for update 
 as
 begin
	declare @maloai varchar(10), @trangthai_loaimon bit
	select @maloai = MaLoai, @trangthai_loaimon = TrangThai from inserted
	if(@trangthai_loaimon = 1)
		update ThucDon set TrangThai = 1 where MaLoai = @maloai
 end
 go


 -- Trigger xóa tài khoản, ca làm việc và hóa đơn khi xóa nhân viên tương ứng
 create trigger XoaTaiKhoan on NhanVien
 instead of delete
 as
 begin
	declare @manv varchar(10), @mahd varchar(10)

	select @manv = MaNV from deleted
	select @mahd = MaHD from HoaDon where MaNV = @manv

	delete from TaiKhoan where TenTaiKhoan = @manv
	delete from CaLamViec where MaNV = @manv
	delete from ChiTietHoaDon where MaHD = @mahd
	delete from HoaDon where MaNV = @manv
	delete from NhanVien where MaNV = @manv
 end
 go




 

----------------FUNCTION--------------------

-- Đăng nhập theo loại tài khoản
create function f_DangNhap(@taikhoan varchar(10), @matkhau varchar(50), @quyen nvarchar(20))
returns int
	begin
		if @quyen = N'Quản lý'
			begin 
				if (select count(*) from TaiKhoan where TenTaiKhoan = @taikhoan 
				and MatKhau = @matkhau and Quyen = @quyen) =1
				return 1
			end
		else if @quyen = N'Nhân viên'
			begin
				if (select count(*) from TaiKhoan where TenTaiKhoan  = @taikhoan 
				and MatKhau = @matkhau and Quyen = @quyen) = 1
				return 2
			end
		return 0
	end
go


-- Kiểm tra mật khẩu
create function f_KiemTraMatKhau(@taikhoan varchar(10), @matkhau varchar(50))
returns int
	begin
		if (select count(*) from TaiKhoan where TenTaiKhoan = @taikhoan 
		and MatKhau = @matkhau and Quyen = N'Nhân viên') = 1
			return 1
		return 0
	end
go

-- Kiểm tra nhân viên có tồn tại trong hóa đơn hay không
create function f_KiemTraNhanVienTrongHoaDon(@manv varchar(10))
returns int
	begin
		if (select count(*) from HoaDon where MaNV = @manv) > 1
			return 1
		return 0
	end
go


-- Kiểm tra mã hóa đơn đã tồn tại chưa
create function f_KiemTraMaHD(@mahd varchar(10))
returns bit
as
	begin
		if (select count(*) from HoaDon where MaHD = @mahd) = 1
			return 1
		return 0
	end
go


-- Kiểm tra mã ca đã tồn tại chưa
create function f_KiemTraMaCa(@maca varchar(10))
returns bit
as
	begin
		if (select count(*) from CaLamViec where MaCa = @maca) = 1
			return 1
		return 0
	end
go



-- Tính tổng tiền năm hiện tại
create function f_TinhTongTienNamHienTai()
returns int
	begin
		declare @tongtiennamnay int, @namhientai varchar(10)

		select @namhientai = format(getdate(), 'yyyy')

		select @tongtiennamnay = sum(TongTien) from HoaDon
		where year(NgayTao) = @namhientai and TrangThai = 1
		group by year(NgayTao)

		return @tongtiennamnay
	end
go


-- Tính tổng tiền năm ngoái
create function f_TinhTongTienNamNgoai()
returns int
	begin
		declare @tongtiennamngoai int, @namhientai varchar(10), @namngoai varchar(10)

		select @namhientai = format(getdate(), 'yyyy')
		select @namngoai = convert(varchar, (convert(int, @namhientai) - 1))

		select @tongtiennamngoai = sum(TongTien) from HoaDon
		where year(NgayTao) = @namngoai and TrangThai = 1
		group by year(NgayTao)

		return @tongtiennamngoai
	end
go






----------------PROCEDURE----------------------

-- Đổi mật khẩu
create procedure p_DoiMatKhau
@tentk1 varchar(10), -- "NV"
@tentk2 varchar(10), -- NV
@matkhaucu varchar(50),
@matkhaumoi varchar(50)	
as
	begin
		update TaiKhoan set MatKhau = @matkhaumoi 
		where TenTaiKhoan = @tentk1 and MatKhau = @matkhaucu
		
		declare @thucthi varchar(100)
		set @thucthi = 'alter login ' + @tentk2 + ' with password = ''' + 
		@matkhaumoi + '''' + ' old_password = ''' + @matkhaucu + ''''
		exec (@thucthi)
	end
go


-- Load quyền
create procedure p_LoadQuyen
as
	begin
		select DISTINCT Quyen from TaiKhoan
	end
go

-- Load tài khoản
create procedure p_LoadTaiKhoan
as
	begin
		select * from TaiKhoan
	end
go


-- Tìm kiếm tài khoản
create procedure p_TimKiemTaiKhoan
@n varchar(5),
@tentaikhoan varchar(50),
@quyen nvarchar(20)
as
	begin
		select * from TaiKhoan where TenTaiKhoan like '%' + @tentaikhoan + '%' and Quyen like '%' + @n +  @quyen + '%'
	end
go

-- Lấy số lượng tài khoản
create procedure p_LaySoLuongTaiKhoan
as
	begin
		select count(TenTaiKhoan) as SoTK from TaiKhoan
	end
go

-- Load nhân viên
create procedure p_LoadNhanVien
as
	begin
		select NV.MaNV, NV.HoTen, NV.DiaChi, NV.SDT, NV.NgayVaoLam, NV.SoNgayLam, 
		NV.GioiTinh, NV.NgaySinh, NV.ChucVu, CLV.Ca
		from NhanVien as NV inner join CaLamViec as CLV on NV.MaNV = CLV.MaNV
		order by NV.MaNV
	end
go


-- Load nhân viên theo mã
create procedure p_LoadNhanVienTheoMa
@manv varchar(10)
as
	begin
		select * from NhanVien where MaNV = @manv
	end
go


-- Thêm nhân viên
create procedure p_ThemNhanVien
@manv1 varchar(10), -- return "NVxx"
@manv2 varchar(10), -- return NVxx
@hoten nvarchar(50),
@diachi nvarchar(100),
@sdt varchar(11),
@ngayvaolam date,
@songaylam int,
@gioitinh bit,
@ngaysinh date,
@chucvu nvarchar(20),
@maca varchar(10),
@ca int
as
begin
	begin transaction
		begin try
			insert into NhanVien values(@manv1, @hoten, @diachi, @sdt, @ngayvaolam, 
			@songaylam, @gioitinh, @ngaysinh, @chucvu)
			insert into CaLamViec values(@maca, @manv1, @ca)

			declare @createLogin varchar(200), @createUser varchar(200)
			declare @matkhau varchar(50)

			select @matkhau = MatKhau from TaiKhoan where TenTaiKhoan = @manv1
			if(@chucvu = N'Thu ngân')
				begin
					set @createLogin = 'create login ' + @manv2 + ' with password = ''' + @matKhau + ''''
					set @createUser = 'create user ' + @manv2 + ' for login ' + @manv2
					exec (@createLogin)
					exec (@createUser)
				end
			commit transaction
		end try
		begin catch
			declare @ErrorMessage nvarchar(4000);
			SELECT @ErrorMessage = error_message()
			raiserror(@ErrorMessage, 16, 1)
			rollback transaction
		end catch

	declare @statement varchar(200)
	if(@chucvu = N'Thu ngân')
		begin
			set @statement ='grant exec on dbo.f_DangNhap to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.f_KiemTraMaHD to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.f_KiemTraMatKhau to ' + @manv2
			exec (@statement)
			
			set @statement ='grant exec on dbo.p_LoadNhanVienTheoMa to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LoadThucDonChoGoiMon to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LoadThucDonChoGoiMonTheoMa to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LoadThucDonChoGoiMonTheoTenLoai to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LoadBan to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LoadDVT to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LayMaHoaDonChuaThanhToan to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LayTongSoLuongHoaDon to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LayTongSoLuongCTHD to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_ThemHoaDon to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_ThemCTHD to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_CapNhatHoaDon to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_KiemTraHoaDonCuaBan to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LoadTenBan to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LayMaBan to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_KiemTraTrangThaiBan to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_CapNhatMaBanCuaHoaDon to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_CapNhatBan to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_DoiMatKhau to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_XoaHoaDon to ' + @manv2
			exec (@statement)

			set @statement ='grant exec on dbo.p_LayLaiMatKhau to ' + @manv2
			exec (@statement)
		end
end
go


-- Cập nhật nhân viên
create procedure p_CapNhatNhanVien
@manv varchar(10),
@hoten nvarchar(50),
@diachi nvarchar(100),
@sdt varchar(11),
@ngayvaolam date,
@songaylam int,
@gioitinh bit,
@ngaysinh date,
@chucvu nvarchar(20),
@ca int
as
	begin
		update NhanVien set HoTen = @hoten, DiaChi = @diachi, SDT = @sdt, NgayVaoLam = @ngayvaolam, 
		SoNgayLam = @songaylam, GioiTinh = @gioitinh, NgaySinh = @ngaysinh, ChucVu = @chucvu
		where MaNV = @manv

		update CaLamViec set Ca = @ca where MaNV = @manv
	end
go


-- Xóa nhân viên
create procedure p_XoaNhanVien
@manv1 varchar(10), -- "NV"
@manv2 varchar(10), -- NV
@chucvu nvarchar(20)
as
	begin
		delete from NhanVien where MaNV = @manv1

		if(@chucvu = N'Thu ngân')
		begin
			declare @thucthi varchar(100)

			set @thucthi =  'drop login ' + @manv2
			exec(@thucthi)

			set @thucthi = 'drop user ' + @manv2
			exec(@thucthi)
		end
	end
go


-- Tìm kiếm nhân viên theo mã
create procedure p_TimKiemNhanVienTheoMa
@manv varchar(10)
as
	begin
		select NV.MaNV, NV.HoTen, NV.DiaChi, NV.SDT, NV.NgayVaoLam, NV.SoNgayLam, 
		NV.GioiTinh, NV.NgaySinh, NV.ChucVu, CLV.Ca
		from NhanVien as NV inner join CaLamViec as CLV 
		on NV.MaNV = CLV.MaNV and NV.MaNV like '%' + @manv + '%'
	end
go


-- Tìm kiếm nhân viên theo tên (tiếng việt)
create procedure p_TimKiemNhanVienTheoTen
@n varchar(5),
@hoten nvarchar(50)
as
	begin
		select NV.MaNV, NV.HoTen, NV.DiaChi, NV.SDT, NV.NgayVaoLam, NV.SoNgayLam, 
		NV.GioiTinh, NV.NgaySinh, NV.ChucVu, CLV.Ca
		from NhanVien as NV inner join CaLamViec as CLV 
		on NV.MaNV = CLV.MaNV and NV.HoTen like '%' + @n +  @hoten + '%'
	end
go


-- Lấy số lượng nhân viên
create procedure p_LaySoLuongNhanVien
as
	begin
		select count(MaNV) as SoNV from NhanVien
	end
go

-- Load Ca
create procedure p_LoadCa
as
	begin
		select distinct Ca from CaLamViec
	end
go



-- Lấy tổng số lượng mã ca
create procedure p_LayTongMaCa
as
	begin
		select count(MaCa) from CaLamViec
	end
go

-- Thêm bàn
create procedure p_ThemBan
@maban varchar(10),
@tenban varchar(10),
@trangthai bit
as
	begin
		insert into Ban values(@maban, @tenban, @trangthai)
	end
go


-- Cập nhật bàn
create proc p_CapNhatBan
@maban varchar(10),
@trangthai bit
as
	begin
		update Ban set 
		TrangThai = @trangthai
		where MaBan = @maban
	end
go

-- Xóa bàn
create procedure p_XoaBan
@maban varchar(10)
as
	begin
		delete from Ban where MaBan = @maban
	end
go

-- Load bàn
create procedure p_LoadBan
as
	begin
		select * from Ban
	end
go

-- Tìm kiếm bàn theo mã
create procedure p_TimKiemBanTheoMa
@maban varchar(10)
as
	begin
		select * from Ban where MaBan like '%' + @maban + '%'
	end
go


-- Tìm kiếm bàn theo tên
create procedure p_TimKiemBanTheoTen
@tenban varchar(20)
as
	begin
		select * from Ban where TenBan like '%' + @tenban + '%'
	end
go

-- Lấy số lượng bàn
create procedure p_LaySoLuongBan
as
	begin
		select count(*) from Ban
	end
go


-- Load tên bàn
create procedure p_LoadTenBan
as
	begin
		select TenBan from Ban
	end
go


-- Lấy mã bàn theo tên bàn
create procedure p_LayMaBan
@tenban varchar(20)
as
	begin
		select MaBan from Ban where TenBan = @tenban
	end
go


-- Kiểm tra trạng thái bàn
create procedure p_KiemTraTrangThaiBan
@maban varchar(10)
as
	begin
		select TrangThai from Ban where MaBan = @maban
	end
go


-- Load thực đơn cho gọi món
create procedure p_LoadThucDonChoGoiMon
as
	begin
		select TD.MaMon, TD.TenMon, TD.DonGia, LM.TenLoai 
		from ThucDon as TD inner join LoaiMon as LM 
		on TD.MaLoai = LM.MaLoai and TD.TrangThai = 1
	end
go


-- Load thực đơn cho gọi món theo mã
create procedure p_LoadThucDonChoGoiMonTheoMa
@mamon varchar(10)
as
	begin
		select * from ThucDon where MaMon = @mamon and TrangThai = 1
	end
go


-- Load thực đơn cho gọi món theo tên loại
create procedure p_LoadThucDonChoGoiMonTheoTenLoai
@n varchar(5),
@tenloai nvarchar(10)
as
	begin
		select TD.MaMon, TD.TenMon, TD.DonGia, LM.TenLoai
		from ThucDon as TD inner join LoaiMon as LM 
		on TD.MaLoai = LM.MaLoai and TD.TrangThai = 1 and LM.TenLoai = @n + @tenloai
	end
go



-- Load thực đơn cho quản lý
create procedure p_LoadThucDonChoQuanLy
as
	begin
		select * from ThucDon
	end
go

-- Load DVT
create procedure p_LoadDVT
as
	begin
		select distinct DVT from ThucDon
	end
go

-- Thêm thực đơn
create procedure p_ThemThucDon
@mamon varchar(10),
@maloai varchar(10),
@tenmon nvarchar(50),
@dongia int,
@dvt nvarchar(10),
@trangthai bit
as
	begin
		insert into ThucDon values(@mamon, @maloai, @tenmon, @dongia, @dvt, @trangthai)
	end
go

-- Cập nhật thực đơn
create procedure p_CapNhatThucDon
@mamon varchar(10),
@maloai varchar(10),
@tenmon nvarchar(50),
@dongia int,
@dvt nvarchar(10)
as
	begin
		update ThucDon set 
		MaLoai = @maloai, 
		TenMon = @tenmon, 
		DonGia = @dongia, 
		DVT = @dvt
		where MaMon = @mamon and TrangThai = 1
	end
go

-- Xóa thực đơn
create procedure p_XoaThucDon
@mamon varchar(10)
as
	begin
		delete from ThucDon where MaMon = @mamon
	end
go

-- Tìm kiếm thực đơn theo mã
create procedure p_TimKiemThucDonTheoMa
@mamon varchar(10)
as
	begin
		select * from ThucDon where MaMon like '%' + @mamon + '%'
	end
go

-- Tìm kiếm thực đơn theo tên (tiếng việt)
create procedure p_TimKiemThucDonTheoTen
@n varchar(5),
@tenmon nvarchar(50)
as
	begin
		select * from ThucDon where TenMon like '%' + @n +  @tenmon + '%'
	end
go


-- Lấy số lượng món
create procedure p_LaySoLuongMon
as
	begin
		select count(MaMon) as SoMon from ThucDon
	end
go


-- Load Mã Loại
create procedure p_LoadMaLoai
as
	begin
		select MaLoai from LoaiMon
	end
go


-- Load loại món
create procedure p_LoadLoaiMon
as
	begin
		select * from LoaiMon
	end
go

-- Thêm loại món
create procedure p_ThemLoaiMon
@maloai varchar(10),
@tenloai nvarchar(50),
@trangthai bit
as
	begin
		insert into LoaiMon values(@maloai, @tenloai, @trangthai)
	end
go


-- Cập nhật loại món
create procedure p_CapNhatLoaiMon
@maloai varchar(10),
@tenloai nvarchar(50),
@trangthai bit
as
	begin
		update LoaiMon set TenLoai = @tenloai, TrangThai = @trangthai
		where MaLoai = @maloai
	end
go


-- Xóa loại món
create procedure p_XoaLoaiMon
@maloai varchar(10)
as
	begin
		update LoaiMon set TrangThai = 0
		where MaLoai = @maloai
	end
go

-- Tìm kiếm loại món theo tên
create procedure p_TimKiemLoaiMonTheoTen
@n varchar(5),
@tenloai nvarchar(50)
as
	begin
		select * from LoaiMon where TenLoai like '%' + @n +  @tenloai + '%'
	end
go

-- Tìm kiếm loại món theo mã
create procedure p_TimKiemLoaiMonTheoMa
@maloai nvarchar(50)
as
	begin
		select * from LoaiMon where MaLoai like '%' +  @maloai + '%'
	end
go


-- Lấy mã món
create procedure p_LayMaMon
@n varchar(5),
@tenmon nvarchar(50),
@dongia int,
@tenloai nvarchar(20)
as
	begin
		select TD.MaMon from ThucDon as TD, LoaiMon as LM
		where TD.MaLoai = LM.MaLoai and TD.TenMon = @n + @tenmon
			and TD.DonGia = @dongia and LM.TenLoai = @n + @tenloai
	end
go


-- Lấy mã hóa đơn chưa thanh toán
create procedure p_LayMaHoaDonChuaThanhToan
@maban varchar(10)
as
	begin
		select MaHD from HoaDon where MaBan = @maban and TrangThai = 0
	end
go



-- Kiểm tra hóa đơn đã được thêm vào bàn hay chưa
create procedure p_KiemTraHoaDonCuaBan
@maban varchar(10)
as
	begin
		select * from HoaDon where MaBan = @maban and TrangThai = 0
	end
go

-- Lấy tổng số lượng hóa đơn
create procedure p_LayTongSoLuongHoaDon
as
	begin
		select count(MaHD) from HoaDon
	end
go

-- Lấy tổng số lượng chi tiết hóa đơn
create procedure p_LayTongSoLuongCTHD
as
	begin
		select count(MaCTHD) from ChiTietHoaDon
	end
go


-- Load hóa đơn
create procedure p_LoadHoaDon
as
	begin
		select * from HoaDon
	end
go

-- Thêm hóa đơn
create procedure p_ThemHoaDon
@mahd varchar(10),
@manv varchar(10),
@maban varchar(10),
@ngaytao date,
@giamgia float,
@tongtien int,
@trangthai bit
as
	insert into HoaDon values(@mahd, @manv, @maban, 
	@ngaytao, @giamgia, @tongtien, @trangthai)
go


-- Xóa hóa đơn
create procedure p_XoaHoaDon
@mahd varchar(10)
as
	begin
		delete from HoaDon where MaHD = @mahd
	end
go


-- Cập nhật trạng thái hóa đơn
create procedure p_CapNhatHoaDon
@mahd varchar(10),
@tongtien int,
@trangthai bit
as
	begin
		update HoaDon set TongTien = @tongtien, TrangThai = @trangthai where MaHD = @mahd
	end
go


-- Cập nhật mã bàn của hóa đơn
create procedure p_CapNhatMaBanCuaHoaDon
@mahd varchar(10),
@maban varchar(10)
as
	begin
		update HoaDon set MaBan = @maban where MaHD = @mahd
	end
go


-- Lấy tổng tiền của hóa đơn
create procedure p_LayTongTien
@mahd varchar(10)
as
	begin
		select TongTien from HoaDon where MaHD = @mahd
	end
go


-- Tìm kiếm hóa đơn theo mã hóa đơn
create procedure p_TimKiemHoaDonTheoMaHD
@mahd varchar(10)
as
	begin
		select * from HoaDon where MaHD like '%' + @mahd + '%'
	end
go


-- Tìm kiếm hóa đơn theo mã nhân viên
create procedure p_TimKiemHoaDonTheoMaNV
@manv varchar(10)
as
	begin
		select * from HoaDon where MaNV like '%' + @manv + '%'
	end
go


-- Tìm kiếm hóa đơn theo mã hóa đơn
create procedure p_TimKiemHoaDonTheoMaBan
@maban varchar(10)
as
	begin
		select * from HoaDon where MaBan like '%' + @maban + '%'
	end
go


-- Load chi tiết hóa đơn theo mã hóa đơn
create procedure p_LoadCTHD
@mahd varchar(10)
as	
	begin
		select * from ChiTietHoaDon where MaHD = @mahd
	end
go

-- Thêm Chi tiết hóa đơn
create procedure p_ThemCTHD
@macthd varchar(10),
@mahd varchar(10),
@mamon varchar(10),
@soluong int
as
	begin
		insert into ChiTietHoaDon values(@macthd, @mahd, @mamon, @soluong)
	end
go


-- Load tính lương nhân viên
create procedure p_LoadTinhLuong
as
	begin
		select NV.MaNV, NV.HoTen, NV.ChucVu, NV.SoNgayLam, Count(CLV.Ca) as N'Số Ca', 
				case when NV.ChucVu=N'Thu Ngân' then NV.SoNgayLam*25000*5*Count(CLV.Ca)						       
				when NV.ChucVu=N'Pha Chế'  then NV.SoNgayLam*24000*5*Count(CLV.Ca)
				when NV.ChucVu=N'Phục Vụ'  then NV.SoNgayLam*23000*5*Count(CLV.Ca) end as N'Tổng Lương'
		from NhanVien as NV inner join CaLamViec as CLV
		on NV.MaNV=CLV.MaNV
		group by NV.MaNV, NV.HoTen, NV.ChucVu, NV.SoNgayLam
	end
go


-- Đặt số ngày làm = 0 khi tính lương của nhân viên tương ứng
create procedure p_TinhLuong
@manv varchar(10)
as
	begin
		update NhanVien set SoNgayLam = 0 where MaNV = @manv
	end
go


-- Thống kê theo tháng
/*
-- convert(int, SUBSTRING(CONCAT(month(NgayTao), '/', year(NgayTao)), 1, CHARINDEX('/', CONCAT(month(NgayTao), '/', year(NgayTao))) - 1))
-- concat là nối chuỗi lại
-- chuyển chuỗi sang số để sắp xếp theo giá trị tăng dần
-- SUBSTRING(CONCAT(month(NgayTao), '/', year(NgayTao)) là chuỗi tháng năm vd 1/2022
-- CHARINDEX('/', CONCAT(month(NgayTao), '/', year(NgayTao))) - 1) là trả về index của '/' trong chuỗi
-1 để chỉ lấy giá trị trước '/' -> kết quả 1 hoặc 11
-- convert(int, chuỗi) vd convert(int, 11)
*/
-- Thống kê theo tháng
create procedure p_ThongKeTheoThang
@nam varchar(10)
as
	begin
		select CONCAT(month(NgayTao), '/', year(NgayTao)) as ThangNam, sum(TongTien) as TongTien from HoaDon
		where year(NgayTao) = @nam and TrangThai = 1
		group by CONCAT(month(NgayTao), '/', year(NgayTao))
		order by convert(int, SUBSTRING(CONCAT(month(NgayTao), '/', year(NgayTao)), 1, CHARINDEX('/', CONCAT(month(NgayTao), '/', year(NgayTao))) - 1))
	end
go

-- Thống kê theo năm
create procedure p_ThongKeTheoNam
@namtu varchar(10), -- từ năm
@namden varchar(10) -- đến năm
as
	begin
		select year(NgayTao) as Nam, sum(TongTien) as TongTien from HoaDon
		where year(NgayTao) between @namtu and @namden and TrangThai = 1
		group by year(NgayTao)
	end
go


-- Lấy chi tiết hóa đơn cho hóa đơn thanh toán
create procedure p_LayCTHDChoThanhToan
@mahd varchar(10),
@manv varchar(10),
@maban varchar(10)
as
	select TD.TenMon, TD.DonGia, CTHD.SoLuong, TD.DonGia*CTHD.SoLuong as ThanhTien,
           NV.HoTen, B.TenBan, HD.NgayTao, HD.TongTien, HD.MaHD
	from ChiTietHoaDon as CTHD, HoaDon as HD, ThucDon as TD, NhanVien as NV, Ban as B
	where HD.MaHD = @mahd and HD.MaBan = @maban and HD.MaNV = @manv and HD.TrangThai = 1
		  and CTHD.MaMon = TD.MaMon and CTHD.MaHD = HD.MaHD and HD.MaNV = NV.MaNV 
		  and HD.MaBan = B.MaBan
go


-- Lấy lại mật khẩu
create procedure p_LayLaiMatKhau
@n varchar(5),
@manv varchar(10),
@hoten nvarchar(50),
@sdt varchar(12)
as
	begin
		select TK.MatKhau from NhanVien as NV, TaiKhoan as TK
		where NV.MaNV = @manv and NV.HoTen = @n + @hoten and NV.SDT = @sdt 
			and NV.ChucVu != N'Quản lý' and NV.MaNV = TK.TenTaiKhoan
	end
go





----------------Tạo dữ liệu cho database QuanLyCaPhe--------------------


-- Thêm dữ liệu nhân viên
exec p_ThemNhanVien 'NV02', NV02, N'Nguyễn Ngọc Thạch', N'42/17 Bình Thọ, Thủ Đức','0987733760', '2021-03-01', 30, 0, '1995-05-03', N'Thu ngân', 'MC02', 1
go
exec p_ThemNhanVien 'NV03', NV03, N'Nguyễn Bảo Long', N'43/12 Linh Chiểu, Thủ Đức','0343751820', '2021-03-01', 30, 0, '1995-07-11', N'Phục vụ', 'MC03', 1
go
exec p_ThemNhanVien 'NV04', NV04, N'Đỗ Thị Nhung', N'22/18 Linh Chiểu, Thủ Đức','01655849046', '2021-03-01', 30, 1, '1996-09-22', N'Pha chế', 'MC04', 1
go
exec p_ThemNhanVien 'NV05', NV05, N'Trần Thị Thùy', N'35/12 Linh Chiểu, Thủ Đức','0987755624', '2021-03-01', 30, 1, '1999-01-03', N'Phục vụ', 'MC05', 1
go
exec p_ThemNhanVien 'NV06', NV06, N'Nguyễn Quỳnh Chi', N'35/17 Linh Chiểu, Thủ Đức','0936655487', '2021-03-01', 30, 1, '1995-08-08', N'Thu ngân', 'MC06', 2
go
exec p_ThemNhanVien 'NV07', NV07, N'Nguyễn Thị Thanh', N'28/17 Linh Trung, Thủ Đức','0345782869', '2021-03-01', 30, 1, '1995-11-02', N'Phục vụ', 'MC07', 2
go
exec p_ThemNhanVien 'NV08', NV08, N'Tôn Thất Gia', N'57/85 Linh Chiểu, Thủ Đức','01699857845', '2021-03-01', 30, 0, '1995-05-28', N'Pha chế', 'MC08', 2
go
exec p_ThemNhanVien 'NV09', NV09, N'Lâm Hoàng Phúc', N'58/57 Bình Thọ, Thủ Đức','0325145785', '2021-03-01', 30, 0, '1995-04-17', N'Phục vụ', 'MC09', 2
go
exec p_ThemNhanVien 'NV10', NV10, N'Nguyễn Nhật Vũ', N'23/1 Linh Trung, Thủ Đức','0343751920', '2021-03-01', 30, 0, '1995-04-06', N'Thu ngân', 'MC10', 3
go
exec p_ThemNhanVien 'NV11', NV11, N'Nguyễn Tuấn Tài', N'23/1 Nguyễn Duy Tân, Quận 3','0343782596', '2021-03-01', 30, 1, '1995-08-29', N'Phục vụ', 'MC11', 3
go
exec p_ThemNhanVien 'NV12', NV12, N'Nguyễn Minh Chiến', N'20/85 Linh Chiểu, Thủ Đức','0987755624', '2021-03-01', 30, 0, '1995-01-15', N'Pha chế', 'MC12', 3
go
exec p_ThemNhanVien 'NV13', NV13, N'Trần Thị Trúc', N'11/57 Bình Thọ, Thủ Đức','01683522154', '2021-03-01', 30, 0, '1995-09-09', N'Phục vụ', 'MC13', 3
go

-- Thêm hóa đơn
insert into HoaDon values ('HD01', 'NV02', 'MB03', '2021-03-01', 0, 46000, 1)
insert into HoaDon values ('HD02', 'NV02', 'MB01', '2021-04-01', 0, 36000, 1)
insert into HoaDon values ('HD03', 'NV02', 'MB09', '2021-05-01', 0, 36000, 1)
insert into HoaDon values ('HD04', 'NV02', 'MB13', '2021-06-01', 0, 35000, 1)
insert into HoaDon values ('HD05', 'NV06', 'MB02', '2021-03-01', 0, 30000, 1)
insert into HoaDon values ('HD06', 'NV06', 'MB04', '2021-04-01', 0, 35000, 1)
insert into HoaDon values ('HD07', 'NV06', 'MB14', '2021-05-01', 0, 75000, 1)
insert into HoaDon values ('HD08', 'NV06', 'MB15', '2021-06-01', 0, 28000, 1)
insert into HoaDon values ('HD09', 'NV10', 'MB05', '2021-03-01', 0, 38000, 1)
insert into HoaDon values ('HD10', 'NV10', 'MB01', '2021-04-01', 0, 34000, 1)
insert into HoaDon values ('HD11', 'NV10', 'MB08', '2021-05-01', 0, 40000, 1)
insert into HoaDon values ('HD12', 'NV10', 'MB07', '2021-06-01', 0, 64000, 1)
insert into HoaDon values ('HD13', 'NV02', 'MB01', '2021-07-01', 0, 150000, 1)
insert into HoaDon values ('HD14', 'NV06', 'MB07', '2021-07-01', 0, 150000, 1)
insert into HoaDon values ('HD15', 'NV10', 'MB10', '2021-07-01', 0, 160000, 1)
insert into HoaDon values ('HD16', 'NV02', 'MB02', '2021-08-01', 0, 160000, 1)
insert into HoaDon values ('HD17', 'NV06', 'MB07', '2021-08-01', 0, 180000, 1)
insert into HoaDon values ('HD18', 'NV10', 'MB10', '2021-08-01', 0, 180000, 1)
insert into HoaDon values ('HD19', 'NV02', 'MB03', '2021-09-01', 0, 180000, 1)
insert into HoaDon values ('HD20', 'NV06', 'MB07', '2021-09-01', 0, 180000, 1)
insert into HoaDon values ('HD21', 'NV10', 'MB10', '2021-09-01', 0, 200000, 1)
insert into HoaDon values ('HD22', 'NV02', 'MB04', '2021-10-01', 0, 200000, 1)
insert into HoaDon values ('HD23', 'NV06', 'MB07', '2021-10-01', 0, 150000, 1)
insert into HoaDon values ('HD24', 'NV10', 'MB10', '2021-10-01', 0, 150000, 1)
insert into HoaDon values ('HD25', 'NV02', 'MB05', '2021-11-01', 0, 150000, 1)
insert into HoaDon values ('HD26', 'NV06', 'MB07', '2021-11-01', 0, 150000, 1)
insert into HoaDon values ('HD27', 'NV10', 'MB10', '2021-11-01', 0, 200000, 1)
insert into HoaDon values ('HD28', 'NV02', 'MB06', '2021-12-01', 0, 200000, 1)
insert into HoaDon values ('HD29', 'NV06', 'MB07', '2021-12-01', 0, 200000, 1)
insert into HoaDon values ('HD30', 'NV10', 'MB10', '2021-12-01', 0, 200000, 1)
insert into HoaDon values ('HD31', 'NV02', 'MB01', '2022-01-01', 0, 150000, 1)
insert into HoaDon values ('HD32', 'NV06', 'MB06', '2022-01-01', 0, 150000, 1)
insert into HoaDon values ('HD33', 'NV10', 'MB11', '2022-01-01', 0, 160000, 1)
insert into HoaDon values ('HD34', 'NV02', 'MB14', '2022-02-01', 0, 160000, 1)
insert into HoaDon values ('HD35', 'NV06', 'MB01', '2022-02-01', 0, 180000, 1)
insert into HoaDon values ('HD36', 'NV10', 'MB02', '2022-02-01', 0, 180000, 1)
insert into HoaDon values ('HD37', 'NV02', 'MB03', '2022-03-01', 0, 180000, 1)
insert into HoaDon values ('HD38', 'NV06', 'MB04', '2022-03-01', 0, 180000, 1)
insert into HoaDon values ('HD39', 'NV10', 'MB06', '2022-03-01', 0, 150000, 1)
insert into HoaDon values ('HD40', 'NV02', 'MB05', '2022-04-01', 0, 150000, 1)
insert into HoaDon values ('HD41', 'NV06', 'MB07', '2022-04-01', 0, 150000, 1)
insert into HoaDon values ('HD42', 'NV10', 'MB08', '2022-04-01', 0, 150000, 1)
insert into HoaDon values ('HD43', 'NV02', 'MB09', '2022-05-01', 0, 150000, 1)
insert into HoaDon values ('HD44', 'NV06', 'MB10', '2022-05-01', 0, 150000, 1)
insert into HoaDon values ('HD45', 'NV10', 'MB10', '2022-05-01', 0, 160000, 1)
insert into HoaDon values ('HD46', 'NV02', 'MB01', '2022-06-01', 0, 160000, 1)
insert into HoaDon values ('HD47', 'NV06', 'MB02', '2022-06-01', 0, 180000, 1)
insert into HoaDon values ('HD48', 'NV10', 'MB04', '2022-06-01', 0, 180000, 1)
insert into HoaDon values ('HD49', 'NV02', 'MB03', '2022-07-01', 0, 180000, 1)
insert into HoaDon values ('HD50', 'NV06', 'MB02', '2022-07-01', 0, 180000, 1)
insert into HoaDon values ('HD51', 'NV10', 'MB01', '2022-07-01', 0, 180000, 1)
insert into HoaDon values ('HD52', 'NV02', 'MB14', '2022-08-01', 0, 180000, 1)
insert into HoaDon values ('HD53', 'NV06', 'MB15', '2022-08-01', 0, 150000, 1)
insert into HoaDon values ('HD54', 'NV10', 'MB11', '2022-08-01', 0, 150000, 1)
insert into HoaDon values ('HD55', 'NV02', 'MB12', '2022-09-01', 0, 200000, 1)
insert into HoaDon values ('HD56', 'NV06', 'MB13', '2022-09-01', 0, 100000, 1)
insert into HoaDon values ('HD57', 'NV10', 'MB10', '2022-09-01', 0, 150000, 1)
insert into HoaDon values ('HD58', 'NV02', 'MB09', '2022-10-01', 0, 150000, 1)
insert into HoaDon values ('HD59', 'NV06', 'MB08', '2022-10-01', 0, 300000, 1)
insert into HoaDon values ('HD60', 'NV10', 'MB07', '2022-10-01', 0, 100000, 1)
insert into HoaDon values ('HD61', 'NV02', 'MB05', '2022-11-01', 0, 250000, 1)
insert into HoaDon values ('HD62', 'NV06', 'MB04', '2022-11-01', 0, 250000, 1)
insert into HoaDon values ('HD63', 'NV10', 'MB03', '2022-11-01', 0, 100000, 1)
go

-- Thêm CTHD
insert into ChiTietHoaDon values ('CTHD01', 'HD01', 'MM01', 1)
insert into ChiTietHoaDon values ('CTHD02', 'HD01', 'MM02', 1)
insert into ChiTietHoaDon values ('CTHD03', 'HD01', 'MM04', 1)
insert into ChiTietHoaDon values ('CTHD04', 'HD02', 'MM05', 1)
insert into ChiTietHoaDon values ('CTHD05', 'HD02', 'MM06', 1)
insert into ChiTietHoaDon values ('CTHD06', 'HD03', 'MM07', 1)
insert into ChiTietHoaDon values ('CTHD07', 'HD03', 'MM08', 1)
insert into ChiTietHoaDon values ('CTHD08', 'HD04', 'MM09', 1)
insert into ChiTietHoaDon values ('CTHD09', 'HD04', 'MM01', 1)
insert into ChiTietHoaDon values ('CTHD10', 'HD05', 'MM11', 1)
insert into ChiTietHoaDon values ('CTHD11', 'HD05', 'MM12', 1)
insert into ChiTietHoaDon values ('CTHD12', 'HD06', 'MM20', 1)
insert into ChiTietHoaDon values ('CTHD13', 'HD06', 'MM18', 1)
insert into ChiTietHoaDon values ('CTHD14', 'HD07', 'MM22', 1)
insert into ChiTietHoaDon values ('CTHD15', 'HD07', 'MM24', 1)
insert into ChiTietHoaDon values ('CTHD16', 'HD07', 'MM16', 1)
insert into ChiTietHoaDon values ('CTHD17', 'HD08', 'MM19', 1)
insert into ChiTietHoaDon values ('CTHD18', 'HD08', 'MM06', 1)
insert into ChiTietHoaDon values ('CTHD19', 'HD09', 'MM07', 1)
insert into ChiTietHoaDon values ('CTHD20', 'HD09', 'MM15', 1)
insert into ChiTietHoaDon values ('CTHD21', 'HD10', 'MM04', 1)
insert into ChiTietHoaDon values ('CTHD22', 'HD10', 'MM05', 1)
insert into ChiTietHoaDon values ('CTHD23', 'HD11', 'MM24', 1)
insert into ChiTietHoaDon values ('CTHD24', 'HD11', 'MM12', 1)
insert into ChiTietHoaDon values ('CTHD25', 'HD12', 'MM06', 1)
insert into ChiTietHoaDon values ('CTHD26', 'HD12', 'MM01', 1)
insert into ChiTietHoaDon values ('CTHD27', 'HD12', 'MM02', 1)
insert into ChiTietHoaDon values ('CTHD28', 'HD12', 'MM03', 1)
insert into ChiTietHoaDon values ('CTHD29', 'HD13', 'MM01', 10)
insert into ChiTietHoaDon values ('CTHD30', 'HD14', 'MM02', 10)
insert into ChiTietHoaDon values ('CTHD31', 'HD15', 'MM03', 10)
insert into ChiTietHoaDon values ('CTHD32', 'HD16', 'MM04', 10)
insert into ChiTietHoaDon values ('CTHD33', 'HD17', 'MM05', 10)
insert into ChiTietHoaDon values ('CTHD34', 'HD18', 'MM06', 10)
insert into ChiTietHoaDon values ('CTHD35', 'HD19', 'MM07', 10)
insert into ChiTietHoaDon values ('CTHD36', 'HD20', 'MM08', 10)
insert into ChiTietHoaDon values ('CTHD37', 'HD21', 'MM09', 10)
insert into ChiTietHoaDon values ('CTHD38', 'HD22', 'MM10', 10)
insert into ChiTietHoaDon values ('CTHD39', 'HD23', 'MM11', 10)
insert into ChiTietHoaDon values ('CTHD40', 'HD24', 'MM12', 10)
insert into ChiTietHoaDon values ('CTHD41', 'HD25', 'MM13', 10)
insert into ChiTietHoaDon values ('CTHD42', 'HD26', 'MM14', 10)
insert into ChiTietHoaDon values ('CTHD43', 'HD27', 'MM15', 10)
insert into ChiTietHoaDon values ('CTHD44', 'HD28', 'MM16', 10)
insert into ChiTietHoaDon values ('CTHD45', 'HD29', 'MM17', 10)
insert into ChiTietHoaDon values ('CTHD46', 'HD30', 'MM18', 10)
insert into ChiTietHoaDon values ('CTHD47', 'HD31', 'MM01', 10)
insert into ChiTietHoaDon values ('CTHD48', 'HD32', 'MM02', 10)
insert into ChiTietHoaDon values ('CTHD49', 'HD33', 'MM03', 10)
insert into ChiTietHoaDon values ('CTHD50', 'HD34', 'MM04', 10)
insert into ChiTietHoaDon values ('CTHD51', 'HD35', 'MM05', 10)
insert into ChiTietHoaDon values ('CTHD52', 'HD36', 'MM06', 10)
insert into ChiTietHoaDon values ('CTHD53', 'HD37', 'MM07', 10)
insert into ChiTietHoaDon values ('CTHD54', 'HD38', 'MM08', 10)
insert into ChiTietHoaDon values ('CTHD55', 'HD39', 'MM01', 10)
insert into ChiTietHoaDon values ('CTHD56', 'HD40', 'MM01', 10)
insert into ChiTietHoaDon values ('CTHD57', 'HD41', 'MM01', 10)
insert into ChiTietHoaDon values ('CTHD58', 'HD42', 'MM02', 10)
insert into ChiTietHoaDon values ('CTHD59', 'HD43', 'MM02', 10)
insert into ChiTietHoaDon values ('CTHD60', 'HD44', 'MM02', 10)
insert into ChiTietHoaDon values ('CTHD61', 'HD45', 'MM03', 10)
insert into ChiTietHoaDon values ('CTHD62', 'HD46', 'MM03', 10)
insert into ChiTietHoaDon values ('CTHD63', 'HD47', 'MM05', 10)
insert into ChiTietHoaDon values ('CTHD64', 'HD48', 'MM05', 10)
insert into ChiTietHoaDon values ('CTHD65', 'HD49', 'MM05', 10)
insert into ChiTietHoaDon values ('CTHD66', 'HD50', 'MM06', 10)
insert into ChiTietHoaDon values ('CTHD67', 'HD51', 'MM06', 10)
insert into ChiTietHoaDon values ('CTHD68', 'HD52', 'MM06', 10)
insert into ChiTietHoaDon values ('CTHD69', 'HD53', 'MM12', 10)
insert into ChiTietHoaDon values ('CTHD70', 'HD54', 'MM12', 10)
insert into ChiTietHoaDon values ('CTHD71', 'HD55', 'MM18', 10)
insert into ChiTietHoaDon values ('CTHD72', 'HD56', 'MM19', 10)
insert into ChiTietHoaDon values ('CTHD73', 'HD57', 'MM20', 10)
insert into ChiTietHoaDon values ('CTHD74', 'HD58', 'MM21', 10)
insert into ChiTietHoaDon values ('CTHD75', 'HD59', 'MM22', 10)
insert into ChiTietHoaDon values ('CTHD76', 'HD60', 'MM23', 10)
insert into ChiTietHoaDon values ('CTHD77', 'HD61', 'MM24', 10)
insert into ChiTietHoaDon values ('CTHD78', 'HD62', 'MM25', 10)
insert into ChiTietHoaDon values ('CTHD79', 'HD63', 'MM26', 10)
go



