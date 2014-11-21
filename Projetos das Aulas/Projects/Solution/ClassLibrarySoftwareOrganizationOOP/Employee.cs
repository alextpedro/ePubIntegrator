using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrarySoftwareOrganizationOOP
{
    public class Employee : Person
    {
        private double _salary;

        public Employee(string fn, string ln, DateTime dn, double sal)
            : base(fn, ln, dn)
        {
            _salary = sal;
        }

        public virtual double Salary
        {
            get { return _salary; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
