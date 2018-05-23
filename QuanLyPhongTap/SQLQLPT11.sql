use QLPHONGTAPGYM
GO


--Nhân viên
ALTER PROC them_NV(@manv nchar(10),@tennv nvarchar(50),@diachi nvarchar(50), @anh image,@sdt int,@machucvu int,@manql int)
as
begin  if exists (select manv from NHANVIEN where MANV=@manv) print ('Không thể thêm được')
else

 insert into NHANVIEN(MANV,TENNV,DIACHI,ANH,SDT,MACHUCVU,MANQL)
 values(@manql,@tennv,@diachi,@anh,@sdt,@machucvu,@manql)
 end

ALTER PROC sua_NV(@manv nchar(10),@tennv nvarchar(50),@diachi nvarchar(50), @anh image,@sdt int,@manql int,@machucvu int)
as
begin

update NHANVIEN set TENNV=@tennv,DIACHI=@diachi,ANH=@anh,
                    SDT=@sdt,MANQL=@manql,MACHUCVU=@machucvu
where MANV=@manv
end

CREATE PROC xoa_NV(@manv nchar(10))
as
begin

		delete NHANVIEN
			where MANV=@manv
		
end


--get NHANVIEN
alter PROC get_NV
as begin
select MANV as[Mã NV],TENNV AS[Tên NV],DIACHI as [Địa Chỉ],NHANVIEN.MACHUCVU AS[Mã Chức Vụ],TENCHUCVU AS [Tên Chức Vụ],SDT as [SĐT],LUONG AS [Lương]
from NHANVIEN,CHUCVU
END
----------------------------
--Khách hàng
CREATE PROC them_KH(@makh char(10),@tenkh nvarchar(50),@cmnd nchar(10),@email nvarchar(50),@diachi nvarchar(50),@sdt int,@mathe int)
as begin
if exists(select MAKH from KHACHHANG where MaKh=@makh) print('Không thêm được')
else insert into KhachHang values(@makh,@tenkh,@cmnd,@email,@diachi,@sdt,@mathe)
end
----------------------
CREATE PROC sua_KH(@makh char(10),@tenkh nvarchar(50),@cmnd nchar(10),@email nvarchar(50),@diachi nvarchar(50),@sdt int,@mathe int)
as begin
update KHACHHANG
set TENKH=@tenkh,
CMND=@cmnd,
EMAIL=@email,
DIACHI=@diachi,
SDT=@sdt,
MATHE=@mathe
where MAKH=@makh
end
-------------------
alter PROC xoa_KH(@makh nchar(10))
as begin
delete PHIEUDKY where MAKH=@makh
delete HOADON where MAKH=@makh
delete KHACHHANG where MAKH=@makh
end
--Get KHACHHANG

CREATE PROC get_KH
AS BEGIN
SELECT MAKH AS [Mã KH],TENKH AS [Tên KH],CMND AS [CMND],EMAIL as [Email],DIACHI AS[Địa Chỉ],SDT AS [SĐT],MATHE AS [Mã Thẻ]
FROM KHACHHANG
end

--Sản phẩm
CREATE PROC them_SP(@masp nchar(10),@tensp nvarchar(50),@gia int,@nguongoc nvarchar(50))
as begin
if exists (select masp from SANPHAM where MASP=@masp) print('Không thêm được')
else
insert into SANPHAM values (@masp,@tensp,@gia,@nguongoc)
end
-------------------------
CREATE PROC sua_SP(@masp nchar(10),@tensp nvarchar(50),@gia int,@nguongoc nvarchar(50))
as begin
UPDATE SANPHAM SET 
TENSP=@tensp,
GIA=@gia,
NGUONGOC=@nguongoc
WHERE MASP=@masp
END
------------------
CREATE PROC xoa_SP(@masp nchar(10))
as begin
delete CTHOADON WHERE MASP=@masp
DELETE SANPHAM  WHERE MASP=@masp
END
---------------
CREATE PROC get_SP
as begin
SELECT MASP AS [Mã SP],TENSP AS [Tên SP],GIA AS [Gía],NGUONGOC as [Nguồn Gốc]
FROM SANPHAM
end

--------------////-------------
--Thiết Bị
CREATE PROC them_tb(@matb nchar(10),@tentb nvarchar(10),@loaitb nvarchar(50),@soluong int,@namsx int,
@hangsx nvarchar(50),@giatb int,@manql int)
as begin
if exists (select MATB from THIETBI where MATB=@matb) print('Không thêm được')
else
insert into THIETBI values (@matb,@tentb,@loaitb,@soluong,@namsx,@hangsx,@giatb,@manql)
end
--------------------------------
CREATE PROC sua_tb(@matb nchar(10),@tentb nvarchar(10),@loaitb nvarchar(50),@soluong int,@namsx int,
@hangsx nvarchar(50),@giatb int,@manql int)
as begin
UPDATE THIETBI SET 
TENTB=@tentb,
LOAITB=@loaitb,
SOLUONG=@soluong,
NAMSX=@namsx,
HANGSX =@hangsx,
GIATB=@giatb,
MANQL=@manql
WHERE MATB=@matb
END

-----------------------------------
CREATE PROC xoa_tb(@matb nchar(10))
as begin
DELETE THIETBI WHERE MATB=@matb
END

--------------
CREATE PROC get_tb
as begin
SELECT MATB AS [Mã TB],TENTB AS [Tên TB],LOAITB AS [Loại TB],SOLUONG AS [Số Lượng],NAMSX as [Năm SX],HANGSX AS [Hãng SX],GIATB AS [Gía TB],MANQL as [Mã NQL]
FROM THIETBI
end

-----------------//----------------------------------------------

