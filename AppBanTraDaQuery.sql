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

insert into dbo.Account(Username,Password,Type)
values('btbncsgo','Password',1)

insert into dbo.Account(Username,Password,Type)
values('staff1','staff1',0)
select * from Account

alter procedure usp_GetListAccount
as
begin
	Select Username,Type from Account
end

create procedure usp_getAccountByUsername
(
	@username varchar(100)
)
as
begin
	Select * from Account where Username = @username
end

execute usp_getAccountByUsername 'btbncsgo'

select * from Account

insert into dbo.TableFood(Name) values (N'Bàn 7')
select * from TableFood

create procedure usp_AccountLogin
(
	@Username varchar(100),
	@Password varchar(100)
)
as
begin
	Select * from Account where Username = @Username and Password = @Password;
end

execute usp_AccountLogin 'btbncsgo','Password'

create procedure usp_GetTableList
as
begin
	Select * from TableFood
end

select * from Food
select * from Bill
select * from BillDetail

insert into dbo.Food(Name,Price) values(N'Nước chanh', 10000);
insert into dbo.Food(Name,Price) values(N'Nước vối', 4000);
insert into dbo.Food(Name,Price) values(N'Nước sấu', 8000);
insert into dbo.Food(Name,Price) values(N'Red Bull', 12000);

insert into dbo.Bill(DateCheckIn,DateCheckOut,TableId,Status) values(getDate(),getDate(),1,0);
insert into dbo.Bill(DateCheckIn,DateCheckOut,TableId,Status) values(getDate(),getDate(),3,0);
insert into dbo.Bill(DateCheckIn,DateCheckOut,TableId,Status) values(getDate(),getDate(),4,0)

insert into dbo.BillDetail(BillId, FoodId, count) values(1,1,4);
insert into dbo.BillDetail(BillId, FoodId, count) values(2,2,3);
insert into dbo.BillDetail(BillId, FoodId, count) values(3,4,10);
insert into dbo.BillDetail(BillId, FoodId, count) values(3,3,2);

select * from Bill where TableId = 3 and status = 0;

select * from BillDetail where BillId = 2;

select * from TableFood

select Food.Name as FoodName, BillDetail.Count as Count, Food.Price as Price, Food.Price*BillDetail.count as TotalPrice from BillDetail, Bill, Food 
where BillDetail.BillId = Bill.Id and BillDetail.FoodId = Food.Id and Bill.TableId = 3
