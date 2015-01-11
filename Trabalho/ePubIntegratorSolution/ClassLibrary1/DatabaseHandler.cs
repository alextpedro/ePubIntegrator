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

			//Create nodes of document <-- Decide on document structure
			XmlElement root = stats.CreateElement("statistics");
			stats.AppendChild(root);

			//Search database for user statistics 
			//int numberofFavorites = context.StatisticsSet;

			//Write statistics to document

			//return document
			return stats;

		}

		public static void RegistereBook(string title, string author, string language, string category)
		{
			//eBook ebook = new eBook();
			//ebook.Language = neweBook.Language.ToString(); //Maybe the database needs to handle multiple languages?
			//ebook.Category = neweBook.Subject.ToString(); //Maybe several categories

			//foreach (string title in neweBook.Title)
			//{
			//	eBookTitles newTitle = new eBookTitles();
			//	newTitle.Title = title;
			//	context.eBookTitlesSet.Add(newTitle);

			//	ebook.eBookTitles.Add(newTitle);
			//}
			
			//foreach (string author in neweBook.Contributer)
			//{
			//	eBookAuthors newAuthor = new eBookAuthors();
			//	newAuthor.Name = author;
			//	context.eBookAuthorsSet.Add(newAuthor);

			//	ebook.eBookAuthors.Add(newAuthor);

			//}

			//foreach (string publisher in neweBook.Publisher)
			//{
			//	eBookPublisher newPublisher = new eBookPublisher();
			//	newPublisher.Name = publisher;
			//	context.eBookPublisherSet.Add(newPublisher);

			//	ebook.eBookPublisher.Add(newPublisher);
			//}


			//context.eBookSet.Add(ebook);
			//context.SaveChanges();
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
	}
}
