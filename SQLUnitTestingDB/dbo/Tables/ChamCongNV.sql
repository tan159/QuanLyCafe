CREATE TABLE [dbo].[ChamCongNV] (
    [MaNV]      INT            NOT NULL,
    [NgayThang] DATE           NOT NULL,
    [MaCa]      INT            NOT NULL,
    [GhiChu]    NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC, [MaCa] ASC, [NgayThang] ASC),
    FOREIGN KEY ([MaCa]) REFERENCES [dbo].[CaLamViec] ([MaCa]),
    FOREIGN KEY ([MaCa]) REFERENCES [dbo].[CaLamViec] ([MaCa]),
    FOREIGN KEY ([MaCa]) REFERENCES [dbo].[CaLamViec] ([MaCa]),
    FOREIGN KEY ([MaCa]) REFERENCES [dbo].[CaLamViec] ([MaCa]),
    FOREIGN KEY ([MaCa]) REFERENCES [dbo].[CaLamViec] ([MaCa]),
    FOREIGN KEY ([MaCa]) REFERENCES [dbo].[CaLamViec] ([MaCa]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV])
);

