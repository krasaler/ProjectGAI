
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/04/2015 13:56:20
-- Generated from EDMX file: D:\Рабочие файлы\Разработка\Проекты\C#\Project GAI\Project GAI\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GAI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__BodyTypes__BodyT__182C9B23]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BodyTypes] DROP CONSTRAINT [FK__BodyTypes__BodyT__182C9B23];
GO
IF OBJECT_ID(N'[dbo].[FK__CarOwner__CarId__3D5E1FD2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarOwner] DROP CONSTRAINT [FK__CarOwner__CarId__3D5E1FD2];
GO
IF OBJECT_ID(N'[dbo].[FK__CarOwner__OwnerI__3E52440B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarOwner] DROP CONSTRAINT [FK__CarOwner__OwnerI__3E52440B];
GO
IF OBJECT_ID(N'[dbo].[FK__Cars__CountryId__276EDEB3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK__Cars__CountryId__276EDEB3];
GO
IF OBJECT_ID(N'[dbo].[FK__Cars__ModelId__267ABA7A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK__Cars__ModelId__267ABA7A];
GO
IF OBJECT_ID(N'[dbo].[FK__Cars__PlaceRegId__25869641]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK__Cars__PlaceRegId__25869641];
GO
IF OBJECT_ID(N'[dbo].[FK__Models__BodyType__1DE57479]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Models] DROP CONSTRAINT [FK__Models__BodyType__1DE57479];
GO
IF OBJECT_ID(N'[dbo].[FK__Models__Produser__1CF15040]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Models] DROP CONSTRAINT [FK__Models__Produser__1CF15040];
GO
IF OBJECT_ID(N'[dbo].[FK__OwnerFine__FineT__440B1D61]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OwnerFines] DROP CONSTRAINT [FK__OwnerFine__FineT__440B1D61];
GO
IF OBJECT_ID(N'[dbo].[FK__OwnerFine__Owner__4316F928]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OwnerFines] DROP CONSTRAINT [FK__OwnerFine__Owner__4316F928];
GO
IF OBJECT_ID(N'[dbo].[FK__Rights__OwnerId__49C3F6B7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rights] DROP CONSTRAINT [FK__Rights__OwnerId__49C3F6B7];
GO
IF OBJECT_ID(N'[dbo].[FK__Rights__RightTyp__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rights] DROP CONSTRAINT [FK__Rights__RightTyp__4AB81AF0];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BodyTypeClassifications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BodyTypeClassifications];
GO
IF OBJECT_ID(N'[dbo].[BodyTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BodyTypes];
GO
IF OBJECT_ID(N'[dbo].[CarOwner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarOwner];
GO
IF OBJECT_ID(N'[dbo].[Cars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cars];
GO
IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO
IF OBJECT_ID(N'[dbo].[FinesTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FinesTypes];
GO
IF OBJECT_ID(N'[dbo].[Models]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Models];
GO
IF OBJECT_ID(N'[dbo].[OwnerFines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OwnerFines];
GO
IF OBJECT_ID(N'[dbo].[Owners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Owners];
GO
IF OBJECT_ID(N'[dbo].[Produsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produsers];
GO
IF OBJECT_ID(N'[dbo].[Rights]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rights];
GO
IF OBJECT_ID(N'[dbo].[RightsTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RightsTypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BodyTypeClassifications'
CREATE TABLE [dbo].[BodyTypeClassifications] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'BodyTypes'
CREATE TABLE [dbo].[BodyTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL,
    [BodyTypeClassificationsId] int  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'FinesTypes'
CREATE TABLE [dbo].[FinesTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(500)  NOT NULL
);
GO

-- Creating table 'Produsers'
CREATE TABLE [dbo].[Produsers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'RightsTypes'
CREATE TABLE [dbo].[RightsTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(4)  NOT NULL
);
GO

-- Creating table 'CarOwner'
CREATE TABLE [dbo].[CarOwner] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CarId] int  NOT NULL,
    [OwnerId] int  NOT NULL,
    [Data] datetime  NOT NULL
);
GO

-- Creating table 'OwnerFines'
CREATE TABLE [dbo].[OwnerFines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FineTypeId] int  NOT NULL,
    [OwnerId] int  NOT NULL
);
GO

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ModelId] int  NOT NULL,
    [PlaceRegId] int  NOT NULL,
    [CountryId] int  NOT NULL,
    [NumberBody] decimal(10,0)  NOT NULL,
    [NumberEngine] decimal(10,0)  NOT NULL,
    [NumberChassis] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'Rights'
CREATE TABLE [dbo].[Rights] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OwnerId] int  NOT NULL,
    [RightTypeId] int  NOT NULL,
    [Data] datetime  NOT NULL
);
GO

-- Creating table 'Owners'
CREATE TABLE [dbo].[Owners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL,
    [LastName] nvarchar(30)  NOT NULL,
    [MiddleName] nvarchar(30)  NOT NULL,
    [Adres] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Models'
CREATE TABLE [dbo].[Models] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProduserId] int  NOT NULL,
    [BodyTypesId] int  NOT NULL,
    [Name] nvarchar(30)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BodyTypeClassifications'
ALTER TABLE [dbo].[BodyTypeClassifications]
ADD CONSTRAINT [PK_BodyTypeClassifications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BodyTypes'
ALTER TABLE [dbo].[BodyTypes]
ADD CONSTRAINT [PK_BodyTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FinesTypes'
ALTER TABLE [dbo].[FinesTypes]
ADD CONSTRAINT [PK_FinesTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produsers'
ALTER TABLE [dbo].[Produsers]
ADD CONSTRAINT [PK_Produsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RightsTypes'
ALTER TABLE [dbo].[RightsTypes]
ADD CONSTRAINT [PK_RightsTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CarOwner'
ALTER TABLE [dbo].[CarOwner]
ADD CONSTRAINT [PK_CarOwner]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OwnerFines'
ALTER TABLE [dbo].[OwnerFines]
ADD CONSTRAINT [PK_OwnerFines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rights'
ALTER TABLE [dbo].[Rights]
ADD CONSTRAINT [PK_Rights]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Owners'
ALTER TABLE [dbo].[Owners]
ADD CONSTRAINT [PK_Owners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [PK_Models]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BodyTypeClassificationsId] in table 'BodyTypes'
ALTER TABLE [dbo].[BodyTypes]
ADD CONSTRAINT [FK__BodyTypes__BodyT__0CBAE877]
    FOREIGN KEY ([BodyTypeClassificationsId])
    REFERENCES [dbo].[BodyTypeClassifications]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__BodyTypes__BodyT__0CBAE877'
CREATE INDEX [IX_FK__BodyTypes__BodyT__0CBAE877]
ON [dbo].[BodyTypes]
    ([BodyTypeClassificationsId]);
GO

-- Creating foreign key on [FineTypeId] in table 'OwnerFines'
ALTER TABLE [dbo].[OwnerFines]
ADD CONSTRAINT [FK__OwnerFine__FineT__300424B4]
    FOREIGN KEY ([FineTypeId])
    REFERENCES [dbo].[FinesTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OwnerFine__FineT__300424B4'
CREATE INDEX [IX_FK__OwnerFine__FineT__300424B4]
ON [dbo].[OwnerFines]
    ([FineTypeId]);
GO

-- Creating foreign key on [CarId] in table 'CarOwner'
ALTER TABLE [dbo].[CarOwner]
ADD CONSTRAINT [FK__CarOwner__CarId__29572725]
    FOREIGN KEY ([CarId])
    REFERENCES [dbo].[Cars]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CarOwner__CarId__29572725'
CREATE INDEX [IX_FK__CarOwner__CarId__29572725]
ON [dbo].[CarOwner]
    ([CarId]);
GO

-- Creating foreign key on [CountryId] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK__Cars__CountryId__1920BF5C]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Cars__CountryId__1920BF5C'
CREATE INDEX [IX_FK__Cars__CountryId__1920BF5C]
ON [dbo].[Cars]
    ([CountryId]);
GO

-- Creating foreign key on [PlaceRegId] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK__Cars__PlaceRegId__173876EA]
    FOREIGN KEY ([PlaceRegId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Cars__PlaceRegId__173876EA'
CREATE INDEX [IX_FK__Cars__PlaceRegId__173876EA]
ON [dbo].[Cars]
    ([PlaceRegId]);
GO

-- Creating foreign key on [RightTypeId] in table 'Rights'
ALTER TABLE [dbo].[Rights]
ADD CONSTRAINT [FK__Rights__RightTyp__35BCFE0A]
    FOREIGN KEY ([RightTypeId])
    REFERENCES [dbo].[RightsTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Rights__RightTyp__35BCFE0A'
CREATE INDEX [IX_FK__Rights__RightTyp__35BCFE0A]
ON [dbo].[Rights]
    ([RightTypeId]);
GO

-- Creating foreign key on [OwnerId] in table 'CarOwner'
ALTER TABLE [dbo].[CarOwner]
ADD CONSTRAINT [FK__CarOwner__OwnerI__2A4B4B5E]
    FOREIGN KEY ([OwnerId])
    REFERENCES [dbo].[Owners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CarOwner__OwnerI__2A4B4B5E'
CREATE INDEX [IX_FK__CarOwner__OwnerI__2A4B4B5E]
ON [dbo].[CarOwner]
    ([OwnerId]);
GO

-- Creating foreign key on [OwnerId] in table 'OwnerFines'
ALTER TABLE [dbo].[OwnerFines]
ADD CONSTRAINT [FK__OwnerFine__Owner__2F10007B]
    FOREIGN KEY ([OwnerId])
    REFERENCES [dbo].[Owners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OwnerFine__Owner__2F10007B'
CREATE INDEX [IX_FK__OwnerFine__Owner__2F10007B]
ON [dbo].[OwnerFines]
    ([OwnerId]);
GO

-- Creating foreign key on [OwnerId] in table 'Rights'
ALTER TABLE [dbo].[Rights]
ADD CONSTRAINT [FK__Rights__OwnerId__34C8D9D1]
    FOREIGN KEY ([OwnerId])
    REFERENCES [dbo].[Owners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Rights__OwnerId__34C8D9D1'
CREATE INDEX [IX_FK__Rights__OwnerId__34C8D9D1]
ON [dbo].[Rights]
    ([OwnerId]);
GO

-- Creating foreign key on [BodyTypesId] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [FK__Models__BodyType__1DE57479]
    FOREIGN KEY ([BodyTypesId])
    REFERENCES [dbo].[BodyTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Models__BodyType__1DE57479'
CREATE INDEX [IX_FK__Models__BodyType__1DE57479]
ON [dbo].[Models]
    ([BodyTypesId]);
GO

-- Creating foreign key on [ModelId] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK__Cars__ModelId__267ABA7A]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[Models]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Cars__ModelId__267ABA7A'
CREATE INDEX [IX_FK__Cars__ModelId__267ABA7A]
ON [dbo].[Cars]
    ([ModelId]);
GO

-- Creating foreign key on [ProduserId] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [FK__Models__Produser__1CF15040]
    FOREIGN KEY ([ProduserId])
    REFERENCES [dbo].[Produsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Models__Produser__1CF15040'
CREATE INDEX [IX_FK__Models__Produser__1CF15040]
ON [dbo].[Models]
    ([ProduserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------