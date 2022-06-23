CREATE TABLE [dbo].[Utilizador] (
    [NIF]      INT          NOT NULL,
    [Nome]     VARCHAR (25) NOT NULL,
    [Endereco] VARCHAR (25) NULL,
    [Tipo]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([NIF] ASC)
);

