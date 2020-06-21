CREATE TABLE [dbo].[Account] (
    [IDAccount]    INT            IDENTITY (1, 1) NOT NULL,
    [TenTaiKhoan]  NVARCHAR (100) NOT NULL,
    [TenHienThi]   NVARCHAR (100) NOT NULL,
    [PassWord]     NVARCHAR (100) DEFAULT ((0)) NULL,
    [LoaiTaiKhoan] INT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([IDAccount] ASC)
);

