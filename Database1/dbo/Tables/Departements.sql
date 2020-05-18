CREATE TABLE [dbo].[Departements] (
    [DepartementId] INT            IDENTITY (1, 1) NOT NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Ville]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Departements] PRIMARY KEY CLUSTERED ([DepartementId] ASC)
);

