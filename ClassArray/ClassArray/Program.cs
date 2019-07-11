using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 45, 32, 12, 66, 98 };
            int[] array1 = new int[6];
            Console.WriteLine("the length of the first array :" + array.Length);
            Console.WriteLine("the elements:" );
            PrintArray(array);
            Array.Sort(array);
            Console.WriteLine("the elements sorted:");
            PrintArray(array);
           // Console.WriteLine("the sortet array :");
            Console.WriteLine("the index of array :" + Array.IndexOf(array, 12));
            Array.Reverse(array);
            Console.WriteLine("the reverse array :");
            PrintArray(array);
            
            Console.ReadKey();
        }

        private static void PrintArray(int[] array)
        {
            foreach(object item in array)
            {
                Console.WriteLine(item + "");
            }
        }
    }
}
