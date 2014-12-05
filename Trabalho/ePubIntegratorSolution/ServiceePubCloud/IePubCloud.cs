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
        XmlDocument GetUserStatistics(int userID);

        ////Returns XML Document with all statistics.
        [OperationContract]
        XmlDocument GetGlobalStatistics();

        //Receives a user id and a XML Document with the user's statistics.
        [OperationContract]
        void AddUserStatistics(int user, XmlDocument statistics);

        //TODO: Database only available to webservice, needs to receive fields.
        [OperationContract]
        void RegistereBook(XmlDocument bookinfo);

        [OperationContract]
        void RegisterUser(string username, string password);

        [OperationContract]
        void AddBookmark(int ebookID, int chapterID);

        [OperationContract]
        void AddFavorite(int ebookID, int chapterID);
        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        
    }
}
