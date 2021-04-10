using System;

namespace ConsoleApp1
{
    interface IVehicle
    {
        double Weight { get; set; }
        double Speed { get; set; }
    }

    interface IMovement
    {
        void ToLeft();
        void ToRight();
    }

    interface IFly
    {
        void Up();
        void Down();
    }

    class Car : IVehicle, IMovement
    {
        public double Weight { get; set; }
        public double Speed { get; set; }

        public void ToLeft()
        {
            throw new NotImplementedException();
        }

        public void ToRight()
        {
            throw new NotImplementedException();
        }
    }

    class Bus : IVehicle, IMovement
    {
        public double Weight { get; set; }
        public double Speed { get; set; }

        public void ToLeft()
        {
            throw new NotImplementedException();
        }

        public void ToRight()
        {
            throw new NotImplementedException();
        }
    }

    class Plane : IVehicle, IMovement, IFly
    {
        public double Weight { get; set; }
        public double Speed { get; set; }

        public void Down()
        {
            throw new NotImplementedException();
        }

        public void ToLeft()
        {
            throw new NotImplementedException();
        }

        public void ToRight()
        {
            throw new NotImplementedException();
        }

        public void Up()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Speed = 250, Weight = 1500 };
            Bus bus = new Bus { Speed = 120, Weight = 4000 };
            Plane plane = new Plane { Speed = 1000, Weight = 40000 };


            IMovement movement = car;
            movement = bus;

            movement.ToLeft();


            Console.Read();
        }
    }
}
