using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.WebService1SoapClient webService1 = new ServiceReference1.WebService1SoapClient();
            string fortune = webService1.TellFortune();
            Console.WriteLine("Your fortune is: " + fortune);
        }
    }
}
