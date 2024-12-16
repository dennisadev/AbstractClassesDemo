using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        //Properties HasTrunk for Car and HasSideCart for Motorcycle
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle Drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle drive with virtual method");
        }
    }
}
