--drop database FAP_Project
--create database FAP_Project
select * from student
use FAP_Project

create table [ApplicationType](
 ID int identity(1,1) primary key,
 [Name] nvarchar(256),
)


create table [Folk](
	Id int identity(1,1) primary key,
	[Name] nvarchar(64)
)

create table [Religion](
	Id int identity(1,1) primary key,
	[Name] nvarchar(64)
)

create table [Student](
 ID int identity(1,1) primary key,
 Fullname nvarchar(256),
 DOB date,
 Gender bit,
 [Identity] nvarchar(32),
 [Address] ntext,
 [RealAddress] nvarchar(64),
 Phonenumber nvarchar(32),
 Email nvarchar(128),
 DOI Date,
 POI nvarchar(128),
 ParentName nvarchar(256),
 ParentPhone nvarchar(32),
 ParentAddress ntext,
 ParentEmail nvarchar (256),
 ParentJob nvarchar(128),
 ParentPOW nvarchar(256),
 OldID nvarchar(32),
 MemberCode nvarchar(32),
 EnrollDate date,
 Mode nvarchar(128),
 Status nvarchar(128),
 CurrentTerm nvarchar(32),
 Major nvarchar(128),
 Curriculumn nvarchar(128),
 Capstone nvarchar(128),
 OldMajor nvarchar(128),
 ChangeMajorConfirm nvarchar(128),
 SVCQConfirm nvarchar(128),
 SVCQDate date,
 PreparedSVConfirm nvarchar(128),
 SevenYear nvarchar(32),
 MainClass nvarchar(128),
 FinancialType nvarchar(128),
 DropConfirm nvarchar(128),
 ChangeCity nvarchar(128),
 SuspendConfirm nvarchar(128),
 TNConfirm nvarchar(128),
 RejoinConfirm nvarchar(128),
 TTto nvarchar(32),
 Specialize nvarchar(32),
 Folk int references [Folk](Id),
 Religion int references [Religion](Id),
 Born nvarchar(128),
 Financial nvarchar(128) default N'0',
 Avatar nvarchar(256)
)

create table [Staff](
 ID int identity(1,1) primary key,
 Fullname nvarchar(256),
 Phonenumber nvarchar(32),
 Email nvarchar(128)
)


create table [Login](
	ID int identity(1,1) primary key,
	RollNumber nvarchar(32),
	[Role] int default 0, --0 for student, 1 for teacher, 2 for parents, 3 for staff, 4 for hr
	[Student] int references [Student](ID),
	[Staff] int references [Staff](ID),
	[Password] nvarchar(64),
)


create table [Application](
 ID int identity(1,1) primary key,
 TypeID int references [ApplicationType](ID),
 [Student] int references [Student](ID),
 Purpose ntext,
 [File] nvarchar(512),
 Status int default 2,
 Note ntext,
 CreatedDate date,
 UpdateDate date
)


create table [Province](
	Id int identity(1,1) primary key,
	[Name] nvarchar(64)
)

create table [City](
	ID int identity(1,1) primary key,
	Name nvarchar(64),
	[Province] int references [Province](Id)
)

create table [District](
	ID int identity(1,1) primary key,
	Name nvarchar(64),
	[City] int references [City](Id)
)

insert into ApplicationType([Name]) values (N'Đề nghị miễn điểm danh')
insert into ApplicationType([Name]) values (N'Đề nghị cấp bảng điểm quá trình')
insert into ApplicationType([Name]) values (N'Đề nghị chuyển đổi tín chỉ')
insert into ApplicationType([Name]) values (N'Đề nghị chuyển đổi từ học Võ sang học Cờ')

insert into Student(Fullname, Gender, Email, MemberCode) values(N'Nguyễn Thu An', 0, N'AnNTHE150432@fpt.edu.vn', N'AnNTHE150432')
insert into Student(Fullname, Gender, Email, MemberCode) values(N'Nguyễn Minh Hạnh', 0, N'HanhNMHE150431@fpt.edu.vn', N'HanhNMHE150431')
insert into Staff(Fullname, Phonenumber, Email) values (N'Nguyễn Văn A', '01010010010', N'ANVST0000001@fpt.edu.vn')
insert into Staff(Fullname, Phonenumber, Email) values (N'Nguyễn Văn B', '01010013010', N'BNVST0000001@fpt.edu.vn')
insert into Staff(Fullname, Phonenumber, Email) values (N'Nguyễn Văn C', '01012313010', N'CNVST0000001@fpt.edu.vn')
insert into [Login](RollNumber, [Role], Staff, [Password]) values ('ST0000001', 4, 1, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Staff, [Password]) values ('ST0000002', 3, 2, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Staff, [Password]) values ('ST0000003', 1, 3, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Student, [Password]) values ('HE150432', 0, 1, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Student, [Password]) values ('HE150431', 0, 2, N'kVU41twDyttUL/SM7IO0vQ==')

insert into [Folk]([Name]) values (N'Kinh')
insert into [Folk]([Name]) values (N'Tày')

insert into [Religion]([Name]) values (N'Không')
insert into [Religion]([Name]) values (N'Phật Giáo')
insert into [Religion]([Name]) values (N'Công Giáo')

insert into [Province](Name) values (N'Hà Nội')
insert into [Province](Name) values (N'Hồ Chí Minh')
insert into [Province](Name) values (N'Đà Nẵng')

insert into [City] (Name, [Province]) values (N'Quận Thanh Xuân', 1)
insert into [City] (Name, [Province]) values (N'Quận Hai Bà Trưng', 1)
insert into [City] (Name, [Province]) values (N'Quận 1', 2)
insert into [City] (Name, [Province]) values (N'Quận 2', 2)
insert into [City] (Name, [Province]) values (N'Quận Cẩm Lệ', 3)
insert into [City] (Name, [Province]) values (N'Quận Hải Châu', 3)

insert into [District] (Name, [City]) values (N'Phường Hạ Đình', 1)
insert into [District] (Name, [City]) values (N'Phường Khương Mai', 1)
insert into [District] (Name, [City]) values (N'Phường Nhân Chính', 1)
insert into [District] (Name, [City]) values (N'Phường Quỳnh Lôi', 2)
insert into [District] (Name, [City]) values (N'Phường Bách Khoa', 2)
insert into [District] (Name, [City]) values (N'Phường Thanh Nhàn', 2)
insert into [District] (Name, [City]) values (N'Phường Bến Nghé', 3)
insert into [District] (Name, [City]) values (N'Phường Bến Thành', 3)
insert into [District] (Name, [City]) values (N'Phường Cô Giang', 3)
insert into [District] (Name, [City]) values (N'Phường An Phú', 4)
insert into [District] (Name, [City]) values (N'Phường Thảo Điền', 4)
insert into [District] (Name, [City]) values (N'Phường An Khánh', 4)
insert into [District] (Name, [City]) values (N'Phường Hòa An', 5)
insert into [District] (Name, [City]) values (N'Phường Hòa Phát', 5)
insert into [District] (Name, [City]) values (N'Phường Hòa Thọ Đông', 5)
insert into [District] (Name, [City]) values (N'Phường Hải Châu I', 6)
insert into [District] (Name, [City]) values (N'Phường Hòa Thuận Đông', 6)
insert into [District] (Name, [City]) values (N'Phường Bình Hiên', 6)