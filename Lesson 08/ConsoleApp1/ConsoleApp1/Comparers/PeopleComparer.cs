using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Comparers
{
    public class PeopleComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.GetHashCode() == y.GetHashCode();
        }

        public int GetHashCode(Person person)
        {
            int firstNameHashCode = person.FirstName.GetHashCode();
            int lastNameHashCode = person.LastName.GetHashCode();
            int birthHashCode = person.Birth.GetHashCode();
            int passportHashCode = person.Passport.GetHashCode();
            return firstNameHashCode ^
                lastNameHashCode ^
                birthHashCode ^
                passportHashCode;
        }
    }
}
