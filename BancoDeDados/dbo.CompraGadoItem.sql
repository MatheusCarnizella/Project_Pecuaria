CREATE TABLE [dbo].[CompraGadoItem] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [IdCompraGado] INT NOT NULL,
    [IdAnimal]     INT NOT NULL,
    [Quantidade]   INT NOT NULL,
    CONSTRAINT [PK_CompraGadoItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CompraGadoItem_Animal_IdAnimal] FOREIGN KEY ([IdAnimal]) REFERENCES [dbo].[Animal] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CompraGadoItem_CompraGado_IdCompraGado] FOREIGN KEY ([IdCompraGado]) REFERENCES [dbo].[CompraGado] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompraGadoItem_IdAnimal]
    ON [dbo].[CompraGadoItem]([IdAnimal] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompraGadoItem_IdCompraGado]
    ON [dbo].[CompraGadoItem]([IdCompraGado] ASC);

