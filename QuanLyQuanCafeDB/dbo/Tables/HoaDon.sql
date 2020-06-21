CREATE TABLE [dbo].[HoaDon] (
    [MaHoaDon]    INT            IDENTITY (1, 1) NOT NULL,
    [ThoiDiemVao] DATE           DEFAULT (getdate()) NOT NULL,
    [ThoiDiemRa]  DATE           NULL,
    [MaBan]       INT            NOT NULL,
    [MaNV]        INT            NOT NULL,
    [Ghichu]      NVARCHAR (100) NULL,
    [TrangThai]   INT            DEFAULT ((0)) NOT NULL,
    [GiamGia]     INT            DEFAULT ((0)) NULL,
    [TienDua]     INT            DEFAULT ((0)) NULL,
    [TienThua]    INT            DEFAULT ((0)) NULL,
    [TongTien]    FLOAT (53)     NULL,
    PRIMARY KEY CLUSTERED ([MaHoaDon] ASC),
    FOREIGN KEY ([MaBan]) REFERENCES [dbo].[BanAn] ([MaBan]),
    FOREIGN KEY ([MaBan]) REFERENCES [dbo].[BanAn] ([MaBan]),
    FOREIGN KEY ([MaBan]) REFERENCES [dbo].[BanAn] ([MaBan]),
    FOREIGN KEY ([MaBan]) REFERENCES [dbo].[BanAn] ([MaBan]),
    FOREIGN KEY ([MaBan]) REFERENCES [dbo].[BanAn] ([MaBan]),
    FOREIGN KEY ([MaBan]) REFERENCES [dbo].[BanAn] ([MaBan]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV])
);


GO
CREATE TRIGGER [dbo].[UPDATEBILL]
ON [dbo].[HoaDon] FOR UPDATE
AS
BEGIN
	DECLARE @maHoaDon INT
	SELECT @maHoaDon = MaHoaDon FROM inserted
	
	DECLARE @maBan INT
	SELECT @maBan = MaBan FROM dbo.HoaDon WHERE MaHoaDon = @maHoaDon
	
	DECLARE @soLuong INT
	SELECT @soLuong = COUNT(*) FROM dbo.HoaDon WHERE MaBan = @maBan AND TrangThai = 0
	
	IF(@soLuong = 0 )
		UPDATE dbo.BanAn SET TrangThai = N'Trống' WHERE MaBan = @maBan
END
