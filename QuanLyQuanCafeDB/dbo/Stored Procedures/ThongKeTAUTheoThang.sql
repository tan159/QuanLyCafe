CREATE PROC ThongKeTAUTheoThang
@thang int
as
begin
SELECT bi.MaTAU ,TenTAU,SUM(SoLuong)as SoLuong,MONTH(b.ThoiDiemVao) as Thang
FROM dbo.HoaDonChiTiet as bi,dbo.ThucAnUong as f,dbo.HoaDon as b
WHERE bi.MaTAU = f.MaTAU AND bi.MaHoaDon = b.MaHoaDon AND MONTH(b.ThoiDiemVao) = @thang
GROUP BY bi.MaTAU,TenTAU,MONTH(b.ThoiDiemVao)
end
