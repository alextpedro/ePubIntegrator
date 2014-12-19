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
        private const string ROOTNODE = "/config";


        public ConfigHandler(String xmlPath)
        {
            _xmlPath = xmlPath + FILE;
            _xmldoc = new XmlDocument();
            _xmldoc.Load(_xmlPath);
        }

        public void loginUser(String user, String server)
        {
            if (!(isUserValid(user))) createUser(user, server); //se o utilizador não existir criar novo user no XML.
            _xmldoc.SelectSingleNode(ROOTNODE + "[@lastuser]").Attributes[0].Value = user;
            saveXML();
        }

        //Cria um utilizador user no XML asseguir ao ePub
        private void createUser(String user, String server)
        {
            XmlElement root = _xmldoc.DocumentElement;
            XmlNode userNode = _xmldoc.CreateElement("user");
            XmlNode serverNode = _xmldoc.CreateElement("server");
            XmlNode lastloginNode = _xmldoc.CreateElement("lastlogin");
            XmlAttribute attUsername = _xmldoc.CreateAttribute("username");
            attUsername.InnerText = user;
            serverNode.InnerText = server;
            lastloginNode.InnerText = DateTime.Now.ToString();
            userNode.Attributes.Append(attUsername);
            userNode.AppendChild(serverNode);
            userNode.AppendChild(lastloginNode);
            root.AppendChild(userNode);
            saveXML();
        }

        public List<String> getLastUserInfo()
        {
            String user = _xmldoc.SelectSingleNode(ROOTNODE + "[@lastuser]").Attributes[0].InnerText;
            List<String> info = new List<String>();
            info.Add(user);
            info.Add(_xmldoc.SelectSingleNode(ROOTNODE + "/user[@username='" + user + "']/server").InnerText);
            info.Add(_xmldoc.SelectSingleNode(ROOTNODE + "/user[@username='" + user + "']/lastlogin").InnerText);

            return info;
        }



        //Verifica se o utilizador ja está registado no XML
        private Boolean isUserValid(String user)
        {
            if (_xmldoc.SelectSingleNode(ROOTNODE + "/user[@username='" + user + "']") != null) return true;
            else return false;
        }

        private void saveXML()
        {
            //NÃO ESQUECER - FALTA VALIDAR XML E MARCAR UPDATE-TIME
            _xmldoc.Save(_xmlPath);
        }

        public String getUserBookPath(String user)
        {
            try
            {
                return _xmldoc.SelectSingleNode(ROOTNODE + "/user[@username='" + user + "']/bookpath").InnerText;
            }
            catch (Exception)
            {
                return "";
            }
        }



        internal void setBookPath(string user, string path)
        {
            if (_xmldoc.SelectSingleNode(ROOTNODE + "/user[@username='" + user + "']/bookpath") == null)
            {
                XmlNode bookpathNode = _xmldoc.CreateElement("bookpath");
                bookpathNode.InnerText = path;
                _xmldoc.SelectSingleNode(ROOTNODE + "/user[@username='" + user + "']").AppendChild(bookpathNode);
                saveXML();
            } else _xmldoc.SelectSingleNode(ROOTNODE + "/user[@username='" + user + "']/bookpath").InnerText = path;
            saveXML();
        }
    }
}
