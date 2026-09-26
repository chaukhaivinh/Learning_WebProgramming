CREATE DATABASE QL_DTDD1
GO

USE QL_DTDD1
GO

-- 2. Tạo bảng Loai (Danh mục sản phẩm)
CREATE TABLE Loai (
    ID INT PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL
);

-- 3. Tạo bảng SanPham
CREATE TABLE SanPham (
    ID INT PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL,
    Link NVARCHAR(200), -- Tên file hình ảnh (vd: Nokia.jpg)
    Price FLOAT,
    Describe NVARCHAR(MAX),
    TypeID INT FOREIGN KEY REFERENCES Loai(ID)
);

-- 4. Thêm dữ liệu mẫu cho bảng Loai
INSERT INTO Loai (ID, DisplayName) VALUES 
(1, N'Nokia'),
(2, N'Samsung'),
(3, N'Motorola'),
(4, N'LG'),
(5, N'Iphone');

-- 5. Thêm dữ liệu mẫu cho bảng SanPham
INSERT INTO SanPham (ID, DisplayName, Link, Price, Describe, TypeID) VALUES 
(1, N'Nokia N70', N'Images/N70.jpg', 2000000, N'Thẻ nhớ 1GB, camera 2MP', 1),
(2, N'Nokia N72', N'Images/N72.jpg', 2100000, N'Hỗ trợ nhạc MP3, FM', 1),
(3, N'Samsung Galaxy A6', N'Images/GalaxyA6.jpg', 5200000, N'Màn hình Super AMOLED', 2),
(4, N'Samsung Galaxy J5', N'Images/GalaxyJ5.jpg', 6000000, N'Camera chụp đêm tốt', 2),
(5, N'Iphone 6S', N'Images/Iphone6s.jpg', 4500000, N'Dung lượng 64GB, màu Vàng', 5),
(6, N'Iphone 7', N'Images/Iphone7.jpg', 6500000, N'Chống nước IP67', 5);