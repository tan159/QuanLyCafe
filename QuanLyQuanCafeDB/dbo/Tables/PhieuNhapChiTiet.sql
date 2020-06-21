CREATE TABLE [dbo].[PhieuNhapChiTiet] (
    [MaPhieuNhap] INT NOT NULL,
    [MaNL]        INT NOT NULL,
    [SoLuong]     INT DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaPhieuNhap] ASC, [MaNL] ASC),
    FOREIGN KEY ([MaNL]) REFERENCES [dbo].[NguyenLieu] ([MaNL]),
    FOREIGN KEY ([MaNL]) REFERENCES [dbo].[NguyenLieu] ([MaNL]),
    FOREIGN KEY ([MaNL]) REFERENCES [dbo].[NguyenLieu] ([MaNL]),
    FOREIGN KEY ([MaNL]) REFERENCES [dbo].[NguyenLieu] ([MaNL]),
    FOREIGN KEY ([MaNL]) REFERENCES [dbo].[NguyenLieu] ([MaNL]),
    FOREIGN KEY ([MaNL]) REFERENCES [dbo].[NguyenLieu] ([MaNL]),
    FOREIGN KEY ([MaPhieuNhap]) REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap]),
    FOREIGN KEY ([MaPhieuNhap]) REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap]),
    FOREIGN KEY ([MaPhieuNhap]) REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap]),
    FOREIGN KEY ([MaPhieuNhap]) REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap]),
    FOREIGN KEY ([MaPhieuNhap]) REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap]),
    FOREIGN KEY ([MaPhieuNhap]) REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
);

