CREATE PROC ThongKeDoanhThuTheoThang
as
begin
SELECT MONTH(ThoiDiemVao),SUM(TongTien) 
FROM dbo.HoaDon 
WHERE TrangThai = 1
GROUP BY MONTH(ThoiDiemVao)
ORDER BY MONTH(ThoiDiemVao)
end
