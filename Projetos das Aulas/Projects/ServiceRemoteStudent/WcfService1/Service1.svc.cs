using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int getAge(Student s)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - s.Birthdate.Year;
            if (s.Birthdate > today.AddYears(-age)) age--;
            return age;
        }

        public Student addStudent(string name, DateTime birthdate)
        {
            Student newStudent = new Student(name, birthdate);
            newStudent.Name = name;
            newStudent.Birthdate = birthdate;
            return newStudent;
        }
    } 
}
