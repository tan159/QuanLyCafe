CREATE TABLE [dbo].[BanAn] (
    [MaBan]     INT            IDENTITY (1, 1) NOT NULL,
    [TenBan]    NVARCHAR (100) NULL,
    [TrangThai] NVARCHAR (100) CONSTRAINT [DF__BanAn__TrangThai__46E78A0C] DEFAULT (N'Trống') NULL,
    [MieuTa]    NVARCHAR (100) NULL,
    [KhuVuc]    NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([MaBan] ASC)
);

