using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Vehicle
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public virtual void StartEngine() 
        {
            Console.WriteLine("Engine start!");
        }

        public abstract void Drive();
    }
}
