using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor involved..");
        }
        ~Employee()
        {
            Console.WriteLine("destructore involved");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            Employee em1 = new Employee();
            Console.ReadKey();
          
        }
    }
}
