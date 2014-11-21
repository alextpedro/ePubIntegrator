using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySoftwareOrganizationOOP;

namespace ConsoleApplicationOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pessoas = new List<Person>();

            Customer client1 = new Customer("Armando", "Pereira", new DateTime(1973, 10, 12), "place1");
            Customer client2 = new Customer("Manel", "António", new DateTime(1987, 12, 12), "place2");
            Customer client3 = new Customer("Ana", "Silva", new DateTime(1972, 3, 25), "place3");

            Manager manager1 = new Manager("André", "Pires", new DateTime(1988, 10, 13), 2000.05);

            Programmer programmer1 = new Programmer("Miguel", "Ferreira", new DateTime(1988, 10, 13), 1000);
            Programmer programmer2 = new Programmer("Ana", "Figueira", new DateTime(1987, 10, 13), 1000);
            Programmer programmer3 = new Programmer("Filipe", "Lopes", new DateTime(1986, 10, 13), 1500);
            Programmer programmer4 = new Programmer("Vasco", "Caetano", new DateTime(1985, 10, 13), 1000);
            Programmer programmer5 = new Programmer("Filipa", "Pinto", new DateTime(1960, 10, 13), 1000);

            manager1.AddProgrammer(programmer1);
            manager1.AddProgrammer(programmer2);
            manager1.AddProgrammer(programmer3);
            manager1.AddProgrammer(programmer4);
            manager1.AddProgrammer(programmer5);

            pessoas.Add(client1);
            pessoas.Add(client2);
            pessoas.Add(client3);
            pessoas.Add(manager1);
            pessoas.Add(programmer1);
            pessoas.Add(programmer2);
            pessoas.Add(programmer3);
            pessoas.Add(programmer4);
            pessoas.Add(programmer5);

            Console.WriteLine("Program started...");

            var pessoasFiltradas = from p in pessoas
                                   where p.FullName.StartsWith("A") && p is Customer
                                   select p;

            pessoasFiltradas = from p in pessoas
                               where p.Age > 40
                               select p;

            foreach (Person pessoa in pessoasFiltradas)
            {
               pessoa.Print();
            }
            Console.ReadLine();
        }
    }
}
