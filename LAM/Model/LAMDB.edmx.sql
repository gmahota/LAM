
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/11/2013 21:45:09
-- Generated from EDMX file: E:\Visual Studio 2013\Projects\ECV\LAM\LAM\Model\LAMDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [lam];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Balcao_Companhia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Balcao] DROP CONSTRAINT [FK_Balcao_Companhia];
GO
IF OBJECT_ID(N'[dbo].[FK_Chegada_Companhia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Chegada] DROP CONSTRAINT [FK_Chegada_Companhia];
GO
IF OBJECT_ID(N'[dbo].[FK_Partida_Companhia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Partida] DROP CONSTRAINT [FK_Partida_Companhia];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Balcao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Balcao];
GO
IF OBJECT_ID(N'[dbo].[Chegada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Chegada];
GO
IF OBJECT_ID(N'[dbo].[Companhia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companhia];
GO
IF OBJECT_ID(N'[dbo].[Partida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Partida];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Chegada'
CREATE TABLE [dbo].[Chegada] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Voo] nvarchar(250)  NULL,
    [Destino] nvarchar(250)  NULL,
    [Chegada1] nvarchar(250)  NULL,
    [Previsao] nvarchar(250)  NULL,
    [Obs] nvarchar(250)  NULL,
    [Companhia] decimal(18,0)  NULL
);
GO

-- Creating table 'Companhia'
CREATE TABLE [dbo].[Companhia] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Icon] varbinary(max)  NULL,
    [Contacto] nvarchar(250)  NULL,
    [Nome] nvarchar(250)  NULL,
    [Sigla] nvarchar(250)  NULL
);
GO

-- Creating table 'Balcaos'
CREATE TABLE [dbo].[Balcaos] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Companhia] decimal(18,0)  NULL,
    [Voo] nvarchar(250)  NULL,
    [Cidade] nvarchar(250)  NULL,
    [Classe] nvarchar(250)  NULL,
    [Balcao1] int  NULL,
    [Tv] int  NULL
);
GO

-- Creating table 'Partidas'
CREATE TABLE [dbo].[Partidas] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Companhia] decimal(18,0)  NULL,
    [Voo] nvarchar(250)  NULL,
    [Partida1] nvarchar(250)  NULL,
    [Previsao] nvarchar(250)  NULL,
    [Obs] nvarchar(250)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Chegada'
ALTER TABLE [dbo].[Chegada]
ADD CONSTRAINT [PK_Chegada]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companhia'
ALTER TABLE [dbo].[Companhia]
ADD CONSTRAINT [PK_Companhia]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Balcaos'
ALTER TABLE [dbo].[Balcaos]
ADD CONSTRAINT [PK_Balcaos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Partidas'
ALTER TABLE [dbo].[Partidas]
ADD CONSTRAINT [PK_Partidas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Companhia] in table 'Chegada'
ALTER TABLE [dbo].[Chegada]
ADD CONSTRAINT [FK_Chegada_Companhia]
    FOREIGN KEY ([Companhia])
    REFERENCES [dbo].[Companhia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Chegada_Companhia'
CREATE INDEX [IX_FK_Chegada_Companhia]
ON [dbo].[Chegada]
    ([Companhia]);
GO

-- Creating foreign key on [Companhia] in table 'Balcaos'
ALTER TABLE [dbo].[Balcaos]
ADD CONSTRAINT [FK_Balcao_Companhia]
    FOREIGN KEY ([Companhia])
    REFERENCES [dbo].[Companhia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Balcao_Companhia'
CREATE INDEX [IX_FK_Balcao_Companhia]
ON [dbo].[Balcaos]
    ([Companhia]);
GO

-- Creating foreign key on [Companhia] in table 'Partidas'
ALTER TABLE [dbo].[Partidas]
ADD CONSTRAINT [FK_Partida_Companhia]
    FOREIGN KEY ([Companhia])
    REFERENCES [dbo].[Companhia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Partida_Companhia'
CREATE INDEX [IX_FK_Partida_Companhia]
ON [dbo].[Partidas]
    ([Companhia]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------