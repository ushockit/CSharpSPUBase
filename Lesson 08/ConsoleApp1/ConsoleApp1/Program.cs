using ConsoleApp1.Comparers;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> list = new List<int>();
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            Init();

            Console.WriteLine("-= Aggregate =-");
            //int result = list.Aggregate((val1, val2) => val1 + val2);
            //Console.WriteLine(result);

            Console.WriteLine("-= All =-");
            //if (list.All((n) => n > 0))
            //{
            //    Console.WriteLine("Все числа положительные");
            //}
            //else
            //{
            //    Console.WriteLine("Не все числа положитьельные");
            //}
            Console.WriteLine("-= Any =-");

            //if (list.Any(n => n % 50 == 0))
            //{
            //    Console.WriteLine("Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Not exists");
            //}

            Console.WriteLine("-= Average =-");
            //Console.WriteLine($"Average for nums = {list.Average()}");
            //Console.WriteLine($"Average for people = {people.Average(person => person.Birth.Year)}");

            Console.WriteLine("-= Count =-");
            //Console.WriteLine($"Count nums = {list.Count()}");
            //Console.WriteLine($"Count people = {people.Count()}");
            //Console.WriteLine($"Count even nums = {list.Count(n => n % 2 == 0)}");
            //Console.WriteLine($"Count people with passport series 'AO' = {people.Count(p => p.Passport.Series.Equals("AO"))}");


            Console.WriteLine("-= Distinct =-");
            //Console.WriteLine($"Count unique nums = {list.Distinct().Count()}");
            //people.Add(people[0]);
            //people.Add(people[0]);
            //Console.WriteLine($"Count unique people = {people.Distinct(new PeopleComparer()).Count()}");

            Console.WriteLine("-= First / FirstOrDefault =-");

            //int val = list.First(n => n == 10);
            //int val = list.FirstOrDefault(n => n == 10);
            //Console.WriteLine(val);

            Console.WriteLine("-= GroupBy =-");
            //var grouped = list.GroupBy(n => n % 2 == 0);
            //var grouped = people.GroupBy(p => p.Passport.Series);

            Console.WriteLine("-= Max =-");
            //int max = list.Max();
            //Console.WriteLine(max);
            //var max = people.Max(p => p.Birth.Year);
            //Console.WriteLine(max);

            Console.WriteLine("-= OrderBy =-");
            //var sortedPeople = people.OrderBy(p => p.Birth).ToList();
            //sortedPeople.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("-= Skip / Take =-");
            //int skip = 0;
            //int take = 5;
            //var firstPart = people.Skip(skip).Take(take);
            //skip += take;
            //var secondPart = people.Skip(skip).Take(take);

            Console.WriteLine("-= ToDictionary =-");
            //var dict = people.ToDictionary(p => p.Id);

            Console.WriteLine("-= Where =-");

            // выборка всех людей с серией 'AE'
            //var res = people.Where(p => p.Passport.Series.Equals("AE")).ToList();
            //var res = list.Where(n => (n >= 1 && n <= 100) && (n % 5 == 0)).ToList();
            

            Console.Read();
        }

        private static void Init()
        {
            string[] series = new string[] { "AE", "AO", "AH" };
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                list.Add(rnd.Next(-500, 500));
                people.Add(new Person 
                { 
                    Id = i + 1,
                    FirstName = $"First name {i + 1}",
                    LastName = $"Last name {i + 1}",
                    Birth = new DateTime(rnd.Next(1960, 2001), rnd.Next(1, 13), rnd.Next(1, 29)),
                    Passport = new Passport
                    {
                        Id = i + 1,
                        Series = series[rnd.Next(0, 3)],
                        Number = rnd.Next(100_000, 1_000_000)
                    }
                });
            }
        }
    }
}
