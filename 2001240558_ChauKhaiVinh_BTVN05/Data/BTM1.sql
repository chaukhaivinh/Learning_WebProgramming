create database QL_NhanVien
create table Deparment
(
	ID char(10) not null,
	DisplayName nvarchar(20),
	constraint PK_Deparment primary key(ID),
)
create table Emloyee
(
	ID char(10) not null,
	DisplayName nvarchar(20),
	Gender nvarchar(5),
	City nvarchar(50),
	DepID char(10),
	constraint PK_Employee primary key(ID),
	constraint FK_Emloyee_Deparment foreign key (DepID) references Deparment(ID)
)
INSERT INTO Deparment (ID, DisplayName) VALUES
('1', N'Khoa CNTT'),
('2', N'Khoa Ngoại Ngữ'),
('3', N'Khoa Tài Chính'),
('4', N'Khoa Thực Phẩm'),
('5', N'Phòng Đào Tạo');

-- Thêm dữ liệu vào bảng Emloyee
INSERT INTO Emloyee (ID, DisplayName, Gender, City, DepID) VALUES
('1', N'Nguyễn Hải...', N'Nữ', N'Đà Lạt', '1'),
('2', N'Trương Mạn...', N'Nam', N'TP.HCM', '1'),
('3', N'Đinh Duy M...', N'Nam', N'Thái Bình', '2'),
('4', N'Ngô Thị Ng...', N'Nữ', N'Long An', '2'),
('5', N'Đào Minh C...', N'Nữ', N'Bạc Liêu', '3'),
('14', N'Phan Thị Ng...', N'Nữ', N'Bến Tre', '3'),
('15', N'Trương Ngu...', N'Nữ', N'TP.HCM', '4'),
('16', N'Lê Thanh Li...', N'Nam', N'TP.HCM', '4'),
('17', N'bbb', N'Nữ', N'TP.HCM', '5');