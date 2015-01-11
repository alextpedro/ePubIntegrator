using ePubCloudDatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace ServiceePubCloud
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class ServiceePubCloud : IePubCloud
	{

		public System.Xml.XmlDocument GetUserStatistics(string username)
		{
			XmlDocument userStats = DatabaseHandler.GetUserStatistics(username);
			return userStats;
		}

		public Boolean VerifyLogin(string username, string password) {
			return DatabaseHandler.ValidateLogin(username, password);
		}

		public System.Xml.XmlDocument GetGlobalStatistics()
		{
			XmlDocument globalStats = DatabaseHandler.getGlobalStats();
			return globalStats;
		}

		public Boolean AddUserStatistics(string username, XmlDocument statistics)
		{
			if (DatabaseHandler.AddUserStatistics(username, statistics))
			{
				return true;
			}
			else return false;
		}

		public Boolean RegistereBook(string title, string author, string language, string category, string publisher)
		{
			if (DatabaseHandler.RegistereBook(title, author, language, category, publisher))
				return true;
			else return false;
		}

		public Boolean RegisterUser(string username, string password, string email, string address, DateTime birthdate)
		{
			if (DatabaseHandler.AddUserWLogin(username, password, email, address, birthdate))
				return true;
			else 
				return false;
		}

		public Boolean isWebServiceUp()
		{
			return true;
		}

		public Boolean AddBookmark(string ebookTitle, string chapterTitle)
		{
			if (DatabaseHandler.AddBookmark(ebookTitle, chapterTitle))
				return true;
			else return false;
		}

		public Boolean AddFavorite(string ebookTitle, string chapterTitle)
		{
			if (DatabaseHandler.AddFavorite(ebookTitle, chapterTitle))
				return true;
			else return false;
		}
	}
}
