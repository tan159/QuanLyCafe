CREATE proc [dbo].[insertTable](
	@tenBan nvarchar(100),
	@khuVuc nvarchar(100),
	@mieuTa nvarchar(100)		
)
as
begin
	IF NOT EXISTS(SELECT TenBan,KhuVuc 
				FROM dbo.BanAn 
				WHERE TenBan = @tenBan AND KhuVuc = @khuVuc)
	BEGIN
		INSERT INTO dbo.BanAn(TenBan,KhuVuc,MieuTa)
		VALUES(@tenBan,@khuVuc,@mieuTa)	
	END
end
