CREATE PROC [dbo].[InsertBillInfo]
@maHoaDon INT,
@maTAU INT,
@soLuong INT
AS 
BEGIN 
	DECLARE @isExitsBillInfo INT
	DECLARE @soLuongTAU INT = 1
	
	SELECT @isExitsBillInfo = MaHoaDon,@soLuongTAU = SoLuong 
	FROM dbo.HoaDonChiTiet 
	WHERE MaHoaDon = @maHoaDon AND MaTAU = @maTAU
	
	IF(@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newSoLuong INT = @soLuongTau + @soLuong
		IF(@newSoLuong > 0)
			UPDATE dbo.HoaDonChiTiet SET SoLuong = @soLuongTAU + @soLuong WHERE MaTAU = @maTAU
		ELSE
			DELETE dbo.HoaDonChiTiet WHERE MaHoaDon = @maHoaDon AND MaTAU = @maTAU
	END
	ELSE 
	BEGIN
		INSERT DBO.HoaDonChiTiet
		(MaHoaDon,MaTAU,SoLuong)
		VALUES 
		(@maHoaDon,@maTAU,@soLuong)
	END

END
