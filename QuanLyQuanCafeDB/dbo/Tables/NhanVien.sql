CREATE TABLE [dbo].[NhanVien] (
    [MaNV]     INT            IDENTITY (1, 1) NOT NULL,
    [HoNV]     NVARCHAR (20)  NOT NULL,
    [TenNV]    NVARCHAR (20)  NOT NULL,
    [NgaySinh] DATETIME       NOT NULL,
    [GioiTinh] NVARCHAR (10)  NULL,
    [DiaChi]   NVARCHAR (100) NOT NULL,
    [SDT]      NVARCHAR (11)  NULL,
    [Email]    NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC)
);

