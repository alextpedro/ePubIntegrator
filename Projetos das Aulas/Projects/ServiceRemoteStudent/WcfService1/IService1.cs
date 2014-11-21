using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // My operation contract
        [OperationContract]
        int getAge(Student s);

        // My operation contract
        [OperationContract]
        Student addStudent(String name, DateTime birthdate);
    }

    // My Data Contract
    [DataContract]
    public class Student
    {
        String name;
        DateTime birthdate;

        public Student(String newname, DateTime newbirthdate)
        {
            name = newname;
            birthdate = newbirthdate;
        }

        [DataMember]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
    }
}
