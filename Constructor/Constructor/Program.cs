using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Cons
    {
        public int id;
        public string name;
        public float salary;
        public Cons(int i,string n,float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine("id :" + id + "name :" + name + "salary :" + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cons ob = new Cons(2, "joynal", 3456f);

            ob.display();
            Console.ReadKey();
        }
    }
}
