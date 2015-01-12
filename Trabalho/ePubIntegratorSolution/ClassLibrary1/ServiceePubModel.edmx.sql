
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/12/2015 00:22:27
-- Generated from EDMX file: C:\Users\Draconicrose\Documents\Visual Studio 2012\Projects\ePubIntegrator\Trabalho\ePubIntegratorSolution\ClassLibrary1\ServiceePubModel.edmx
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
IF OBJECT_ID(N'[dbo].[FK_LoginUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoginSet] DROP CONSTRAINT [FK_LoginUser];
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
    [IdUser] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NULL,
    [DateOfBirth] datetime  NOT NULL,
    [Address] nvarchar(max)  NULL
);
GO

-- Creating table 'LoginSet'
CREATE TABLE [dbo].[LoginSet] (
    [IdLogin] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [User_IdUser] int  NOT NULL
);
GO

-- Creating table 'eBookSet'
CREATE TABLE [dbo].[eBookSet] (
    [IdeBook] int IDENTITY(1,1) NOT NULL,
    [Language] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Bookmark_IdBookmark] int  NULL,
    [Favorite_IdFavorite] int  NULL
);
GO

-- Creating table 'BookmarkSet'
CREATE TABLE [dbo].[BookmarkSet] (
    [IdBookmark] int IDENTITY(1,1) NOT NULL,
    [Book] nvarchar(max)  NOT NULL,
    [Chapter] nvarchar(max)  NOT NULL,
    [User_IdUser] int  NOT NULL
);
GO

-- Creating table 'ChapterSet'
CREATE TABLE [dbo].[ChapterSet] (
    [IdChapter] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [eBook_IdeBook] int  NOT NULL,
    [Bookmark_IdBookmark] int  NULL,
    [Favorite_IdFavorite] int  NULL
);
GO

-- Creating table 'FavoriteSet'
CREATE TABLE [dbo].[FavoriteSet] (
    [IdFavorite] int IDENTITY(1,1) NOT NULL,
    [Book] nvarchar(max)  NOT NULL,
    [Chapter] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'eBookTitlesSet'
CREATE TABLE [dbo].[eBookTitlesSet] (
    [Title] nvarchar(max)  NOT NULL,
    [IdTitles] int IDENTITY(1,1) NOT NULL,
    [eBook_IdeBook] int  NOT NULL
);
GO

-- Creating table 'eBookAuthorsSet'
CREATE TABLE [dbo].[eBookAuthorsSet] (
    [Name] nvarchar(max)  NOT NULL,
    [IdAuthors] int IDENTITY(1,1) NOT NULL,
    [eBook_IdeBook] int  NOT NULL
);
GO

-- Creating table 'eBookPublisherSet'
CREATE TABLE [dbo].[eBookPublisherSet] (
    [Name] nvarchar(max)  NOT NULL,
    [IdPublisher] int IDENTITY(1,1) NOT NULL,
    [eBook_IdeBook] int  NOT NULL
);
GO

-- Creating table 'StatisticsSet'
CREATE TABLE [dbo].[StatisticsSet] (
    [IdStatistic] int IDENTITY(1,1) NOT NULL,
    [NumberofFavorites] int  NOT NULL,
    [NumberofBookmarks] int  NOT NULL,
    [LastAppUseDate] datetime  NOT NULL,
    [User_IdUser] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdUser] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdLogin] in table 'LoginSet'
ALTER TABLE [dbo].[LoginSet]
ADD CONSTRAINT [PK_LoginSet]
    PRIMARY KEY CLUSTERED ([IdLogin] ASC);
GO

-- Creating primary key on [IdeBook] in table 'eBookSet'
ALTER TABLE [dbo].[eBookSet]
ADD CONSTRAINT [PK_eBookSet]
    PRIMARY KEY CLUSTERED ([IdeBook] ASC);
GO

-- Creating primary key on [IdBookmark] in table 'BookmarkSet'
ALTER TABLE [dbo].[BookmarkSet]
ADD CONSTRAINT [PK_BookmarkSet]
    PRIMARY KEY CLUSTERED ([IdBookmark] ASC);
GO

-- Creating primary key on [IdChapter] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [PK_ChapterSet]
    PRIMARY KEY CLUSTERED ([IdChapter] ASC);
GO

-- Creating primary key on [IdFavorite] in table 'FavoriteSet'
ALTER TABLE [dbo].[FavoriteSet]
ADD CONSTRAINT [PK_FavoriteSet]
    PRIMARY KEY CLUSTERED ([IdFavorite] ASC);
GO

-- Creating primary key on [IdTitles] in table 'eBookTitlesSet'
ALTER TABLE [dbo].[eBookTitlesSet]
ADD CONSTRAINT [PK_eBookTitlesSet]
    PRIMARY KEY CLUSTERED ([IdTitles] ASC);
GO

-- Creating primary key on [IdAuthors] in table 'eBookAuthorsSet'
ALTER TABLE [dbo].[eBookAuthorsSet]
ADD CONSTRAINT [PK_eBookAuthorsSet]
    PRIMARY KEY CLUSTERED ([IdAuthors] ASC);
GO

-- Creating primary key on [IdPublisher] in table 'eBookPublisherSet'
ALTER TABLE [dbo].[eBookPublisherSet]
ADD CONSTRAINT [PK_eBookPublisherSet]
    PRIMARY KEY CLUSTERED ([IdPublisher] ASC);
GO

