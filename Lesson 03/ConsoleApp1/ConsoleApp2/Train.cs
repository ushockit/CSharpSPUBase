using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Train : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Train drive!");
        }
    }
}
