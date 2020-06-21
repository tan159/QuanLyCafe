CREATE TABLE [dbo].[DanhMuc] (
    [MaDanhMuc]  INT            IDENTITY (1, 1) NOT NULL,
    [TenDanhMuc] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaDanhMuc] ASC)
);

