using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student
            {
                Course = 1,
                FirstName = "Vasya",
                LastName = "Pupkin",
                Group = new Group { Name = "SPU021" }
            };

            Student stud2 = stud.Clone();
            stud2.FirstName = "Petya";
            stud2.LastName = "Ivanov";
            stud2.Group.Name = "VP-12";


            Console.Read();
        }
    }
}
