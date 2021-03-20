using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref/out params

            /*int a = 10;

            ChangeWithRef(ref a);
            Console.WriteLine($"a = {a}");*/

            /*int a;
            ChangeWithOut(out a);*/

            /*int a;
            int.TryParse(Console.ReadLine(), out a);
            
            Console.WriteLine(a);*/


            //MethodWithManyParams(10, 20, 30, 40);
            Printf("int val = %d, bool val = %d, double val = %f, char val = %s, string val = %s", 10, true, 10.5, 'a', "Hello");

            Console.Read();
        }
        static void ChangeWithRef(ref int value)
        {
            value += 20;
        }
        static void ChangeWithOut(out int value)
        {
            value = 100;
        }

        static void MethodWithManyParams(params int[] values)
        {
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
        }

        static void Printf(string format, params object[] values)
        {
            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);
            //}
            int srchPos = 0;
            int pos;
            int idx = 0;

            //поиск первого вхождения
            pos = format.IndexOf('%', srchPos);
            while (pos != -1) {
                format = format.Remove(pos, 2);
                format = format.Insert(pos, values[idx++].ToString());
                pos = format.IndexOf('%', srchPos);
            }
        }
    }
}
