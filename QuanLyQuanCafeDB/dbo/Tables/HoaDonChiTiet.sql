CREATE TABLE [dbo].[HoaDonChiTiet] (
    [MaHoaDon] INT NOT NULL,
    [MaTAU]    INT NOT NULL,
    [SoLuong]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([MaHoaDon] ASC, [MaTAU] ASC),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon]),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon]),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon]),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon]),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon]),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon]),
    FOREIGN KEY ([MaTAU]) REFERENCES [dbo].[ThucAnUong] ([MaTAU]),
    FOREIGN KEY ([MaTAU]) REFERENCES [dbo].[ThucAnUong] ([MaTAU]),
    FOREIGN KEY ([MaTAU]) REFERENCES [dbo].[ThucAnUong] ([MaTAU]),
    FOREIGN KEY ([MaTAU]) REFERENCES [dbo].[ThucAnUong] ([MaTAU]),
    FOREIGN KEY ([MaTAU]) REFERENCES [dbo].[ThucAnUong] ([MaTAU]),
    FOREIGN KEY ([MaTAU]) REFERENCES [dbo].[ThucAnUong] ([MaTAU])
);


GO
CREATE TRIGGER [dbo].[UPDATEBILLINFO]
ON [dbo].[HoaDonChiTiet] FOR INSERT ,UPDATE
AS
BEGIN
	DECLARE @maHoaDon INT
	SELECT @maHoaDon = MaHoaDon FROM inserted
	
	DECLARE @maBan INT
	SELECT @maBan = maBan FROM dbo.HoaDon WHERE MaHoaDon = @maHoaDon AND TrangThai = 0
	
	UPDATE dbo.BanAn SET TrangThai = N'Có người' WHERE MaBan = @maBan
END

GO
CREATE TRIGGER [dbo].[DeleteBillInfo]
ON [dbo].[HoaDonChiTiet] FOR DELETE
AS
BEGIN 
	DECLARE @maHoaDon INT
	SELECT @maHoaDon = MaHoaDon FROM deleted 
	
	DECLARE @maBan INT
	SELECT @maBan = MaBan FROM dbo.HoaDon WHERE MaHoaDon = @maHoaDon
	
	DECLARE @count INT = 0 
	
	SELECT @count = COUNT(*) FROM dbo.HoaDonChiTiet as bi ,dbo.HoaDon as b 
	WHERE bi.MaHoaDon = b.MaHoaDon AND b.MaHoaDon = @maHoaDon AND b.TrangThai = 0
	
	IF(@count = 0 )
		UPDATE dbo.BanAn SET TrangThai = N'Trống' WHERE MaBan = @maBan
END
