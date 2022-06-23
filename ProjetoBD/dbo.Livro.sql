CREATE TABLE [dbo].[Livro] (
    [Ref]          BIGINT       NOT NULL,
    [Titulo]       VARCHAR (30) NOT NULL,
    [Price]        MONEY        NOT NULL,
    [Iva]          INT          DEFAULT ((6)) NOT NULL,
    [ID_Editora]   INT          NOT NULL,
    [ID_Autor]     INT          NULL,
    [Tipo_Produto] INT          NULL,
    PRIMARY KEY CLUSTERED ([Ref] ASC),
    FOREIGN KEY ([ID_Editora]) REFERENCES [dbo].[Editora] ([Identificador]),
    FOREIGN KEY ([ID_Autor]) REFERENCES [dbo].[Autor] ([Identificador]),
    FOREIGN KEY ([Tipo_Produto]) REFERENCES [dbo].[Produto] ([Identificador])
);

