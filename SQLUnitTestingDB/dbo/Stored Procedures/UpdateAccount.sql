CREATE PROC [dbo].[UpdateAccount]
@tenTaiKhoan NVARCHAR(100),
@tenHienThi NVARCHAR(100),
@passWord NVARCHAR(100),
@newPassWord NVARCHAR(100)
AS
BEGIN
	DECLARE @isTrue INT =0
	
	SELECT @isTrue = COUNT(*) FROM dbo.Account WHERE TenTaiKhoan = @tenTaiKhoan AND PassWord = @passWord
	
	IF(@isTrue = 1)
	BEGIN
		IF(@newPassWord = NULL OR @newPassWord = '')
		BEGIN
			UPDATE dbo.Account SET TenHienThi = @tenHienThi WHERE TenTaiKhoan = @tenTaiKhoan
		END
		ELSE
			UPDATE dbo.Account SET TenHienThi = @tenHienThi,PassWord =@newPassWord WHERE TenTaiKhoan = @tenTaiKhoan
	END
END
