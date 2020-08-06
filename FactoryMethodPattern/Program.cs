using FactoryMethodPattern.LoggerFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory_CassolWise());
            customerManager.Save();

            Console.ReadLine();
        }
    }
}
