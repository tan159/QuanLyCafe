CREATE PROC [dbo].[InsertPhieuNhapChiTiet]
@maPhieuNhap INT,
@maNL INT,
@soLuong INT
AS	
BEGIN 
	DECLARE @isExitsBillInfo INT
	DECLARE @soLuongNL INT = 1
	SELECT @isExitsBillInfo = 1,@soLuongNL = SoLuong FROM dbo.PhieuNhapChiTiet WHERE MaPhieuNhap = @maPhieuNhap AND MaNL = @maNL
	
	IF(@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newSoLuong INT = @soLuongNL + @soLuong
		IF(@newSoLuong > 0)
			UPDATE dbo.PhieuNhapChiTiet SET SoLuong = @soLuongNL + @soLuong WHERE MaNL = @maNL
		ELSE
			DELETE dbo.PhieuNhapChiTiet WHERE MaPhieuNhap = @maPhieuNhap AND MaNL = @maNL
	END
	ELSE 
	BEGIN
		INSERT DBO.PhieuNhapChiTiet
		(MaPhieuNhap,MaNL,SoLuong)
		VALUES 
		(@maPhieuNhap,@maNL,@soLuong)
	END

END
