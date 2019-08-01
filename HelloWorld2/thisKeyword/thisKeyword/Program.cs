using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisKeyword
{
    class Employee
    {
        public int id;
        public float salary;
        public string name;
        public Employee(int id,float salary,string name)
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
        //~Employee()
        //{
        //    Console.WriteLine("destructor called..");
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(22, 2345.44f, "joynal");
            employee.display();
            Console.ReadKey();

        }
    }
}
