using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrarySoftwareOrganizationOOP
{
    public class Programmer : Employee
    {
        public Programmer(string fn, string ln, DateTime dn, double sal) : base (fn,ln,dn,sal)
        {
        }
    }
}
