using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        int course;
        string groupName;

        public Student() : base()
        {
            groupName = string.Empty;
            course = 1;
        }

        public Student(string firstName, string lastName, int course, string groupName)
            : base(firstName, lastName)
        {
            this.course = course;
            this.groupName = groupName;
        }
    }
}
