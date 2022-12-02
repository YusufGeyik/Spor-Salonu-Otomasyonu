CREATE TABLE [dbo].[UyeTbl] (
    [UyeId]           INT            IDENTITY (1, 1) NOT NULL,
    [UyeAdSoyad]      VARCHAR (50)   NULL,
    [UyeTelefonNo]    VARCHAR (50)   NULL,
    [UyeCinsiyet]     VARCHAR (6)    NULL,
    [UyeYas]          INT            NULL,
    [UyeBakiye]       INT            NULL,
    [UyeBranslar]     NVARCHAR (MAX) NULL,
    [UyePeriyot]      INT            NULL,
    [UyelikPaketi]    VARCHAR (8)    NULL,
    [BaslangicTarihi] VARCHAR (50)   NULL,
    [BitisTarihi]     VARCHAR (50)   NULL,
    [log]             VARCHAR (MAX)  NULL,
    [odenenmiktar] INT NULL, 
    PRIMARY KEY CLUSTERED ([UyeId] ASC)
);

