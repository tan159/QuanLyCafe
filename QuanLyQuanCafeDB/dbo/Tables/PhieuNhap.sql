CREATE TABLE [dbo].[PhieuNhap] (
    [MaPhieuNhap] INT            IDENTITY (1, 1) NOT NULL,
    [NgayNhap]    DATE           DEFAULT (getdate()) NOT NULL,
    [MaNV]        INT            NOT NULL,
    [MoTa]        NVARCHAR (100) NULL,
    [MaNCC]       INT            NULL,
    [TrangThai]   INT            DEFAULT ((0)) NULL,
    [TongTien]    FLOAT (53)     NULL,
    PRIMARY KEY CLUSTERED ([MaPhieuNhap] ASC),
    FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap] ([MaNCC]),
    FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap] ([MaNCC]),
    FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap] ([MaNCC]),
    FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap] ([MaNCC]),
    FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap] ([MaNCC]),
    FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap] ([MaNCC]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV]),
    FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV])
);

