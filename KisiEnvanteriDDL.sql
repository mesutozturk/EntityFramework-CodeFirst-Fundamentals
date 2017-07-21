use master
go
create database KisiEnvanteri
go
use KisiEnvanteri
go
create table Kisiler(
	Id uniqueidentifier primary key,
	Ad nvarchar(25) not null,
	Soyad nvarchar(25) not null,
	Boy int,
	Kilo int,
	DogumTarihi date,
	Cinsiyet int,
	MedeniDurum int,
	Meslek nvarchar(50),
	Fotograf varbinary(max)
)
go
alter table Kisiler
add TCKN char(11)