CREATE PROC DeleteAccount(
@id int
)
as
begin
	DELETE dbo.Account 
	WHERE IDAccount=@id
end