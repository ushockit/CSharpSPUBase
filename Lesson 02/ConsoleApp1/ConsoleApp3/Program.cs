using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Point
    {
        private int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    x = value;
                }
            }
        }
        public int Y { get; private set; }

        //private int x;
        //private int y;

        //public void SetX(int x)
        //{
        //    if (x > 0)
        //    {
        //        this.x = x;
        //    }
        //}
        //public void SetY(int y)
        //{
        //    this.y = y;
        //}
        //public int GetX()
        //{
        //    return x;
        //}
        //public int GetY()
        //{
        //    return y;
        //}
        public Point()
        {
            Y = 0;
        }
    }


    class Student
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int[] Marks { get; set; }
        //Вычисляемое св-во
        public int Average
        {
            get {
                int sum = 0;
                foreach (var mark in Marks)
                {
                    sum += mark;
                }
                return sum / Marks.Length;
            }
        }



        public int GetAverageMark()
        {
            int sum = 0;
            foreach (var mark in Marks)
            {
                sum += mark;
            }
            return sum / Marks.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Point p = new Point();
            p.X = 100;
            //p.Y = 200;
            Console.WriteLine($"x = {p.X}");*/

            Student student = new Student
            {
                FirstName = "Vasya",
                LastName = "Pupkin",
                Marks = new int[] { 5, 4, 4, 3, 4, 2, 5, 1 }
            };

            Console.WriteLine($"Average = {student.GetAverageMark()}");
            Console.WriteLine($"Average = {student.Average}");

            Student stud2 = new Student();
            

            Console.Read();
        }
    }
}
