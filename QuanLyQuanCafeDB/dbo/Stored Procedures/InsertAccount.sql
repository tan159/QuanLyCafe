CREATE PROC InsertAccount(
	@tenTaiKhoan nvarchar(100), 
	@tenHienThi nvarchar(100), 
	@type int
)
as
begin
	INSERT dbo.Account(TenTaiKhoan,TenHienThi,LoaiTaiKhoan) 
	VALUES (@tenTaiKhoan,@tenHienThi,@type)
end