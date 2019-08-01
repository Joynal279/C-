using System;

namespace year
{
    class Program
    {
      

        static void Main(string[] args)
        {

            string[] m = {"Jan","Feb","Mar","Apr","May","June","July","Aug","Sept","Oct","Nov","Dec" };
            string s;
            int a,b,i;
            
            while (true)
            {
                Console.Write("Please enter year:");
                int year = Convert.ToInt32(Console.ReadLine());
                if(year>1998 && 2018 > year)
                {
                     a = year;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry you provide invalid Try again !");
                }
            }

            while (true)
            {
                Console.Write("Please enter month:");
                int month = Convert.ToInt32(Console.ReadLine());
                if (month > 0 && 13 > month)
                {
                    b = month;
                    for( i = 1; i < 12; i++)
                    {
                        if (b == i)
                        {
                             m[i] = m[i-1];
                            break;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry you provide invalid Try again !");
                }
            }
            Console.WriteLine(m[i]+"-"+a);
            Console.ReadKey();
        }
    }
}
