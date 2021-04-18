using ConsoleApp1.Exceptions;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static UsersStorage usersStorage = new UsersStorage(10);
        static void Main(string[] args)
        {
            /*usersStorage.Create(new User
            {
                FirstName = "Vasya",
                LastName = "Pupkin",
                Username = "vasya_2000",
                Birth = new DateTime(2000, 02, 12)
            });

            usersStorage.Create(new User
            {
                FirstName = "Kolya",
                LastName = "Sidorov",
                Username = "vasya_1998",
                Birth = new DateTime(1998, 05, 02)
            });

            usersStorage.Create(new User
            {
                FirstName = "Masha",
                LastName = "Ivanova",
                Username = "masha_1990",
                Birth = new DateTime(1990, 10, 28)
            });


            try
            {
                User user = usersStorage.Find("vasya_2000");
                Console.WriteLine($"Hello, {user.Username}");
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {

            }
            finally     // блок, который срабатывает в любом случае
            {
                Console.WriteLine("Подключение к БД закрыто");
            }*/

            Random rnd = new Random();
            int value = rnd.Next(-100, 101);
            Console.WriteLine($"Value = {value}");

            try
            {
                ProcessValue(value);
            }
            catch (ArgumentException) when (value < 0)
            {
                Console.WriteLine("Value < 0");
            }
            catch (ArgumentException) when (value % 10 == 0)
            {
                Console.WriteLine("Value % 10 == 0");
            }

            // nameof - преобразование имени переменной в строку
            /*Console.WriteLine(nameof(value));
            Console.WriteLine("value");*/


            Console.WriteLine("Hello World!");
        }

        static void ProcessValue(int value)
        {
            if (value < 0 || value % 10 == 0)
            {
                throw new ArgumentException();
            }
            //TODO: Some process
        }
    }
}
