-- Tạo cơ sở dữ liệu
CREATE DATABASE QL_BanSach;
GO

USE QL_BanSach;
GO

-- 1. Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DienThoai VARCHAR(20),
    TaiKhoan VARCHAR(50) UNIQUE,
    MatKhau VARCHAR(50),
    Email VARCHAR(100),
    DiaChi NVARCHAR(200)
);
GO

-- 2. Bảng Chủ Đề sách
CREATE TABLE ChuDe (
    MaChuDe INT PRIMARY KEY,
    TenChuDe NVARCHAR(100) NOT NULL
);
GO

-- 3. Bảng Nhà Xuất Bản
CREATE TABLE NhaXuatBan (
    MaNXB INT PRIMARY KEY,
    TenNXB NVARCHAR(150) NOT NULL,
    DiaChi NVARCHAR(200),
    DienThoai VARCHAR(20)
);
GO

-- 4. Bảng Tác Giả
CREATE TABLE TacGia (
    MaTacGia INT PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    TieuSu NVARCHAR(MAX),
    DienThoai VARCHAR(20)
);
GO

-- 5. Bảng Sách
CREATE TABLE Sach (
    MaSach INT PRIMARY KEY,
    TenSach NVARCHAR(200) NOT NULL,
    GiaBan DECIMAL(18,2),
    MoTa NVARCHAR(MAX),
    NgayCapNhat DATETIME,
    AnhBia VARCHAR(100),
    SoLuongTon INT,
    MaChuDe INT,
    MaNXB INT,
    Moi INT, -- 1: Sách mới, 0: Sách cũ
    CONSTRAINT FK_Sach_ChuDe FOREIGN KEY (MaChuDe) REFERENCES ChuDe(MaChuDe),
    CONSTRAINT FK_Sach_NXB FOREIGN KEY (MaNXB) REFERENCES NhaXuatBan(MaNXB)
);
GO

-- 6. Bảng Tham Gia (Quan hệ giữa Sách và Tác Giả)
CREATE TABLE ThamGia (
    MaSach INT,
    MaTacGia INT,
    VaiTro NVARCHAR(50),
    ViTri NVARCHAR(50),
    PRIMARY KEY (MaSach, MaTacGia),
    CONSTRAINT FK_ThamGia_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
    CONSTRAINT FK_ThamGia_TacGia FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia)
);
GO

-- 7. Bảng Đơn Hàng
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY,
    NgayGiao DATETIME,
    NgayDat DATETIME,
    DaThanhToan BIT, -- 0: Chưa thanh toán, 1: Đã thanh toán
    TinhTrangGiaoHang INT, -- 0: Đang chuẩn bị, 1: Đang giao, 2: Đã giao
    MaKH INT,
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
GO

-- 8. Bảng Chi Tiết Đơn Hàng
CREATE TABLE ChiTietDonHang (
    MaDonHang INT,
    MaSach INT,
    SoLuong INT,
    DonGia DECIMAL(18,2),
    PRIMARY KEY (MaDonHang, MaSach),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    CONSTRAINT FK_CTDH_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);
GO

-- ==========================================
-- THÊM DỮ LIỆU MẪU
-- ==========================================

-- 1. Thêm Khách Hàng (Đủ từ 1 đến 7 để khớp với Đơn Hàng)
INSERT INTO KhachHang (MaKH, HoTen, NgaySinh, GioiTinh, DienThoai, TaiKhoan, MatKhau, Email, DiaChi) VALUES
(1, N'Nguyễn Văn An', '1998-05-12', N'Nam', '0901234567', 'annguyen', '123456', 'an.nv@gmail.com', N'TP.HCM'),
(2, N'Trần Thị Mai', '2000-09-20', N'Nữ', '0912345678', 'maitran', '123456', 'mai.tt@gmail.com', N'Đà Nẵng'),
(3, N'Lê Văn Bình', '1995-10-05', N'Nam', '0922334455', 'binhle', '123456', 'binh.lv@gmail.com', N'Hà Nội'),
(4, N'Phạm Thị Thu', '2001-03-15', N'Nữ', '0933445566', 'thupham', '123456', 'thu.pt@gmail.com', N'Đà Nẵng'),
(5, N'Hoàng Minh Tuấn', '1997-12-12', N'Nam', '0944556677', 'tuanhoang', '123456', 'tuan.hm@gmail.com', N'TP.HCM'),
(6, N'Vũ Thị Lan', '1999-07-25', N'Nữ', '0955667788', 'lanvu', '123456', 'lan.vt@gmail.com', N'Cần Thơ'),
(7, N'Đỗ Hoàng Long', '2002-01-30', N'Nam', '0966778899', 'longdo', '123456', 'long.dh@gmail.com', N'Hải Phòng');
GO

