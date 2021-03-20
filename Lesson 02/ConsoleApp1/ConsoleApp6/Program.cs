using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCG = System.Collections.Generic;
using static System.Console;
using ConsoleApp6.Models.Cars;
using ConsoleApp6.Models.People;

namespace A
{
    class Foo
    {

    }
}

namespace B
{
    class Foo
    {

    }
}

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            A.Foo fooA = new A.Foo();
            B.Foo fooB = new B.Foo();

            WriteLine("Hello world");

            var path = @"C:\Program files";

            /*var text = "Lorem ipsum dolor sit amet, consectetur" +
                " adipiscing elit, sed do eiusmod tempor incididunt" +
                " ut labore et dolore magna aliqua. Ut enim ad minim " +
                "veniam, quis nostrud exercitation ullamco laboris " +
                "nisi ut aliquip ex ea commodo consequat. Duis aute " +
                "irure dolor in reprehenderit in voluptate velit esse " +
                "cillum dolore eu fugiat nulla pariatur. Excepteur sint " +
                "occaecat cupidatat non proident, sunt in culpa qui officia" +
                " deserunt mollit anim id est laborum.";*/

            var text = @"Lorem ipsum dolor sit amet, consectetur
adipiscing elit, sed do eiusmod tempor incididunt ut 
labore et dolore magna aliqua. Ut enim ad minim veniam, 
quis nostrud exercitation ullamco laboris nisi ut aliquip 
ex ea commodo consequat. Duis aute irure dolor in reprehenderit
in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
Excepteur sint occaecat cupidatat non proident, sunt in culpa 
qui officia deserunt mollit anim id est laborum.";

            string val = "Hello";
            string val2 = "Hey";
            Console.WriteLine($"{val, 10}");
            Console.WriteLine($"{val2, 10}");

            int[] items = new int[] { 1, 2, 3, 4 };

            //Array.Resize(ref items, items.Length + 5);
            Array.Resize(ref items, items.Length - 2);


            Car car = new Car();


            Person person = new Person(car);



            Console.Read();
        }
    }
}
