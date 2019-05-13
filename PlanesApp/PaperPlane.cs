using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesApp
{
    class PaperPlane : Plane
    {
        public override void Display()
        {
            Console.WriteLine("I am a paper plane!");
        }

        public override void StartEngine()
        {
            Console.WriteLine("No engine to start!");
        }

        public override void Fly()
        {
            Console.WriteLine("Flying with paper wings");
        }

        public override void Land()
        {
            Console.WriteLine("Crash!");
        }
    }
}
