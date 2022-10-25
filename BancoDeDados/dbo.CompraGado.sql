CREATE TABLE [dbo].[CompraGado] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [IdPecuarista] INT           NOT NULL,
    [DataEntrega]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_CompraGado] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CompraGado_Pecuarista_IdPecuarista] FOREIGN KEY ([IdPecuarista]) REFERENCES [dbo].[Pecuarista] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CompraGado_IdPecuarista]
    ON [dbo].[CompraGado]([IdPecuarista] ASC);

