using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrarySoftwareOrganizationOOP
{
    public class PersonAlreadyExistException : System.ApplicationException
    {
        public PersonAlreadyExistException() { }
        protected PersonAlreadyExistException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
    }
}
