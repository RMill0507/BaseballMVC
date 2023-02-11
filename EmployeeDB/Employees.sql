CREATE TABLE [dbo].[Employees]
(
	[employeeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [department] NVARCHAR(50) NOT NULL, 
    [isAdmin] NVARCHAR(50) NOT NULL
)
