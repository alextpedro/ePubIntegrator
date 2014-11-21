using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha4
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCustomer();
            //UpdateCustomer();
            //DeleteCustomer();
            //Query1998();
            

       }

        public static void AddCustomer() {
            using (NORTHWNDEntities context = new NORTHWNDEntities())
            {
                //add new costumer
                Customer novo = new Customer();
                novo.CustomerID = "IS";
                novo.CompanyName = "ESTG";
                novo.ContactName = "Pires";
                novo.Country = "Portugal";

                context.Customers.Add(novo);
                context.SaveChanges();

                List<Customer> listaCust = context.Customers.Where(i => i.Country == "Portugal").ToList();

                foreach (Customer item in listaCust)
                {
                    Console.WriteLine(item.CompanyName + item.Country);
                }
            }
        }

        public static void UpdateCustomer() {
            try
            {
                using (var context = new NORTHWNDEntities()) {
                    Customer c = context.Customers.First(i => i.CustomerID == "IS");
                    c.ContactTitle = "DEI";
                    context.SaveChanges();
                    Console.WriteLine("Customer Updated!");
                }
            }
            catch(Exception ex){
                Console.WriteLine(ex.ToString());
            }
            System.Console.ReadLine();
        }

        public static void DeleteCustomer() {
            try
            {
                using (var context = new NORTHWNDEntities()) {
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

        public static void Query1998(){

            using(var context = new NORTHWNDEntities()){
                var customers = context.Orders.Where(o=>o.OrderDate > new DateTime(1998,1, 1));
                foreach (var c in customers) {
                    Console.WriteLine("{0} from {1} Ordered item on {2}", c.Customer.CustomerID, c.Customer.CompanyName, c.OrderDate);
                }
                Console.ReadLine();
            }
            System.Console.ReadLine();
        }
    }
}
