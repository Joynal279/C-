using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    class statickey
    {
        public static int id;
        public int kname=0;
        public static float rateOfInterest=8.9f;
            public statickey(int id,string name)
        {
            //this.id = id;
            kname++;

        }
        public void display()
        {
            Console.WriteLine(id + " " + kname + " " + rateOfInterest);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            statickey.rateOfInterest = 88.78f;
            Console.WriteLine("value of id = " + statickey.id);
            statickey StaticKey = new statickey(2, "tamim");
            StaticKey.display(); rateOfInterest
            Console.ReadKey();
        }
    }
}