-- 2. Thêm Chủ Đề
INSERT INTO ChuDe (MaChuDe, TenChuDe) VALUES
(1, N'Công nghệ thông tin'),
(2, N'Kinh tế - Tài chính'),
(3, N'Văn học nghệ thuật'),
(4, N'Truyện Giả Tưởng');
GO

-- 3. Thêm Nhà Xuất Bản
INSERT INTO NhaXuatBan (MaNXB, TenNXB, DiaChi, DienThoai) VALUES
(1, N'NXB Trẻ', N'161B Lý Chính Thắng, Q.3, TP.HCM', '02839316289'),
(2, N'NXB Kim Đồng', N'55 Quang Trung, Hà Nội', '0439434730');
GO

-- 4. Thêm Tác Giả (Bổ sung J.K. Rowling cho Harry Potter)
INSERT INTO TacGia (MaTacGia, TenTacGia, DiaChi, TieuSu, DienThoai) VALUES
(1, N'Nguyễn Nhật Ánh', N'TP.HCM', N'Nhà văn nổi tiếng viết cho thanh thiếu niên.', '0900000001'),
(2, N'Robert C. Martin', N'USA', N'Tác giả của cuốn sách Clean Code nổi tiếng.', '0900000002'),
(3, N'J.K. Rowling', N'Anh Quốc', N'Tác giả nổi tiếng toàn cầu với bộ truyện Harry Potter.', '0988888881');
GO

