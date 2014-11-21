using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente.ServiceRefTest;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Service1Client webservice = new Service1Client();
            Console.WriteLine(webservice.SayHello("cenas"));
            Console.ReadLine();
        }
    }
}
