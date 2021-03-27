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
            // Кортежи (Tuple)
            //(int, int) tuple = Example();

            /*ValueTuple<int, int> tuple = (10, 20);
            var tuple2 = tuple;

            tuple2.Item1 = 30;

            Console.WriteLine(tuple);
            Console.WriteLine(tuple2);*/

            /*Tuple<int, int> tuple = new Tuple<int, int>(10, 20);
            var tuple2 = tuple;

            Console.WriteLine(tuple);
            Console.WriteLine(tuple2);*/

            //(int x, int y) tuple = Example();

            //string s = new('-', 10);

            
            Console.Read();
        }
        static (int, int) Example()
        {
            return (10, 20);
        }

        static string GetName(int value)
        {
            return value switch
            {
                1 => "Value 1",
                2 => "Value 2",
                3 => "Value 3",
                _ => throw new NotImplementedException()
            };
        }

        static void GetData(int? count)
        {
            count = count ?? 10;
        }
    }
}
