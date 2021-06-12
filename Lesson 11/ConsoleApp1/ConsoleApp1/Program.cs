using ConsoleApp1.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string API_URL = "https://api.privatbank.ua/p24api";
            var client = new RestClient(API_URL);
            var request = new RestRequest("/pboffice?json", DataFormat.Json);

            var response = client.Get(request).Content;
            var pickups = JsonConvert.DeserializeObject<List<Pickup>>(response);

            var cities = pickups.Select(pickup => pickup.City)
                .Distinct()
                .ToList();

            var countView = 10;
            var offset = 0;

            var viewCities = cities.Skip(offset).Take(countView).ToList();

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"{offset}/{cities.Count}");
                int num = 0;
                foreach (var city in viewCities)
                {
                    Console.WriteLine($"[{++num}] {city}");
                }

                Console.WriteLine("Press left or right arrow");
                var keyInfo = Console.ReadKey();
                var key = keyInfo.Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (offset > 0)
                        {
                            offset -= countView;
                            viewCities = cities.Skip(offset).Take(countView).ToList();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (offset + countView <= cities.Count)
                        {
                            offset += countView;
                            viewCities = cities.Skip(offset).Take(countView).ToList();
                        }
                        break;
                }
                if ("0123456789".Contains(keyInfo.KeyChar))
                {
                    int selNum = int.Parse(keyInfo.KeyChar.ToString());
                    Console.WriteLine($"Selected city: {cities[offset + selNum - 1]}");
                    Console.WriteLine($"Selected city: {viewCities[selNum - 1]}");
                    Console.Read();
                }
            }

            Console.Read();
        }
    }
}
