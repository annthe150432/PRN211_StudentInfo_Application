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

insert into ApplicationType([Name]) values (N'?????? nghi?? mi????n ??i????m danh')
insert into ApplicationType([Name]) values (N'?????? nghi?? c????p ba??ng ??i????m qua?? tri??nh')
insert into ApplicationType([Name]) values (N'?????? nghi?? chuy????n ??????i ti??n chi??')
insert into ApplicationType([Name]) values (N'?????? nghi?? chuy????n ??????i t???? ho??c Vo?? sang ho??c C????')

insert into Student(Fullname, Gender, Email, MemberCode) values(N'Nguy????n Thu An', 0, N'AnNTHE150432@fpt.edu.vn', N'AnNTHE150432')
insert into Student(Fullname, Gender, Email, MemberCode) values(N'Nguy????n Minh Ha??nh', 0, N'HanhNMHE150431@fpt.edu.vn', N'HanhNMHE150431')
insert into Staff(Fullname, Phonenumber, Email) values (N'Nguy????n V??n A', '01010010010', N'ANVST0000001@fpt.edu.vn')
insert into Staff(Fullname, Phonenumber, Email) values (N'Nguy????n V??n B', '01010013010', N'BNVST0000001@fpt.edu.vn')
insert into Staff(Fullname, Phonenumber, Email) values (N'Nguy????n V??n C', '01012313010', N'CNVST0000001@fpt.edu.vn')
insert into [Login](RollNumber, [Role], Staff, [Password]) values ('ST0000001', 4, 1, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Staff, [Password]) values ('ST0000002', 3, 2, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Staff, [Password]) values ('ST0000003', 1, 3, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Student, [Password]) values ('HE150432', 0, 1, N'kVU41twDyttUL/SM7IO0vQ==')
insert into [Login](RollNumber, [Role], Student, [Password]) values ('HE150431', 0, 2, N'kVU41twDyttUL/SM7IO0vQ==')

insert into [Folk]([Name]) values (N'Kinh')
insert into [Folk]([Name]) values (N'Ta??y')

insert into [Religion]([Name]) values (N'Kh??ng')
insert into [Religion]([Name]) values (N'Ph????t Gia??o')
insert into [Religion]([Name]) values (N'C??ng Gia??o')

insert into [Province](Name) values (N'Ha?? N????i')
insert into [Province](Name) values (N'H???? Chi?? Minh')
insert into [Province](Name) values (N'??a?? N????ng')

insert into [City] (Name, [Province]) values (N'Qu????n Thanh Xu??n', 1)
insert into [City] (Name, [Province]) values (N'Qu????n Hai Ba?? Tr??ng', 1)
insert into [City] (Name, [Province]) values (N'Qu????n 1', 2)
insert into [City] (Name, [Province]) values (N'Qu????n 2', 2)
insert into [City] (Name, [Province]) values (N'Qu????n C????m L????', 3)
insert into [City] (Name, [Province]) values (N'Qu????n Ha??i Ch??u', 3)

insert into [District] (Name, [City]) values (N'Ph??????ng Ha?? ??i??nh', 1)
insert into [District] (Name, [City]) values (N'Ph??????ng Kh????ng Mai', 1)
insert into [District] (Name, [City]) values (N'Ph??????ng Nh??n Chi??nh', 1)
insert into [District] (Name, [City]) values (N'Ph??????ng Quy??nh L??i', 2)
insert into [District] (Name, [City]) values (N'Ph??????ng Ba??ch Khoa', 2)
insert into [District] (Name, [City]) values (N'Ph??????ng Thanh Nha??n', 2)
insert into [District] (Name, [City]) values (N'Ph??????ng B????n Nghe??', 3)
insert into [District] (Name, [City]) values (N'Ph??????ng B????n Tha??nh', 3)
insert into [District] (Name, [City]) values (N'Ph??????ng C?? Giang', 3)
insert into [District] (Name, [City]) values (N'Ph??????ng An Phu??', 4)
insert into [District] (Name, [City]) values (N'Ph??????ng Tha??o ??i????n', 4)
insert into [District] (Name, [City]) values (N'Ph??????ng An Kha??nh', 4)
insert into [District] (Name, [City]) values (N'Ph??????ng Ho??a An', 5)
insert into [District] (Name, [City]) values (N'Ph??????ng Ho??a Pha??t', 5)
insert into [District] (Name, [City]) values (N'Ph??????ng Ho??a Tho?? ????ng', 5)
insert into [District] (Name, [City]) values (N'Ph??????ng Ha??i Ch??u I', 6)
insert into [District] (Name, [City]) values (N'Ph??????ng Ho??a Thu????n ????ng', 6)
insert into [District] (Name, [City]) values (N'Ph??????ng Bi??nh Hi??n', 6)