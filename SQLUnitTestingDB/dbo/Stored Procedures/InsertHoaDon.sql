CREATE PROC [dbo].[InsertHoaDon]
@maBan INT,
@maNV INT
AS
BEGIN
	INSERT  dbo.HoaDon(ThoiDiemVao ,
	ThoiDiemRa ,
	MaBan ,
	MaNV ,
	Ghichu ,
	TrangThai )
	VALUES(GETDATE(),NULL,@maBan,@maNV,Null,0)
	
END
