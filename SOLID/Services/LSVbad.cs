using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle Started");
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car started");
        }
    }

    public class Cycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car started");
        }
    }
}
