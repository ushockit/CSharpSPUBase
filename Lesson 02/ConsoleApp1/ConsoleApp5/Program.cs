using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1;
            int? val2 = 30;

            val1 = (int)val2;

            /*DateTime dateTime = new DateTime(2020, 10, 5);
            DateTime dateTime2 = new DateTime(2020, 10, 5, 23, 10, 56);

            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime2);
            Console.WriteLine(dateTime.ToShortDateString());

            DateTime now = DateTime.Now;
            Console.WriteLine($"Current datetime = {now}");*/


            DateTime? date = null;
            DateTime date2;


            Demo(date);


            Console.Read();
        }

        static void Demo(DateTime? date)
        {
            date = date is null ? DateTime.Now : date;
            date = date ?? DateTime.Now;

            Console.WriteLine(date);
        }
    }
}
