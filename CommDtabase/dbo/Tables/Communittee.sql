CREATE TABLE [dbo].[Communittee]
(
	[CommunitteeId] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(150) NULL, 
    [Description] TEXT NULL, 
    [Password] VARCHAR(200) NULL, 
    [Address] VARCHAR(500) NULL
)
