using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public Passport Passport { get; set; }
        public override string ToString()
        {
            return $"#{Id} {LastName} {FirstName} {Birth} {Passport.Series} {Passport.Number}";
        }
    }
}
