using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlRpcClient
{
    [XmlRpcUrl("http://www.cookcomputing.com/xmlrpcsamples/math.rem")]
    public interface IMath : IXmlRpcProxy
    {
        [XmlRpcMethod("math.Add")]
        int AddNumber(int num1, int num2);
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMath proxy = XmlRpcProxyGen.Create<IMath>();
            int total = proxy.AddNumber(41,12);
            Console.WriteLine("State name");
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
