CREATE PROC [dbo].[InsertHoaDonChiTiet]
@maHoaDon INT,
@maTAU INT,
@soLuong INT
AS	
BEGIN
	INSERT dbo.HoaDonChiTiet(MaHoaDon,MaTAU,SoLuong)
VALUES (
	@maHoaDon,
	@maTAU,
	@soLuong
)
END
