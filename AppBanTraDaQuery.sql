create database AppBanTraDa;
go
use AppBanTraDa;
go

create table Food
(
	Id int identity primary key,
	Name nvarchar(100),
	Price float
);

create table TableFood
(
	Id int identity primary key,
	Status nvarchar(100),
	Name nvarchar(100)
);

create table Bill
(
	Id int identity primary key,
	DateCheckIn Date,
	DateCheckOut Date,
	TableId int,
	Status int, --Da thanh toan: 1, Chua thanh toan: 0
	foreign key(TableId) references dbo.TableFood(Id)
);

create table BillDetail
(
	Id int identity primary key,
	BillId int,
	FoodId int,
	count int,
	foreign key(BillId) references dbo.Bill(Id),
	foreign key(FoodId) references dbo.Food(Id)
);

create table Account
(
	Username varchar(100) primary key,
	Password varchar(100),
	Type int --1: admin, 0: staff
);