CREATE proc [dbo].[ThongKeChamCong]
@maCa int,
@thang int
as
begin
	SELECT cc.MaNV,nv.HoNV,nv.TenNV,		
		   COUNT(CASE cc.MaCa WHEN @maCa THEN 1 END) Công
	       
	FROM  
		 dbo.ChamCongNV as cc,
		 dbo.NhanVien as nv
	WHERE 
	GhiChu = 'Có làm' AND MONTH(NgayThang) = @thang AND cc.MaNV = nv.MaNV
	GROUP BY
		   cc.MaNV,
		nv.TenNv,
		nv.HoNV
end
