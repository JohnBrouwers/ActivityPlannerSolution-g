using ActivityPlanner.Models;
using System;

namespace ActivityPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jansen");
            person.Firstname = "";
            Person p = new Employee("Hans");
            Employee e = new Person();

            Console.WriteLine("Hello World!");
        }
    }
}
