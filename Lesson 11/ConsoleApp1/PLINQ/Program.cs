using System;
using System.Linq;

namespace PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var results = from n in nums.AsParallel()
                          where n > 0 
                          select Factorial(n);
            nums.AsParallel()
                .Where(n => n > 0)
                .Select(n => Factorial(n));
            results.ForAll(Console.WriteLine);
            
            Console.Read();
        }
        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
