CREATE DATABASE QL_NhaSach
GO

USE QL_NhaSach
GO

CREATE TABLE Loai (
    ID INT PRIMARY KEY IDENTITY(1,1),
    DisplayName NVARCHAR(100) NOT NULL
);

CREATE TABLE NhaSanXuat (
    ID INT PRIMARY KEY IDENTITY(1,1),
    DisplayName NVARCHAR(100) NOT NULL
);
CREATE TABLE SanPham (
    ID INT PRIMARY KEY IDENTITY(1,1),
    DisplayName NVARCHAR(150) NOT NULL,
    TypeID INT FOREIGN KEY REFERENCES Loai(ID),
    ManuID INT FOREIGN KEY REFERENCES NhaSanXuat(ID),
    Price FLOAT,
    Note NVARCHAR(MAX),
    Images NVARCHAR(200) -- Tên file hình ảnh
);
CREATE TABLE KhachHang (
    ID INT PRIMARY KEY IDENTITY(1,1),
    DisplayName NVARCHAR(100) NOT NULL,
    Phone VARCHAR(20) UNIQUE NOT NULL,
    Passwword VARCHAR(50) NOT NULL
);
INSERT INTO Loai (DisplayName) 
VALUES 
(N'Sách giáo khoa'),
(N'Tiểu thuyết'),
(N'Truyện tranh'),
(N'Sách kỹ năng sống'),
(N'Văn phòng phẩm');
GO

INSERT INTO NhaSanXuat (DisplayName) 
VALUES 
(N'NXB Giáo Dục'),
(N'NXB Trẻ'),
(N'NXB Kim Đồng'),
(N'Nhã Nam'),
(N'Thiên Long');
GO

INSERT INTO SanPham (DisplayName, TypeID, ManuID, Price, Note, Images) 
VALUES 
(N'Toán Học Lớp 10', 1, 1, 35000, N'Sách giáo khoa chuẩn bộ GD&ĐT', 'Images/toan10.jpg'),
(N'Harry Potter và Hòn đá Phù thủy', 2, 2, 125000, N'Tiểu thuyết giả tưởng kinh điển', 'Images/harrypotter.jpg'),
(N'Thám tử lừng danh Conan Tập 1', 3, 3, 22000, N'Truyện tranh trinh thám', 'Images/conan.jpg'),
(N'Cây Cam Ngọt Của Tôi', 2, 4, 108000, N'Tiểu thuyết bán chạy', 'Images/caycamngot.jpg'),
(N'Đắc Nhân Tâm', 4, 2, 85000, N'Sách kỹ năng bán chạy nhất mọi thời đại', 'Images/dacnhantam.jpg'),
(N'Bút bi TL-027 (Xanh)', 5, 5, 5000, N'Bút bi ngòi 0.5mm, mực xanh', 'Images/butbitl027.jpg');
GO

INSERT INTO KhachHang (DisplayName, Phone, Passwword) 
VALUES 
(N'Nguyễn Văn A', '0901234567', 'NVA@123'),
(N'Trần Thị B', '0987654321', 'TTB@123'),
(N'Lê Hoàng C', '0911222333', 'LHC@123'),
(N'Phạm Quang D', '0933444555', 'PQD@123'),
(N'Vũ Bích E', '0944555666', 'VBE@123');
GO