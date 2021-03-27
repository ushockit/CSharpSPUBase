using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Vasya", "Pupkin");
            Console.WriteLine(person.ToString());

            Employee employee = new Employee("Vasya", "Pupkin", 15_000);
            Console.WriteLine(employee);

            //Person[] people = new Person[]
            //{
            //    new Employee("Vasya", "Pupkin", 15_000),
            //    new Student("Petya", "Ivanov", 2, "SPU021")
            //};

            //if (people[0] is Student)
            //{
            //    Console.WriteLine("Available cast");
            //}
            //else
            //{
            //    Console.WriteLine("Error cast");
            //}
            //Student empl = (Student)people[0];

            //Будет null в случае безуспешного преобразования
            //Student stud = people[0] as Student;

            Console.Read();
        }
    }
}
