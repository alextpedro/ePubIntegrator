﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ClassLibraryePub
{
    class MyXmlHandler
    {
        String _xmlPath;
        String _xsdPath;
        String _validateMessage;
        bool _isvalid;

        private String xmlPath;
        public MyXmlHandler(String _xmlPath, String xsdPath)
        {
            _xmlPath = xmlPath;
            _xsdPath = xsdPath;
        }

        /*
        public MyXmlHandler(String xmlPath)
        {
            _xmlPath = xmlPath;
        }
        */
        /*
        public XmlDocument openXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_xmlPath);
            return xmlDoc;
        } 
         */

        //properties

        public String ValidateMessage
        {
            get
            {
                return _validateMessage;
            }
        }

        //so é chamada se houver algum erro com os ficheiros
        public bool ValidateXML()
        {
            _isvalid = true;
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(_xmlPath); //load do xml file
                ValidationEventHandler eventXML = new ValidationEventHandler(myValidateEvent);
                xmldoc.Schemas.Add(null, _xsdPath);
                xmldoc.Validate(eventXML);
            }
            catch (XmlException ex)
            {
                _isvalid = false;
            }

            return _isvalid;
        }

        private void myValidateEvent(Object sender, ValidationEventArgs args)
        {
            _isvalid = false;
            switch (args.Severity)
            {
                case XmlSeverityType.Error:
                    _validateMessage = String.Format("[ERROR] {0}", args.Message);
                    break;
                case XmlSeverityType.Warning:
                    _validateMessage = String.Format("[WARNING] {0}", args.Message);
                    break;
            }
        }

        public void saveXML()
        {

        }


        private void createXmlDoc() {

            XmlDocument xmldoc = new XmlDocument();

            //create root node
            XmlNode rootNode = xmldoc.CreateElement("ePub");
            xmldoc.AppendChild(rootNode);

            //xml declaration
            XmlDeclaration xmlDecla = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmldoc.InsertBefore(xmlDecla, rootNode);

            //user
            XmlNode userNode = xmldoc.CreateElement("user");
            XmlAttribute attUsername = xmldoc.CreateAttribute("username");
            attUsername.Value = "pires123";
            userNode.Attributes.Append(attUsername);
            rootNode.AppendChild(userNode);
            //ebook
            XmlNode ebookNode = xmldoc.CreateElement("ebook");
            XmlAttribute attCategory = xmldoc.CreateAttribute("category");
            attCategory.Value = "Fantasy";
            ebookNode.Attributes.Append(attCategory);
            userNode.AppendChild(ebookNode);
            //titles(1 or more)
            XmlNode titlesNode= xmldoc.CreateElement("titles");
            ebookNode.AppendChild(titlesNode);
            XmlNode _title= xmldoc.CreateElement("title");
            _title.InnerText="Harry Potter";
            titlesNode.AppendChild(_title);
            //authors(1 or more)
            XmlNode authorsNode = xmldoc.CreateElement("authors");
            ebookNode.AppendChild(authorsNode);
            XmlNode _author= xmldoc.CreateElement("author");
            _author.InnerText="JKR";
            authorsNode.AppendChild(_author);
            //publishers(1 or more)
            XmlNode publishersNode = xmldoc.CreateElement("publishers");
            ebookNode.AppendChild(publishersNode);
            XmlNode _publisher = xmldoc.CreateElement("publisher");
            _publisher.InnerText = "eReading";
            publishersNode.AppendChild(_publisher);
            //subject
            XmlNode subjectNode = xmldoc.CreateElement("subject");
            subjectNode.InnerText = "An Unforgetable Story";
            ebookNode.AppendChild(subjectNode);
            //favourite
            XmlNode favouriteNode = xmldoc.CreateElement("favourite");
            ebookNode.AppendChild(favouriteNode);

            XmlNode dateNode = xmldoc.CreateElement("date");
            dateNode.InnerText = "2-12-2014";
            favouriteNode.AppendChild(dateNode);
            //bookmark
            XmlNode bookmarkNode = xmldoc.CreateElement("bookmark");
            ebookNode.AppendChild(bookmarkNode);

            dateNode.InnerText = "";
            bookmarkNode.AppendChild(dateNode);

            //chapters
            XmlNode chapterNode = xmldoc.CreateElement("chapter");
            chapterNode.InnerText = "Chapter 1";
            ebookNode.AppendChild(chapterNode);
            
            chapterNode.AppendChild(favouriteNode);

            dateNode.InnerText = "";
            favouriteNode.AppendChild(dateNode);
          
            ebookNode.AppendChild(bookmarkNode);

            dateNode.InnerText = "15-11-2014";
            bookmarkNode.AppendChild(dateNode);

            xmldoc.Save("C:\\Users\\Files\\document.xml");
        }

    }
}