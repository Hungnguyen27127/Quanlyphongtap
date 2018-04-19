select * 
from TAIKHOAN
where TEN_USER = 'hungnguyen' and MATKHAU = '123'

select TENDICHVU from GOIDICHVU

select * from HOIVIEN

insert into HOIVIEN
values ('HV008', 'Hoàng Nguyệt Anh', '5-12-1989', 'nữ', 'Hà Nội', '0125484513')

use QLPHONGTAPGYM
go

create proc getCustomerInfo
as
begin
	select HOIVIEN.MAHOIVIEN, TENHOIVIEN, NGAYSINH, GIOITINH, DIACHI, SDT, THEHOIVIEN.MATHE, MADICHVU
	from HOIVIEN, THEHOIVIEN, CTDICHVU
	where HOIVIEN.MAHOIVIEN = THEHOIVIEN.MAHOIVIEN and THEHOIVIEN.MATHE = CTDICHVU.MATHE
end
exec getCustomerInfo
go

update HOIVIEN
set GIOITINH = N'nữ' , TENHOIVIEN = N'Hoàng Nguyệt Anh'
where MAHOIVIEN = 'HV008'


create proc addCustomerInfo
as
begin
	insert into HOIVIEN
	values (
