using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Раннее связывание
            //var person = new Person();

            //person.FirstName = "";
            //person.LastName = "";
            //person.Birth = DateTime.Now;

            // Позднее связывание
            var type = Type.GetType("ConsoleApp2.Models.Person", true, false);
            var props = type.GetProperties();

            var obj = Activator.CreateInstance(type);

            
            var method = Type.GetType(props[4].PropertyType.FullName)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .FirstOrDefault(m => m.Name.Equals("Parse"));

            var res = method.Invoke(null, new object[] { "2010-05-10" });
            ;
            


            while (true)
            {
                Console.Clear();

                string objectInfo = string.Join(", ", props.Select(prop => prop.GetValue(obj)?.ToString()));
                Console.WriteLine(objectInfo);

                var counter = 0;
                foreach (var prop in props)
                {
                    Console.WriteLine($"[{++counter}] {prop.PropertyType.Name} {prop.Name}");
                }

                int idx = int.Parse(Console.ReadLine());
                var propInfo = props[idx - 1];

                


                Console.WriteLine(propInfo.Name);

                Console.WriteLine("Enter value: ");
                string value = Console.ReadLine();

                
                

                
                switch(propInfo.PropertyType.Name)
                {
                    case "String":
                        propInfo.SetValue(obj, value);
                        break;
                    case "DateTime":
                        propInfo.SetValue(obj, DateTime.Parse(value));
                        break;
                }
            }

            /*var assembly = Assembly.LoadFrom("DatabaseLibrary.dll");
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(type.FullName);
            }

            var activeType = types[0];

            var obj = Activator.CreateInstance(activeType);*/


            Console.Read();
        }
    }
}
