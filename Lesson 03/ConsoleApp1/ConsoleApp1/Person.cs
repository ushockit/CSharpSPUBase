using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        protected string firstName;
        protected string lastName;

        public Person()
        {
            firstName = lastName = string.Empty;
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            return $"{lastName} {firstName}";
        }
    }
}
