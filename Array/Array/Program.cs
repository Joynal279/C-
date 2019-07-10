using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{

    class arra
    {
        public void fun(int[] arr1)
        {
            for(int i = 0; i <= arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            arra ar = new arra();
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 6,7,8, 9 };
            ar.fun(arr1);
            Console.ReadKey();
        }
    }
}
