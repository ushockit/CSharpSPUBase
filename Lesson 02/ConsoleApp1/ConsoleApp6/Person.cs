using ConsoleApp6.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models.People
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public Car Car { get; set; }

        public Person(Car car)
        {
            Car = car;
        }
    }
}
