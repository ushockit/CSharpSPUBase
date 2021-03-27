using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student : Person
    {
        public int Course { get; set; }
        public Group Group { get; set; }


        public Student Clone()
        {
            Student student = this.MemberwiseClone() as Student;
            student.Group = Group.Clone();
            return student;
        }
    }
}
