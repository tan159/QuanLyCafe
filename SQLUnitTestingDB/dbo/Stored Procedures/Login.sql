CREATE PROC [dbo].[Login]
@tenTaiKhoan NVARCHAR(100),
@passWord NVARCHAR(100)
AS
BEGIN
	SELECT * FROM Account WHERE TenTaiKhoan = @tenTaiKhoan AND PassWord = @passWord
END
