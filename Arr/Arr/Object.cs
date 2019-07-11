using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr
{
    class A
    {
        public int id;
        public string name;
        public void insert(int i,string n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine("id :" + id + " name :" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.insert(23, "joynal");
            obj.display();
            Console.ReadKey();

        }
    }
}
