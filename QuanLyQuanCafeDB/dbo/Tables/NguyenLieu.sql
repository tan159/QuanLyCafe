CREATE TABLE [dbo].[NguyenLieu] (
    [MaNL]      INT            IDENTITY (1, 1) NOT NULL,
    [TenNL]     NVARCHAR (100) NOT NULL,
    [DonGia]    FLOAT (53)     NOT NULL,
    [MieuTa]    NVARCHAR (100) NULL,
    [DonViTinh] NVARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([MaNL] ASC)
);

