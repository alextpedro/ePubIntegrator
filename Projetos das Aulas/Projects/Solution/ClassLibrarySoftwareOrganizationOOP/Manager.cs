using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrarySoftwareOrganizationOOP
{
    public class Manager : Employee
    {
        private List<Programmer> _programmers;

        public Manager(string fn, string ln, DateTime dn, double sal)
            : base(fn, ln, dn, sal)
        {
            _programmers = new List<Programmer>();
        }

        public int NumberOfProgrammers
        {
            get { return _programmers.Count; }
        }

        public Programmer this[int index]
        {
            get { return _programmers[index]; }
        }

        public void AddProgrammer(Programmer newProgrammer)
        {
            if (newProgrammer!=null) _programmers.Add(newProgrammer); 
        }

        public override void Print()
        {
            base.Print();
            foreach (Programmer programmer in _programmers)
            {
                programmer.Print();
            }
        }
    }
}
