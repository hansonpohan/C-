CREATE TABLE [dbo].[persons]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [姓名] NVARCHAR(50) NULL, 
    [電話] NVARCHAR(50) NULL, 
    [地址] NVARCHAR(100) NULL, 
    [email] NVARCHAR(50) NULL, 
    [生日] DATE NULL, 
    [婚姻狀態] BIT NULL, 
    [點數] INT NULL
)
