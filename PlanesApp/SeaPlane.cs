using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesApp
{
    class SeaPlane: Plane
    {
        public override void Display()
        {
            Console.WriteLine("I am a Seaplane!");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Single engine started!");
        }

        public override void Fly()
        {
            Console.WriteLine("Flying with real wings");
        }

        public override void Land()
        {
            Console.WriteLine("Landing with floats");
        }
    }
}
