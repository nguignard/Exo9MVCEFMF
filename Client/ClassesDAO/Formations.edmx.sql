
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/01/2015 16:49:11
-- Generated from EDMX file: C:\Users\Administrateur\Documents\Visual Studio 2013\Projects\Exo9MVCADODLL\ClassesDAO\Formations.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Formations];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StagesStagiaires]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StagiairesSet] DROP CONSTRAINT [FK_StagesStagiaires];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[StagiairesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StagiairesSet];
GO
IF OBJECT_ID(N'[dbo].[StagesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StagesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'StagiairesSet'
CREATE TABLE [dbo].[StagiairesSet] (
    [NumOsia] int  NOT NULL,
    [NomStagiaire] nvarchar(20)  NOT NULL,
    [PrenomStagiaire] nvarchar(20)  NOT NULL,
    [rueStagiaire] nvarchar(32)  NULL,
    [VilleStagiaire] nvarchar(32)  NULL,
    [CodePostalStagiaire] nchar(5)  NULL,
    [NbreNotes] int  NULL,
    [PointsNotes] decimal(6,2)  NULL,
    [Stages_Idsection] nchar(5)  NOT NULL
);
GO

-- Creating table 'StagesSet'
CREATE TABLE [dbo].[StagesSet] (
    [Idsection] nchar(5)  NOT NULL,
    [NomSection] nvarchar(40)  NOT NULL,
    [DateDebut] datetime  NULL,
    [DateFin] datetime  NOT NULL
);
GO

-- Creating table 'StagiairesSet_StagiaireCIF'
CREATE TABLE [dbo].[StagiairesSet_StagiaireCIF] (
    [Fongecif] nvarchar(30)  NOT NULL,
    [TypeCIF] nchar(3)  NOT NULL,
    [NumOsia] int  NOT NULL
);
GO

-- Creating table 'StagiairesSet_StagiaireDE'
CREATE TABLE [dbo].[StagiairesSet_StagiaireDE] (
    [RemuAfpa] bit  NOT NULL,
    [NumOsia] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NumOsia] in table 'StagiairesSet'
ALTER TABLE [dbo].[StagiairesSet]
ADD CONSTRAINT [PK_StagiairesSet]
    PRIMARY KEY CLUSTERED ([NumOsia] ASC);
GO

-- Creating primary key on [Idsection] in table 'StagesSet'
ALTER TABLE [dbo].[StagesSet]
ADD CONSTRAINT [PK_StagesSet]
    PRIMARY KEY CLUSTERED ([Idsection] ASC);
GO

-- Creating primary key on [NumOsia] in table 'StagiairesSet_StagiaireCIF'
ALTER TABLE [dbo].[StagiairesSet_StagiaireCIF]
ADD CONSTRAINT [PK_StagiairesSet_StagiaireCIF]
    PRIMARY KEY CLUSTERED ([NumOsia] ASC);
GO

-- Creating primary key on [NumOsia] in table 'StagiairesSet_StagiaireDE'
ALTER TABLE [dbo].[StagiairesSet_StagiaireDE]
ADD CONSTRAINT [PK_StagiairesSet_StagiaireDE]
    PRIMARY KEY CLUSTERED ([NumOsia] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Stages_Idsection] in table 'StagiairesSet'
ALTER TABLE [dbo].[StagiairesSet]
ADD CONSTRAINT [FK_StagesStagiaires]
    FOREIGN KEY ([Stages_Idsection])
    REFERENCES [dbo].[StagesSet]
        ([Idsection])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StagesStagiaires'
CREATE INDEX [IX_FK_StagesStagiaires]
ON [dbo].[StagiairesSet]
    ([Stages_Idsection]);
GO

-- Creating foreign key on [NumOsia] in table 'StagiairesSet_StagiaireCIF'
ALTER TABLE [dbo].[StagiairesSet_StagiaireCIF]
ADD CONSTRAINT [FK_StagiaireCIF_inherits_Stagiaires]
    FOREIGN KEY ([NumOsia])
    REFERENCES [dbo].[StagiairesSet]
        ([NumOsia])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumOsia] in table 'StagiairesSet_StagiaireDE'
ALTER TABLE [dbo].[StagiairesSet_StagiaireDE]
ADD CONSTRAINT [FK_StagiaireDE_inherits_Stagiaires]
    FOREIGN KEY ([NumOsia])
    REFERENCES [dbo].[StagiairesSet]
        ([NumOsia])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------