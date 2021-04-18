using ConsoleApp2.Models;
using GCDemo.Models;
using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Account acc = new Account { Login = "vasya", Password = "123456" };

            GC.Collect(0);

            Console.WriteLine($"Acc generation = {GC.GetGeneration(acc)}");

            Console.WriteLine($"Total memory = {GC.GetTotalMemory(false)}");*/

            //for (int i = 0; i < 1_000_000; i++)
            //{
            //    Account acc = new Account { Login = "vasya", Password = "123456" };
            //    Thread.Sleep(50);
            //    Console.WriteLine("Created");
            //}


            /*DatabaseConnection connection = new DatabaseConnection();
            connection.Dispose();*/

            // конструкция using, по завершению работы автоматически вызывает метод Dispose
            // конструкция using, применима только к объектам, которые реализует интерфейс IDisposable
            using(DatabaseConnection connection = new DatabaseConnection())
            {

            }




            Console.WriteLine("Hello World!");
        }
    }
}
