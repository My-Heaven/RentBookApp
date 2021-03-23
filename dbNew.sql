create database [RentBooksApp]
go

use [RentBooksApp]
go

create table tblEmployees(
	userName varchar(50) primary key,
	fullName nvarchar(50) not null,
	password varchar(50),
	roleID bit  not null,
)
go
create table tblCostomers(
	Phone varchar(50) primary key,
	fullName nvarchar(50) not null,
	createDate date not null,
	Address nvarchar(500),
	status bit not null,
)
go
create table tblBookTypes(
	typeID int identity(1,1) primary key,
	typeName nvarchar(100) not null,
)
go
create table tblBooks(
	bookID int identity(1,1) primary key,
	bookTitle nvarchar(100) not null,
	quantity int not null,
	price float not null,
	typeID int foreign key references tblBookTypes(typeID) not null,
	author nvarchar(100) not null,
	publishingYear int not null,
	createDate date not null,
	status bit not null,
)
go

create table tblRecord(
	recordID int identity(1,1) primary key,
	userName varchar(50) foreign key references tblEmployees(userName) not null,
	description nvarchar(500) not null,
	recordDate datetime not null
)
go

create table tblOrders(
	orderID int identity(1,1) primary key,
	creater varchar(50) foreign key references tblEmployees(userName) not null,
	tblCostomer varchar(50) foreign key references tblCostomers(Phone) not null,
	orderDate date not null,
	returnDate date not null,
	price float not null,
	status bit not null,
)
go

create table tblOderDetail(
	detailID int identity(1,1) primary key,
	orderID int foreign key references tblOrders(orderID) not null,
	bookID int foreign key references tblBooks(bookID) not null,
	price float not null,
)
go