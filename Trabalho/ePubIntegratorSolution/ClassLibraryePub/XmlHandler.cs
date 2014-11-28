using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ClassLibraryePub
{
    class XmlHandler
    {
        String _xmlPath;
        String _xsdPath;
        String _validateMessage;
        bool _isvalid;

        private String xmlPath;
        public XmlHandler(String _xmlPath, String xsdPath)
        {
            _xmlPath = xmlPath;
            _xsdPath = xsdPath;
        }

        /*
        public XmlHandler(String xmlPath)
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
    }
}
