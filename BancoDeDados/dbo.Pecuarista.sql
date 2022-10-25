CREATE TABLE [dbo].[Pecuarista] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [NomePecuarista] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Pecuarista] PRIMARY KEY CLUSTERED ([Id] ASC)
);

