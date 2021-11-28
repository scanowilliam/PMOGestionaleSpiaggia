CREATE TABLE [dbo].[Cliente] (
    [Id_Cliente]      INT           NOT NULL,
    [Nome_Cliente]    VARCHAR (30)  NOT NULL,
    [Cognome_Cliente] VARCHAR (30)  NOT NULL,
    [Data_Inizio]     SMALLDATETIME NOT NULL,
    [Data_Fine]       SMALLDATETIME NOT NULL,
    [Offerta]         INT           NOT NULL,
    [Prezzo]          FLOAT (53)    NOT NULL,
    [Telefono]        VARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Cliente] ASC)
);

