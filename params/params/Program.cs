using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class para
    {
        public void func(params int[] val)
        {
            for(int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        public void func1(params object[] val)
        {
            for(int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            para p = new para();
            p.func(1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 9);
            p.func1("joynal","abedin",1,2,3,4,5,"joy");
            Console.ReadKey();
        }
    }
}
