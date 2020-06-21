CREATE PROC [dbo].[InsertPhieuNhap]
@MaNCC int,
@MaNV int
AS
BEGIN
		INSERT dbo.PhieuNhap
		(
			NgayNhap,	
			MaNV,
			MoTa,
			MaNCC,
			TrangThai
		)
		VALUES 
		(
			GETDATE(),		
			@MaNV,
			N'Không',
			@MaNCC,
			0
		)
END
