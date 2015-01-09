
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/09/2015 15:26:14
-- Generated from EDMX file: C:\Users\2131314\Documents\Visual Studio 2012\Projects\ePubIntegrator\Trabalho\ePubIntegratorSolution\ClassLibrary1\ServiceePubModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ePubIntegratorDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserLogin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoginSet] DROP CONSTRAINT [FK_UserLogin];
GO
IF OBJECT_ID(N'[dbo].[FK_BookmarkeBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[eBookSet] DROP CONSTRAINT [FK_BookmarkeBook];
GO
IF OBJECT_ID(N'[dbo].[FK_ChaptereBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChapterSet] DROP CONSTRAINT [FK_ChaptereBook];
GO
IF OBJECT_ID(N'[dbo].[FK_BookmarkChapter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChapterSet] DROP CONSTRAINT [FK_BookmarkChapter];
GO
IF OBJECT_ID(N'[dbo].[FK_UserBookmark]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookmarkSet] DROP CONSTRAINT [FK_UserBookmark];
GO
IF OBJECT_ID(N'[dbo].[FK_FavoriteeBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[eBookSet] DROP CONSTRAINT [FK_FavoriteeBook];
GO
IF OBJECT_ID(N'[dbo].[FK_FavoriteChapter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChapterSet] DROP CONSTRAINT [FK_FavoriteChapter];
GO
IF OBJECT_ID(N'[dbo].[FK_eBookeBookTitles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[eBookTitlesSet] DROP CONSTRAINT [FK_eBookeBookTitles];
GO
IF OBJECT_ID(N'[dbo].[FK_eBookeBookAuthors]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[eBookAuthorsSet] DROP CONSTRAINT [FK_eBookeBookAuthors];
GO
IF OBJECT_ID(N'[dbo].[FK_eBookPublishereBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[eBookPublisherSet] DROP CONSTRAINT [FK_eBookPublishereBook];
GO
IF OBJECT_ID(N'[dbo].[FK_StatisticsUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StatisticsSet] DROP CONSTRAINT [FK_StatisticsUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[LoginSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoginSet];
GO
IF OBJECT_ID(N'[dbo].[eBookSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[eBookSet];
GO
IF OBJECT_ID(N'[dbo].[BookmarkSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookmarkSet];
GO
IF OBJECT_ID(N'[dbo].[ChapterSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChapterSet];
GO
IF OBJECT_ID(N'[dbo].[FavoriteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FavoriteSet];
GO
IF OBJECT_ID(N'[dbo].[eBookTitlesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[eBookTitlesSet];
GO
IF OBJECT_ID(N'[dbo].[eBookAuthorsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[eBookAuthorsSet];
GO
IF OBJECT_ID(N'[dbo].[eBookPublisherSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[eBookPublisherSet];
GO
IF OBJECT_ID(N'[dbo].[StatisticsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StatisticsSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DateOfBirth] datetime  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LoginSet'
CREATE TABLE [dbo].[LoginSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'eBookSet'
CREATE TABLE [dbo].[eBookSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Language] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Bookmark_Id] int  NULL,
    [Favorite_Id] int  NULL
);
GO

-- Creating table 'BookmarkSet'
CREATE TABLE [dbo].[BookmarkSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Book] nvarchar(max)  NOT NULL,
    [Chapter] nvarchar(max)  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'ChapterSet'
CREATE TABLE [dbo].[ChapterSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [eBook_Id] int  NOT NULL,
    [Bookmark_Id] int  NULL,
    [Favorite_Id] int  NULL
);
GO

-- Creating table 'FavoriteSet'
CREATE TABLE [dbo].[FavoriteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Book] nvarchar(max)  NOT NULL,
    [Chapter] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'eBookTitlesSet'
CREATE TABLE [dbo].[eBookTitlesSet] (
    [Title] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [eBook_Id] int  NOT NULL
);
GO

-- Creating table 'eBookAuthorsSet'
CREATE TABLE [dbo].[eBookAuthorsSet] (
    [Name] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [eBook_Id] int  NOT NULL
);
GO

-- Creating table 'eBookPublisherSet'
CREATE TABLE [dbo].[eBookPublisherSet] (
    [Name] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [eBook_Id] int  NOT NULL
);
GO

-- Creating table 'StatisticsSet'
CREATE TABLE [dbo].[StatisticsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumberofFavorites] nvarchar(max)  NOT NULL,
    [NumberofBookmarks] nvarchar(max)  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LoginSet'
ALTER TABLE [dbo].[LoginSet]
ADD CONSTRAINT [PK_LoginSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'eBookSet'
ALTER TABLE [dbo].[eBookSet]
ADD CONSTRAINT [PK_eBookSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookmarkSet'
ALTER TABLE [dbo].[BookmarkSet]
ADD CONSTRAINT [PK_BookmarkSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [PK_ChapterSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FavoriteSet'
ALTER TABLE [dbo].[FavoriteSet]
ADD CONSTRAINT [PK_FavoriteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'eBookTitlesSet'
ALTER TABLE [dbo].[eBookTitlesSet]
ADD CONSTRAINT [PK_eBookTitlesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'eBookAuthorsSet'
ALTER TABLE [dbo].[eBookAuthorsSet]
ADD CONSTRAINT [PK_eBookAuthorsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'eBookPublisherSet'
ALTER TABLE [dbo].[eBookPublisherSet]
ADD CONSTRAINT [PK_eBookPublisherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StatisticsSet'
ALTER TABLE [dbo].[StatisticsSet]
ADD CONSTRAINT [PK_StatisticsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'LoginSet'
ALTER TABLE [dbo].[LoginSet]
ADD CONSTRAINT [FK_UserLogin]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Bookmark_Id] in table 'eBookSet'
ALTER TABLE [dbo].[eBookSet]
ADD CONSTRAINT [FK_BookmarkeBook]
    FOREIGN KEY ([Bookmark_Id])
    REFERENCES [dbo].[BookmarkSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BookmarkeBook'
CREATE INDEX [IX_FK_BookmarkeBook]
ON [dbo].[eBookSet]
    ([Bookmark_Id]);
GO

-- Creating foreign key on [eBook_Id] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [FK_ChaptereBook]
    FOREIGN KEY ([eBook_Id])
    REFERENCES [dbo].[eBookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChaptereBook'
CREATE INDEX [IX_FK_ChaptereBook]
ON [dbo].[ChapterSet]
    ([eBook_Id]);
GO

-- Creating foreign key on [Bookmark_Id] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [FK_BookmarkChapter]
    FOREIGN KEY ([Bookmark_Id])
    REFERENCES [dbo].[BookmarkSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BookmarkChapter'
CREATE INDEX [IX_FK_BookmarkChapter]
ON [dbo].[ChapterSet]
    ([Bookmark_Id]);
GO

-- Creating foreign key on [User_Id] in table 'BookmarkSet'
ALTER TABLE [dbo].[BookmarkSet]
ADD CONSTRAINT [FK_UserBookmark]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBookmark'
CREATE INDEX [IX_FK_UserBookmark]
ON [dbo].[BookmarkSet]
    ([User_Id]);
GO

-- Creating foreign key on [Favorite_Id] in table 'eBookSet'
ALTER TABLE [dbo].[eBookSet]
ADD CONSTRAINT [FK_FavoriteeBook]
    FOREIGN KEY ([Favorite_Id])
    REFERENCES [dbo].[FavoriteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteeBook'
CREATE INDEX [IX_FK_FavoriteeBook]
ON [dbo].[eBookSet]
    ([Favorite_Id]);
GO

-- Creating foreign key on [Favorite_Id] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [FK_FavoriteChapter]
    FOREIGN KEY ([Favorite_Id])
    REFERENCES [dbo].[FavoriteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteChapter'
CREATE INDEX [IX_FK_FavoriteChapter]
ON [dbo].[ChapterSet]
    ([Favorite_Id]);
GO

-- Creating foreign key on [eBook_Id] in table 'eBookTitlesSet'
ALTER TABLE [dbo].[eBookTitlesSet]
ADD CONSTRAINT [FK_eBookeBookTitles]
    FOREIGN KEY ([eBook_Id])
    REFERENCES [dbo].[eBookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_eBookeBookTitles'
CREATE INDEX [IX_FK_eBookeBookTitles]
ON [dbo].[eBookTitlesSet]
    ([eBook_Id]);
GO

-- Creating foreign key on [eBook_Id] in table 'eBookAuthorsSet'
ALTER TABLE [dbo].[eBookAuthorsSet]
ADD CONSTRAINT [FK_eBookeBookAuthors]
    FOREIGN KEY ([eBook_Id])
    REFERENCES [dbo].[eBookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_eBookeBookAuthors'
CREATE INDEX [IX_FK_eBookeBookAuthors]
ON [dbo].[eBookAuthorsSet]
    ([eBook_Id]);
GO

-- Creating foreign key on [eBook_Id] in table 'eBookPublisherSet'
ALTER TABLE [dbo].[eBookPublisherSet]
ADD CONSTRAINT [FK_eBookPublishereBook]
    FOREIGN KEY ([eBook_Id])
    REFERENCES [dbo].[eBookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_eBookPublishereBook'
CREATE INDEX [IX_FK_eBookPublishereBook]
ON [dbo].[eBookPublisherSet]
    ([eBook_Id]);
GO

-- Creating foreign key on [User_Id] in table 'StatisticsSet'
ALTER TABLE [dbo].[StatisticsSet]
ADD CONSTRAINT [FK_StatisticsUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StatisticsUser'
CREATE INDEX [IX_FK_StatisticsUser]
ON [dbo].[StatisticsSet]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------