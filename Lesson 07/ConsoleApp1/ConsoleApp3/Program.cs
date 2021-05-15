using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Values
    {
        int[] vals = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < vals.Length; i++)
            {
                yield return vals[i];
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Values values = new Values();

            foreach (var v in values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
