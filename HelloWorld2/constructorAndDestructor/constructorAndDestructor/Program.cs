using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorAndDestructor
{
    class A
    {
        public A()
        {
            Console.WriteLine("constructor called....");
        }
        ~A()
        {
            Console.WriteLine("Destructor called....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.ReadKey();
        }
    }
}
