create database rapphim
GO

use rapphim
SET DATEFORMAT DMY
GO

--drop database QLRP

CREATE TABLE NhanVien
(
	id VARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(100),
	SDT VARCHAR(100),
	CMND INT NOT NULL Unique
)
GO

CREATE TABLE ACCOUNT
(
	id varchar(10) primary key,
	idnv varchar(50),
	taikhoan varchar(50),
	matkhau varchar(50),
	chucvu varchar(50),
	FOREIGN KEY (idnv) REFERENCES dbo.NhanVien(id)
)

CREATE TABLE LoaiManHinh
(
	id VARCHAR(50) PRIMARY KEY,
	TenMH NVARCHAR(100) --2D || 3D || IMax
)
GO

CREATE TABLE PhongChieu
(
	id VARCHAR(50) PRIMARY KEY,
	TenPhong NVARCHAR(100) NOT NULL,
	idManHinh VARCHAR(50),
	SoChoNgoi INT NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1, -- 0:không hoạt động || 1:đang hoạt động
	SoHangGhe int not null,
	SoGheMotHang int not null,

	FOREIGN KEY (idManHinh) REFERENCES dbo.LoaiManHinh(id)
)
GO

CREATE TABLE Phim
(
	id varchar(50) PRIMARY KEY,
	TenPhim nvarchar(100) NOT NULL,
	MoTa nvarchar(1000) NULL,
	ThoiLuong float NOT NULL,
	NgayKhoiChieu date NOT NULL,
	NgayKetThuc date NOT NULL,
	SanXuat nvarchar(50) NOT NULL,
	DaoDien nvarchar(100) NULL,
	NamSX int NOT NULL
)
GO

CREATE TABLE DinhDangPhim --Phim có hỗ trợ màn hình 3D hay IMax không?
(
	id varchar(50) NOT NULL primary key,
	idPhim VARCHAR(50) NOT NULL,
	idLoaiManHinh VARCHAR(50) NOT NULL,

	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id),
	FOREIGN KEY (idLoaiManHinh) REFERENCES dbo.LoaiManHinh(id)
)
GO

CREATE TABLE TheLoai
(
	id VARCHAR(50) PRIMARY KEY,
	TenTheLoai NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(100)
)
GO

CREATE TABLE PhanLoaiPhim --Quan hệ giữa Phim và LoaiPhim là quan hệ n-n
(
	idPhim VARCHAR(50) NOT NULL,
	idTheLoai VARCHAR(50) NOT NULL,

	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id),
	FOREIGN KEY (idTheLoai) REFERENCES dbo.TheLoai(id),

	CONSTRAINT PK_PhanLoaiPhim PRIMARY KEY(idPhim,idTheLoai)
)
GO

CREATE TABLE LichChieu
(
	id VARCHAR(50) PRIMARY KEY,  -- ID phải là duy nhất
	ThoiGianChieu DATETIME NOT NULL,
	idPhong VARCHAR(50) NOT NULL,
	idDinhDang VARCHAR(50) NOT NULL,
	GiaVe DECIMAL(18, 2) NOT NULL,  -- Sử dụng DECIMAL thay vì Money
	TrangThai INT NOT NULL DEFAULT 0, -- 0: Chưa tạo vé cho lịch chiếu || 1: Đã tạo vé
	FOREIGN KEY (idPhong) REFERENCES dbo.PhongChieu(id),
	FOREIGN KEY (idDinhDang) REFERENCES dbo.DinhDangPhim(id)
)


CREATE TABLE KhachHang
(
	id VARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(100),
	SDT VARCHAR(100),
	CMND INT NOT NULL Unique,

)
GO

CREATE TABLE DoanhThu
(
    idLichChieu VARCHAR(50) NOT NULL, -- Liên kết với bảng LichChieu
    idPhim VARCHAR(50) NOT NULL,     -- Liên kết với bảng Phim
    Tien FLOAT,
    PRIMARY KEY (idLichChieu, idPhim), -- Khóa chính kết hợp
    FOREIGN KEY (idLichChieu) REFERENCES dbo.LichChieu(id),
    FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id)
)




