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

select Food.Name as FoodName,Food.Price as Price, BillDetail.Count as Count,  Food.Price*BillDetail.count as TotalPrice from BillDetail, Bill, Food 
where BillDetail.BillId = Bill.Id and BillDetail.FoodId = Food.Id and Bill.TableId = 3

Select * from Food

create procedure usp_AddBill
(
	@TableId int
)
as
begin
	insert into dbo.Bill(DateCheckIn,DateCheckOut,TableId,Status) values (getDate(),getDate(), @TableId, 0)
end	


--nếu đã tồn tại cái Bill của bàn này và chưa có món này, thì thêm mới BillDetail, còn nếu đã có món ăn + bàn này thì chỉ cộng thêm/giảm bớt món ăn
alter procedure usp_AddBillDetail
(
	@BillId int,
	@FoodId int,
	@Count int
)
as
begin
	declare @isExistBillDetail int;
	declare @FoodCount int = 1
	select @isExistBillDetail = Id, @FoodCount = BillDetail.count from BillDetail where BillId = @BillId and FoodId = @FoodId
	if(@isExistBillDetail>0)
	begin
		declare @newCount int = @FoodCount + @Count
		--Nếu số lượng thức ăn của BillDeTail là lớn hơn 0 thì cập nhật, còn nếu = 0 thì xóa BillDetail đó đi
		if(@newCount>0)
		begin
			update BillDetail set count = @FoodCount + @Count where BillId = @BillId and FoodId = @FoodId
		end
		else
		begin
			delete from BillDetail where BillId = @BillId and FoodId = @FoodId
		end
	end
	else
	begin
		insert into dbo.BillDetail(BillId,FoodId,count) values (@BillId,@FoodId,@Count);
	end
end

alter procedure usp_CheckOutBill
(
	@BillId int
)
as
begin
	declare @tableId int;
	select @tableId = TableFood.Id from TableFood, Bill where Bill.Id = @BillId and Bill.TableId = @tableId;
	delete from BillDetail where BillDetail.BillId = @BillId;
	delete from Bill where Id = @BillId;
	
end

select * from TableFood

alter procedure usp_ChangeTableStatus
(
	@TableFoodId int
)
as
begin
	update dbo.TableFood set TableFood.Status = N'Có Người' where TableFood.Id = @TableFoodId
end

create procedure usp_ChangeTableStatusToEmpty
(
	@TableFoodId int
)
as
begin
	update dbo.TableFood set TableFood.Status = N'Trống' where TableFood.Id = @TableFoodId
end

select * from Bill

