using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesApp
{
    class ToyPlane : Plane
    {
        public override void Display()
        {
            Console.WriteLine("I am a toy plane!");
        }

        public override void StartEngine()
        {
            Console.WriteLine("No engine to start!");
        }

        public override void Fly()
        {
            Console.WriteLine("This plane is unable to fly");
        }

        public override void Land()
        {
            Console.WriteLine("Crash!");
        }
    }
}
