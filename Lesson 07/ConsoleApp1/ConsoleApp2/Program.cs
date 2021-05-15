using System;

namespace ConsoleApp2
{
    // Generic constaints - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
    class Point<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point()
        {
            X = default(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> point = new Point<int>();
            Console.WriteLine("Hello World!");
        }
    }
}
