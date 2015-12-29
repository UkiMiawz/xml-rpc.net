using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlRpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService.MathsClient obj = new XmlRpcClient.MathService.MathsClient();
            MathService.Math mathobj = new XmlRpcClient.MathService.Math();
            mathobj.Number1 = 10;
            mathobj.Number2 = 5;
            Console.WriteLine("Addition continues..");
            Console.WriteLine(obj.Addition(mathobj));
            Console.WriteLine("Subtraction continues..");
            Console.WriteLine(obj.Subtraction(mathobj));
            Console.ReadLine();
        }
    }
}
