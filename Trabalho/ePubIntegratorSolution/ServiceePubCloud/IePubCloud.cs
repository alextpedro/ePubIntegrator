using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using eBdb.EpubReader;

namespace ServiceePubCloud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IePubCloud
    {
        //Returns XML Document with saved user statistics.
        [OperationContract]
        XmlDocument GetUserStatistics(string username);

        ////Returns XML Document with all statistics.
        [OperationContract]
        XmlDocument GetGlobalStatistics();

        //Receives a user id and a XML Document with the user's statistics.
        [OperationContract]
        void AddUserStatistics(int user, XmlDocument statistics);

        //Receives a bookinfo xml and registers the book in the database
        [OperationContract]
        void RegistereBook(Epub newEpub);

        //Receives an XML document with info pertaining to a new user
        [OperationContract]
        void RegisterUser(string username, string password, string email, string address, DateTime birthdate);

        //Adds a new bookmark to a book
        [OperationContract]
        void AddBookmark(int ebookID, int chapterID);

        //Adds a new favorite to a book. 
        [OperationContract]
        void AddFavorite(int ebookID, int chapterID);

        [OperationContract]
        Boolean VerifyLogin(string username, string password);
        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        
    }
}
