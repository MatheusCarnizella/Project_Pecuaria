CREATE TABLE [dbo].[Animal] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [NomeAnimal] NVARCHAR (500)  NOT NULL,
    [Preco]      DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED ([Id] ASC)
);

