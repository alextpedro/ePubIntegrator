using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ePubCloudDatabaseLibrary;
using System.Xml;

namespace ServiceePubCloud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceePubCloud : IePubCloud
    {

        public System.Xml.XmlDocument GetUserStatistics(int userID)
        {
            //Remove this once done. It causes the warnings.
            throw new NotImplementedException();

            //TODO: All of it.
            //Create new XML document
            XmlDocument statistics = new XmlDocument();

            //Access the database
            DatabaseHandler.GetUserStatistics(userID);
        }

        public Boolean VerifyLogin(string username, string password) {
            return DatabaseHandler.ValidateLogin(string username, string password);
        }

        public System.Xml.XmlDocument GetGlobalStatistics()
        {
            throw new NotImplementedException();
        }

        public void AddUserStatistics(int user, System.Xml.XmlDocument statistics)
        {
            throw new NotImplementedException();
        }

        public void RegistereBook(eBdb.EpubReader.Epub newebook)
        {
            DatabaseHandler.RegistereBook(newebook);
        }

        public void RegisterUser(string username, string password, string email, string address, DateTime birthdate)
        {
            DatabaseHandler.AddUserWLogin(username, password, email, address, birthdate);
        }

        public void AddBookmark(int ebookID, int chapterID)
        {
            throw new NotImplementedException();
        }

        public void AddFavorite(int ebookID, int chapterID)
        {
            throw new NotImplementedException();
        }

        public System.Xml.XmlDocument GetBookmarks(int userID, int eBookID)
        {
            throw new NotImplementedException();
        }

        public System.Xml.XmlDocument GetFavorites(int userID, int eBookID)
        {
            throw new NotImplementedException();
        }


        public void RegistereBook(XmlDocument bookinfo)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(XmlDocument newUserInfo)
        {
            throw new NotImplementedException();
        }
    }
}
