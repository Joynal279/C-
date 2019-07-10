using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class refer
    {
        public void fun(ref int val)
        {
             val = val * val;
            Console.WriteLine("the value of : " + val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int val = 50;
            Console.WriteLine("the value before call : " + val);
            refer re = new refer();
            re.fun(ref val);
            Console.WriteLine("after calling the function now value : " + val);
            Console.ReadKey();

            
        }
    }
}