-- 1. Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (id, HoTen, NgaySinh, DiaChi, SDT, CMND)
VALUES 
('NV001', 'Nguyen Van A', '1990-01-01', '123 Le Loi', '0123456789', 111111111),
('NV002', 'Tran Thi B', '1992-02-02', '456 Nguyen Trai', '0987654321', 222222222),
('NV003', 'Le Van C', '1985-03-03', '789 Hai Ba Trung', '0912345678', 333333333),
('NV004', 'Pham Thi D', '1993-04-04', '101 Vo Thi Sau', '0938765432', 444444444),
('NV005', 'Hoang Van E', '1988-05-05', '202 Cong Quynh', '0945678901', 555555555);

-- 2. Thêm dữ liệu vào bảng ACCOUNT
INSERT INTO ACCOUNT (id, idnv, taikhoan, matkhau, chucvu)
VALUES 
('ACC001', 'NV001', 'nguyenvana', 'pass123', 'quanly'),
('ACC002', 'NV002', 'tranthib', 'pass456', 'banve'),
('ACC003', 'NV003', 'levanc', 'pass789', 'banve'),
('ACC004', 'NV004', 'phamthid', 'pass012', 'quanly');


-- 4. Thêm dữ liệu vào bảng LoaiManHinh
INSERT INTO LoaiManHinh (id, TenMH)
VALUES 
('MH001', '2D'),
('MH002', '3D'),
('MH003', 'IMAX'),
('MH004', '4DX'),
('MH005', 'ScreenX'),
('MH006', 'LED Screen'),
('MH007', 'Premium 3D'),
('MH008', 'Dolby Cinema'),
('MH009', 'Gold Class'),
('MH010', 'Standard');
-- 5. Thêm dữ liệu vào bảng PhongChieu
INSERT INTO PhongChieu (id, TenPhong, idManHinh, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang)
VALUES 
('PC001', 'Phong 1', 'MH001', 165, 1, 10, 10),
('PC002', 'Phong 2', 'MH002', 165, 1, 12, 10),
('PC003', 'Phong 3', 'MH003', 165, 1, 15, 10),
('PC004', 'Phong 4', 'MH004', 165, 0, 20, 10),
('PC005', 'Phong 5', 'MH005', 165, 1, 18, 10),
('PC006', 'Phong 6', 'MH006', 165, 1, 20, 10),
('PC007', 'Phong 7', 'MH007', 165, 1, 10, 10),
('PC008', 'Phong 8', 'MH008', 165, 1, 12, 10),
('PC009', 'Phong 9', 'MH009', 165, 1, 10, 10),
('PC010', 'Phong 10', 'MH010', 165, 1, 12, 10);

