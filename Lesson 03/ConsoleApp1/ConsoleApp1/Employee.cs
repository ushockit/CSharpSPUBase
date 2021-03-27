using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee : Person
    {
        decimal salary;

        public Employee() : base()
        {
            this.salary = 0.0m;
        }

        public Employee(string firstName, string lastName, decimal salary)
            : base(firstName, lastName)
        {
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {salary} uah";
        }
    }
}