-- Creating primary key on [IdStatistic] in table 'StatisticsSet'
ALTER TABLE [dbo].[StatisticsSet]
ADD CONSTRAINT [PK_StatisticsSet]
    PRIMARY KEY CLUSTERED ([IdStatistic] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Bookmark_IdBookmark] in table 'eBookSet'
ALTER TABLE [dbo].[eBookSet]
ADD CONSTRAINT [FK_BookmarkeBook]
    FOREIGN KEY ([Bookmark_IdBookmark])
    REFERENCES [dbo].[BookmarkSet]
        ([IdBookmark])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BookmarkeBook'
CREATE INDEX [IX_FK_BookmarkeBook]
ON [dbo].[eBookSet]
    ([Bookmark_IdBookmark]);
GO

-- Creating foreign key on [eBook_IdeBook] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [FK_ChaptereBook]
    FOREIGN KEY ([eBook_IdeBook])
    REFERENCES [dbo].[eBookSet]
        ([IdeBook])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ChaptereBook'
CREATE INDEX [IX_FK_ChaptereBook]
ON [dbo].[ChapterSet]
    ([eBook_IdeBook]);
GO

-- Creating foreign key on [Bookmark_IdBookmark] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [FK_BookmarkChapter]
    FOREIGN KEY ([Bookmark_IdBookmark])
    REFERENCES [dbo].[BookmarkSet]
        ([IdBookmark])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BookmarkChapter'
CREATE INDEX [IX_FK_BookmarkChapter]
ON [dbo].[ChapterSet]
    ([Bookmark_IdBookmark]);
GO

-- Creating foreign key on [User_IdUser] in table 'BookmarkSet'
ALTER TABLE [dbo].[BookmarkSet]
ADD CONSTRAINT [FK_UserBookmark]
    FOREIGN KEY ([User_IdUser])
    REFERENCES [dbo].[UserSet]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBookmark'
CREATE INDEX [IX_FK_UserBookmark]
ON [dbo].[BookmarkSet]
    ([User_IdUser]);
GO

-- Creating foreign key on [Favorite_IdFavorite] in table 'eBookSet'
ALTER TABLE [dbo].[eBookSet]
ADD CONSTRAINT [FK_FavoriteeBook]
    FOREIGN KEY ([Favorite_IdFavorite])
    REFERENCES [dbo].[FavoriteSet]
        ([IdFavorite])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteeBook'
CREATE INDEX [IX_FK_FavoriteeBook]
ON [dbo].[eBookSet]
    ([Favorite_IdFavorite]);
GO

-- Creating foreign key on [Favorite_IdFavorite] in table 'ChapterSet'
ALTER TABLE [dbo].[ChapterSet]
ADD CONSTRAINT [FK_FavoriteChapter]
    FOREIGN KEY ([Favorite_IdFavorite])
    REFERENCES [dbo].[FavoriteSet]
        ([IdFavorite])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteChapter'
CREATE INDEX [IX_FK_FavoriteChapter]
ON [dbo].[ChapterSet]
    ([Favorite_IdFavorite]);
GO

-- Creating foreign key on [eBook_IdeBook] in table 'eBookTitlesSet'
ALTER TABLE [dbo].[eBookTitlesSet]
ADD CONSTRAINT [FK_eBookeBookTitles]
    FOREIGN KEY ([eBook_IdeBook])
    REFERENCES [dbo].[eBookSet]
        ([IdeBook])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_eBookeBookTitles'
CREATE INDEX [IX_FK_eBookeBookTitles]
ON [dbo].[eBookTitlesSet]
    ([eBook_IdeBook]);
GO

-- Creating foreign key on [eBook_IdeBook] in table 'eBookAuthorsSet'
ALTER TABLE [dbo].[eBookAuthorsSet]
ADD CONSTRAINT [FK_eBookeBookAuthors]
    FOREIGN KEY ([eBook_IdeBook])
    REFERENCES [dbo].[eBookSet]
        ([IdeBook])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_eBookeBookAuthors'
CREATE INDEX [IX_FK_eBookeBookAuthors]
ON [dbo].[eBookAuthorsSet]
    ([eBook_IdeBook]);
GO

-- Creating foreign key on [eBook_IdeBook] in table 'eBookPublisherSet'
ALTER TABLE [dbo].[eBookPublisherSet]
ADD CONSTRAINT [FK_eBookPublishereBook]
    FOREIGN KEY ([eBook_IdeBook])
    REFERENCES [dbo].[eBookSet]
        ([IdeBook])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_eBookPublishereBook'
CREATE INDEX [IX_FK_eBookPublishereBook]
ON [dbo].[eBookPublisherSet]
    ([eBook_IdeBook]);
GO

-- Creating foreign key on [User_IdUser] in table 'StatisticsSet'
ALTER TABLE [dbo].[StatisticsSet]
ADD CONSTRAINT [FK_StatisticsUser]
    FOREIGN KEY ([User_IdUser])
    REFERENCES [dbo].[UserSet]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StatisticsUser'
CREATE INDEX [IX_FK_StatisticsUser]
ON [dbo].[StatisticsSet]
    ([User_IdUser]);
GO

-- Creating foreign key on [User_IdUser] in table 'LoginSet'
ALTER TABLE [dbo].[LoginSet]
ADD CONSTRAINT [FK_LoginUser]
    FOREIGN KEY ([User_IdUser])
    REFERENCES [dbo].[UserSet]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginUser'
CREATE INDEX [IX_FK_LoginUser]
ON [dbo].[LoginSet]
    ([User_IdUser]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------