-- 6. Thêm dữ liệu vào bảng Phim
INSERT INTO Phim (id, TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, SanXuat, DaoDien, NamSX)
VALUES 
('P001', 'Phim Mat Biec', 'Mot cau chuyen tinh yeu', 120, '2024-01-01', '2024-03-01','Galaxy Studio', 'Victor Vu', 2023),
('P002', 'Phim Hai Phong', 'Hanh trinh kham pha', 130, '2024-01-01','2024-06-01', 'CGV Studio', 'Nguyen Khoa', 2023),
('P003', 'Phim Hanh Dong', 'Nhung cuoc chien day cam xuc', 150, '2024-01-01', '2023-09-01', 'Lotte Cinema', 'Pham Huynh', 2023),
('P004', 'Phim Am Nhac', 'Tinh yeu va am nhac', 140, '2024-01-01', '2023-12-01', 'Beta Studio', 'Tran Thanh', 2023),
('P005', 'Phim Gia Dinh', 'Gia tri gia dinh', 100, '2024-01-01', '2024-03-01', 'CGV Studio', 'Doan Minh', 2024),
('P006', 'Phim Bo Gia', 'Gia tri gia dinh', 128, '2024-03-12', '2024-05-12', 'CGV Studio', 'Tran Thanh', 2024),
('P007', 'Phim Hai Phuong', 'Gia dinh', 98, '2025-03-12', '2025-05-12', 'CGV Studio', 'Le Van Kiet', 2025),
('P008', 'Phim Em La Ba Noi Cua Anh', 'Kham pha lai cuoc doi minh', 127, '2025-05-12', '2025-07-12', 'CGV Studio', 'Phan Gia Nhat Linh', 2025),
('P009', 'Phim Tiec Trang Mau', 'Moi thu thay doi khi ho quyet dinh chia se tat ca tin nhan va cuoc goi dien thoai trong bua tiec.', 120 , '2025-10-02', '2025-12-28', 'Lotte Entertainment', 'Nguyen Quang Dung', 2025),
('P010', 'Phim Song Lang', 'Ke ve moi quan he day cam xuc', 100, '2025-02-05', '2025-03-31', 'CGV Studio', 'Leon Le', 2025),
('P011', 'Phim Cua Lai Vo Bau', 'Tinh cam pha chut hai huoc', 100, '2025-03-12', '2025-05-12', 'CGV Studio', 'Nhat Trung', 2025),
('P012', 'Phim Thang Nam Ruc Ro', 'Ban thoi trung hoc gap lai nhau sau nhieu nam xa cach', 118, '2025-03-09', '2025-06-30', 'CGV Studio', 'Nguyen Quang Dung', 2025),
('P013', 'Phim Lat Mat 5', 'Mot gia dinh roi vao tinh the nguy hiem khi bi truy duoi', 100, '2025-04-16', '2025-06-30', 'CGV Studio', 'Ly Hai', 2025),
('P014', 'Phim Toi Thay Hoa Vang Tren Co Xanh', 'Mot cau chuyen nhe nhang va day hoi niem ve tuoi tho', 102, '2025-10-12', '2025-12-31', 'CGV Studio', 'Victor Vu', 2025),
('P015', 'Phim Ky Niem', 'Chuyen tinh xuyen thoi gian', 115, '2025-06-01', '2025-08-01', 'Galaxy Studio', 'Pham Anh Khoa', 2025),
('P016', 'Phim Bao To', 'Nhung cuoc chien giua nhung nguoi hung', 140, '2025-07-15', '2025-09-15', 'CGV Studio', 'Le Phuong', 2025),
('P017', 'Phim Thien Duong', 'Hanh trinh tim kiem mot kho bau', 130, '2025-09-01', '2025-11-01', 'Beta Studio', 'Tran Ngoc', 2025),
('P018', 'Phim Vong Tron', 'Mot bi mat gia dinh duoc kham pha', 125, '2025-10-10', '2025-12-10', 'Lotte Cinema', 'Vu An', 2025),
('P019', 'Phim Loi Hua', 'Tinh ban va long trung thanh', 100, '2026-01-01', '2026-03-01', 'CGV Studio', 'Nguyen Huy', 2026),
('P020', 'Phim Tinh Ban', 'Hanh trinh cua nhung nguoi tre', 120, '2026-04-01', '2026-06-01', 'Galaxy Studio', 'Dang Quang', 2026);



-- 7. Thêm dữ liệu vào bảng DinhDangPhim
INSERT INTO DinhDangPhim (id, idPhim, idLoaiManHinh)
VALUES 
('DD001', 'P001', 'MH001'),
('DD002', 'P002', 'MH002'),
('DD003', 'P003', 'MH003'),
('DD004', 'P004', 'MH004'),
('DD005', 'P005', 'MH005'),
('DD006', 'P006', 'MH006'),
('DD007', 'P007', 'MH007'),
('DD008', 'P008', 'MH008'),
('DD009', 'P009', 'MH009'),
('DD010', 'P010', 'MH010'),
('DD011', 'P011', 'MH008'),
('DD012', 'P012', 'MH009'),
('DD013', 'P013', 'MH006'),
('DD014', 'P014', 'MH005'),
('DD015', 'P015', 'MH004');



