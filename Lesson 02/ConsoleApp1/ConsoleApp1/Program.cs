using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //struct Point
    //{
    //    public int x;
    //    public int y;

    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}
    class Point
    {
        //константы/статические поля
        //....
        public static int counter;
        public const int DEFAULT_X = 0;
        public const int DEFAULT_Y = 0;
        public readonly string name;
        //приватные переменные
        private int x;
        private int y;

        //публичные значения
        //...

        static Point()
        {
            Console.WriteLine("Called static constructor");
            counter = 0;
        }
        //конструкторы
        public Point()
        {
            Console.WriteLine("Called default constructor");
            x = DEFAULT_X;
            y = DEFAULT_Y;
            counter++;
            name = string.Empty;
        }
        public Point(string name, int x, int y) : this()
        {
            Console.WriteLine("Called constructor with params");
            this.x = x;
            this.y = y;
            this.name = name;
        }

        //методы/перегрузки

        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        public static Point Sum(Point p1, Point p2)
        {
            return new Point("New point", 
                p1.GetX() + p2.GetX(), 
                p1.GetY() + p2.GetY());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point(10, 20);

            //Point point2 = point;

            //point2.x = 56;

            //Console.WriteLine($"x = {point.x} y = {point.y}");
            //Console.WriteLine($"x = {point2.x} y = {point2.y}");


            Point p = new Point("Some point", 10, 20);
            Point p2;
            p2 = p;

            Point p3 = new Point("P#3", -5, 11);


            //p2.SetX(50);

            DemoPoint(p2);

            Console.WriteLine($"x = {p.GetX()} y = {p.GetY()}");
            Console.WriteLine($"x = {p2.GetX()} y = {p2.GetY()}");

            Console.WriteLine($"Counter = {Point.counter}");


            //обращение к статическим данным класса Point
            Point res = Point.Sum(p2, p3);


            Console.Read();
        }

        static void DemoPoint(Point point)
        {
            point.SetX(-5);
            point.SetY(26);
        }
    }
}
