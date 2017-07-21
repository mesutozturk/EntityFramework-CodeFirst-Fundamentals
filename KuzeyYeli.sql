use master
go
create database KuzeyYeli
go
use KuzeyYeli
go
create table Kategoriler(
	ID int primary key identity,
	Ad nvarchar(30) unique not null,
	Aciklama nvarchar(max),
	EklenmeTarihi smalldatetime default getdate()
)
go
create table Urunler(
	ID int primary key identity,
	Ad nvarchar(75) unique not null,
	Fiyat decimal(7,2) default 0 check (Fiyat >= 0),
	Stok int default 0 check (Stok>=0),
	KategoriID int null references Kategoriler(ID),
	EklenmeTarihi smalldatetime default getdate(),
	AktifMi bit default 1
)

insert into Kategoriler (Ad,Aciklama) values('Meyve','Meyveler')
insert into Kategoriler (Ad,Aciklama) values('Sebze','Sebzeler')

alter table Kategoriler
alter column EklenmeTarihi smalldatetime not null

alter table Urunler
alter column EklenmeTarihi smalldatetime not null

insert into Urunler (Ad,AktifMi,Fiyat,KategoriID,Stok)
values ('Armut',1,3,1,5)

select * from Urunler
select ID,Ad from Kategoriler