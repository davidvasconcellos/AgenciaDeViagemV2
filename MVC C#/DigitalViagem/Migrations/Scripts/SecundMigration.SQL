IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(40) NOT NULL,
    [CPF] char(11) NOT NULL,
    [Endereco] char(50) NOT NULL,
    [Telefone] char(15) NOT NULL,
    [Data_Nascimento] date NOT NULL,
    [Situacao] nvarchar(9) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211216214655_FirstMigration', N'5.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Viagens] (
    [Id] int NOT NULL IDENTITY,
    [Origem] nvarchar(40) NOT NULL,
    [Destino] nvarchar(40) NOT NULL,
    [DataVolta] date NOT NULL,
    [DataPartida] date NOT NULL,
    [Valor] char(50) NOT NULL,
    [Status] nvarchar(15) NOT NULL,
    CONSTRAINT [PK_Viagens] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211219225419_SecundMigration', N'5.0.13');
GO

COMMIT;
GO

