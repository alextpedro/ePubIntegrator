using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFicha4
{
    public class ClassFicha4
    {
        public void AddCustomer(string id, string compName, string name, string country)
        {
            using (NORTHWNDEntities context = new NORTHWNDEntities())
            {
                //add new costumer
                Customer novo = new Customer();
                novo.CustomerID = id;
                novo.CompanyName = compName;
                novo.ContactName = name;
                novo.Country = country;

                context.Customers.Add(novo);
                context.SaveChanges();
            }
        }

        public void UpdateCustomer()
        {
            try
            {
                using (var context = new NORTHWNDEntities())
                {
                    Customer c = context.Customers.First(i => i.CustomerID == "IS");
                    c.ContactTitle = "DEI";
                    context.SaveChanges();
                    Console.WriteLine("Customer Updated!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            System.Console.ReadLine();
        }

        public void DeleteCustomer()
        {
            try
            {
                using (var context = new NORTHWNDEntities())
                {
                    Customer c = context.Customers.First(i => i.CustomerID == "IS");
                    context.Customers.Remove(c);
                    context.SaveChanges();
                    Console.WriteLine("Customer Deleted!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            System.Console.ReadLine();
        }


    }
}
