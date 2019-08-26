using System;

namespace studentBlackboardSimple
{
    public class Vehicle : IDriveable
    {
        public double Speed { get; set; }
        public int Wheels { get; set; }
        public string Brand { get; set; }

        public Vehicle(string brand="no brand", int wheels = 4, int speed=0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"the {Brand} is driving at {Speed} MPH");
            
        }

        public void Stop()
        {
            Console.WriteLine($"the {Brand} is stopped");
            Speed = 0;
        }
    }
}