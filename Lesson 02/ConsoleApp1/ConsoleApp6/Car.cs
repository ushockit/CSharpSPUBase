using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models.Cars
{
    public enum CarType
    {

    }
    public class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public CarType Type { get; set; }
    }
}
