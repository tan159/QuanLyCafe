CREATE TABLE [dbo].[NhaCungCap] (
    [MaNCC]    INT            IDENTITY (1, 1) NOT NULL,
    [TenNhaCC] NVARCHAR (100) NULL,
    [Email]    NVARCHAR (100) NULL,
    [DiaChi]   NVARCHAR (100) NULL,
    [Phone]    NVARCHAR (11)  NULL,
    PRIMARY KEY CLUSTERED ([MaNCC] ASC)
);

