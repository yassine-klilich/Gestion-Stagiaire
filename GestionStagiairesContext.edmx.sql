
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/07/2018 20:57:50
-- Generated from EDMX file: E:\My Studies\I ♥ Studing\Client-Server applications\Client-Serveur programming\SECTION 5\Entity Framework\Gestion Stagiaires\GestionStagiairesContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Gestion Stagiaires];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StagiaireFormation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stagiaires] DROP CONSTRAINT [FK_StagiaireFormation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Formations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formations];
GO
IF OBJECT_ID(N'[dbo].[Stagiaires]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stagiaires];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Formations'
CREATE TABLE [dbo].[Formations] (
    [IdFormation] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Stagiaires'
CREATE TABLE [dbo].[Stagiaires] (
    [IdStagiaire] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [DateNaissance] datetime  NULL,
    [IdFormation] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdFormation] in table 'Formations'
ALTER TABLE [dbo].[Formations]
ADD CONSTRAINT [PK_Formations]
    PRIMARY KEY CLUSTERED ([IdFormation] ASC);
GO

-- Creating primary key on [IdStagiaire] in table 'Stagiaires'
ALTER TABLE [dbo].[Stagiaires]
ADD CONSTRAINT [PK_Stagiaires]
    PRIMARY KEY CLUSTERED ([IdStagiaire] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdFormation] in table 'Stagiaires'
ALTER TABLE [dbo].[Stagiaires]
ADD CONSTRAINT [FK_StagiaireFormation]
    FOREIGN KEY ([IdFormation])
    REFERENCES [dbo].[Formations]
        ([IdFormation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StagiaireFormation'
CREATE INDEX [IX_FK_StagiaireFormation]
ON [dbo].[Stagiaires]
    ([IdFormation]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------