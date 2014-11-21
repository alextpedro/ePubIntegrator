using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFicha4;

namespace ConsoleApplicationFicha4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassFicha4 classLib4 = new ClassFicha4();
            classLib4.AddCustomer("ERSC", "Cisco", "Cheila", "Lisboa");
        }
    }
}
