CREATE TABLE [dbo].[Students]
(
	[StudentId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StudentFirstName] NVARCHAR(50) NOT NULL, 
    [StudentLastName] NVARCHAR(50) NOT NULL, 
    [StudentMajor] INT NULL
)
