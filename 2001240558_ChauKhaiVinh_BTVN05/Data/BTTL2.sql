create database QL_PhongBan
CREATE TABLE PhongBan (
    ID INT PRIMARY KEY,
    DisplayName NVARCHAR(100),
);
CREATE TABLE NhanVien (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10),
    City NVARCHAR(100),
    DeptId INT FOREIGN KEY REFERENCES PhongBan(ID)
);
-- Thêm dữ liệu
INSERT INTO PhongBan (ID, DisplayName)
VALUES 
    (1, N'Khoa CNTT'),
    (2, N'Khoa Ngoại Ngữ'),
    (3, N'Khoa Tài Chính'),
    (4, N'Khoa Thực Phẩm'),
    (5, N'Phòng Đào Tạo');
INSERT INTO NhanVien (Id, Name, Gender, City, DeptId)
VALUES 
    (1, N'Nguyễn Văn An', N'Nam', N'TP.HCM', 1),
    (2, N'Trần Thị Bình', N'Nữ', N'Hà Nội', 1),
    (3, N'Lê Văn Cường', N'Nam', N'Đà Nẵng', 2),
    (4, N'Phạm Thị Dung', N'Nữ', N'Cần Thơ', 2),
    (5, N'Hoàng Văn Em', N'Nam', N'TP.HCM', 2),
    (6, N'Vũ Thị Giang', N'Nữ', N'Hải Phòng', 3),
    (7, N'Đặng Văn Hùng', N'Nam', N'Cần Thơ', 4),
    (8, N'Châu Khải Vinh', N'Nam', N'TP.HCM', 5),
    (9, N'Dương Gia Linh', N'Nữ', N'Vĩnh Long', 5),
    (10, N'Trần Hà Linh', N'Nữ', N'Cà Mau', 4);
