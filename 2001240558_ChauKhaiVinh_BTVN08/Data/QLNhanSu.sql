-- Tạo cơ sở dữ liệu
CREATE DATABASE QL_NhanSu;
GO

USE QL_NhanSu;
GO

CREATE TABLE Deparment (
    ID INT PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Employee (
    ID INT PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10),
    City NVARCHAR(100),
    DeptID INT,
    CONSTRAINT FK_Employee_Department FOREIGN KEY (DeptID) REFERENCES Deparment(ID)
);
GO

INSERT INTO Deparment (ID, DisplayName) VALUES 
(1, N'Khoa CNTT'),
(2, N'Khoa Ngoại Ngữ'),
(3, N'Khoa Tài Chính'),
(4, N'Khoa Thực Phẩm'),
(5, N'Phòng Đào Tạo');
GO

INSERT INTO Employee (ID, DisplayName, Gender, City, DeptID) VALUES 
(1, N'Nguyễn Hải Yến', N'Nữ', N'Đà Lạt', 1),
(2, N'Trương Mạnh', N'Nam', N'TP.HCM', 1),
(3, N'Đinh Duy Minh', N'Nam', N'Thái Bình', 2),
(4, N'Ngô Thị Ngọc', N'Nữ', N'Long An', 2),
(5, N'Đào Minh Châu', N'Nữ', N'Bạc Liêu', 3),
(14, N'Phan Thị Ngân', N'Nữ', N'Bến Tre', 3),
(15, N'Trương Ngự', N'Nữ', N'TP.HCM', 4),
(16, N'Lê Thanh Liêm', N'Nam', N'TP.HCM', 4),
(17, N'bbb', N'Nữ', N'TP.HCM', 5);
GO