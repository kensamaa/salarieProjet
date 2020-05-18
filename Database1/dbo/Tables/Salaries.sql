CREATE TABLE [dbo].[Salaries] (
    [SalarieId]     INT            IDENTITY (1, 1) NOT NULL,
    [Nom]           NVARCHAR (MAX) NULL,
    [Prenom]        NVARCHAR (MAX) NULL,
    [Fonctione]     NVARCHAR (MAX) NULL,
    [DepartementId] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Salaries] PRIMARY KEY CLUSTERED ([SalarieId] ASC),
    CONSTRAINT [FK_dbo.Salaries_dbo.Departements_DepartementId] FOREIGN KEY ([DepartementId]) REFERENCES [dbo].[Departements] ([DepartementId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_DepartementId]
    ON [dbo].[Salaries]([DepartementId] ASC);

