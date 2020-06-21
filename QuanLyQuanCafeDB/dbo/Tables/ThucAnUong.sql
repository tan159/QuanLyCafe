CREATE TABLE [dbo].[ThucAnUong] (
    [MaTAU]     INT            IDENTITY (1, 1) NOT NULL,
    [TenTAU]    NVARCHAR (100) NOT NULL,
    [MaDanhMuc] INT            NOT NULL,
    [DonGia]    FLOAT (53)     DEFAULT ((0)) NOT NULL,
    [GiamGia]   FLOAT (53)     DEFAULT ((0)) NULL,
    [MieuTa]    NVARCHAR (100) NULL,
    [HinhAnh]   VARCHAR (MAX)  NULL,
    PRIMARY KEY CLUSTERED ([MaTAU] ASC),
    FOREIGN KEY ([MaDanhMuc]) REFERENCES [dbo].[DanhMuc] ([MaDanhMuc]),
    FOREIGN KEY ([MaDanhMuc]) REFERENCES [dbo].[DanhMuc] ([MaDanhMuc]),
    FOREIGN KEY ([MaDanhMuc]) REFERENCES [dbo].[DanhMuc] ([MaDanhMuc]),
    FOREIGN KEY ([MaDanhMuc]) REFERENCES [dbo].[DanhMuc] ([MaDanhMuc]),
    FOREIGN KEY ([MaDanhMuc]) REFERENCES [dbo].[DanhMuc] ([MaDanhMuc]),
    FOREIGN KEY ([MaDanhMuc]) REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
);

