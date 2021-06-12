using System;

namespace ConsoleApp5
{
    class Reader
    {
        Lazy<Library> library = new Lazy<Library>();
        public void ReadBook()
        {
            library.Value.GetBook();
            Console.WriteLine("Читаем бумажную книгу");
        }

        public void ReadEbook()
        {
            Console.WriteLine("Читаем книгу на компьютере");
        }
    }

    class Library
    {
        private string[] books = new string[99];
        public Library()
        {
            Console.WriteLine("Create library");
        }

        public void GetBook()
        {
            Console.WriteLine("Выдаем книгу читателю");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // https://metanit.com/sharp/tutorial/2.32.php
            //Index start = 1;
            //Index end = 5;

            //Index idx = ^2;
            //string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
            //Console.WriteLine(people[idx]);

            //Range range = start..end;
            //;

            Reader reader = new Reader();
            reader.ReadBook();

            Console.WriteLine("Hello World!");
        }
    }
}
