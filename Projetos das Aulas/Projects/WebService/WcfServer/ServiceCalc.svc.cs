using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCalc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCalc.svc or ServiceCalc.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCalc : IServiceCalc
    {

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                result = 0;
            }
            return result;
        }
    }
}
