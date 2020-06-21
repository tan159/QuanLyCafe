CREATE PROC UserSearch(
	@Username nvarchar(100)
)
AS
BEGIN 
	SELECT *
	FROM Account
	WHERE TenTaiKhoan = @Username
END
