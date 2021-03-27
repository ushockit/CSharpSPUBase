using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class SimplePlayer : Player
    {
        public override void AddHealth()
        {
            Health += 5;
        }
    }
}
