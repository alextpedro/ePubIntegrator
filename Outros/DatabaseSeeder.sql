--SEEDING SQL 
SET IDENTITY_INSERT [dbo].[UserSet] ON
INSERT INTO [dbo].[UserSet] ([IdUser], [Email], [DateOfBirth], [Address]) VALUES (1, 'teste1@email.com', N'1991-07-01 00:00:00', 'Test1 Street')
INSERT INTO [dbo].[UserSet] ([IdUser], [Email], [DateOfBirth], [Address]) VALUES (2, 'teste2@email.com', N'1991-07-02 00:00:00', 'Test2 Street')
INSERT INTO [dbo].[UserSet] ([IdUser], [Email], [DateOfBirth], [Address]) VALUES (3, 'teste3@email.com', N'1991-07-03 00:00:00', 'Test3 Street')
INSERT INTO [dbo].[UserSet] ([IdUser], [Email], [DateOfBirth], [Address]) VALUES (4, 'teste4@email.com', N'1991-07-04 00:00:00', 'Test4 Street')
INSERT INTO [dbo].[UserSet] ([IdUser], [Email], [DateOfBirth], [Address]) VALUES (5, 'teste5@email.com', N'1991-07-05 00:00:00', 'Test5 Street')
INSERT INTO [dbo].[UserSet] ([IdUser], [Email], [DateOfBirth], [Address]) VALUES (6, 'admin@email.com', N'1991-07-31 00:00:00', 'Admini')
SET IDENTITY_INSERT [dbo].[UserSet] OFF

SET IDENTITY_INSERT [dbo].[LoginSet] ON
INSERT INTO [dbo].[LoginSet] ([IdLogin], [Username], [Password], [User_IdUser]) VALUES (1, 'test2', '2', 2)
INSERT INTO [dbo].[LoginSet] ([IdLogin], [Username], [Password], [User_IdUser]) VALUES (2, 'test3', '3', 3)
INSERT INTO [dbo].[LoginSet] ([IdLogin], [Username], [Password], [User_IdUser]) VALUES (3, 'test3', '3', 3)
INSERT INTO [dbo].[LoginSet] ([IdLogin], [Username], [Password], [User_IdUser]) VALUES (4, 'test4', '4', 4)
INSERT INTO [dbo].[LoginSet] ([IdLogin], [Username], [Password], [User_IdUser]) VALUES (5, 'test5', '5', 5)
INSERT INTO [dbo].[LoginSet] ([IdLogin], [Username], [Password], [User_IdUser]) VALUES (6, 'admin', '123', 6)
SET IDENTITY_INSERT [dbo].[LoginSet] OFF

SET IDENTITY_INSERT [dbo].[StatisticsSet] ON
INSERT INTO [dbo].[StatisticsSet] ([IdStatistic], [NumberofFavorites], [NumberofBookmarks], [LastAppUseDate], [User_IdUser]) VALUES (1, 1, 1, '2015-01-12 00:00:00', 1)
INSERT INTO [dbo].[StatisticsSet] ([IdStatistic], [NumberofFavorites], [NumberofBookmarks], [LastAppUseDate], [User_IdUser]) VALUES (2, 2, 2, '2015-01-12 00:00:00', 1)
INSERT INTO [dbo].[StatisticsSet] ([IdStatistic], [NumberofFavorites], [NumberofBookmarks], [LastAppUseDate], [User_IdUser]) VALUES (3, 3, 3, '2015-01-12 00:00:00', 3)
INSERT INTO [dbo].[StatisticsSet] ([IdStatistic], [NumberofFavorites], [NumberofBookmarks], [LastAppUseDate], [User_IdUser]) VALUES (4, 4, 4, '2015-01-12 00:00:00', 4)
INSERT INTO [dbo].[StatisticsSet] ([IdStatistic], [NumberofFavorites], [NumberofBookmarks], [LastAppUseDate], [User_IdUser]) VALUES (5, 5, 5, '2015-01-12 00:00:00', 5)
INSERT INTO [dbo].[StatisticsSet] ([IdStatistic], [NumberofFavorites], [NumberofBookmarks], [LastAppUseDate], [User_IdUser]) VALUES (6, 6, 6, '2015-01-12 00:00:00', 6)
SET IDENTITY_INSERT [dbo].[StatisticsSet] OFF

