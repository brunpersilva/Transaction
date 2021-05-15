Create DataBase Transactions

use Transactions

create Table OrderType(
	Id int NOT NULL PRIMARY KEY,
	Description nvarchar(50)
);

go
create Table TransactionStatus(
	Id int NOT NULL PRIMARY KEY,
	Description nvarchar(50)
);

go

create table [User](
	Id int identity(1,1) NOT NULL PRIMARY KEY,
	Name nvarchar(200),
	Email nvarchar(200)
)

go

create table [Transaction](
	Id int NOT NULL PRIMARY KEY,
	TransactionCode nvarchar(100),
	UserId int Constraint FK_UserID FOREIGN KEY REFERENCES [User](Id),
	Value decimal,
	OrderType int Constraint FK_OrderTypeID FOREIGN KEY REFERENCES [OrderType](Id),
	TransactionStatus int Constraint FK_TransactionStatusID FOREIGN KEY REFERENCES TransactionStatus(Id),
	Date Datetime2,
)
go 

Create Procedure sp_Insert_User
		@Name nvarchar(200),
		@Email nvarchar(200)

As
Begin
	
	SET NOCOUNT ON;	
		

		insert into [User](Name, Email) Values(@Name, @Email)			
		SELECT CAST(scope_identity() AS int)
		
End
