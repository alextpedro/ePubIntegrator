using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCalc" in both code and config file together.
    [ServiceContract]
    public interface IServiceCalc
    {
        [OperationContract]
        int Sum(int num1, int num2);

        [OperationContract]
        int Subtract(int num1, int num2);

        [OperationContract]
        int Multiply(int num1, int num2);

        [OperationContract]
        int Divide(int num1, int num2);
    }
}
