using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrarySoftwareOrganizationOOP
{
    public class Customer : Person
    {
        private string _address;

        public Customer(string fn, string ln, DateTime dn, string adr) 
            : base(fn,ln,dn) //base = super
        {
            _address = adr;
        }

        public string Address
        {
            get { return _address; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Morada :" + Address);
        }
    }
}
