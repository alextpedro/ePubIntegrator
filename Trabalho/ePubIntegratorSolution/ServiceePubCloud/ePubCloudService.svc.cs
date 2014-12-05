using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceePubCloud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IePubCloud
    {

        public System.Xml.XmlDocument GetUserStatistics(int userID)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void RegisterUser(string username, string password)
        {
            throw new NotImplementedException();
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


        int GetBookmarks(int userID, int eBookID)
        {
            
        }

        [OperationContract]
        int GetFavorites(int userID, int eBookID);

        [OperationContract]
        int GeteBookIDbyTitle(string title);

        [OperationContract]
        int GeteBookIDbyAuthor(string author);
    }
}
