CREATE TABLE [dbo].[HopDong] (
    [MaHopDong]   INT        IDENTITY (1, 1) NOT NULL,
    [MaNV]        INT        NULL,
    [NgayVaoLam]  DATE       NULL,
    [NgayKetThuc] DATE       NULL,
    [MaChucVu]    INT        NULL,
    [Luong]       FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([MaHopDong] ASC),
    FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu]),
    FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu]),
    FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu]),
    FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu]),
    FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu]),
    FOREIGN KEY ([MaChucVu]) REFERENCES [dbo].[ChucVu] ([MaChucVu]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV])
);

