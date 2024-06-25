create database Qly_SanPham
use Qly_SanPham

create table sp 
(

TEN NVARCHAR(20),
THELOAI  NVARCHAR(20),
DONGIA INT


)
drop table sp

INSERT INTO SP (TEN, THELOAI, DONGIA ) values 
('keo mut','banh keo','50000'),
('tao','hoa qua' ,'100000'),
('truyen tranh','sach','18000'),
('banh oreo', 'banh keo', '20000')


select * from sp