using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bus = new Bus();
            Vehicle train = new Train();
            bus.Drive();
            train.Drive();

            Console.Read();
        }
    }
}
