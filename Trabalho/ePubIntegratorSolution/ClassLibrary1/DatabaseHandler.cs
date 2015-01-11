using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBdb.EpubReader;
using System.Xml;


namespace ePubCloudDatabaseLibrary
{
	public static class DatabaseHandler
	{
		static ServiceePubModelContainer context = new ServiceePubModelContainer();

		public static Boolean AddUserWLogin(string username, string password, string email, string address, DateTime birthdate)
		{
			try
			{
				Login l = context.LoginSet.Where(i => i.Username == username).FirstOrDefault();
				if (l == null && username != null && password != null)
				{
					User newUser = new User();
					newUser.Email = email;
					newUser.Address = address;
					newUser.DateOfBirth = birthdate;

					Login newLogin = new Login();
					newLogin.Username = username;
					newLogin.Password = password;
					newLogin.User = newUser;

					context.UserSet.Add(newUser);
					context.LoginSet.Add(newLogin);

					context.SaveChanges();

					if (context.LoginSet.Where(i => i.Username == username).FirstOrDefault() != null)
					{
						return true;
					}
					else
					{
						return false;
					}

				}
				else
				{
					throw new TaskCanceledException("User already exists!");
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
				return false;
			}
			
		}


		public static XmlDocument GetUserStatistics(string username)
		{
			//Create a document
			XmlDocument stats = new XmlDocument();
			XmlDeclaration decl = stats.CreateXmlDeclaration("1.0", null, null);
			stats.AppendChild(decl);

			//Create root of document
			XmlElement root = stats.CreateElement("statistics");
			stats.AppendChild(root);

			//Search database for user statistics 
			User user = context.LoginSet.Where(i => i.Username == username).FirstOrDefault().User;
			Statistics statsList = context.StatisticsSet.Where(i => i.User == user).FirstOrDefault();

			//Write statistics to document
			XmlElement numOfFavs = stats.CreateElement("numberOfFavorites");
			numOfFavs.InnerText = statsList.NumberofFavorites.ToString();

			XmlElement numOfBookmarks = stats.CreateElement("numberOfBookmarks");
			numOfBookmarks.InnerText = statsList.NumberofBookmarks.ToString();

			root.AppendChild(numOfFavs);
			root.AppendChild(numOfBookmarks);

			//return document
			return stats;

		}

		public static Boolean RegistereBook(string title, string author, string language, string category, string publisher)
		{
			//Verify if similarly titled ebook already exists in database
			eBookTitles b = context.eBookTitlesSet.Where(i => i.Title == title).FirstOrDefault();

			if (b != null)
			{
				//Create new eBook
				eBook neweBook = new eBook();
				neweBook.Language = language;
				neweBook.Category = category;

				//Create new Title, Author and Publisher lists
				eBookTitles titleList = new eBookTitles();
				titleList.Title = title;
				titleList.eBook = neweBook;

				eBookAuthors authorsList = new eBookAuthors();
				authorsList.Name = author;
				authorsList.eBook = neweBook;

				eBookPublisher publisherList = new eBookPublisher();
				publisherList.Name = publisher;
				publisherList.eBook = neweBook;

				//Add to database
				context.eBookTitlesSet.Add(titleList);
				context.eBookAuthorsSet.Add(authorsList);
				context.eBookPublisherSet.Add(publisherList);
				context.eBookSet.Add(neweBook);

				context.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}

			
		}

		public static Boolean ValidateLogin(string username, string password) {
			/*See if user exists*/
			Login l = context.LoginSet.Where(i => i.Username == username).FirstOrDefault();

			/*If the user exists verify that both the username and the password given match the database and return true. 
			 * If they don't or if the user does not exist return false*/
			if (l != null)
			{
				if (l.Username == username && l.Password == password)
				{
					return true;
				}

				return false;
			}
				
			return false;
		}

		public static XmlDocument getGlobalStats()
		{
			//Create document
			XmlDocument globalStats = new XmlDocument();
			XmlDeclaration decl = globalStats.CreateXmlDeclaration("1.0", null, null);
			globalStats.AppendChild(decl);

			XmlElement root = globalStats.CreateElement("statistics");
			globalStats.AppendChild(root);

			List<Statistics> listStats = context.StatisticsSet.ToList();
			int globalNumOfFavs = 0;
			int globalNumOfBookmarks = 0;

			foreach (Statistics statistic in listStats)
			{
				globalNumOfFavs += statistic.NumberofFavorites;
				globalNumOfBookmarks += statistic.NumberofBookmarks;
			}

			//Add stats to document
			XmlElement numFavs = globalStats.CreateElement("numberOfFavorites");
			numFavs.InnerText = globalNumOfFavs.ToString();

			XmlElement numBookmarks = globalStats.CreateElement("numberOfBookmarks");
			numBookmarks.InnerText = globalNumOfBookmarks.ToString();

			root.AppendChild(numFavs);
			root.AppendChild(numFavs);

			return globalStats;
		}

		public static Boolean AddUserStatistics(string username, XmlDocument statistics)
		{
			//Find user through username
			Login l = context.LoginSet.Where(i => i.Username == username).FirstOrDefault();
			User user = l.User;

			//Check if user has Statistics already
			//If yes, replace with new ones
			//If no, create new user statistics from file
			Statistics userStats = context.StatisticsSet.Where(i => i.User == user).FirstOrDefault();
			if (userStats != null)
			{
				userStats.NumberofFavorites = Convert.ToInt32(statistics.SelectSingleNode("statistics/numberOfFavorites").InnerText);
				userStats.NumberofBookmarks = Convert.ToInt32(statistics.SelectSingleNode("statistics/numberOfBookmarks").InnerText);
				return true;
			}
			else
			{
				Statistics newStats = new Statistics();
				newStats.NumberofFavorites = Convert.ToInt32(statistics.SelectSingleNode("statistics/numberOfFavorites").InnerText);
				newStats.NumberofBookmarks = Convert.ToInt32(statistics.SelectSingleNode("statistics/numberOfBookmarks").InnerText);
				newStats.User = user;

				context.StatisticsSet.Add(newStats);
				context.SaveChanges();
			}
			return false;
		}

		public static bool AddBookmark(string ebookTitle, string chapterTitle)
		{
			//Find ebook through title
			eBook ebook = context.eBookTitlesSet.Where(i => i.Title == ebookTitle).FirstOrDefault().eBook;

			if (ebook != null)
			{
				Bookmark bookmark = new Bookmark();
				bookmark.Book = ebookTitle;
				bookmark.eBook = ebook;
				bookmark.Chapter = chapterTitle;
				bookmark.ChapterMark = context.ChapterSet.Where(i => i.Title == chapterTitle).FirstOrDefault();

				ebook.Bookmark = bookmark;

				context.BookmarkSet.Add(bookmark);
				context.SaveChanges();

				return true;
			}
			else return false;
		}

		public static bool AddFavorite(string ebookTitle, string chapterTitle)
		{
			//Find ebook through title
			eBook ebook = context.eBookTitlesSet.Where(i => i.Title == ebookTitle).FirstOrDefault().eBook;

			if (ebook != null)
			{
				Favorite fav = new Favorite();
				fav.Book = ebookTitle;
				fav.eBook = ebook;
				fav.Chapter = chapterTitle;
				fav.ChapterMark = context.ChapterSet.Where(i => i.Title == chapterTitle).FirstOrDefault();

				ebook.Favorite = fav;

				context.FavoriteSet.Add(fav);
				context.SaveChanges();

				return true;
			}
			else return false;
		}
	}
}
