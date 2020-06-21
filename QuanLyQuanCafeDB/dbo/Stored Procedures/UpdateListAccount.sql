CREATE PROC UpdateListAccount(
@id int ,@tenTaiKhoan nvarchar(100),@tenHienThi nvarchar(100),@pass nvarchar(100) ,@type int
)
as
begin
	UPDATE dbo.Account 
	SET TenTaiKhoan =@tenTaiKhoan, TenHienThi=@tenHienThi, LoaiTaiKhoan=@type, PassWord=@pass
	WHERE IDAccount=@id
end
