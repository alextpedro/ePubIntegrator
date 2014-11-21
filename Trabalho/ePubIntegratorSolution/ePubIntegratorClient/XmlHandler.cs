using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ePubIntegratorClient
{
    class XmlHandler
    {
        String _xmlPath;
        String _xsdPath;
        String _validatemessage;
        bool _isvalid;

        private String xmlPath;
        public XmlHandler(String xmlPath, String xsdPath)
        {
            _xmlPath = xmlPath;
            _xsdPath = xsdPath;
        }

        public XmlHandler(String xmlPath)
        {
            _xmlPath = xmlPath;
        }

        public XmlDocument openXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_xmlPath);
            return xmlDoc;
        }

        public bool ValidateXML()
        {
            _isvalid = true;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(_xmlPath);
                ValidationEventHandler eventXML = new ValidationEventHandler(myValidateEvent);
                doc.Schemas.Add(null, _xsdPath);
                doc.Validate(eventXML);
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
                    _validatemessage = String.Format("[ERROR] {0}", args.Message);
                    break;
                case XmlSeverityType.Warning:
                    _validatemessage = String.Format("[WARNING] {0}", args.Message);
                    break;
            }
        }
    }
}