-- 5. Thêm Sách (Harry Potter 1-8 và các sách chuyên ngành)
INSERT INTO Sach (MaSach, TenSach, GiaBan, MoTa, NgayCapNhat, AnhBia, SoLuongTon, MaChuDe, MaNXB, Moi) VALUES
(1, N'Harry Potter và Hòn đá Phù thủy (Phần 1)', 150000, N'Phần 1 của bộ truyện Harry Potter.', '2026-01-01', 'hp1.jpg', 100, 4, 1, 1),
(2, N'Harry Potter và Phòng chứa Biệt mật (Phần 2)', 160000, N'Phần 2 của bộ truyện Harry Potter.', '2026-01-01', 'hp2.jpg', 90, 4, 1, 1),
(3, N'Harry Potter và Tên tù nhân ngục Azkaban (Phần 3)', 180000, N'Phần 3 của bộ truyện Harry Potter.', '2026-01-01', 'hp3.jpg', 85, 4, 1, 1),
(4, N'Harry Potter và Chiếc cốc Lửa (Phần 4)', 220000, N'Phần 4 của bộ truyện Harry Potter.', '2026-01-01', 'hp4.jpg', 75, 4, 1, 1),
(5, N'Harry Potter và Hội Phượng hoàng (Phần 5)', 250000, N'Phần 5 của bộ truyện Harry Potter.', '2026-01-01', 'hp5.jpg', 60, 4, 1, 1),
(6, N'Harry Potter và Hoàng tử Lai (Phần 6)', 240000, N'Phần 6 của bộ truyện Harry Potter.', '2026-01-01', 'hp6.jpg', 70, 4, 1, 1),
(7, N'Harry Potter và Bảo bối Tử thần (Phần 7)', 260000, N'Phần 7 của bộ truyện Harry Potter.', '2026-01-01', 'hp7.jpg', 50, 4, 1, 1),
(8, N'Harry Potter và Đứa trẻ bị nguyền rủa (Phần 8)', 200000, N'Phần kịch bản phần 8 của Harry Potter.', '2026-01-01', 'hp8.jpg', 80, 4, 1, 1),
(9, N'Lập trình Python cơ bản và nâng cao', 180000, N'Sách hướng dẫn lập trình Python từ mất gốc đến nâng cao.', '2026-03-25', 'python.jpg', 50, 1, 1, 1),
(10, N'Thiết kế Web với HTML5 và CSS3', 150000, N'Tài liệu tự học thiết kế giao diện web hiện đại.', '2026-03-25', 'htmlcss.jpg', 40, 1, 1, 1),
(11, N'Cấu trúc dữ liệu và giải thuật', 210000, N'Sách chuyên ngành cho sinh viên công nghệ thông tin.', '2026-03-25', 'dsa.jpg', 35, 1, 1, 0),
(12, N'Nhập môn Trí tuệ nhân tạo', 250000, N'Khái niệm cơ bản về AI và Machine Learning.', '2026-03-25', 'ai.jpg', 30, 1, 1, 1),
(13, N'Cơ sở dữ liệu và SQL Server', 190000, N'Hướng dẫn quản trị và thiết kế cơ sở dữ liệu.', '2026-03-25', 'sql.jpg', 45, 1, 1, 0),
(14, N'Kinh tế học vĩ mô', 170000, N'Giáo trình kinh tế học vĩ mô chuẩn đại học.', '2026-03-25', 'vimo.jpg', 60, 2, 1, 0),
(15, N'Nguyên lý kế toán', 160000, N'Hệ thống kiến thức nền tảng về kế toán doanh nghiệp.', '2026-03-25', 'ketoan.jpg', 55, 2, 1, 0),
(16, N'Đầu tư chứng khoán thông minh', 230000, N'Phương pháp đầu tư tài chính an toàn và hiệu quả.', '2026-03-25', 'chungkhoan.jpg', 40, 2, 1, 1),
(17, N'Quản trị học hiện đại', 195000, N'Kỹ năng quản trị và điều hành tổ chức.', '2026-03-25', 'quantri.jpg', 45, 2, 1, 1),
(18, N'Tài chính doanh nghiệp căn bản', 210000, N'Phân tích dòng tiền và quản lý tài chính công ty.', '2026-03-25', 'taichinh.jpg', 35, 2, 1, 0),
(19, N'Cho tôi xin một vé đi tuổi thơ', 120000, N'Tác phẩm nổi tiếng của nhà văn Nguyễn Nhật Ánh.', '2026-03-25', 'tuoitho.jpg', 80, 3, 1, 1),
(20, N'Nhà giả kim', 135000, N'Cuốn tiểu thuyết truyền cảm hứng vĩ đại thế kỷ XX.', '2026-03-25', 'nhagiakim.jpg', 100, 3, 2, 1),
(21, N'Số đỏ', 95000, N'Tiểu thuyết châm biếm xuất sắc của nhà văn Vũ Trọng Phụng.', '2026-03-25', 'sodo.jpg', 65, 3, 2, 0),
(22, N'Dế Mèn phiêu lưu ký', 85000, N'Tác phẩm văn học thiếu nhi kinh điển của Tô Hoài.', '2026-03-25', 'demen.jpg', 90, 3, 2, 0),
(23, N'Nhật ký trong tù', 90000, N'Tập thơ chữ Hán của Chủ tịch Hồ Chí Minh.', '2026-03-25', 'nhatkytrongtu.jpg', 70, 3, 2, 0);
GO

-- 6. Thêm Liên Kết Tác Giả - Sách (Bảng ThamGia)
-- Gán 8 phần Harry Potter cho tác giả J.K. Rowling (MaTacGia = 3)
INSERT INTO ThamGia (MaSach, MaTacGia, VaiTro, ViTri) VALUES
(1, 3, N'Tác giả', N'Chính'),
(2, 3, N'Tác giả', N'Chính'),
(3, 3, N'Tác giả', N'Chính'),
(4, 3, N'Tác giả', N'Chính'),
(5, 3, N'Tác giả', N'Chính'),
(6, 3, N'Tác giả', N'Chính'),
(7, 3, N'Tác giả', N'Chính'),
(8, 3, N'Tác giả', N'Chính'),
(19, 1, N'Tác giả', N'Chính'); -- Sách của Nguyễn Nhật Ánh
GO

-- 7. Thêm Đơn Hàng
INSERT INTO DonHang (MaDonHang, NgayGiao, NgayDat, DaThanhToan, TinhTrangGiaoHang, MaKH) VALUES
(1, '2026-03-10', '2026-03-05', 1, 2, 1),
(2, NULL, '2026-03-20', 0, 0, 2);
GO

-- 8. Thêm Chi Tiết Đơn Hàng
INSERT INTO ChiTietDonHang (MaDonHang, MaSach, SoLuong, DonGia) VALUES
(1, 1, 1, 150000),
(2, 2, 2, 160000);
GO