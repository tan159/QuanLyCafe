CREATE PROC [dbo].[ThongKeBill]
@checkin date,
@checkout date
AS
BEGIN
	SELECT ba.TenBan ,hd.TongTien ,nv.HoNV , nv.TenNV, hd.ThoiDiemVao,hd.ThoiDiemRa
	FROM dbo.BanAn as ba ,dbo.NhanVien as nv ,dbo.HoaDon as hd
	WHERE ThoiDiemVao >= @checkin AND ThoiDiemRa <= @checkout AND hd.TrangThai = 1 AND ba.MaBan = hd.MaBan AND nv.MaNV = hd.MaNV
END
