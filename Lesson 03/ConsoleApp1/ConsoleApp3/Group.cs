using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Group
    {
        public string Name { get; set; }

        public Group Clone()
        {
            return this.MemberwiseClone() as Group;
        }
    }
}
