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

create procedure usp_GetListAccount
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
create procedure usp_AddBillDetail
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



select * from TableFood

create procedure usp_ChangeTableStatus
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

select * from Account

select * from Account where Username = 'btbncsgo'

select * from Food where Id = 1

create procedure usp_DeleteFood
(
	@FoodId int
)
as
begin
	Delete from Food where Id = @FoodId
end

create procedure usp_AddFood
(
	@Name nvarchar(100),
	@Price float
)
as
begin
	insert into dbo.Food values (@Name,@Price)
end

execute usp_AddFood N'Kem trang tien', 12000

create procedure usp_EditFoodPrice
(
	@Price float,
	@Id int
)
as
begin
	update dbo.Food set Price = @Price where Id = @Id
end

usp_EditFoodPrice 10500,1

select * from TableFood

create procedure usp_AddTalbeFood
(
	@Name nvarchar(100)
)
as
begin
	insert into dbo.TableFood(Status, Name) values (N'Trống',@Name)
end

select * from TableFood

delete from TableFood where Id = 7

--27052020

alter procedure usp_CheckOutBill
(
	@BillId int
)
as
begin
	declare @tableId int;
	declare @tableFoodName nvarchar(100);
	declare @DateCheckOut Date;
	declare @TotalPrice float;
	select @tableId = TableFood.Id from TableFood, Bill where Bill.Id = @BillId and Bill.TableId = @tableId;
	select @DateCheckOut = Bill.DateCheckOut from Bill;
	select @tableFoodName = TableFood.Name from TableFood, Bill where Bill.Id = @BillId and Bill.TableId = @tableId;
	declare @totalBillDetail int = 0;
	while @totalBillDetail<30
	begin
		set @TotalPrice = Food.Price*BillDetail.count from BillDetail, Food
	end;
	
	--Xoa Bill va BillDetail di va de ban ve trang thai trong
	delete from BillDetail where BillDetail.BillId = @BillId;
	delete from Bill where Id = @BillId;
	
end

create table SavedBill
(
	Id int identity primary key,
	TableName nvarchar(100),count int,
	TotalPrice float,
	DateCheckOut Date,
	FoodName nvarchar(100)
	
)
go

select * from SavedBill where SavedBill.FoodName = N'Nước mía';

alter procedure usp_AddSavedBill
(
	@TableName nvarchar(100),
	@count int,
	@TotalPrice float,
	@DateCheckOut Date,
	@FoodName nvarchar(100)
)
as
begin
	insert into dbo.SavedBill(TableName, count, TotalPrice, DateCheckOut,FoodName) values(@TableName, @count, @TotalPrice,@DateCheckOut,@FoodName)
end

select * from Bill
select * from BillDetail where BillId = 38
select * from Bill where Bill.TableId = 6
select Name from Food where Id = 1
Select * from SavedBill where DateCheckOut >= '2020-05-01' and DateCheckOut <= '2020-05-27' and SavedBill.FoodName = N'Nước mía'