SET IDENTITY_INSERT [dbo].[FavoriteSet] ON
INSERT INTO [dbo].[FavoriteSet] ([IdFavorite], [Book], [Chapter]) VALUES (1, N'Book1', N'Chapter1')
INSERT INTO [dbo].[FavoriteSet] ([IdFavorite], [Book], [Chapter]) VALUES (2, N'Book2', N'Chapter2')
INSERT INTO [dbo].[FavoriteSet] ([IdFavorite], [Book], [Chapter]) VALUES (3, N'Book3', N'Chapter3')
INSERT INTO [dbo].[FavoriteSet] ([IdFavorite], [Book], [Chapter]) VALUES (4, N'Book4', N'Chapter4')
INSERT INTO [dbo].[FavoriteSet] ([IdFavorite], [Book], [Chapter]) VALUES (5, N'Book5', N'Chapter5')
INSERT INTO [dbo].[FavoriteSet] ([IdFavorite], [Book], [Chapter]) VALUES (6, N'Book6', N'Chapter6')
SET IDENTITY_INSERT [dbo].[FavoriteSet] OFF

SET IDENTITY_INSERT [dbo].[eBookSet] ON
INSERT INTO [dbo].[eBookSet] ([IdeBook], [Language], [Category], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (1, 'PT', 'Drama', NULL, NULL)
INSERT INTO [dbo].[eBookSet] ([IdeBook], [Language], [Category], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (2, 'PT', 'Drama', NULL, NULL)
INSERT INTO [dbo].[eBookSet] ([IdeBook], [Language], [Category], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (3, 'PT', 'Drama', NULL, NULL)
INSERT INTO [dbo].[eBookSet] ([IdeBook], [Language], [Category], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (4, 'PT', 'Drama', NULL, NULL)
INSERT INTO [dbo].[eBookSet] ([IdeBook], [Language], [Category], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (5, 'PT', 'Drama', NULL, NULL)
INSERT INTO [dbo].[eBookSet] ([IdeBook], [Language], [Category], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (6, 'PT', 'Drama', NULL, NULL)
SET IDENTITY_INSERT [dbo].[eBookSet] OFF

SET IDENTITY_INSERT [dbo].[eBookTitlesSet] ON
INSERT INTO [dbo].[eBookTitlesSet] ([Title], [IdTitles], [eBook_IdeBook]) VALUES (N'Book1', 1, 1)
INSERT INTO [dbo].[eBookTitlesSet] ([Title], [IdTitles], [eBook_IdeBook]) VALUES (N'Book2', 2, 2)
INSERT INTO [dbo].[eBookTitlesSet] ([Title], [IdTitles], [eBook_IdeBook]) VALUES (N'Book3', 3, 3)
INSERT INTO [dbo].[eBookTitlesSet] ([Title], [IdTitles], [eBook_IdeBook]) VALUES (N'Book4', 4, 4)
INSERT INTO [dbo].[eBookTitlesSet] ([Title], [IdTitles], [eBook_IdeBook]) VALUES (N'Book5', 5, 5)
INSERT INTO [dbo].[eBookTitlesSet] ([Title], [IdTitles], [eBook_IdeBook]) VALUES (N'Book6', 6, 6)
SET IDENTITY_INSERT [dbo].[eBookTitlesSet] OFF

SET IDENTITY_INSERT [dbo].[eBookPublisherSet] ON
INSERT INTO [dbo].[eBookPublisherSet] ([Name], [IdPublisher], [eBook_IdeBook]) VALUES (N'PUBTEST1', 1, 1)
INSERT INTO [dbo].[eBookPublisherSet] ([Name], [IdPublisher], [eBook_IdeBook]) VALUES (N'PUBTEST2', 2, 2)
INSERT INTO [dbo].[eBookPublisherSet] ([Name], [IdPublisher], [eBook_IdeBook]) VALUES (N'PUBTEST3', 3, 3)
INSERT INTO [dbo].[eBookPublisherSet] ([Name], [IdPublisher], [eBook_IdeBook]) VALUES (N'PUBTEST4', 4, 4)
INSERT INTO [dbo].[eBookPublisherSet] ([Name], [IdPublisher], [eBook_IdeBook]) VALUES (N'PUBTEST5', 5, 5)
INSERT INTO [dbo].[eBookPublisherSet] ([Name], [IdPublisher], [eBook_IdeBook]) VALUES (N'PUBTEST6', 6, 6)
SET IDENTITY_INSERT [dbo].[eBookPublisherSet] OFF

SET IDENTITY_INSERT [dbo].[eBookAuthorsSet] ON
INSERT INTO [dbo].[eBookAuthorsSet] ([Name], [IdAuthors], [eBook_IdeBook]) VALUES (N'Auth1', 1, 1)
INSERT INTO [dbo].[eBookAuthorsSet] ([Name], [IdAuthors], [eBook_IdeBook]) VALUES (N'Auth2', 2, 2)
INSERT INTO [dbo].[eBookAuthorsSet] ([Name], [IdAuthors], [eBook_IdeBook]) VALUES (N'Auth3', 3, 3)
INSERT INTO [dbo].[eBookAuthorsSet] ([Name], [IdAuthors], [eBook_IdeBook]) VALUES (N'Auth4', 4, 4)
INSERT INTO [dbo].[eBookAuthorsSet] ([Name], [IdAuthors], [eBook_IdeBook]) VALUES (N'Auth5', 5, 5)
INSERT INTO [dbo].[eBookAuthorsSet] ([Name], [IdAuthors], [eBook_IdeBook]) VALUES (N'Auth6', 6, 6)
SET IDENTITY_INSERT [dbo].[eBookAuthorsSet] OFF

SET IDENTITY_INSERT [dbo].[BookmarkSet] ON
INSERT INTO [dbo].[BookmarkSet] ([IdBookmark], [Book], [Chapter], [User_IdUser]) VALUES (1, N'1', N'1', 1)
INSERT INTO [dbo].[BookmarkSet] ([IdBookmark], [Book], [Chapter], [User_IdUser]) VALUES (2, N'2', N'2', 2)
INSERT INTO [dbo].[BookmarkSet] ([IdBookmark], [Book], [Chapter], [User_IdUser]) VALUES (3, N'3', N'3', 3)
INSERT INTO [dbo].[BookmarkSet] ([IdBookmark], [Book], [Chapter], [User_IdUser]) VALUES (4, N'4', N'4', 4)
INSERT INTO [dbo].[BookmarkSet] ([IdBookmark], [Book], [Chapter], [User_IdUser]) VALUES (5, N'5', N'5', 5)
INSERT INTO [dbo].[BookmarkSet] ([IdBookmark], [Book], [Chapter], [User_IdUser]) VALUES (6, N'6', N'6', 6)
SET IDENTITY_INSERT [dbo].[BookmarkSet] OFF

SET IDENTITY_INSERT [dbo].[ChapterSet] ON
INSERT INTO [dbo].[ChapterSet] ([IdChapter], [Title], [eBook_IdeBook], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (1, N'Test1', 1, 1, 1)
INSERT INTO [dbo].[ChapterSet] ([IdChapter], [Title], [eBook_IdeBook], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (2, N'Test2', 2, 2, 2)
INSERT INTO [dbo].[ChapterSet] ([IdChapter], [Title], [eBook_IdeBook], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (3, N'Test3', 3, 3, 3)
INSERT INTO [dbo].[ChapterSet] ([IdChapter], [Title], [eBook_IdeBook], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (4, N'Test4', 4, 4, 4)
INSERT INTO [dbo].[ChapterSet] ([IdChapter], [Title], [eBook_IdeBook], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (5, N'Test5', 5, 5, 5)
INSERT INTO [dbo].[ChapterSet] ([IdChapter], [Title], [eBook_IdeBook], [Bookmark_IdBookmark], [Favorite_IdFavorite]) VALUES (6, N'Test6', 6, 6, 6)
SET IDENTITY_INSERT [dbo].[ChapterSet] OFF