CREATE PROC [dbo].[XemChamCong]
@date date
as
begin
select cc.MaNV ,nv.HoNV,nv.TenNV ,cc.NgayThang,cc.MaCa ,cc.GhiChu
FROM dbo.ChamCongNV as cc ,dbo.NhanVien as nv
WHERE NgayThang =@date AND cc.MaNV = nv.MaNV
end
