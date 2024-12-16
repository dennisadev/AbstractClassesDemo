using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        //Year, Make, and Model Properties
        public int Year { get; set; } = 0;
        public string Make { get; set; } = null;
        public string Model { get; set; } = null;

        //Vehicle class shall have an abstract method called DriveAbstract with no implementation.

        public abstract void DriveAbstract();

        //Vehicle class shall have a virtual method called DriveVirtual with a base implementation.

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default drive");
        }
    }
}
