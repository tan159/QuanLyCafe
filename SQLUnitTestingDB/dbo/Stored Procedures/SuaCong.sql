﻿CREATE proc SuaCong
@date date,
@maca int
as
begin
select cc.MaNV, nv.HoNV,nv.TenNV
from dbo.ChamCongNV as cc,dbo.NhanVien as nv
WHERE cc.MaNV = nv.MaNV AND cc.NgayThang = @date AND GhiChu =N'Có làm' AND cc.MaCa = @maca
end
