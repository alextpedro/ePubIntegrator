using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySoftwareOrganizationOOP
{
    public abstract class Person : IPrintable
    {
        DateTime _birthdate;
        string _firstname, _lastname;

        public Person()
        {
        }

        public Person(string fn, string ln, DateTime dn)
        {
            _firstname = fn;
            _lastname = ln;
            _birthdate = dn;
        }

        public string FullName
        {
            get { return _firstname + " " + _lastname; }
        } 

        public double Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - _birthdate.Year;
                if (_birthdate > today.AddYears(-age)) age--;
                return age;
            }
        }

        public virtual void Print()
        { 
            Console.WriteLine("Nome Completo: " + FullName);
            Console.WriteLine("Idade: " + Age);
        }
    }
}