-- 8. Thêm dữ liệu vào bảng TheLoai
INSERT INTO TheLoai (id, TenTheLoai, MoTa)
VALUES 
('TL005', 'Gia Dinh', 'Phim ve gia dinh'),
('TL009', 'Lich Su', 'Phim ve lich su'),
('TL007', 'Vien Tuong', 'Phim ve vien tuong'),
('TL001', 'Tinh Cam', 'Phim ve tinh cam'),
('TL003', 'Hanh Dong', 'Phim ve hanh dong'),
('TL010', 'Phiêu Luu', 'Phim ve phieu luu'),
('TL004', 'Am Nhac', 'Phim ve am nhac'),
('TL002', 'Hai Huoc', 'Phim ve hai huoc'),
('TL006', 'Kinh Di', 'Phim ve kinh di'),
('TL008', 'Tam Ly', 'Phim ve tam ly');

-- 9. Thêm dữ liệu vào bảng PhanLoaiPhim
INSERT INTO PhanLoaiPhim (idPhim, idTheLoai)
VALUES 
('P001', 'TL004'),
('P002', 'TL008'),
('P003', 'TL010'),
('P004', 'TL005'),
('P005', 'TL002'),
('P006', 'TL001'),
('P007', 'TL006'),
('P008', 'TL007'),
('P009', 'TL003'),
('P010', 'TL009'),
('P011', 'TL002'),
('P012', 'TL010'),
('P013', 'TL001'),
('P014', 'TL005'),
('P015', 'TL008'),
('P016', 'TL004'),
('P017', 'TL003');

-- 10. Thêm dữ liệu vào bảng LichChieu
INSERT INTO LichChieu (id, ThoiGianChieu, idPhong, idDinhDang, GiaVe, TrangThai)
VALUES 
('LC001', '15-12-2024 14:00:00', 'PC009', 'DD015', 70000, 1),  -- Phim 15
('LC002', '06-01-2024 20:00:00', 'PC006', 'DD006', 65000, 1),  -- Phim 6
('LC003', '04-01-2024 16:00:00', 'PC004', 'DD004', 75000, 1),  -- Phim 4
('LC004', '20-01-2024 12:00:00', 'PC010', 'DD002', 75000, 1),  -- Phim 20
('LC005', '17-01-2024 18:00:00', 'PC007', 'DD015', 60000, 1),  -- Phim 17
('LC006', '07-01-2024 10:00:00', 'PC007', 'DD007', 70000, 1),  -- Phim 7
('LC007', '13-01-2024 10:00:00', 'PC003', 'DD013', 60000, 1),  -- Phim 13
('LC008', '01-01-2024 10:00:00', 'PC001', 'DD001', 60000, 1),  -- Phim 1
('LC009', '16-01-2024 16:00:00', 'PC006', 'DD015', 75000, 1),  -- Phim 16
('LC010', '05-01-2024 18:00:00', 'PC005', 'DD005', 60000, 1),  -- Phim 5
('LC011', '02-01-2024 12:00:00', 'PC002', 'DD002', 65000, 1),  -- Phim 2
('LC012', '03-01-2024 14:00:00', 'PC003', 'DD003', 70000, 1),  -- Phim 3
('LC013', '01-01-2024 18:00:00', 'PC001', 'DD011', 70000, 1),  -- Phim 11
('LC014', '14-01-2024 12:00:00', 'PC004', 'DD014', 65000, 1),  -- Phim 14
('LC015', '08-01-2024 12:00:00', 'PC008', 'DD008', 75000, 1),  -- Phim 8
('LC016', '18-01-2024 20:00:00', 'PC008', 'DD012', 65000, 1),  -- Phim 18
('LC017', '12-01-2024 20:00:00', 'PC002', 'DD012', 75000, 1),  -- Phim 12
('LC018', '19-01-2024 10:00:00', 'PC009', 'DD005', 70000, 1),  -- Phim 19
('LC019', '09-01-2024 14:00:00', 'PC009', 'DD009', 60000, 1),  -- Phim 9
('LC020', '04-01-2024 20:00:00', 'PC005', 'DD015', 65000, 1),  -- Phim 16
('LC021', '12-03-2025 14:00:00', 'PC005', 'DD012', 60000, 1),  -- Phim Hai Phuong
('LC022', '10-03-2025 16:00:00', 'PC006', 'DD009', 65000, 1),  -- Phim Hai Phuong
('LC023', '15-03-2025 18:00:00', 'PC007', 'DD010', 70000, 1),  -- Phim Hai Phuong
('LC024', '20-03-2025 20:00:00', 'PC008', 'DD001', 75000, 1),  -- Phim Hai Phuong
('LC025', '01-05-2025 15:00:00', 'PC009', 'DD013', 60000, 1),  -- Phim Em La Ba Noi Cua Anh
('LC026', '03-05-2025 17:00:00', 'PC010', 'DD014', 65000, 1),  -- Phim Em La Ba Noi Cua Anh
('LC027', '10-01-2024 19:00:00', 'PC001', 'DD003', 70000, 1),  -- Phim Em La Ba Noi Cua Anh
('LC028', '15-05-2025 21:00:00', 'PC002', 'DD014', 75000, 1),  -- Phim Em La Ba Noi Cua Anh
('LC029', '01-10-2025 14:00:00', 'PC003', 'DD007', 60000, 1),  -- Phim Tiec Trang Mau
('LC030', '05-10-2025 16:00:00', 'PC004', 'DD011', 65000, 1),  -- Phim Tiec Trang Mau
('LC031', '10-10-2025 18:00:00', 'PC005', 'DD009', 70000, 1),  -- Phim Tiec Trang Mau
('LC032', '15-10-2025 20:00:00', 'PC006', 'DD001', 75000, 1),  -- Phim Tiec Trang Mau
('LC033', '01-01-2026 14:00:00', 'PC007', 'DD005', 60000, 1),  -- Phim Loi Hua
('LC034', '05-01-2026 16:00:00', 'PC008', 'DD008', 65000, 1),  -- Phim Loi Hua
('LC035', '10-01-2026 18:00:00', 'PC009', 'DD013', 70000, 1),  -- Phim Loi Hua
('LC036', '15-01-2026 20:00:00', 'PC010', 'DD007', 75000, 1),  -- Phim Loi Hua
('LC037', '12-01-2024 15:00:00', 'PC001', 'DD001', 60000, 1),  -- Phim Tinh Ban
('LC038', '05-04-2026 17:00:00', 'PC002', 'DD004', 65000, 1),  -- Phim Tinh Ban
('LC039', '10-04-2026 19:00:00', 'PC003', 'DD014', 70000, 1),  -- Phim Tinh Ban
('LC040', '15-04-2026 21:00:00', 'PC004', 'DD015', 75000, 1);  -- Phim Tinh Ban


