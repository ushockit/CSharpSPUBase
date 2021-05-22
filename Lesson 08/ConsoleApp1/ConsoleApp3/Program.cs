using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    delegate int MathDelegate<T>(int value1, int value2);
    delegate string FormatDelegate(string str);

    class Program
    {

        static void Main(string[] args)
        {
            //MathDelegate<int> mDelegate;
            //mDelegate = SumNums;

            Func<int, int, int> mDelegate = SumNums;

            int a = 10;
            int b = 20;

            int result = mDelegate(a, b);
            Console.WriteLine($"{a} + {b} = {result}");
            Print(TransformStr2, "hello");

            //Predicate
            //Func
            //Action

            //Predicate<int> predicate = (n) => n % 2 == 0;
            //Predicate<int> predicate = (n) => {
            //    return n % 2 == 0; 
            //};

            //Console.WriteLine(predicate(10));
            //Console.WriteLine(predicate(15));

            Func<int, int, bool> func = (val1, val2) => val1 > val2;
            Console.WriteLine(func(10, 20));






            Console.Read();
        }

        static void Print(FormatDelegate format, string str)
        {
            Console.WriteLine(format?.Invoke(str));
            Console.WriteLine(format(str));
        }

        static int SumNums(int a, int b)
        {
            return a + b;
        }

        static string TransformStr(string str) => $"|--> {str} <--|";
        static string TransformStr2(string str) => $"^--> {str} <--^";
    }
}
