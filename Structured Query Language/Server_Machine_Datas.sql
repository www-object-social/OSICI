﻿CREATE TABLE [dbo].[Server_Machine_Datas]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL,
	[IsActive] bit NOT NULL,
)
