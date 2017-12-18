CREATE TABLE [dbo].[Users] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NULL,
    [Surname]        VARCHAR (50) NULL,
    [Identity_Type]  VARCHAR (50) NULL,
    [Identiy_Number] VARCHAR (50) NULL,
    [Date_Of_Birth]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

