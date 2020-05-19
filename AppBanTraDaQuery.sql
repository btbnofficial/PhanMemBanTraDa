create database AppBanTraDa;
go
use AppBanTraDa;
go

Create table Food
(
	Id int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	Price float not null default 0
);

create table TableFood
(
	Id int identity primary key,
	Status nvarchar(100) not null default N'Trống',
	Name nvarchar(100) not null default N'Chưa đặt tên'
);

create table Bill
(
	Id int identity primary key,
	DateCheckIn Date not null default getDate(),
	DateCheckOut Date,
	TableId int not null,
	Status int not null, --Da thanh toan: 1, Chua thanh toan: 0
	foreign key(TableId) references dbo.TableFood(Id)
);

create table BillDetail
(
	Id int identity primary key,
	BillId int not null,
	FoodId int not null,
	count int not null,
	foreign key(BillId) references dbo.Bill(Id),
	foreign key(FoodId) references dbo.Food(Id)
);

create table Account
(
	Username varchar(100) primary key,
	Password varchar(100) not null,
	Type int not null --1: admin, 0: staff
);