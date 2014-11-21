using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ClassLibrarySoftwareOrganizationOOP
{
    public class Persons : Collection<Person>
    {

        public Persons()
        {
        }

        public Person this[int index]
        {
            get { return base[index]; }
        }

        public void AddPerson(Person personToAdd) 
        {
            try
            {
                base.Add(personToAdd);
            }
            catch (PersonAlreadyExistException)
            {

            }
        }

    }
}