-- 11. Thêm dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (id, HoTen, NgaySinh, DiaChi, SDT, CMND)
VALUES 
('KH001', 'Le Hoang Anh', '1990-05-01', '123 Tan Binh', '0901234567', 123456789),
('KH002', 'Nguyen Thi Lan', '1995-06-01', '456 Go Vap', '0912345678', 223344556),
('KH003', 'Pham Van Minh', '1985-07-01', '789 Binh Thanh', '0923456789', 334455667),
('KH004', 'Tran Van Binh', '1988-08-01', '101 Tan Phu', '0934567890', 445566778),
('KH005', 'Ho Thi Thanh', '1993-09-01', '202 Phu Nhuan', '0945678901', 556677889);

--trigger
CREATE TRIGGER trg_EnsureSingleAccount
ON ACCOUNT
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem có nhân viên nào có nhiều hơn 1 tài khoản không
    IF EXISTS (
        SELECT idnv
        FROM ACCOUNT
        GROUP BY idnv
        HAVING COUNT(idnv) > 1
    )
    BEGIN
        -- Nếu có, rollback và thông báo lỗi
        RAISERROR ('Mỗi nhân viên chỉ được phép có một tài khoản.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO


ALTER TABLE DoanhThu WITH CHECK CHECK CONSTRAINT ALL;

ALTER TABLE DoanhThu
ADD NgayChieu DATE; -- Thêm cột Ngày Chiếu

UPDATE DoanhThu
SET NgayChieu = (
    SELECT ThoiGianChieu
    FROM LichChieu
    WHERE LichChieu.id = DoanhThu.idLichChieu
);
