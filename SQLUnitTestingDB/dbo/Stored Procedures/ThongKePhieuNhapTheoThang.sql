CREATE PROC [dbo].[ThongKePhieuNhapTheoThang]
@thang int
AS
BEGIN
	SELECT pn.MaPhieuNhap,nv.HoNV,nv.TenNV,ncc.TenNhaCC,pn.NgayNhap,pn.TongTien
	FROM dbo.NhanVien as nv , dbo.NhaCungCap as ncc ,dbo.PhieuNhap as pn
	WHERE TrangThai = 1 AND MONTH(pn.NgayNhap)= @thang AND pn.MaNV = nv.MaNV AND pn.MaNCC = ncc.MaNCC
END
