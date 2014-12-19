using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ePubIntegratorClient
{
    public class ConfigHandler
    {

        private String _xmlPath;
        private XmlDocument _xmldoc;
        private const string FILE = "/userconfig.xml";
        private const string ROOTNODE = "/config/";


        public ConfigHandler(String xmlPath)
        {
            _xmlPath = xmlPath + FILE;
            _xmldoc = new XmlDocument();
            _xmldoc.Load(_xmlPath);
        }

        public void loginUser(String user, string server)
        {
            if (!(isUserValid(user))) createUser(user, server); //se o utilizador não existir criar novo user no XML.
            //NAO ESKECER ADICIONAR LASTUSER E SAVE
        }

        //Cria um utilizador user no XML asseguir ao ePub
        private void createUser(String user, String server)
        {
            XmlElement root = _xmldoc.DocumentElement;
            XmlNode userNode = _xmldoc.CreateElement("user");
            XmlNode serverNode = _xmldoc.CreateElement("server");
            XmlNode lastloginNode = _xmldoc.CreateElement("lastlogin");
            XmlAttribute attUsername = _xmldoc.CreateAttribute("username");
            attUsername.Value = user;
            serverNode.Value = server;
            lastloginNode.Value = DateTime.Now.ToString();
            userNode.Attributes.Append(attUsername);
            userNode.AppendChild(serverNode);
            userNode.AppendChild(lastloginNode);
            root.AppendChild(userNode);
            saveXML();
        }

        public String[] getLastUserInfo()
        {
            String user = _xmldoc.SelectSingleNode(ROOTNODE + "[@lastuser]").Value;
            String[] info = null;
            info[0] = user;
            info[1] = _xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']/server").Value; ;
            info[2] = _xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']/lastlogin").Value; ;
            return info;
        }

        public void updateFavorite(String user, Book book, Boolean favorite)
        {
            //verificar data antes do update
            DateTime timeNow = System.DateTime.Now; //recolher data do momento
            DateTime timeXML = Convert.ToDateTime(_xmldoc.SelectSingleNode(ROOTNODE + "@updated").Value); //recolher data do XML
            if (timeNow >= timeXML) //verificar se vale a pena fazer update caso desactualizado
            {
               // if (!(isUserValid(user))) createUser(user); //se o utilizador não existir criar novo user no XML.
                if (!(isBookListed(user, book))) createBook(user, book); //se o livro não existir criar novo
                if (!(bookHasFavNode(user, book))) createFavNode(user, book); //se não existir favorito no livro do utilizador criar novo

                String xpathstr = ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/favourite";

                _xmldoc.SelectSingleNode(xpathstr).Attributes[0].Value = DateTime.Now.ToString();
                _xmldoc.SelectSingleNode(xpathstr).Attributes[1].Value = favorite.ToString();

                System.Diagnostics.Debug.WriteLine("[DEBUG] An update called to favourites...");
                saveXML();
            }
        }

        private void createFavNode(string user, Book book)
        {
            XmlNode favouriteNode = _xmldoc.CreateElement("favourite");
            XmlAttribute attUpdated = _xmldoc.CreateAttribute("updated");
            XmlAttribute attGlobal = _xmldoc.CreateAttribute("global");
            attUpdated.Value = DateTime.Now.ToString();
            attGlobal.Value = "False";
            favouriteNode.Attributes.Append(attUpdated);
            favouriteNode.Attributes.Append(attGlobal);
            _xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']").AppendChild(favouriteNode);
            saveXML();
        }

        //verifica se existe o node para os favoritos
        private bool bookHasFavNode(string user, Book book)
        {
            if (_xmldoc.SelectSingleNode(ROOTNODE + "[@lastuser='" + user + "']/ebook[@hash='" + book.Hash + "']/favourite[@global]") != null) return true;
            else return false;
        }

        //cria um livro com a sua hash associada no utilizador dado
        private void createBook(string user, Book book)
        {
            XmlNode ebookNode = _xmldoc.CreateElement("ebook");
            XmlAttribute attHash = _xmldoc.CreateAttribute("hash");
            attHash.Value = book.Hash.ToString();
            ebookNode.Attributes.Append(attHash);
            _xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']").AppendChild(ebookNode);
            saveXML();
        }

        //Verifica se o livro já se encotra na lista de determinado utilizador
        private bool isBookListed(String user, Book book)
        {
            int hash = book.Hash;// esta hash vai servir de ID para o livro
            if (_xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + hash + "']") != null) return true;
            else return false;
        }

        //Verifica se o utilizador ja está registado no XML
        private Boolean isUserValid(String user)
        {
            if (_xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']") != null) return true;
            else return false;
        }




        private void saveXML()
        {
            //NÃO ESQUECER - FALTA VALIDAR XML E MARCAR UPDATE-TIME
            _xmldoc.Save(_xmlPath);
        }

        internal bool getFavValue(string user, Book book)
        {
            try
            {
                String xpathstr = ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/favourite";
                return Convert.ToBoolean(_xmldoc.SelectSingleNode(xpathstr).Attributes[1].Value);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
