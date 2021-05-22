using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Extensions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "vasya@gmail.com";

            //if (str.IsValidEmail())
            //{
            //    Console.WriteLine("VALID");
            //}
            //else
            //{
            //    Console.WriteLine("INVALID");
            //}

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(21);

            if (list.AllEven())
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            Console.Read();
        }
    }
}
