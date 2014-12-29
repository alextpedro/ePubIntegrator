using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ePubIntegratorClient
{
    public class BookFavHandler
    {
        private String _xmlPath;
        private XmlDocument _xmldoc;

        //variaveis constantes
        private const string FILE = "/bookfav.xml";
        private const string ROOTNODE = "/ePub/";
        private const string FAV = "favourite";
        private const string BMRK = "bookmark";

        public BookFavHandler()
        {
            String path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            _xmlPath = path + FILE;
            _xmldoc = new XmlDocument();
            _xmldoc.Load(_xmlPath);
        }

        //guarda o XML
        private void saveXML()
        {
            //NÃO ESQUECER - FALTA VALIDAR XML E MARCAR UPDATE-TIME
            _xmldoc.Save(_xmlPath);
        }

        //---------Manipular Utilizadores
        //Verifica se o utilizador ja está registado no XML
        private Boolean isUserValid(String user)
        {
            if (_xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']") != null) return true;
            else return false;
        }
        
        //Cria um utilizador user no XML asseguir ao ePub
        private void createUser(String user)
        {
            XmlElement root = _xmldoc.DocumentElement;
            XmlNode userNode = _xmldoc.CreateElement("user");
            XmlAttribute attUsername = _xmldoc.CreateAttribute("username");
            attUsername.Value = user;
            userNode.Attributes.Append(attUsername);
            root.AppendChild(userNode);
            saveXML();
        }

        //---------Manipular Livros
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

        //---------Manipular Favoritos e Bookmarks
        //retorna ou o favorito ou o bookmark de acordo com o ultimo parâmetro
        private bool getFavBmrkValue(string user, Book book, String value)
        {
            try
            {            
                String xpathstr = ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/"+value;
                return Convert.ToBoolean(_xmldoc.SelectSingleNode(xpathstr).Attributes[1].Value);
            }
            catch (Exception)
            {
                return false;
            }
        }

        //chama getFavBmrkValue para obter bookmark
        public bool getBmrkValue(string user, Book book)
        {
            return getFavBmrkValue(user, book, BMRK);
        }

        //chama getFavBmrkValue para obter vavorito
        public bool getFavValue(string user, Book book)
        {
            return getFavBmrkValue(user, book, FAV);
        }

        //gera nodes caso não existam
        private void generateNodes(String user, Book book, String nodeName)
        {
            if (!(isUserValid(user))) createUser(user); //se o utilizador não existir criar novo user no XML.
            if (!(isBookListed(user, book))) createBook(user, book); //se o livro não existir criar novo
            if (!(bookHasFavBmrkNode(user, book, nodeName))) createFavBmrkNode(user, book, nodeName); //se não existir favorito/bookmark no livro do utilizador criar novo
        }

        //actualiza o o node expecificado com o valor(value) passado por parâmetro
        public void updateFavBmrk(String user, Book book, Boolean value, String nodeName)
        {
            //verificar data antes do update
            DateTime timeNow = System.DateTime.Now; //recolher data do momento
            DateTime timeXML = Convert.ToDateTime(_xmldoc.SelectSingleNode(ROOTNODE + "@updated").Value); //recolher data do XML
            if (timeNow >= timeXML) //verificar se vale a pena fazer update caso desactualizado
            {
                generateNodes(user, book, nodeName);

                String xpathstr = ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/"+nodeName;

                _xmldoc.SelectSingleNode(xpathstr).Attributes[0].Value = DateTime.Now.ToString();
                _xmldoc.SelectSingleNode(xpathstr).Attributes[1].Value = value.ToString();

                System.Diagnostics.Debug.WriteLine("[DEBUG] A "+nodeName+" update called on bookfav.xml");
                saveXML();
            }
        }

        //verifica no utilizador e no livro se o node existe
        private bool bookHasFavBmrkNode(string user, Book book, String nodeName)
        {
            if (_xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/"+nodeName+"[@global]") != null) return true;
            else return false;
        }

        //cria um node no xml com o nome passado por parâmetro, adiciona tempo de update e o global
        private void createFavBmrkNode(string user, Book book, String nodeName)
        {
            XmlNode node = _xmldoc.CreateElement(nodeName);
            XmlAttribute attUpdated = _xmldoc.CreateAttribute("updated");
            XmlAttribute attGlobal = _xmldoc.CreateAttribute("global");
            attUpdated.Value = DateTime.Now.ToString();
            attGlobal.Value = "False";
            node.Attributes.Append(attUpdated);
            node.Attributes.Append(attGlobal);
            _xmldoc.SelectSingleNode(ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']").AppendChild(node);
            saveXML();
        }

        //---------Manipular Capítulos
        //procura pelo capítulo introduzido em favoritos ou bookmarks

        public void updateChapterNode(string user, Book book, String nodeName, String chapterName, Boolean value)
        {
            //verificar data antes do update
            DateTime timeNow = System.DateTime.Now; //recolher data do momento
            DateTime timeXML = Convert.ToDateTime(_xmldoc.SelectSingleNode(ROOTNODE + "@updated").Value); //recolher data do XML
            if (timeNow >= timeXML) //verificar se vale a pena fazer update caso desactualizado
            {
                generateNodes(user, book, nodeName);
                String xpathstr = "";
                if (!value)
                {//se existir = delete chapter
                    xpathstr = ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/" + nodeName;
                    XmlNode nodeToRemove = _xmldoc.SelectSingleNode(xpathstr + "/chapter[text()='"+chapterName+"']");
                    _xmldoc.SelectSingleNode(xpathstr).RemoveChild(nodeToRemove);
                }
                else
                {//se não existir = criar chapter
                    xpathstr = ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/" + nodeName;
                    XmlNode chapterElement = _xmldoc.CreateElement("chapter");
                    chapterElement.InnerText = chapterName;
                    _xmldoc.SelectSingleNode(xpathstr).AppendChild(chapterElement);
                }
                System.Diagnostics.Debug.WriteLine("[DEBUG] A " + nodeName + " update to " + chapterName + " called on bookfav.xml");
                saveXML();
            }
        }

        private bool getChapterValue(string user, Book book, string type, string chapter)
        {
            String xpathstr = ROOTNODE + "user[@username='" + user + "']/ebook[@hash='" + book.Hash + "']/" + type + "/chapter";
            List<String> chapterlist = new List<String>();
            XmlNodeList nodeList = _xmldoc.SelectNodes(xpathstr);
            Boolean value = false;
            foreach (XmlNode node in nodeList)
            {
                if (node.InnerText == chapter) value = true;
            }
            return value;
        }

        public bool getFavChapterValue(string user, Book book, string chapter)
        {
            return getChapterValue(user, book, FAV, chapter);
        }

        public bool getBmrkChapterValue(string user, Book book, string chapter)
        {
            return getChapterValue(user, book, BMRK, chapter);
        }
    }
}
