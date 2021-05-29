using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class DemoAttribute : Attribute
    {
        public string Value { get; }
        public DemoAttribute(string value)
        {
            Value = value;
        }
    }
    // [Demo("Some person")]
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    [Serializable]
    public class Car : ISerializable
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Person Owner { get; set; }

        public Car()
        {

        }
        private Car(SerializationInfo info, StreamingContext context)
        {
            var mark = info.GetString("Mark");
            ;
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Mark", "Modified_" + Mark);
            info.AddValue("Model", "Modified_" + Model);
            info.AddValue("Price", Price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object[] attrs = typeof(Person).GetCustomAttributes(false);

            //foreach (var attr in attrs)
            //{
            //    if (attr is DemoAttribute)
            //    {
            //        Console.WriteLine((attr as DemoAttribute).Value);
            //    }
            //}

            //Person person = new Person { FirstName = "Vasya", LastName = "Pupkin" };
            //Car car = new Car
            //{
            //    Owner = person,
            //    Mark = "Opel",
            //    Model = "Astra",
            //    Price = 101
            //};
            //Car car2 = new Car
            //{
            //    Owner = person,
            //    Mark = "Opel",
            //    Model = "Omega",
            //    Price = 102
            //};

            //List<Car> cars = new List<Car> { car, car2 };


            //XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));

            //using (FileStream fs = new FileStream("cars.xml", FileMode.Create, FileAccess.Write))
            //{
            //    serializer.Serialize(fs, cars);
            //    Console.WriteLine("Success");
            //}

            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //using (FileStream fs = new FileStream("cars.dat", FileMode.Create, FileAccess.Write))
            //{
            //    binaryFormatter.Serialize(fs, cars);
            //    Console.WriteLine("Success");
            //}


            //List<Car> cars = new List<Car>();

            //XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
            //using (FileStream fs = new FileStream("cars.dat", FileMode.Open, FileAccess.Read))
            //{
            //    cars = serializer.Deserialize(fs) as List<Car>;
            //}

            List<Car> cars = new List<Car>();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("cars.dat", FileMode.Open, FileAccess.Read))
            {
                cars = binaryFormatter.Deserialize(fs) as List<Car>;
            }


            Console.Read();
        }
    }
}
