CREATE PROC [dbo].[LayAccount]
@tenTaiKhoan NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE TenTaiKhoan = @tenTaiKhoan
END
