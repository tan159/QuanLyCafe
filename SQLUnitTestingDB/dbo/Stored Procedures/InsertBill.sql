CREATE PROC [dbo].[InsertBill]
@MaBan int,
@MaNV int
AS
BEGIN
		INSERT dbo.HoaDon
		(
			ThoiDiemVao,
			ThoiDiemRa,
			MaBan,
			MaNV,
			TrangThai,
			Ghichu
		)
		VALUES 
		(
			GETDATE(),
			NULL,
			@MaBan,
			@MaNV,
			0,
			N'Không'
		)
END
