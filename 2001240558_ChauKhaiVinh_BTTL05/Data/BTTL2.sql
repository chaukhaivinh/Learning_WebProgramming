create database QL_PhongBan
CREATE TABLE PhongBan (
    MaPhong INT PRIMARY KEY,
    TenPhong NVARCHAR(100)
);

-- Thêm dữ liệu
INSERT INTO PhongBan (MaPhong, TenPhong)
VALUES 
    (1, N'Khoa CNTT'),
    (2, N'Khoa Ngoại Ngữ'),
    (3, N'Khoa Tài Chính'),
    (4, N'Khoa Thực Phẩm'),
    (5, N'Phòng Đào Tạo');